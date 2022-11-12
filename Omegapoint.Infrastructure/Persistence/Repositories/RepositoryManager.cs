using System;
using Domain.RepositoryInterface;
using Omegapoint.Infrastructure;

namespace Persistence.Repositories
{
  public sealed class RepositoryManager : IRepositoryManager
  {
    private readonly Lazy<IPdfRepository> _lazyPdfRepository;
    private readonly Lazy<IUnitOfWork> _lazyUnitOfWork;
    public RepositoryManager(RepositoryDbContext dbContext)
    {
      _lazyPdfRepository = new Lazy<IPdfRepository>(() => new PdfRepository(dbContext));
      _lazyUnitOfWork = new Lazy<IUnitOfWork>(() => new UnitOfWork(dbContext));
    }
    public IPdfRepository PdfRepository => _lazyPdfRepository.Value;
    public IUnitOfWork UnitOfWork => _lazyUnitOfWork.Value;
  }
}