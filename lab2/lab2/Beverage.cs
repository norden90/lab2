namespace lab2;

public class Beverage : Products
{
    public Beverage(string name, int price, int amount, int productId) : base(name, price, amount, productId)
    {
        Name = name;
        Price = price;
        Amount = 0;
        ProductId = productId;

    }
}