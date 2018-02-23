using System;

delegate int Callback(int a, int b);   // 함수(2 args, int return)를 담을 수 있는 변수형 선언

class MainClass {
  static int sum(int i, int j) {
    return i + j;
  }
  public static void Main (string[] args) {
    Callback cb = sum;  // or new Callback(sum);
    Console.WriteLine(cb(10, 20) == 30);
    
    cb = delegate (int i, int j) { return i+j; };   // 익명 함수
    Console.WriteLine(cb(10, 20) == 30);
    
    cb = (int i, int j) => { return i+j; };         // 람다식
    Console.WriteLine(cb(10, 20) == 30);

    cb = (i, j) => i+j;                             // 람다식
    Console.WriteLine(cb(10, 20) == 30);
    
  }
  
}







