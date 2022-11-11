using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Exceptions
{
  public sealed class FileSizeBadRequestException : BadRequestException
  {
    public FileSizeBadRequestException(string FileSize)
    : base($"The PDF file size is {FileSize}, unfortunately the API cannot support larger than 2MB")
    {
    }
  }
}