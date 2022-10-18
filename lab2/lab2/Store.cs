﻿using System;
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

var apple = new Apple("äpple", 5, 0,1);
var beverage = new Beverage("Pepsi Max", 15, 0,2);
var sausage = new Sausage("korv", 30, 0,3);

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
        LogIn();
    }
}

void LogIn()
{
    Console.Clear();
    Console.Write("Ange ditt namn:");
    var inputUsername = Console.ReadLine();
    Console.Write("Ange ditt lösenord:");
    var inputPassword = Console.ReadLine();

    foreach (var customer in kunder)
    {
        if (inputUsername == customer.Name)
        {
            if (customer.VerifyPassword(inputPassword))
            {
                Console.Clear();
                Console.WriteLine("Välkommen!");
                loggedInCustomer = customer;
                Console.ReadKey();
                MainMenu();
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"Du skrev fel lösenord {inputUsername}!\n" +
                                  $"Var vänligen och försök igen.");
                Console.ReadKey();
                LogIn();
            }

        }
    }

    foreach (var customer in kunder)

        if (inputPassword != customer.Name)
        {
            Console.WriteLine($"{inputUsername} existerar inte! Vill du skapa en ny?\n" +
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
                Console.WriteLine("Det var tråkigt....");
                Console.ReadKey();
                Start();
            }
        }
}

