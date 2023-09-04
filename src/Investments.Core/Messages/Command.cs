using MediatR;

namespace Investments.Core.Messages;

public abstract class Command : IRequest<bool>
{
    public DateTime Timestamp { get; private set; }
    
    protected Command()
    {
        Timestamp = DateTime.Now;
    }

    public abstract bool IsValid();
}