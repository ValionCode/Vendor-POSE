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

    }
    public void DecreasePatience()
    {

    }
}