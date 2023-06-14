using Microsoft.EntityFrameworkCore;
using DemoEFWebApi.Models;

namespace DemoEFWebApi.Services;

public class ClientesRepositoryEF : IClientesRepositorio
{
    private readonly LojinhaContext _contexto;
    public ClientesRepositoryEF(LojinhaContext contexto)
    {
        _contexto = contexto;
    }
    public async Task<Cliente?> ConsultarPorIdAsync(int id)
    {
        return await _contexto.Clientes.FindAsync(id);
    }
}