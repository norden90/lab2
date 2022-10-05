namespace lab2;

public class Beverage : Products
{
    public Beverage(string name, int price) : base(name, price)
    {

    }
    public override Products AddCart()
    {
        var cart = new int();
        return cart;
    }
}