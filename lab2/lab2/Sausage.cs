namespace lab2;

public class Sausage : Products
{
    public Sausage(string name, int price, int productId) : base(name, price, productId)
    {
        Name = "Sausage";
        Price = 35;
        ProductId = 003;
    }
   
}