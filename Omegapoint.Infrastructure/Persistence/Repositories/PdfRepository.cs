using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.RepositoryInterface;
using Microsoft.EntityFrameworkCore;
using Omegapoint.Infrastructure;

namespace Persistence.Repositories
{
  internal sealed class PdfRepository : IPdfRepository
  {
    private readonly RepositoryDbContext _dbContext;
    public PdfRepository(RepositoryDbContext dbContext) => _dbContext = dbContext;

    public Task<IEnumerable<Pdf>> GetAllAsync(CancellationToken cancellationToken = default)
    {
      throw new NotImplementedException();
    }

    public Task<Pdf> GetByIdAsync(int pdfId, CancellationToken cancellationToken = default)
    {
      throw new NotImplementedException();
    }

    public void Insert(Pdf pdf) => _dbContext.Pdfs.Add(pdf);
  }
}