using System;

namespace Domain.Exceptions
{
  public sealed class PdfNotFoundException : NotFoundException
  {
    public PdfNotFoundException(int pdfId)
        : base($"The PDF File with the ID: {pdfId} was not found.")
    {
    }
  }
}