namespace lab2;

public class Sausage : Products
{
    public override Sausage AddCart()
    {
        var sausage = new Sausage();
        return sausage;
    }
}