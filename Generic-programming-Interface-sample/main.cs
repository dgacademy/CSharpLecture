using System;

interface IEquatable<T> {
  bool Equals(T obj);   // public 생략 가능
}

interface IStringifable {
  string Stringify();
}

interface ICloneable<T> {
  T Clone();
}

public class Car : IEquatable<Car>, IStringifable, ICloneable<Car>
{
  public string Make {get; set;}
  public string Model { get; set; }
  public string Year { get; set; }

  public bool Equals(Car car)
  {
    if (this.Make == car.Make && this.Model == car.Model && this.Year == car.Year)
        return true;
    else
        return false;
  }
  
  public string Stringify() {
    return Make + ", " + Model + ", " + Year;
  }
  
  public Car Clone() {
    Car car = new Car();
    car.Make = this.Make;
    car.Model = this.Model;
    car.Year = this.Year;
    return car;
  }
}

class MainClass {
  public static void Main (string[] args) {
    Car car = new Car();
    car.Make = "BMW";
    car.Model = "Mini";
    car.Year = "2018";
    
    Car car2 = new Car();
    car2.Make = "BMW";
    car2.Model = "Mini";
    car2.Year = "2018";
    
    Console.WriteLine(car.Equals(car2) == true);
    Console.WriteLine(car.Stringify() == "BMW, Mini, 2018");
    Car cloneCar = car.Clone();
    Console.WriteLine(cloneCar.Equals(car) == true);
    cloneCar.Make = "Tesla";
    Console.WriteLine(car.Make == "BMW");
  }
}