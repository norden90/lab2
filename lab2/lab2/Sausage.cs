namespace lab2;

public class Sausage : Products
{
    public Sausage(string name, int price, int amount) : base(name, price, amount)
    {
        Name = name;
        Price = price;
        Amount = 0;
    }
   
}