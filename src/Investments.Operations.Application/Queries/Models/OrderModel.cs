namespace Investments.Operations.Application.Queries.Models;

public class OrderModel
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public IEnumerable<OperationModel> Operations { get; set; }
}