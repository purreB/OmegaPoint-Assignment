using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Services.Abstractions;
using Contracts;

namespace Omegapoint.Api.Controllers
{
  [ApiController]
  [Route("api/v1/[controller]")]
  public class PdfController : ControllerBase
  {
    private readonly IServiceManager _serviceManager;
    public PdfController(IServiceManager serviceManager) => _serviceManager = serviceManager;
    [HttpGet("{pdfId}")]
    public async Task<IActionResult> GetPdfById(int pdfId, CancellationToken cancellationToken)
    {
      var pdfDto = await _serviceManager.PdfService.GetByIdAsync(pdfId, cancellationToken);
      return File(pdfDto.Content, "application/octet-stream", pdfDto.FileName);
    }

    [HttpPost]
    public async Task<IActionResult> CreatePdf([FromForm] PdfForCreationDto pdfForCreationDto)
    {
      var pdfDto = await _serviceManager.PdfService.CreateAsync(pdfForCreationDto);
      return CreatedAtAction(nameof(GetPdfById), new { pdfId = pdfDto.Id }, pdfDto);
    }
  }
}