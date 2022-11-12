using System.Reflection;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Omegapoint.Infrastructure
{
  public sealed class RepositoryDbContext : DbContext
  {
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseInMemoryDatabase(databaseName: "PdfDatabase");
    }
    public DbSet<Pdf> Pdfs { get; set; }
  }
}