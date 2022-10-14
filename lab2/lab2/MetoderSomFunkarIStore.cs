using System;
using System.Reflection;

namespace lab2;



//CalcCart();


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


//AddCart();


//void AddCart()
//{

//    Console.WriteLine($"Hej {andreas.Name}! Vad vill du lägga till i din kundvagn?");

//andreas.Cart.Add(sausage);
//andreas.Cart.Add(apple);
//andreas.Cart.Add(sausage);

//    foreach (var a in kunder)
//    {
//        foreach (var k in a.Cart)

//        {
//            Console.WriteLine($"Du har en {k.Name}, kostar {k.Price}");
//        }
//    }

//    Console.ReadKey();

//}

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

//    }
//}


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



//if (username == a.Name && password == a.Password)
//{
//    Console.WriteLine("Du har loggat in! Välkommen");
//    Console.ReadLine();
//    Console.ReadKey();
//    break;
//}
//else if (username == a.Name && password != a.Password)
//{
//    Console.WriteLine("Du har skrivit fel lösenord!");
//    Console.WriteLine("Försök igen!");
//    break;
//}
//else if (username != a.Name && password != a.Password)
//{
//    Console.WriteLine("Användaren finns inte, vill du skapa en ny?\n" +
//                      "1: Ja\n" +
//                      "2: Nej");
//    var temp = Console.ReadLine();
//    if (temp == "1")
//    {
//        kunder.Add(AddCustomer());

//    }
//    else if (temp == "2")
//    {
//        Console.WriteLine("Återgår till loginsidan");
//        Console.ReadKey();
//        LogIn();
//    }
//}

//void CalcCart(List<Products> cart)
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
//                      $"Du har {apple.Amount} {apple.Name}" +
//                      $"Du har {sausage.Amount} {sausage.Name}" +
//                      $"{beverage.Amount} ");
//}