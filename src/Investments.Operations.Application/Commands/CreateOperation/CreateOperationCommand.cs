using FluentValidation;
using Investments.Core.Messages;
using MediatR;

namespace Investments.Operations.Application.Commands.CreateOperation;

public class CreateOperationCommand : Command, IRequest
{
    public Guid OrderId { get; set; }
    public decimal Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    
    public override bool IsValid()
    {
        var validationResult = new CreateOperationCommandValidator().Validate(this);

        return validationResult.IsValid;
    }
}

public class CreateOperationCommandValidator : AbstractValidator<CreateOperationCommand>
{
    public CreateOperationCommandValidator()
    {
        RuleFor(command => command.OrderId)
            .NotEmpty();

        RuleFor(command => command.Quantity)
            .GreaterThan(decimal.Zero);
        
        RuleFor(command => command.UnitPrice)
            .GreaterThan(decimal.Zero);
    }
}