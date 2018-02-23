using System;

struct Cake {
  public string name;
  public int price;
}

class Cake2 {
  public string name;
  public int price;

  
  public Cake2 Clone() {
    Cake2 newCake = new Cake2();
    newCake.name = name;
    newCake.price = price;
    return newCake;
  }
}

class MainClass {
  public static void Main (string[] args) {
    Cake cake = new Cake();
    cake.name = "Blueberry";
    cake.price = 30000;
    
    Cake b = cake;
    Console.WriteLine(b.name == "Blueberry");
    Console.WriteLine(b.price == 30000);
    
    b.price = 10000;
    Console.WriteLine(b.price == 10000);
    Console.WriteLine(cake.price == 30000);
    
    Cake2 cake2 = new Cake2();
    cake2.name = "Blueberry";
    cake2.price = 30000;    

    Cake2 newCake;
    newCake = cake2;
    newCake.name = "Santa";
    Console.WriteLine(cake2.name == "Santa");
    
    Cake2 newCake2 = newCake.Clone();
    newCake2.price = 7;
    Console.WriteLine(newCake.price == 30000);
    
    string str = "ctkim";
    string str2 = str;
    str = "OK";
    Console.WriteLine(str2 == "ctkim");
    

  }
}