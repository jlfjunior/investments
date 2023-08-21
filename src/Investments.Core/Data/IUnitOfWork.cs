namespace Investments.Core.Data;

public interface IUnitOfWork
{
    Task<bool> CommitAsync();
}