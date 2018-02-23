using System;

class MainClass {
  public static void Main (string[] args) {
    double a = 1;
    double b = 2;
    double c = 1;
    
    double D = b * b - 4 * a * c;
    
    if (D == 0) {
        double sol = (-b + Math.Sqrt(D)) / (2*a);
        Console.WriteLine("1: " + sol);
        if (a * sol * sol + b * sol + c == 0) {
          Console.WriteLine("OK!");
        }
    } else {
      if (D > 0) {
        double sol = (-b + Math.Sqrt(D)) / (2*a);
        double sol2 = (-b - Math.Sqrt(D)) / (2*a);
        Console.WriteLine("1: " + sol + ", " + sol2);
      } else {
        Console.WriteLine("None");
      }
    }
  }
}