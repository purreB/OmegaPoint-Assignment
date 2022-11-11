using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Omegapoint.Api.Controllers
{
  [ApiController]
  [Route("api/v1/[controller]")]
  public class PdfController : ControllerBase
  {
    [HttpGet]
    public string GetPdf()
    {
      var helloWorld = "Hello, world!";
      return helloWorld;
    }
  }
}