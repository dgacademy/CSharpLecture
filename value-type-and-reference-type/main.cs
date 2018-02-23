using System;

class Cake {
  public string name;
  public int price;
  
  public Cake Clone() {
    Cake newCake = new Cake();
    newCake.name = name;
    newCake.price = price;
    return newCake;
  }
}

class MainClass {
  public static void Main (string[] args) {
    Cake a = new Cake();
    a.name = "Blueberry";
    a.price= 30000;
    
    Cake b = new Cake();
    b.name = a.name;
    b.price = a.price;
    
    Cake c = a.Clone();
    c.name = "Santa";
    Console.WriteLine(c.price == a.price);
    
    
  }
}






