using System.Dynamic;

namespace lab2;

public abstract class Products
{
    protected Products(string name, int price, int productId, int quantity)
    {
        Name = name;
        Price = price;
        ProductId = productId;
        Quantity = quantity;
    }

    public string Name { get; set; }
    
    public int Price { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }


    public abstract Products AddCart();

}