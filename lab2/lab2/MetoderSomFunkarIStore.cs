using System;
using System.Reflection;

namespace lab2;

//CheckCart(andreas.Cart);

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

//    andreas.Cart.Add(sausage);
//    andreas.Cart.Add(apple);
//    andreas.Cart.Add(sausage);

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











//        Console.Clear(); //val av meny
//        Console.WriteLine("Välkommen till min butik!");
//        Console.WriteLine("\n Var god och välj i menyn\n" +
//                          "[A] Lägg till produkt \n" +
//                          "[S] Visa totala åldern \n" +
//                          "[D] Nuvarande passagerare \n" +
//                          "[F] Antal platser kvar \n" +
//                          "[G] Genomsnittsålder \n" +
//                          "[Q] Avsluta simulatorn\n" +
//                          "                      \n" +
//                          "       _______________\n" +
//                          "    _ / _ |[][][][][] | - -\n" +
//                          "   (      Västtrafik  | - -\n" +
//                          "   = --OO------ - OO-- = dwb\n ");

//        ConsoleKeyInfo inputFromUser = Console.ReadKey(true);
//        switch (inputFromUser.Key)
//        {

//            case ConsoleKey.A: //Val av tagent öppnar en viss del av menyn.
//            {
//                AddCart();//anropa metod
//                break;
//            }
//            case ConsoleKey.S:
//            {
//                total_age();
//                break;
//            }
//            case ConsoleKey.D:
//            {
//                print_bus();
//                break;
//            }
//            case ConsoleKey.F:
//            {
//                fria_säten();
//                break;
//            }
//            case ConsoleKey.G:
//            {
//                average_age();
//                break;
//            }

//            case ConsoleKey.Q:
//            {
//                Environment.Exit(0);
//                return;
//            }
//        }
//    }
//}