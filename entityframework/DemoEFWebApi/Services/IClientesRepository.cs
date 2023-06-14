using DemoEFWebApi.Models;

namespace DemoEFWebApi.Services;

public interface IClientesRepositorio
{
    Task<Cliente?> ConsultarPorIdAsync(int id);
}