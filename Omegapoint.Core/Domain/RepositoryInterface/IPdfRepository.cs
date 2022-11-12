using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.RepositoryInterface
{
  public interface IPdfRepository
  {
    Task<IEnumerable<Pdf>> GetAllAsync(CancellationToken cancellationToken = default);
    Task<Pdf> GetByIdAsync(int pdfId, CancellationToken cancellationToken = default);
    void Insert(Pdf pdf);
  }
}