using System;

class MainClass {
  public static void Main (string[] args) {

    int ix = 128; // sbyte의 최대값 127보다 1 큰 수: 00000000 00000000 00000000 10000000
    Console.WriteLine(ix);  // 128 출력     
         
    sbyte sy = (sbyte)ix; 
    Console.WriteLine(sy);  // -128 출력: 10000000



    float a = 69.6875f; 
    Console.WriteLine("a : {0}", a); 

    double b = (double)a; 
    Console.WriteLine("b : {0}", b); 

    Console.WriteLine("69.6875 == b : {0}", 69.6875 == b); 

    // float => double
    float x = 0.1f; 
    Console.WriteLine("x : {0}", x); 
   
    double y = (double)x; 
    Console.WriteLine("y : {0}", y); 
 
    Console.WriteLine("0.1 == y : {0}", 0.1 == y); 

  }
}