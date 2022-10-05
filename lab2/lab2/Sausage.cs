namespace lab2;

public class Sausage : Products
{
    public Sausage(string name, int price, int productId, int quantity) : base(name, price, productId, quantity)
    {
        Name = "Sausage";
        Price = 25;
        ProductId = 3;
    }
    public override Products AddCart()
    {
        

        return sausage;
    }
}