namespace lab2;

public class Sausage : Products
{
    public Sausage(string name, int price, int amount) : base(name, price, amount)
    {
        Name = "sausage";
        Price = 35;
        Amount = 0;
    }
   
}