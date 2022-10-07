namespace lab2;

public class Beverage : Products
{
    public Beverage(string name, int price, int amount) : base(name, price, amount)
    {
        Name = name;
        Price = price;
        Amount = 0;
    }
}