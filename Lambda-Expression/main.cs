using System;

delegate int Callback(int a, int b);

class MainClass {
  static int sum(int i, int j) {
    return i + j;
  }
  
  public static void Main (string[] args) {
    Console.WriteLine ("Lambda Expression: 일종의 익명함수 표현식이다!");
    
    Callback cb = sum;  // or new Callback(sum);
    Console.WriteLine(cb(10, 20) == 30);
    
    cb = delegate (int i, int j) { return i+j; };   // 익명 함수
    Console.WriteLine(cb(10, 20) == 30);
    
    cb = (int i, int j) => { return i+j; };         // 람다식(문 형식)
    Console.WriteLine(cb(10, 20) == 30);

    cb = (i, j) => i+j;                             // 람다식
    Console.WriteLine(cb(10, 20) == 30);
    
    Console.WriteLine( new Callback((i, j) => i+j)(10, 20) == 30 );
  }
}





