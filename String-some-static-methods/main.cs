using System;

class MainClass {
  public static void Main (string[] args) {
    string s;
    
    s = "ABC";
    Console.WriteLine(s.Length == 3);
    
    s = string.Empty;
    Console.WriteLine(s == "");
    
    s = "ABCDEF";
    Console.WriteLine(s.IndexOf("CDE") == 2);
    
    s = "Mr Song";
    Console.WriteLine(s.Replace("Mr", "Miss") == "Miss Song");
    
    s = "1000,2000,3000";
    string[] prices = s.Split(',');
    foreach(string price in prices)
      Console.WriteLine(price);
    
    s = "1000, 2000, 3000";
    prices = s.Replace(" ", "").Split(',');
    foreach(string price in prices)
      Console.WriteLine(price);    
    
    s = "ABCDEF";
    Console.WriteLine(s.Substring(1, 3) == "BCD");
  }
}


