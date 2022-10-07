using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Channels;
using lab2;


var kunder = new List<Customer>();

kunder.Add(new Customer("Knatte", "123"));
kunder.Add(new Customer("Fnatte", "321"));
kunder.Add(new Customer("Tjatte", "213"));

var produkter = new List<Products>();

var apple = new Apple("apple", 15, 0);
var beverage = new Beverage("Beverage", 35, 0);
var sausage = new Sausage("Sausage", 25, 0);


while (true)
{
    
    

    Console.Clear();
    Console.WriteLine("Välkommen till min butik!");
    Console.WriteLine("\n Var god och välj i menyn\n" +
                      "[A] Lägg till produkt \n" +
                      "[S] Visa Lista \n" +
                      "[D] Nuvarande passagerare \n" +
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






