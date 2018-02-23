using System;

class MainClass {
  
  public static void Main (string[] args) {
    int [,] a =  
    {
      {10, 20 },
      {20, 30 },
      {50, 60 }
    };
    
    Console.WriteLine(a[1,1]);
    a[1,1] = 1000;
    Console.WriteLine(a[1,1]);

  }
}