using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Domain.Exceptions;
using Microsoft.AspNetCore.Http;

namespace Contracts
{
  public class PdfForCreationDto
  {
    [Required]
    public IFormFile File { get; set; }
  }
}