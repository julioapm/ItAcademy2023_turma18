using DemoEFWebApi.Models;

namespace DemoEFWebApi.Services;

public class ProdutosRepositoryEF : IProdutosRepository
{
    public Task<Produto> ConsultarPorIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Produto>> ConsultarTodosAsync()
    {
        throw new NotImplementedException();
    }
}