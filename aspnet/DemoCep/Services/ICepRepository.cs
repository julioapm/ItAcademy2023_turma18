using DemoCep.Models;

namespace DemoCep.Services;

public interface ICepRepository
{
    IEnumerable<CepModel> ConsultaTodos();
    CepModel? ConsultaPorCodigo(string codigo);
}