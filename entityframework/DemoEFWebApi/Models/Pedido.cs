namespace DemoEFWebApi.Models;

public class Pedido
{
    public int Id {get;set;}
    public DateTime DataEmissao {get;set;}
    //relacionamento N-1 com Cliente
    public Cliente Cliente {get;set;} = null!;
    public int ClienteId {get;set;}
    
}