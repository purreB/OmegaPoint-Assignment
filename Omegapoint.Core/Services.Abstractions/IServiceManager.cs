namespace Services.Abstractions
{
  public interface IServiceManager
  {
    IPdfService PdfService { get; }
  }
}