using System;

class Car {
  public string name;
  public Engine engine = new Engine();
  public Wheel[] wheels = new Wheel[4];
  
  public Car() {
    for (int i=0; i< wheels.Length; i++) {
      wheels[i] = new Wheel();
      Console.WriteLine(wheels[i].name);
    }
  }
  
  public void TurnOn() { Console.WriteLine("Turn on"); }
  public void GoForward() { Console.WriteLine("Go forward"); }
  public void GoBackward() { Console.WriteLine("Go Backword"); }
  public void Stop() { Console.WriteLine("Stop"); }
  public void TurnOff() { Console.WriteLine("Turn off"); }
}

class Engine {
  
}

class Wheel {
  public string name;
  public static int count;
  public Wheel() { count++; name = "wheel "+count;  }
}


class MainClass {
  public static void Main (string[] args) {
    Car car = new Car();
    
    car.TurnOn();
    car.GoForward();
    car.GoBackward();
    car.Stop();
    car.TurnOff();
  }
}