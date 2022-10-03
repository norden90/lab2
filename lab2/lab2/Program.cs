//Skapa en konsollaplikation som skall agera som en enkel affär.

//När programmet körs så ska man få se någon form av meny där man ska kunna välja att registrera ny kund eller logga in.

//Därefter ska ytterligare en meny visas där man ska kunna välja att handla, se kundvagn eller gå till kassan.


using System.Threading.Channels;
using lab2;

var customers = new List<Customer>();

//var kund1 = new Customer("Knatte", "123");
//var kund2 = new Customer("Fnatte", "321");
//var kund3 = new Customer("Tjatte", "213");

customers.Add(new Customer("Knatte", "123"));
customers.Add(new Customer("Fnatte", "321"));
customers.Add(new Customer("Tjatte", "213"));

//customers.Add(kund1);
//customers.Add(kund2);
//customers.Add(kund3);


Console.WriteLine("Skapa en ny kund");

Console.WriteLine("Ange ditt namn");
var name = Console.ReadLine();
Console.WriteLine("Ange ett lösenord");
var password = Console.ReadLine();

var kund4 = new Customer(name, password);

customers.Add(kund4);

AddCustomer.()

foreach (var v in customers)
{
   Console.WriteLine($" {v.Name} : {v.Password}");
}