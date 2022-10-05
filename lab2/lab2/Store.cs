//Skapa en konsollaplikation som skall agera som en enkel affär.

//När programmet körs så ska man få se någon form av meny där man ska kunna välja att registrera ny kund eller logga in.

//Därefter ska ytterligare en meny visas där man ska kunna välja att handla, se kundvagn eller gå till kassan.


using System.ComponentModel;
using System.Threading.Channels;
using lab2;

while (true)

{


    var kund = new List<Customer>();
    var produkter = new List<Products>(); 

    var apple = new Apple("Apple", 15);
    var beverage = new Beverage("Beverage", 35);
    var sausage = new Sausage("Sausage", 25, TODO);

    produkter.Add(apple);
    produkter.Add(beverage);
    produkter.Add(sausage);

    

    

    kund.Add(new Customer("Andreas", "666"));
    kund.Add(new Customer("Knatte", "123"));
    kund.Add(new Customer("Fnatte", "321"));
    kund.Add(new Customer("Tjatte", "213"));

    Console.WriteLine("Skapa en ny kund");

    //Console.WriteLine("Ange ditt namn");  Skapa en ny kund! 
    //var name = Console.ReadLine();
    //Console.WriteLine("Ange ett lösenord");
    //var password = Console.ReadLine();

    //var kund4 = new Customer(name, password);

    //kund.Add(kund4);

    foreach (var v in kund)
    {
        Console.WriteLine($"{v.Name} : {v.Password} {v.Cart}");
    }

    foreach (var d in produkter)
    {
        Console.WriteLine($"{d.Name} kostar {d.Price}");
        
    }

    foreach (var c in produkter)
    {
        //Console.WriteLine($"{c.} kostar {c.Price}");
    }

    Console.ReadKey();
}