void MainMenu()
{
    while (true)
    {

        Console.Clear();
        Console.WriteLine("Välkommen till min butik!");
        Console.WriteLine("\n Var god och välj i menyn.\n" +
                          "[A] Vad finns det för varor?\n" +
                          "[S] Lägg till varor.\n" +
                          "[D] Kolla i din kundvagn.\n" +
                          "[F] Totala kostnad för dina köp.\n" +
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
                CheckCart(loggedInCustomer.Cart);
                break;
            }
            case ConsoleKey.F:
            {
                CalcCart(loggedInCustomer.Cart);
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
    Console.Clear();

    var checkAmount = 0;
    var amount = 0;

    Console.Write($"Ange det numret som repesenterar produkten\n" +
                  $"\n" +
                  $"[1]: Äpplen\n" + 
                  $"[2]: Pepsi Max\n" +
                  $"[3]: Korv\n" +
                  $"\n" +
                  $"Vad vill du köpa {loggedInCustomer.Name}?:");

    var input = Console.ReadLine();

    if (input == "1")
    {
        checkAmount++;
        Console.Clear();
        Console.Write($"Ett äpple kostar {apple.Price} kr.\n" +
                          $"Hur många äpplen vill du lägga till?:");
        amount = int.Parse(Console.ReadLine());
        for (int i = 0; i < amount; i++)
        {
            loggedInCustomer.Cart.Add(apple);
            apple.Amount++;
            
        }

        if (apple.Amount == 1)
        {
            Console.WriteLine($"Det finns {apple.Amount} {apple.Name} i din kundvagn.");
            amount = 0;
            Console.ReadKey();
        }
        else if (apple.Amount > 1)
        {
            Console.WriteLine($"Det finns {apple.Amount} äpplen i din kundvagn.");
            amount = 0;
            Console.ReadKey();
        }
        
    }
    else if (input == "2")
    {
        checkAmount++;
        Console.Clear();
        Console.Write($"En Pepsi max kostar {beverage.Price} kr.\n" +
                          $"Hur många Pepsi Max vill du lägga till?:");
        
        amount = int.Parse(Console.ReadLine());
        for (int i = 0; i < amount; i++)
        {
            loggedInCustomer.Cart.Add(beverage);
            beverage.Amount++;
        }

        if (beverage.Amount == 1)
        {
            Console.WriteLine($"Lägger till {beverage.Amount} burk {beverage.Name} i din kundvagn.");
            amount = 0;
            Console.ReadKey();
        }
        else if (beverage.Amount > 1)
        {
            Console.WriteLine($"Lägger till {beverage.Amount} burkar {beverage.Name} i din kundvagn.");
            amount = 0;
            Console.ReadKey();
        }
    }
    else if (input == "3")
    {
        checkAmount++;
        Console.Clear();
        Console.Write($"En korv kostar {sausage.Price} kr.\n" +
                          $"Hur många korvar vill du lägga till?:");
        amount = int.Parse(Console.ReadLine());
        for (int i = 0; i < amount; i++)
        {
            loggedInCustomer.Cart.Add(sausage);
            sausage.Amount++;
            
        }

        if (sausage.Amount == 1)
        {
            Console.WriteLine($"Lägger till {sausage.Amount} {sausage.Name} i din kundvagn.");
            amount = 0;
            Console.ReadKey();
        }
        else if (sausage.Amount > 1)
        {
            Console.WriteLine($"Lägger till {sausage.Amount} korvar i din kundvagn.");
            amount = 0;
            Console.ReadKey();
        }
    }


    if (checkAmount == 0)
    {
        Console.WriteLine($"{loggedInCustomer.Name}, du la ingenting i din kundvang.\n" +
                          $"Återgår till menyn.");
        Console.ReadKey();
        MainMenu();
    }
    else
    {
        checkAmount = 0;
        Console.Clear();
        Console.WriteLine($"Har lagt till varor i din kundvagn {loggedInCustomer.Name}\n" +
                          $"Vill du handla något mer?\n" +
                          $"[1] Tryck 1 för Ja\n" +
                          $"[2] Tryck 2 för nej");
        var input2 = Console.ReadLine();
        if (input2 == "1")
        {
            AddCart();
        }
        else if (input2 == "2")
        {
            MainMenu();
        }
    }
}

void CheckCart(List<Products> cart)
{

    apple.Amount = 0;
    beverage.Amount = 0;
    sausage.Amount = 0;

    var totalProducts = 0;

   
        foreach (var products in cart)
        {
            products.Amount++;
            totalProducts++;
        }
    

    Console.WriteLine($"{loggedInCustomer.Name}s Kundvagn\n");

    Console.WriteLine($"{apple.Name}: {apple.Amount} st.\n" +
                      $"{beverage.Name}: {beverage.Amount} st.\n" +
                      $"{sausage.Name}: {sausage.Amount} st.\n");
    Console.ReadKey();

    if (totalProducts == 0)
    {
        Console.WriteLine("Din kundvagn är tom.");
        Console.ReadKey();
    }

}

void CalcCart(List<Products> cart)
{
    int sum = 0;

    foreach (var products in cart)
    {
        sum += products.Price;
    }
    Console.WriteLine($"Din totala kostnad för alla produkter är: {sum}\n" +
                        $"{apple.Name}: {apple.Amount} st.\n" +
                        $"{sausage.Name}: {sausage.Amount} st.\n" +
                        $"{beverage.Name}: {beverage.Amount} st.\n");
    Console.ReadKey();
}

void CashOut()
{
    Console.WriteLine(loggedInCustomer);
    Console.ReadKey();

    Console.WriteLine($"Vill du köpa dina varor?\n" +
                      "[1]: Tryck 1 för ja\n" +
                      "[2]: Tryck 2 för nej");
    var input = Console.ReadLine();

    if (input == "1")
    {
        Console.Clear();
        Console.Write($"Scannar dina varor...");
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine($"Ditt kör har gått igenom! Tack för att du handlade här på FoodStore\n" +
                          $"Välkommen åter {loggedInCustomer.Name}\n" +
                          $"Önskar dig en fin dag.");

        loggedInCustomer.Cart.Clear();
        loggedInCustomer=null;
        Console.ReadKey();
        Start();
    }
    else if (input == "2")
    {
        Console.WriteLine($"Återgår till menyn");
        Thread.Sleep(1000);
        MainMenu();
    }
}

void LogOut()
{
    Console.Clear();
    Console.WriteLine($"{loggedInCustomer.Name} loggas ut\n" +
        $"Välkommen åter!");
    Console.ReadKey();
    Start();
}

void ShowList(List<Customer> kunder)
{

    foreach (var a in kunder)
    {
        Console.WriteLine($"Name: {a.Name}");
    }
    Console.ReadKey();
}

Customer AddCustomer()

{
    Console.WriteLine("Skapa ditt nya konto här\n" +
                      "Ange ditt namn"); string tempName = Console.ReadLine();
    Console.WriteLine("Ange ett lösenord"); string tempPass = Console.ReadLine();

    var kund = new Customer(tempName, tempPass);

    return kund;
}


