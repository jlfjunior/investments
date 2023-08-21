using Investments.Core.DomainObjects;

namespace Investments.Core.Data;

public interface IRepository<T> where T : IAggregateRoot
{
    IUnitOfWork UnitOfWork { get; }
}