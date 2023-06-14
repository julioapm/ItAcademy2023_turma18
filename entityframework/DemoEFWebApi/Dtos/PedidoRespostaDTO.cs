using DemoEFWebApi.Models;

namespace DemoEFWebApi.Dtos;

public class PedidoRespostaDTO
{
    public int Id {get;set;}
    public string DataEmissao {get;set;} = null!;
    public string NomeCliente {get;set;} = null!;
    public string ValorTotal {get;set;} = null!;
    public IEnumerable<ItemRespostaDTO> Itens {get;set;} = null!;
    public static PedidoRespostaDTO DeModelParaDto(Pedido model)
    {
        var dto = new PedidoRespostaDTO();
        dto.Id = model.Id;
        dto.DataEmissao = model.DataEmissao.ToShortDateString();
        dto.NomeCliente = model.Cliente.Nome;
        var total = model.Itens.Sum(item => item.Quantidade*item.Produto.PrecoUnitario/100M);
        dto.ValorTotal = $"{total:C}";
        dto.Itens = model.Itens.Select(ItemRespostaDTO.DeModelParaDto);
        return dto;
    }
}

public class ItemRespostaDTO
{
    public int IdProduto {get;set;}
    public string NomeProduto {get;set;} = null!;
    public string ValorUnitario {get;set;} = null!;
    public int Quantidade {get;set;}
    public string SubTotal {get;set;} = null!;
    public static ItemRespostaDTO DeModelParaDto(Item model)
    {
        var dto = new ItemRespostaDTO();
        dto.IdProduto = model.ProdutoId;
        dto.NomeProduto = model.Produto.Nome;
        dto.ValorUnitario = $"{model.Produto.PrecoUnitario/100M:C}";
        dto.Quantidade = model.Quantidade;
        dto.SubTotal = $"{model.Quantidade*model.Produto.PrecoUnitario/100M:C}";
        return dto;
    }
}