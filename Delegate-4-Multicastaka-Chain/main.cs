using System;

delegate int Callback(int a, int b);   // 함수(2 args, int return)를 담을 수 있는 변수형 선언

class MainClass {
  static int Sum(int i, int j) {
    Console.WriteLine("Sum");
    return i + j;
  }
  
  static int Multiply(int i, int j) {
    Console.WriteLine("Multiply");
    return i * j;
  }
  
  static int Power(int i, int j) {
    Console.WriteLine("Power");
    return (int)Math.Pow((double)i, (double)j);
  }
  
  
  public static void Main (string[] args) {
    Callback cb = Sum;  // or new Callback(Sum);
    Console.WriteLine(cb(10, 20) == 30);
    
    cb = delegate (int i, int j) { return i+j; };   // 익명 함수
    Console.WriteLine(cb(10, 20) == 30);
    
    cb = (int i, int j) => { return i+j; };         // 람다식
    Console.WriteLine(cb(10, 20) == 30);

    cb = (i, j) => i+j;                             // 람다식
    Console.WriteLine(cb(10, 20) == 30);
    
    Console.WriteLine("\tChain");
    cb = Sum;
    cb += Multiply;
    cb += Power;
    
    Console.WriteLine( cb(3, 2) == 9 );
    
    cb -= Power;
    Console.WriteLine( cb(3, 2) == 6 );
  }
  
}



