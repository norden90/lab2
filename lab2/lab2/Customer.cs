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

    //public string VerifyPassword(string password)
    //{

    //    if (password == Password)

    //    return true;
    //} Att åtgärda för godkänt
    public override string ToString()
    {

        var message = string.Empty;
        var appleCount = 0;
        var beverageCount = 0;
        var sausageCount = 0;
        

        message += $"Namn: {Name}\n";
        message += $"Password: {Password}\n";
        message += $"Kundvagn: ";

        foreach (var produkter in Cart)
        {
            if (produkter.Name == "äpple")
            {
                appleCount++;

                if (produkter.Amount == appleCount)
                {
                    message += $" {produkter.Name}: {produkter.Price * appleCount} Kr.";
                }
            }
            else if (produkter.Name == "Pepsi Max")
            {
                beverageCount++;
                if (produkter.Amount == beverageCount)
                {
                    message += $" {produkter.Name}: {produkter.Price * beverageCount} Kr.";
                }
            }
            else if (produkter.Name == "korv")
            {
                sausageCount++;
                if (produkter.Amount == sausageCount)
                {
                    message += $" {produkter.Name}: {produkter.Price * sausageCount} Kr.";
                }
            }

        }
        

        return message;
    }
}
