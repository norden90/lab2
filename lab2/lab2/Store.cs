using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.IO.Compression;
using System.Threading.Channels;
using lab2;


var kunder = new List<Customer>();
var produkter = new List<Products>();

kunder.Add(new Customer("Andreas", "k"));
kunder.Add(new Customer("Knatte", "123"));
kunder.Add(new Customer("Fnatte", "321"));
kunder.Add(new Customer("Tjatte", "213"));

var apple = new Apple("apple", 5, 0,1);
var beverage = new Beverage("Beverage", 15, 0,2);
var sausage = new Sausage("Sausage", 30, 0,3);

produkter.Add(apple);
produkter.Add(beverage);
produkter.Add(sausage);

Customer? loggedInCustomer = null;

Start();

void Start()
{
    Console.WriteLine("Hej och välkommen till TruckStore!\n" +
                      "[1]: Tryck 1 för att logga in?\n" +
                      "[2]: Tryck 2 för att skapa en ny kund.");
    var input = Console.ReadLine();

    if (input == "1")
    {
        Console.WriteLine("Går till log in");
        LogIn();
    }
    else if (input == "2")
    {
        kunder.Add(AddCustomer());
    }
}

void LogIn()
{

    Console.Write("Ange ditt namn:");
    var inputUsername = Console.ReadLine();
    Console.WriteLine("Ange ditt lösenord:");
    var inputPassword = Console.ReadLine();

    var attemptCustomer = new Customer(inputUsername, inputPassword);

    foreach (var customer in kunder)
    {
        if (attemptCustomer.Name == customer.Name)
        {
            if (attemptCustomer.Password == customer.Password)
            {
                Console.WriteLine("Välkommen!");
                loggedInCustomer = customer;
                Console.ReadKey();
                MainMenu();
            }
            else if (attemptCustomer.Password != customer.Password)
            {
                Console.WriteLine($"Du skrev fel lösenord {attemptCustomer.Name}!\n" +
                    $"Var vänligen och försök igen.");
                Console.ReadKey();
                LogIn();
            }
        }
    }

    foreach (var customer in kunder)
    
        if (attemptCustomer .Name != customer.Name)
        {
            Console.WriteLine($"{attemptCustomer.Name} existerar inte! Vill du skapa en ny?\n" +
                $"[1]: Tryck 1 för ja.\n" +
                $"[2]: Tryck 2 för nej.");
            var input = Console.ReadLine();
            if (input == "1")
            {
                kunder.Add(AddCustomer());
                LogIn();
            }
            else if (input == "2")
            {
                Console.WriteLine("Skit i det då....");
                attemptCustomer = null;
                Thread.Sleep(2000);
                Start();
            }
        }
    }



Customer AddCustomer()

{
    Console.WriteLine("Skapa ditt nya konto här\n" +
                    "Ange ditt namn"); string tempName = Console.ReadLine();
    Console.WriteLine("Ange ett lösenord"); string tempPass = Console.ReadLine();

    var kund = new Customer(tempName, tempPass);

    return kund;
}

void MainMenu()
{
    while (true)
    {

        Console.Clear();
        Console.WriteLine("Välkommen till min butik!");
        Console.WriteLine("\n Var god och välj i menyn.\n" +
                          "[A] Vad finns det för varor?\n" +
                          "[S] Lägg till varor. \n" +
                          "[D] Lägga till produkter.\n" +
                          "[F] Kolla i din kundvagn.\n" +
                          "[G] Betala dina varor.\n" +
                          "[T] Vilka kunder finns i butiken?\n" +
                          "[Q] Logga ut\n" +
                          "                      \n" +
                          "       _______________\n" +
                          "    _ / _ |[][][][][] | - -\n" +
                          "   (      FoodStore   | - -\n" +
                          "   = --OO------ - OO-- = dwb\n ");

        ConsoleKeyInfo inputFromUser = Console.ReadKey(true);
        switch (inputFromUser.Key)
        {

            case ConsoleKey.A:
            {
                ShowProducts();
                break;
            }
            case ConsoleKey.S:
            {
                AddCart();
                break;
            }
            case ConsoleKey.D:
            {
                AddCart();
                break;
            }
            case ConsoleKey.F:
            {
                CheckCart();
                break;
            }
            case ConsoleKey.G:
            {
                CashOut();
                break;
            }
            case ConsoleKey.T:
            {
                ShowList(kunder);
                break;
            }

            case ConsoleKey.Q:
            {
                LogOut();
                 return;
            }

        }

    }
}

void ShowProducts()
{
    Console.Clear();
    foreach (var item in produkter)
    {
        if (item.Name == apple.Name)
        {
            Console.WriteLine($"Vi har äpplen." +
                $"Priset för ett äpple är {apple.Price}.\n");
        }
        else if (item.Name == beverage.Name)
        {
            Console.WriteLine($"Vi har Pepsi max i butiken." +
                $"En flaska kostar {item.Price}.\n");
        }
        else if (item.Name == sausage.Name)
        {
            Console.WriteLine($"Och tillsist har vi korvar från Dusseldorf." +
                $"Priset för en korv är {item.Price}.\n");
        }
    }
    Console.WriteLine("Här är våra varor.");
    Console.ReadKey();
}

void AddCart()
{
    loggedInCustomer.Cart.Add(apple);
}

void CheckCart()
{

}

void CalcCart()
{
    int sum = 0;

    foreach (var a in kunder)
    {
        foreach (var s in a.Cart)
        {
            s.Amount++;
            sum += s.Price;
        }
    }
    Console.WriteLine($"Din totala kostnad för alla produkter är: {sum}\n" +
    $"Du har {apple.Amount} {apple.Name}" +
                        $"Du har {sausage.Amount} {sausage.Name}" +
                        $"{beverage.Amount} ");
}

void CashOut()
{

}

void LogOut()
{
    Console.Clear();
    Console.WriteLine($"{loggedInCustomer.Name} loggas ut\n" +
        $"Välkommen åter!");
    loggedInCustomer = null;
    Thread.Sleep(1000);
    Start();
}

void ShowList(List<Customer> kunder)
{

    foreach (var a in kunder)
    {
        Console.WriteLine($"Name: {a.Name} Password: {a.Password}");
    }
    Console.ReadKey();
}



