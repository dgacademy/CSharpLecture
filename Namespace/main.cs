using System;

namespace Outer {
  namespace A {
    class Car {
      public string name = "Car in namespace A";
    }
  }
  
  namespace B {
    class Car {
      public string name = "Car in namespace B";
    }
  }
}



class MainClass {
  public static void Main (string[] args) {
    Outer.A.Car a = new Outer.A.Car();
    Console.WriteLine(a.name == "Car in namespace A");
    Outer.B.Car b = new Outer.B.Car();
    Console.WriteLine(b.name == "Car in namespace B");
    
  }
}






