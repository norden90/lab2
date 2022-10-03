namespace lab2;




public class Customer
{

    private string _name;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    private string _password;

    public string Password
    {
        get { return _password; }
        set { _password = value; }
    }


    private List<Product> _cart;
    public List<Product> Cart { get { return _cart; } }

    public Customer(string name, string password)
    {
        _name = name;
        _password = password;
        _cart = new List<Product>();
        
    }

    public Customer[]AddCustomer(string name, string password)
    {

        Console.WriteLine("Ange ditt namn");
        var tempName = Console.ReadLine();
        Console.WriteLine("Ange ett lösenord");
        var tempPassword = Console.ReadLine();

        var kund = new Customer(tempName, tempPassword);

        return Customer;


    }
}
