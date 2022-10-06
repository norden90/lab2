namespace lab2;

public class Sausage : Products
{
    public Sausage(string name, int price, int productId, int amount) : base(name, price, productId, amount)
    {
        Name = "Sausage";
        Price = 35;
        ProductId = 003;
        Amount = 0;
    }
   
}