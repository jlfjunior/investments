namespace Investments.Catalog.Application.Requests;

public class ProductRequest
{
    public string CNPJ { get; set; }
    public string Name { get; set; }
    public string Symbol { get; set; }
}