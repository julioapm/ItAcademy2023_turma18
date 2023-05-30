using DemoCep.Models;
using System.Collections.Concurrent;

namespace DemoCep.Services;

public class CepRepositoryMemoria : ICepRepository
{
    private readonly ConcurrentDictionary<string, CepModel> dados =
        new ConcurrentDictionary<string, CepModel>();
    public CepRepositoryMemoria()
    {
        dados.TryAdd("90619900", new CepModel{
            Cep = "90619900",
            Estado = "RS",
            Cidade = "Porto Alegre",
            Bairro = "Partenon",
            Logradouro = "Avenida Ipiranga, 6681"
        });
        dados.TryAdd("01001000", new CepModel{
            Cep = "01001000",
            Estado = "SP",
            Cidade = "São Paulo",
            Bairro = "Sé",
            Logradouro = "Praça da Sé"
        });
    }

    public CepModel Cadastrar(CepModel cep)
    {
        dados.TryAdd(cep.Cep, cep);
        return cep;
    }

    public CepModel? ConsultaPorCodigo(string codigo)
    {
        CepModel? cep;
        dados.TryGetValue(codigo, out cep);
        return cep;
    }

    public IEnumerable<CepModel> ConsultaTodos()
    {
        return dados.Values;
    }
}