using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Contracts;
using Domain.Entities;
using Domain.Exceptions;
using Domain.RepositoryInterface;
using Mapster;
using Services.Abstractions;

namespace Services;

internal sealed class PdfService : IPdfService
{
  private readonly IRepositoryManager _repositoryManager;
  public PdfService(IRepositoryManager repositoryManager) => _repositoryManager = repositoryManager;
  public async Task<IEnumerable<PdfDto>> GetAllAsync(CancellationToken cancellationToken = default)
  {
    var pdfs = await _repositoryManager.PdfRepository.GetAllAsync(cancellationToken);
    var pdfsDto = pdfs.Adapt<IEnumerable<PdfDto>>();
    return pdfsDto;
  }

  public async Task<PdfDto> GetByIdAsync(int id, CancellationToken cancellationToken = default)
  {
    var pdf = await _repositoryManager.PdfRepository.GetByIdAsync(id, cancellationToken);
    if (pdf is null)
    {
      throw new PdfNotFoundException(id);
    }

    var pdfDto = pdf.Adapt<PdfDto>();
    return pdfDto;
  }

  public async Task<PdfDto> CreateAsync(PdfForCreationDto pdfForCreationDto, CancellationToken cancellationToken = default)
  {
    //! HERE WE ADD THE ACTUAL UPLOAD
    //* Add Error Handling here??
    var file = pdfForCreationDto.File;
    long FileSize = file.Length;
    string name = file.FileName.Replace(@"\\\\", @"\\");

    var memoryStream = new MemoryStream();

    await file.CopyToAsync(memoryStream);
    if (memoryStream.Length > 2097152)
    {
      throw new FileSizeBadRequestException(memoryStream.Length);
    }

    var pdf = new PdfDto()
    {
      Name = Path.GetFileName(name),
      FileSize = memoryStream.Length,
      Content = memoryStream.ToArray()
    };
    var pdfUpload = pdf.Adapt<Pdf>();
    _repositoryManager.PdfRepository.Insert(pdfUpload);
    await _repositoryManager.UnitOfWork.SaveChangesAsync(cancellationToken);
    memoryStream.Close();
    memoryStream.Dispose();
    return pdf.Adapt<PdfDto>();





    // var pdf = pdfForCreationDto.Adapt<Pdf>();
    // _repositoryManager.PdfRepository.Insert(pdf);
    // await _repositoryManager.UnitOfWork.SaveChangesAsync(cancellationToken);
    // return pdf.Adapt<PdfDto>();
  }
}

