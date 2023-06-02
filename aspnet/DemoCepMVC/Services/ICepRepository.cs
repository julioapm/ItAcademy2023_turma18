using DemoCepMVC.Models;

namespace DemoCepMVC.Services;

public interface ICepRepository
{
    IEnumerable<CepModel> ConsultaTodos();
    CepModel? ConsultaPorCodigo(string codigo);
    CepModel Cadastrar(CepModel cep);
}