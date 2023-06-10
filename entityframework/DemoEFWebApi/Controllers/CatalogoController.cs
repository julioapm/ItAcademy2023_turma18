using Microsoft.AspNetCore.Mvc;
using DemoEFWebApi.Services;
using DemoEFWebApi.Models;
using DemoEFWebApi.Dtos;

namespace DemoEFWebApi.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class CatalogoController : ControllerBase
{
    private readonly IProdutosRepository _produtosRepository;
    public CatalogoController(IProdutosRepository produtosRepository)
    {
        _produtosRepository = produtosRepository;
    }
    //GET .../api/v1/Catalogo
    [HttpGet]
    public async Task<IEnumerable<ProdutoRespostaDTO>> GetTodos()
    {
        var produtos = await _produtosRepository.ConsultarTodosAsync();
        return produtos.Select(p => ProdutoRespostaDTO.DeModelParaDto(p));
    }
    //GET .../api/v1/Catalogo/{id}
    [HttpGet("{id:int}")]
    public async Task<ActionResult<ProdutoRespostaDTO>> GetPorId(int id)
    {
        var produto = await _produtosRepository.ConsultarPorIdAsync(id);
        if (produto == null) {
            return NotFound();
        }
        return ProdutoRespostaDTO.DeModelParaDto(produto);
    }
}