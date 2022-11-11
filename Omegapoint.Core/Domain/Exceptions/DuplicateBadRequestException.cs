using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Exceptions
{
  public sealed class DuplicateBadRequestException : BadRequestException
  {
    public DuplicateBadRequestException(string pdfName, string pdfChecksum)
    : base($"The name {pdfName} and checksum {pdfChecksum} is already in use.")
    {
    }
  }
}