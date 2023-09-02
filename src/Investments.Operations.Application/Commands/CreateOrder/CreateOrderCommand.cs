using FluentValidation;
using Investments.Core.Messages;
using MediatR;

namespace Investments.Operations.Application.Commands.CreateOrder;

public class CreateOrderCommand : Command, IRequest
{
    public Guid ProductId { get; set; }
    public DateTime OperationDate { get; set; }
    
    public override bool IsValid()
    {
        var validationResult = new CreateOrderCommandValidator().Validate(this);

        return validationResult.IsValid;
    }
}

public class CreateOrderCommandValidator : AbstractValidator<CreateOrderCommand>
{
    public CreateOrderCommandValidator()
    {
        RuleFor(command => command.ProductId)
            .NotEmpty();

        RuleFor(command => command.OperationDate)
            .GreaterThan(DateTime.MinValue);
    }
}