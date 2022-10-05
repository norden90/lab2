using System.Dynamic;

namespace lab2;

public abstract class Products
{
    protected Products(string name, int price, int productId)
    {
        Name = name;
        Price = price;
        ProductId = productId;
        
    }

    public string Name { get; set; }
    
    public int Price { get; set; }
    public int ProductId { get; set; }


    //public abstract Products AddCart();

}