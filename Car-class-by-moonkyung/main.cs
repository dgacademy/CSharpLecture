using System;

class MainClass {
  public static void Main (string[] args) {
    
    Car first = new Car("BMW", "auto", 4, 4);
    Console.WriteLine(first.info.car_name);
  }
}


class Car {
  
   public Car_info info; // 차량 정보
  
  public Car(string name, string gear, int engine_size, int wheels){
    info = new Car_info();
    info.car_name = name;
    info.gear = gear;
    info.engine_size = engine_size;
    info.wheels = wheels;
  }
}

class Car_info {
  
  public string car_name;
  public string gear;
  
  public int engine_size;
  public int wheels;

}