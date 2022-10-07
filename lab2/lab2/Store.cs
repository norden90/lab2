using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Channels;
using lab2;

while (true)
    
{
    var kunder = new List<Customer>();
    var produkter = new List<Products>(); 

    var apple = new Apple("apple", 15, 0);
    var beverage = new Beverage("Beverage", 35, 0);
    var sausage = new Sausage("Sausage", 25, 0);

    //produkter.Add(apple);
    //produkter.Add(beverage);
    //produkter.Add(sausage);




    kunder.Add(new Customer("Andreas", "666"));
    kunder.Add(new Customer("Knatte", "123"));
    kunder.Add(new Customer("Fnatte", "321"));
    kunder.Add(new Customer("Tjatte", "213"));
    
    var andreas = kunder.FirstOrDefault(c => c.Name == "Andreas");
    
    //andreas.Cart.Add(sausage);
    //andreas.Cart.Add(apple);
    //andreas.Cart.Add(sausage);

    AddCart();


    void AddCart()
    {
        
        Console.WriteLine($"Hej {andreas.Name}! Vad vill du lägga till i din kundvagn?");

        andreas.Cart.Add(sausage);
        andreas.Cart.Add(apple);
        andreas.Cart.Add(sausage);

        foreach (var a in kunder)
        {
            foreach (var k in a.Cart)

            {
                Console.WriteLine($"Du har en {k.Name}, kostar {k.Price}");
            }
        }

        Console.ReadKey();

    }

    foreach (var a in kunder)
    {
        Console.WriteLine($"Hej {a.Name}, det här har du i din kundvagn");
        foreach (var k in a.Cart)

        {
            Console.WriteLine($"Du har en {k.Name}, kostar {k.Price}");
        }
    }
    

    //void CheckCart(List<Products> productsList)
    //{
    //    Console.WriteLine($"Hej {andreas.Name}! Här är din kundvagn!");

    //    foreach (var a in kunder)
    //    {
    //        foreach (var k in a.Cart)

    //        {
    //            Console.WriteLine($"Du har en {k.Name}, kostar {k.Price}");
    //        }
    //    }
    //}























    //foreach (var a in kunder)
    //{
    //    foreach (var k in a.Cart)

    //    {
    //        Console.WriteLine($"{k.Name} kostar {k.Price}");
    //    }
    //}

    //foreach (var v in kunder)
    //{
    //    Console.WriteLine($"{v.Name} : {v.Password}");
    //}

    //foreach (var d in produkter)
    //{
    //    Console.WriteLine($"{d.Name} kostar {d.Price}");
    //}

    //int sum = 0;

    //foreach (var a in kunder)
    //{
    //    foreach (var k in a.Cart)

    //    {
    //        Console.WriteLine($"{k.Name} kostar {k.Price}");
    //        sum += k.Price;
    //    }
    //}

    //Console.WriteLine(sum);

    //if (andreas.Cart.Contains(sausage))
    //{
    //    Console.WriteLine("Har korvar.");
    //}
    //else
    //{
    //    Console.WriteLine("har ingen dryck!");
    //}
    Console.ReadKey();
}






    