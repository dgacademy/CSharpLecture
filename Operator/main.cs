using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine (120 << 2);
    Console.WriteLine (-120 >> 1);
    
    uint a = 0;
    Console.WriteLine (~a);
    
    int ia = 0;
    Console.WriteLine (~ia);
    
    int c = 8 >> 1; 
    int d = c >> 2;
    Console.WriteLine(c);
    Console.WriteLine(d);
    
    int e = 0xF0 | 0x0F;
    Console.WriteLine(e);
    
    int i = 1;
    Console.WriteLine(++i); i = 1;
    Console.WriteLine(i++);

  }
}