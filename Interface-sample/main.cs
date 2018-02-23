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

class MainClass {
  public static void Main (string[] args) {
    Car car = new Car();
    car.Make = "BMW";
    car.Model = "Mini";
    car.Year = "2018";
    
    Car car2 = new Car();
    car2.Make = "Tesla";
    car2.Model = "X";
    car2.Year = "2018";
    
    Console.WriteLine(car != car2);
    Console.WriteLine(car.Equals(car2) != true);
    
    Car cloneCar = car.Clone();
    Console.WriteLine(cloneCar.Equals(car) == true);
    cloneCar.Make = "Honda";
    Console.WriteLine(car.Make == "BMW");
    
    Console.WriteLine(car.Stringify() == "BMW, Mini, 2018");
  }
}















