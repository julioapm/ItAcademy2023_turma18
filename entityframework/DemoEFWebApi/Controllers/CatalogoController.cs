using Microsoft.AspNetCore.Mvc;
using DemoEFWebApi.Services;
using DemoEFWebApi.Models;

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
    public async Task<IEnumerable<Produto>> GetTodos()
    {
        return await _produtosRepository.ConsultarTodosAsync();
    }
}