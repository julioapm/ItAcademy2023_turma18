using DemoEFWebApi.Models;

namespace DemoEFWebApi.Services;

public interface IPedidosRepository
{
    Task<Pedido> AdicionarAsync(Pedido pedido);
}