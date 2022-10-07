namespace lab2;

public class Apple : Products
{
    public Apple(string name, int price, int amount) : base(name, price, amount)
    {
        Name = name;
        Price = price;
        Amount = 0;
    }
}