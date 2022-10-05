using System.Dynamic;

namespace lab2;

public abstract class Products
{
    protected Products(string name, int price)
    {
        Name = name;
        Price = price;
    }

    public string Name { get; set; }
    
    public int Price { get; set; }

    public abstract Products AddCart();

}