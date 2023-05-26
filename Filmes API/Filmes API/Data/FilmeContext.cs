using Filme_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Filmes_API.Data;

public class FilmeContext : DbContext
{

    public FilmeContext(DbContextOptions<FilmeContext> opts) : base(opts)
    {
        
    }

    public DbSet <Filme> Filmes { get; set; }
}
