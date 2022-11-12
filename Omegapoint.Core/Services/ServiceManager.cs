using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Services.Abstractions;
using Domain.RepositoryInterface;

namespace Services
{
  public sealed class ServiceManager : IServiceManager
  {
    private readonly Lazy<IPdfService> _lazyPdfService;
    public ServiceManager(IRepositoryManager repositoryManager)
    {
      _lazyPdfService = new Lazy<IPdfService>(() => new PdfService(repositoryManager));
    }
    public IPdfService PdfService => _lazyPdfService.Value;
  }
}