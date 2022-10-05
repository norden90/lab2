namespace lab2;

public class Apple : Products
{
    

    public override Products AddCart()
    {
        var cart = new int();
        return cart;
    }


    public Apple(string name, int price) : base(name, price)
    {

    }
}