namespace lab2;

public class Apple : Products
{
    public Apple(string name, int price, int amount) : base(name, price, amount)
    {
        Name = "apple";
        Price = 15;
        Amount = 0;
    }
}