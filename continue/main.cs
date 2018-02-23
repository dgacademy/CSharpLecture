using System;

class MainClass {
  public static void Main (string[] args) {
    int a, b = 2;
    
    for (a = 0; a < 5; a++) {
      if (b-a <= 0)
        continue; // break;
      Console.WriteLine(b + "-" + a + "=" + (b-a));
    }
  }
}