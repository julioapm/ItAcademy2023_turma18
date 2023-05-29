using System.ComponentModel.DataAnnotations;

namespace DemoAloMundo.DTOs;

public class PessoaDTO
{
    public string Nome {get;set;} = null!;
    [Required]
    public int? Idade {get;set;}
}