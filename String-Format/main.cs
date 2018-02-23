using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine (String.Format("{0,6:C}", 1234));
    Console.WriteLine (String.Format("{0,6:D}", 123) == "   123");
    Console.WriteLine (String.Format("{0,6:E}", 123.45) == "1.234500E+002");
    Console.WriteLine (String.Format("{0,6:F}", 123.456) == "123.46");
    Console.WriteLine (String.Format("{0,6:G}", 123.456));
    Console.WriteLine (String.Format("{0,10:N}", 123456));
    Console.WriteLine (String.Format("{0,6:P}", 1));
    Console.WriteLine (String.Format("{0,6:X}", 255) == "    FF");
    
    // int 
    // http://www.csharp-examples.net/string-format-int/
    
    // double
    // http://www.csharp-examples.net/string-format-double/
    
    
  }
}