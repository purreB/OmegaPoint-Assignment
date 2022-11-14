using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;

namespace Services.Abstractions
{
  public interface IPdfService
  {
    Task<IEnumerable<PdfDto>> GetAllAsync(CancellationToken cancellationToken = default);
    Task<PdfForDownloadDto> GetByIdAsync(int Id, CancellationToken cancellationToken = default);
    Task<PdfDto> CreateAsync(PdfForCreationDto pdfForCreationDto, CancellationToken cancellationToken = default);
  }
}