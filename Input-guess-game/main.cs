using System;

class MainClass {
  public static void Main (string[] args) {
    Random rnd = new Random();
    int a = rnd.Next(1, 30);
    Console.WriteLine("Input(1 ~ 30): ");
    // Console.WriteLine(a);
    
    while(true) {
      string s = Console.ReadLine();
      if (s == "") {
        Console.WriteLine("Exit!");
        break;
      }
      
      int n = 0;
      try {
        n = int.Parse(s);
      } catch(FormatException e) {
        Console.WriteLine(e.Message);
        Console.WriteLine("Input(1 ~ 30): ");
        continue;
      }
      
      if (n == a) {
        Console.WriteLine("Equal!");
        break;
      } else if (n > a) {
        Console.WriteLine("too big!");
      } else {
        Console.WriteLine("too small!");
      }
    }
  }
}