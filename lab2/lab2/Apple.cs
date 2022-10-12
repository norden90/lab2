namespace lab2;

public class Apple : Products
{
    public Apple(string name, int price, int amount, int productId) : base(name, price, amount, productId)
    {
        Name = name;
        Price = price;
        Amount = 0;
        ProductId = productId;
    }
}