using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haggling_Team_4;
public class Vendor
{
    public Dictionary<string, Product> InventoryPrices { get; private set; }
    public double Money { get; private set; }
    public int Patience { get; private set; }

    public Vendor(double initialMoney)
    {
        Money = initialMoney;
        Patience = 10;
        InventoryPrices = new Dictionary<string, Product>();
    }
    public bool Negotiate(string productName, double offeredPrice)
    {
        return false;
    }
    public void UpdatePerishablePrices()
    {
        foreach (var entry in InventoryPrices)
        {
            if (entry.Value is FoodProduct food)
            {
                food.ChangePrice(food.Price * 0.95m);
            }
            else if (entry.Value is DrinkProduct drink)
            {
                drink.ChangePrice(drink.Price * 0.95m);
            }
        }
    }
    public void DecreasePatience()
    {

    }
    public void AddProduct(Product product)
    {
       
    }
}