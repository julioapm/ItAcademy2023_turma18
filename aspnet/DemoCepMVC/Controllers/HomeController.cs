using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DemoCepMVC.Models;
using DemoCepMVC.Services;

namespace DemoCepMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ICepRepository _repository;

    public HomeController(ILogger<HomeController> logger, ICepRepository repository)
    {
        _logger = logger;
        _repository = repository;
    }

    public IActionResult Index()
    {
        var ceps = _repository.ConsultaTodos();
        var cepsViewModel = ceps.Select(c => CepViewModel.FromModel(c));
        return View(cepsViewModel);
    }

    //GET .../Home/Search?id=
    public IActionResult Search(string id)
    {
        ViewData["Id"] = id;
        CepModel? cep = null;
        if (!String.IsNullOrWhiteSpace(id))
        {
            cep = _repository.ConsultaPorCodigo(id);
        }
        return View(cep is not null ? CepViewModel.FromModel(cep) : cep);
    }

    //GET .../Home/Create
    public IActionResult Create()
    {
        return View();
    }

    //POST .../Home/Create
    [HttpPost]
    public IActionResult Create(CepViewModel novoCep)
    {
        if (!ModelState.IsValid)
        {
            return View(novoCep);
        }
        _repository.Cadastrar(CepModel.FromViewModel(novoCep));
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
