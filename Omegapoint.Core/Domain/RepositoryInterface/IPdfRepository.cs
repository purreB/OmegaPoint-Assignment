using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.RepositoryInterface
{
  public interface IPdfRepository
  {
    Task<IEnumerable<Pdf>> GetAllAsync();
    Task<Pdf> GetByIdAsync(int pdfId);
    void Insert(Pdf pdf);
  }
}