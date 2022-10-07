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


    //public int CashOut()
    //{

    //}

    //public string LogIn()
    //{

    //}

    //public string LogOut()
    //{

    //}

    //public override string ToString()
    //{
    //    return base.ToString() + $"{0} and {1} Cart";
    //}
}


