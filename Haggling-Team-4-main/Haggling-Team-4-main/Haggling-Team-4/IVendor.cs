namespace Haggling_Team_4;

public class IVendor
{
    public bool Negotiate(Product product, double offeredPrice);
    public void UpdatePerishablePrices();
    public void AddProduct(Product product);
}
