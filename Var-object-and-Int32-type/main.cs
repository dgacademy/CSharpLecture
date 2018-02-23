using System;

class Car {
  // public var name;      // Error !!!, var type은 오직 지역 변수로만 사용 가능
}

class MainClass {
  public static void Main (string[] args) {
    var price = 10000;      // => int price = 10000;  컴파일 시점에 자동으로 변경 됨
    
    Console.WriteLine(price == 10000);
    Console.WriteLine(price.GetType().ToString() == "System.Int32");
    
    Int32 i32 = 10000;
    Console.WriteLine(i32.GetType().ToString() == "System.Int32");
    
    object obj = 70;        // 객체다!
    Console.WriteLine(obj.GetType().ToString() == "System.Int32");
  }
}






