namespace lab2;

public class Beverage : Products
{
    public Beverage(string name, int price, int amount) : base(name, price, amount)
    {
        Name = "beverage";
        Price = 25;
        Amount = 0;
    }
}