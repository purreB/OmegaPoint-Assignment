namespace Domain.Entities
{
  public class Pdf
  {
    public int Id { get; set; }
    public string? Name { get; set; }
    public long FileSize { get; set; }
    public byte[] Content { get; set; } = null!;
    public string Checksum { get; set; } = null!;
  }
}