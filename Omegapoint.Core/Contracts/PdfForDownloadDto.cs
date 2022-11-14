using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contracts
{
  public class PdfForDownloadDto
  {
    public int Id { get; set; }
    public string FileName { get; set; }
    public byte[] Content { get; set; } = null!;
  }
}