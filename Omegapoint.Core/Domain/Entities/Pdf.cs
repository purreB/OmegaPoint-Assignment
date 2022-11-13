namespace Domain.Entities
{
  public class Pdf
  {
    public int Id { get; set; }
    public byte[] Content { get; set; } = null!;
  }
}