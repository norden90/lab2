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

var apple = new Apple("apple", 15, 0);
var beverage = new Beverage("Beverage", 35, 0);
var sausage = new Sausage("Sausage", 25, 0);

//var andreas = kunder.FirstOrDefault(c => c.Cart == "Andreas");

//andreas.Cart.Add(sausage);

Customer? loggedInCustomer = null;

while (true)
{
    
    Console.Clear();
    Console.WriteLine("Välkommen till min butik!");
    Console.WriteLine("\n Var god och välj i menyn\n" +
                      "[A] Lägg till en kund \n" +
                      "[S] Visa Lista \n" +
                      "[D] Logga in \n" +
                      "[F] Antal platser kvar \n" +
                      "[G] Genomsnittsålder \n" +
                      "[Q] Avsluta simulatorn\n" +
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
            kunder.Add(AddCustomer());
            break;
        }
        case ConsoleKey.S:
        {
            ShowList(kunder);
            break;
        }
        case ConsoleKey.D:
        {
            LogIn();
            break;
        }
        case ConsoleKey.F:
        {
            break;
        }
        case ConsoleKey.G:
        {
            break;
        }

        case ConsoleKey.Q:
        {
            Environment.Exit(0);
            return;
        }

    }

}
Customer AddCustomer()

{
    Console.WriteLine("Hej och välkommen! " + "Ange ditt namn"); string tempName = Console.ReadLine();
    Console.WriteLine("Ange ett lösenord"); string tempPass = Console.ReadLine();

    var kund = new Customer(tempName, tempPass);

    return kund;
}

void ShowList(List<Customer> kund)
{

    foreach (var a in kund)
    {
        Console.WriteLine($"Name: {a.Name} Password: {a.Password}");
    }
    Console.ReadKey();
}

void LogIn()
{

    Console.WriteLine("Skriv in ditt namn:");
    var username = Console.ReadLine();

    Console.WriteLine("Skriv in ett lösenord:");
    var password = Console.ReadLine();

    foreach (var a in kunder)
    {
        if (a.Name == username && a.Password == password)
        {
            Console.WriteLine($"Du finns! {a.Name} ");
            Console.ReadKey();
        }
        else
        {
            break;
        }
    }
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

void LogOut()
{

}

void Start()
{

}

void CashOut()
{

}






