namespace lab2;

public class Customer
{
    private string _password;
    private string _name;
    private List<Products> _cart;

    public string Name
    {
        get { return _name; }
    }
    public string Password
    {
        get { return _password; }
    }
    public List<Products> Cart
    {
        get { return _cart; }
    }

    public Customer(string name, string password)
    {
        _name = name;
        _password = password;
        _cart = new List<Products>();
    }

    public override string ToString()
    {

        var message = string.Empty;
        var counter = 0;

        message += $"Namn: {Name}\n";
        message += $"Password: {Password}\n";
        message += $"Kundvagn: ";

        foreach (var produkter in Cart)
        {

            counter++;
            if (counter == produkter.Amount)
            {
                message += $"{produkter.Name}: {produkter.Price * produkter.Amount}";
                counter = 0;
            }
        }
        return message;
    }
}
