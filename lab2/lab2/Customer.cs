namespace lab2;

public class Customer
{
    private string _password;
    private string _name;

    public string Name
    {
        get { return _name; }
    }
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
    //public int CalcCart(int Cart)
    //{
        
    //}

    //public string CheckCart()
    //{

    //}

    //public string LogIn()
    //{

    //}

    //public string LogOut()
    //{

    //}
    public override string ToString()
    {
        return $"{0} and {1}";
    }
}
