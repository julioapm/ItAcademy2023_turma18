using DemoEFWebApi.Models;

namespace DemoEFWebApi.Services;

public interface IProdutosRepository
{
    Task<IEnumerable<Produto>> ConsultarTodosAsync();
    Task<Produto?> ConsultarPorIdAsync(int id);
}