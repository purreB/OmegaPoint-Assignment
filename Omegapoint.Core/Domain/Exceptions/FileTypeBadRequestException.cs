using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Exceptions
{
  public sealed class FileTypeBadRequestException : BadRequestException
  {
    public FileTypeBadRequestException(string FileType)
    : base($"The file type {FileType} is not supported, please only upload PDF files")
    {
    }
  }
}