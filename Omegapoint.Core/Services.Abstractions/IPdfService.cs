using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;

namespace Services.Abstractions
{
  public interface IPdfService
  {
    Task<IEnumerable<PdfDto>> GetAllAsync();
    Task<PdfDto> GetByIdAsync(int Id);
    Task<PdfDto> CreateAsync(PdfForCreationDto pdfForCreationDto);
  }
}