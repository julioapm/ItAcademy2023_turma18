using Microsoft.EntityFrameworkCore;
using DemoEFWebApi.Models;

namespace DemoEFWebApi.Services;

public class PedidosRepositoryEF : IPedidosRepository
{
    private readonly LojinhaContext _contexto;
    public PedidosRepositoryEF(LojinhaContext contexto)
    {
        _contexto = contexto;
    }

    public async Task<Pedido> AdicionarAsync(Pedido pedido)
    {
        await _contexto.Pedidos.AddAsync(pedido);
        await _contexto.SaveChangesAsync();
        return pedido;
    }
}