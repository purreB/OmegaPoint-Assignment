using Microsoft.AspNetCore.Mvc;
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
    public string GetPdf()
    {
      var helloWorld = "Hello, world!";
      return helloWorld;
    }
    // [HttpGet("{pdfId:id}")]
    // public async Task<IActionResult> GetPdfById(int pdfId, CancellationToken cancellationToken)
    // {
    //   var pdfDto = await _serviceManager.PdfService.GetByIdAsync(pdfId, cancellationToken);
    //   return Ok(pdfDto);
    // }
  }
}