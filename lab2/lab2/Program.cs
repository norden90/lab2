//Skapa en konsollaplikation som skall agera som en enkel affär.

//När programmet körs så ska man få se någon form av meny där man ska kunna välja att registrera ny kund eller logga in.

//Därefter ska ytterligare en meny visas där man ska kunna välja att handla, se kundvagn eller gå till kassan.


using lab2;

List<Customer> Customers = new List<Customer>();

Customers.Add(new Customer("Knatte", "123"));
var kund2 = new Customer("Fnatte", "321");
var kund3 = new Customer("Tjatte", "213");



Console.WriteLine("Skapa en ny kund");

Console.WriteLine("Ange ditt namn");
var name = Console.ReadLine();
Console.WriteLine("Ange ett lösenord");
var password = Console.ReadLine();

var kund4 = new Customer(name, password);

foreach (var v in Customers)
{
    v.Name;
}