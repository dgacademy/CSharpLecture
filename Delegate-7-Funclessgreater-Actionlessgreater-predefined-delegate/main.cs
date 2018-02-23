using System;

class MainClass {
  public static void Main (string[] args) {
    // Action<> delegate
    // in Google: Action<>
    // https://msdn.microsoft.com/ko-kr/library/system.action(v=vs.110).aspx
    Action act1 = () => Console.WriteLine("Action");
    act1();
    Action<int> act2 = (x) => Console.WriteLine(2 * x);
    act2(2);
    Action<double, double> act3 = (x, y) => Console.WriteLine(x / y);
    act3(10, 20);
    
    // Func<> delegate
    // in Google: Func<>
    // https://msdn.microsoft.com/ko-kr/library/bb549151(v=vs.110).aspx
    Func<int> fn1 = () => 10;
    Console.WriteLine(fn1() == 10);
    
    Func<int, int> fn2 = (x) => 2 * x;
    Console.WriteLine(fn2(10) == 20);
    
    Func<double, double, double> fn3 = (x, y) => x / y;
    Console.WriteLine(fn3(10, 20) == 0.5);
    
    Func<int, int, int, int, int, int, int, int, int, int, int, int, int> fn13;
    fn13 = (a, b, c, d, e, f, g, h, i, j, k, l) => a+b+c+d+e+f+g+h+i+j+k+l;
    Console.WriteLine(fn13(1,1,1,1,1,1,1,1,1,1,1,1) == 12);
  }
}






