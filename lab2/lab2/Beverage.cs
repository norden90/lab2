namespace lab2;

public class Beverage : Products
{
    public Beverage(string name, int price, int productId) : base(name, price, productId)
    {
        Name = "beverage";
        Price = 25;
        ProductId = 2;
    }
}