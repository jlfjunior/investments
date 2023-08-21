using Investments.Catalog.Domain.Entities;

namespace Investments.UnitTests;

public class QuoteTest
{
    [Fact]
    public void Quote_Constructor_MustInstanceWithSuccess()
    {
        var product = new Faker<Product>()
            .CustomInstantiator(faker
                => new Product(name: faker.Name.FullName(),
                    symbol: faker.Name.FirstName()))
            .Generate();
        
        var quote = new Faker<Quote>()
            .CustomInstantiator(faker => new Quote(product, faker.Date.Recent(), faker.Random.Decimal(0.01M, 100.00M)));

        quote.Should().NotBeNull();
    }
    
    [Fact]
    public void Quote_UpdateValue_MustChangeValueWithSuccess()
    {
        var product = new Faker<Product>()
            .CustomInstantiator(faker
                => new Product(name: faker.Name.FullName(),
                    symbol: faker.Name.FirstName()))
            .Generate();
        
        var quote = new Faker<Quote>()
            .CustomInstantiator(faker => new Quote(product, faker.Date.Recent(), faker.Random.Decimal(0.01M, 100.00M)))
            .Generate();

        quote.UpdateValue(1.50M);
        
        quote.Should().NotBeNull();
        quote.Value.Should().Be(1.50M);
    }
}