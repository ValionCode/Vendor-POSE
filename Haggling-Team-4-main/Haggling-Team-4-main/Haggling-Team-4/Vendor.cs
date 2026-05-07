using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haggling_Team_4;
public class Vendor
{
    public List<Product>? GetProducts { get; private set; }
    public Dictionary<Product, int> InventoryPrices { get; private set; }
    public double Money { get; private set; }
    public int Patience { get; private set; }


    // private methods
    // ================================================================================

    private Product Search(string productName)
    {
        foreach (var entry in InventoryPrices)
        {
            if (entry.Key.ProductName == productName)
            {
                return entry.Key;
            }
        }
        return null;
    }

    // ================================================================================


    public Vendor(double initialMoney)
    {
        Money = initialMoney;
        Patience = 100;
        InventoryPrices = new Dictionary<Product, int>();
    }
    public bool Negotiate(string productName, decimal offeredPrice, bool IsChild)
    {   
        if(Patience == 0) return false;
        DecreasePatience(IsChild);
        if(offeredPrice > InventoryPrices[productName].Price) return true;
        else return false;
    }
    //Test
    public Product? BuyProduct(string productName){
        throw new NotImplementedException();
    }
    public void UpdatePerishablePrices()    
    {
        foreach (var entry in InventoryPrices)
        {
            if (entry.Key is FoodProduct food)
            {
                food.ChangePrice(food.Price * 0.95m);
            }
            else if (entry.Key is DrinkProduct drink)
            {
                drink.ChangePrice(drink.Price * 0.95m);
            }
        }
    }
    public void DecreasePatience(bool IsChild)
    {
        if(IsChild){
            Patience -= 5;
        }else{
            Patience -= 10;
        }
    }
    public void AddProduct(Product product)
    {
       
    }

    public bool RemoveProduct(int id)
    {
       return false;
    }

    public bool IsProductInStock(int id) 
    {
        if(InventoryPrices[])
        return false
    }
    public int GetPatience(){
        return Patience;
    }
    public void FillList(){

    }
}