using Microsoft.AspNetCore.Mvc;
namespace DemoAloMundo.Controllers;

[ApiController]
[Route("[controller]")]
public class AloMundoController : ControllerBase
{
    private readonly ILogger<AloMundoController> _logger;
    public AloMundoController(ILogger<AloMundoController> logger)
    {
        _logger = logger;
    }
    [HttpGet]
    public string Get()
    {
        _logger.LogInformation("GET /AloMundo");
        return "Alô, Mundo!";
    }
    [HttpGet("{nome}")]
    public string Get(string nome)
    {
        _logger.LogInformation($"GET /AloMundo/{nome}");
        return $"Alô, {nome}!";
    }
    [HttpGet("query")]
    public string GetQuery(string nome)
    {
        _logger.LogInformation($"GET /AloMundo/query?nome={nome}");
        return $"Alô, {nome}!";
    }
}