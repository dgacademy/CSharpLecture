using System;

class MainClass {
  public static void Main (string[] args) {
    int a;
    for (a = 5; a <=8; a++) {
      Console.Write(a + " / 3 = " + a/3);
      
      int b = 1;
      
      switch(a%3) {
        case 1:
          Console.WriteLine(": remaider is 1");
          break;
        case 2:
          Console.WriteLine(": remaider is 2");
          break;
        default:
          Console.WriteLine(": remaider is 0");
          break;        
      }
    }
  }
}



