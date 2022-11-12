using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.RepositoryInterface
{
  public interface IRepositoryManager
  {
    IPdfRepository PdfRepository { get; }
    IUnitOfWork UnitOfWork { get; }
  }
}