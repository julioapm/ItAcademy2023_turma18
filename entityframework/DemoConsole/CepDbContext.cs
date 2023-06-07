using Microsoft.EntityFrameworkCore;

public class CepDbContext : DbContext
{
    public DbSet<CepEntity> Ceps {get;set;} = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=JULIO-NOTEG15\SQLEXPRESS;Database=ita18democep;Trusted_Connection=True;Encrypt=False;");
        optionsBuilder.EnableSensitiveDataLogging().LogTo(Console.WriteLine);
    }
}