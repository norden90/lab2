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

    //void CalcCart()
    //{
    //    int sum = 0;

    //    foreach (var a in kunder)
    //    {
    //        foreach (var s in a.Cart)
    //        {
    //            s.Amount++;
    //            sum += s.Price;
    //        }
    //    }
    //    Console.WriteLine($"Din totala kostnad för alla produkter är: {sum}\n" +
    //    $"Du har {apple.Amount} {apple.Name}" +
    //                      $"Du har {sausage.Amount} {sausage.Name}" +
    //                      $"{beverage.Amount} ");
    //}


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
