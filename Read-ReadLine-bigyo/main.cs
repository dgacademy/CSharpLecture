using System;

public class Example
{
   public static void Main()
   {
     try {
      char c = (char)Console.Read();
      Console.Write(c);
      
      string str = Console.ReadLine();
      Console.Write(str);
     }catch(Exception e) {
       Console.Write(e);
       Console.Write("Error");
     }
   }
}