using System;

interface IEquatable {
  bool Equals(Car car);
}

interface ICloneable {
  Car Clone();
}


class Car : IEquatable, ICloneable {
  public string Make { get; set; }
  public string Model { get; set; }
  public string Year { get; set; }
  
  public bool Equals(Car car) {
    if (Make == car.Make && Model == car.Model && Year == car.Year)
      return true;
    else
      return false;
  }
  
  public Car Clone() {
    Car newCar = new Car();
    newCar.Make = Make;
    newCar.Model = Model;
    newCar.Year = Year;
    return newCar;
  }
}

class Cake {
}

class MainClass {
  public static void Main (string[] args) {
    Car car = new Car();
    car.Make = "BMW";
    car.Model = "Mini";
    car.Year = "2018";
    
    Console.WriteLine(car is int == false);
    Console.WriteLine(car is Cake == false);
    Console.WriteLine(car is Car == true);
    Console.WriteLine(car is IEquatable == true);
    Console.WriteLine(car is ICloneable == true);
    Console.WriteLine(car is object == true);

    ICloneable ic = car as ICloneable;
    Console.WriteLine(ic != null);
    Console.WriteLine(ic.GetType().Name == "Car");
    
    // Cake cake = car as Cake;
    // Console.WriteLine(cake == null);
    
  }
}















