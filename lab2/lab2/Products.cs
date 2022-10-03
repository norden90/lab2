using System.Dynamic;

namespace lab2;

public abstract class Products
{
    public static int Price { get; set; }

    public abstract int AddCart();
}