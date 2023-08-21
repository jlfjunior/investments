using Investments.Catalog.Domain.Entities;
using Investments.Core.DomainObjects;

namespace Investments.UnitTests;

public class ProductTest
{
    [Fact]
    public void Product_Constructor_MustInstanceWithSuccess()
    {
        var product = new Faker<Product>()
            .CustomInstantiator(faker
                => new Product(name: faker.Name.FullName(),
                    symbol: faker.Name.FirstName()))
            .Generate();

        product.Should()
            .NotBeNull();

        product.Id.Should().NotBeEmpty();
        product.Name.Should().NotBeEmpty();
        product.Symbol.Should().NotBeEmpty();
        product.IsEnabled.Should().BeFalse();
    }
    
    [Fact]
    public void Product_Enabled_ProductMustBeEnabled()
    {
        var product = new Faker<Product>()
            .CustomInstantiator(faker
                => new Product(name: faker.Name.FullName(),
                    symbol: faker.Name.FirstName()))
            .Generate();

        product.Enable();
        
        product.Id.Should().NotBeEmpty();
        product.Name.Should().NotBeEmpty();
        product.Symbol.Should().NotBeEmpty();
        product.IsEnabled.Should().BeTrue();
    }
    
    [Theory]
    [InlineData("Fund", null, "Value cannot be null, empty or white spaces.")]
    [InlineData(null, "XPTO", "Value cannot be null, empty or white spaces.")]
    public void Product_IsValid_MustThrowDomainException(string name, string symbol, string message)
    {
        var exception = Assert.Throws<DomainException>(() => 
            new Product(name, symbol));

        exception.Message.Should().Be(message);
    }
}