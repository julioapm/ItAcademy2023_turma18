Console.WriteLine("Iniciando conexão com BD");
using (var db = new CepDbContext())
{
    /*
    Console.WriteLine("Inserindo dados");
    db.Ceps.Add(new CepEntity
    {
        Cep="12345678",
        Estado="RS",
        Cidade="Porto Alegre",
        Bairro="Centro",
        Logradouro="Borges de Medeiros"
    });
    db.SaveChanges();
    */
    /*
    Console.WriteLine("Consultando dados");
    //var todosCeps = db.Ceps.ToList();
    var todosCeps = db.Ceps.OrderBy(c => c.Cidade).ToList();
    todosCeps.ForEach(c => Console.WriteLine($"Id={c.Id} Cep={c.Cep}"));
    */
    /*
    Console.WriteLine("Alterando dados");
    var umCep = await db.Ceps.FindAsync(2);
    if (umCep != null)
    {
        umCep.Bairro = "Outro bairro";
    }
    await db.SaveChangesAsync();
    */
    Console.WriteLine("Removendo dados");
    var umCep = await db.Ceps.FindAsync(2);
    if (umCep != null)
    {
        db.Ceps.Remove(umCep);
    }
    await db.SaveChangesAsync();
}
Console.WriteLine("Finalizando o programa");