using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace Contracts;
public class PdfDto
{
  public int Id { get; set; }
  public string? Name { get; set; }
  public long FileSize { get; set; }
  public byte[] Content { get; set; } = null!;

}
