namespace lab2;

public class Apple : Products
{
    public Apple(string name, int price, int productId, int amount) : base(name, price, productId, amount)
    {
        Name = "apple";
        Price = 15;
        ProductId = 001;
        Amount = 0;

    }

}