using System.Dynamic;

namespace lab2;

public abstract class Products
{
    protected Products(string name, int price, int amount, int productId)
    {
        Name = name;
        Price = price;
        Amount = amount;
        ProductId = productId;

    }

    public string Name { get; set; }
    
    public int Price { get; set; }
    public int ProductId { get; set; }
    public int Amount{ get; set; }
    
   


}