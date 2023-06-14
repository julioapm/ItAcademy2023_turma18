using Microsoft.AspNetCore.Mvc;
using DemoEFWebApi.Services;
using DemoEFWebApi.Models;
using DemoEFWebApi.Dtos;

namespace DemoEFWebApi.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class PedidosController : ControllerBase
{
    private readonly IClientesRepositorio _clientesRepository;
    private readonly IProdutosRepository _produtosRepository;
    private readonly IPedidosRepository _pedidosRepository;

    public PedidosController(IClientesRepositorio clientesRepository, IProdutosRepository produtosRepository, IPedidosRepository pedidosRepository)
    {
        _clientesRepository = clientesRepository;
        _produtosRepository = produtosRepository;
        _pedidosRepository = pedidosRepository;
    }

    //POST .../api/v1/Pedidos
    [HttpPost]
    public async Task<ActionResult<PedidoRespostaDTO>> PostNovoPedido(CarrinhoRequisicaoDTO carrinho)
    {
        var cliente = await _clientesRepository.ConsultarPorIdAsync(carrinho.IdCliente.GetValueOrDefault());
        if (cliente == null)
        {
            return BadRequest();
        }
        if (carrinho.Itens.Count() == 0)
        {
            return BadRequest();
        }
        var pedido = new Pedido();
        pedido.DataEmissao = DateTime.Now;
        pedido.Itens = new List<Item>();
        foreach (var item in carrinho.Itens)
        {
            var produto = await _produtosRepository.ConsultarPorIdAsync(item.IdProduto.GetValueOrDefault());
            if (produto == null)
            {
                return BadRequest();
            }
            var itemPedido = new Item
            {
                Produto = produto,
                Quantidade = item.Quantidade.GetValueOrDefault()
            };
            pedido.Itens.Add(itemPedido);
        }
        var novoPedido = await _pedidosRepository.AdicionarAsync(pedido);
        return PedidoRespostaDTO.DeModelParaDto(novoPedido);
    }
}