using System;

class Car {
  public string name;
  public int price;
}

class MainClass {
  public static void Main (string[] args) {
    Car car = new Car() {
      name = "Mini",
      price = 10000
    };
    
    Console.WriteLine(car.name == "Mini");
  }
}