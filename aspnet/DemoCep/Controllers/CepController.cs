using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using DemoCep.Services;
using DemoCep.Models;
using DemoCep.DTOs;

namespace DemoCep.Controllers;

[ApiController]
[Route("api/v1/cep")]
[EnableCors("PermiteTudo")]
public class CepController : ControllerBase
{
    private ICepRepository _cepRepository;
    private ILogger<CepController> _logger;
    public CepController(ICepRepository cepRepository, ILogger<CepController> logger)
    {
        _cepRepository = cepRepository;
        _logger = logger;
    }
    //GET .../api/v1/cep
    [HttpGet]
    public IEnumerable<CepRespostaDTO> GetTodos()
    {
        return _cepRepository.ConsultaTodos()
                .OrderBy(c => c.Cidade)
                .Select(c => CepModel.ParaDTO(c))
                .ToArray();
    }
    //GET .../api/v1/cep/90619900
    [HttpGet("{codigocep:regex(^\\d{{8}}$)}")]
    [ProducesResponseType(200)]
    [ProducesResponseType(404)]
    public ActionResult<CepRespostaDTO> Get(string codigocep)
    {
        _logger.LogInformation($"GET .../api/v1/cep/{codigocep}");
        var cep = _cepRepository.ConsultaPorCodigo(codigocep);
        if (cep == null)
        {
            return NotFound();
        }
        return CepModel.ParaDTO(cep);
    }
    //POST .../api/v1/cep
    [HttpPost]
    [ProducesResponseType(201)]
    [ProducesResponseType(404)]
    [ProducesResponseType(500)]
    public ActionResult<CepRespostaDTO> Post(CepRequisicaoDTO cepdto)
    {
        CepModel? cepAtual = _cepRepository.ConsultaPorCodigo(cepdto.Cep);
        if (cepAtual != null) {
            return Problem("Cep já existe na base de dados");
        }
        CepModel cepNovo = _cepRepository.Cadastrar(CepModel.ParaModel(cepdto));
        return CreatedAtAction(nameof(Get), new {codigocep = cepNovo.Cep}, cepNovo);
    }
}