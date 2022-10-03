namespace lab2;

public class Customer
{

    private string _name;

    public string Name
    {
        get { return _name; }
    }

    private string _password;

    public string Password
    {
        get { return _password; }
    }


    private List<Products> _cart;
    public List<Products> Cart { get { return _cart; } }

    public Customer(string name, string password)
    {
        _name = name;
        _password = password;
        _cart = new List<Products>();
        
    }

    public override string ToString()
    {
        return $"{0} and {1}";
    }
}
