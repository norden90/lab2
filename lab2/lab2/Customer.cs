namespace lab2;




public class Customer
{
    
    public string Name { get; private set; }

    private string Password { get; set }

    private List<Product> _cart;
    public List<Product> Cart { get { return _cart; } }

    public Kund(string name, string password)
    {
        Name = name;
        Password = password;
        _cart = new List<Product>();
    }
}
