using DemoEFWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoEFWebApi.Services;

public class ProdutosRepositoryEF : IProdutosRepository
{
    private readonly LojinhaContext _contexto;

    public ProdutosRepositoryEF(LojinhaContext contexto)
    {
        _contexto = contexto;
    }

    public async Task<Produto?> ConsultarPorIdAsync(int id)
    {
        return await _contexto.Produtos
            .Where(p => p.Id == id)
            .FirstOrDefaultAsync();
    }

    public async Task<IEnumerable<Produto>> ConsultarTodosAsync()
    {
        return await _contexto.Produtos
            .AsNoTracking()
            .OrderBy(p => p.Nome)
            .ToListAsync();
    }
}