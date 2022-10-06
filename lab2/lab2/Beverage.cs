namespace lab2;

public class Beverage : Products
{
    public Beverage(string name, int price, int productId, int amount) : base(name, price, productId, amount)
    {
        Name = "beverage";
        Price = 25;
        ProductId = 002;
        Amount = 0;
    }
}