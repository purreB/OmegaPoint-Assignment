using Microsoft.AspNetCore.Mvc;

namespace Omegapoint.Controllers
{

  [ApiController]
  [Route("pdf-api/v1/[controller]")]
  public class PdfController : Controller
  {
    [HttpGet]
    public string GetPDF()
    {
      var helloWorld = "hi";
      return helloWorld;
    }
  }
}