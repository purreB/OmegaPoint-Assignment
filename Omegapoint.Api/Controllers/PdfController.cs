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
    [HttpGet]
    public async Task<IActionResult> GetPdfs(CancellationToken cancellationToken)
    {
      var pdfs = await _serviceManager.PdfService.GetAllAsync(cancellationToken);
      return Ok(pdfs);
    }
    [HttpGet("{pdfId}")]
    public async Task<IActionResult> GetPdfById(int pdfId, CancellationToken cancellationToken)
    {
      var pdfDto = await _serviceManager.PdfService.GetByIdAsync(pdfId, cancellationToken);
      return Ok(pdfDto);
    }

    [HttpPost]
    public async Task<IActionResult> CreatePdf([FromForm] PdfForCreationDto pdfForCreationDto)//CreatePdf([FromForm] IFormFile file) //PdfForCreationDto pdfForCreationDto)
    {
      var pdfDto = await _serviceManager.PdfService.CreateAsync(pdfForCreationDto);
      return CreatedAtAction(nameof(GetPdfById), new { pdfId = pdfDto.Id }, pdfDto);
    }
  }
}