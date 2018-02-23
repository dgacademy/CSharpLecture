using System;

class Car<T, U> {
  public T t;
  public U u;
}

class MainClass {
  public static void Main (string[] args) {
    Car<string, int> car = new Car<string, int>();
    car.t = "string";
    car.u = 100;
    
    Console.WriteLine(car.t == "string");
    Console.WriteLine(car.u == 100);
    
    Car<double, string> car2 = new Car<double, string>();
    
  }
}



