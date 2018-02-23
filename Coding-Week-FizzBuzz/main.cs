// FizzBuzz
// 1. 주어진 양의 정수에 대해 3의 배수이면 "Fizz", 5의 배수이면 "Buzz", 둘다 만족하면 "FizzBuzz"를 리턴하는 FizzBuzz()를 작성하세요.
// 2. 1 ~ 100 까지 테스트 결과를 출력하세요.





































































using System;

class MainClass {
  public static string FizzBuzz(int n) {
    if (n % 3 == 0 && n % 5 == 0)     // or if( n % 15 == 0)
      return "FizzBuzz";
    else if (n % 3 == 0)
      return "Fizz";
    else if (n % 5 == 0)
      return "Buzz";
    
    return String.Empty;
  }
  
  public static void Main (string[] args) {
    Console.WriteLine( FizzBuzz(2) == String.Empty );
    Console.WriteLine( FizzBuzz(9) == "Fizz" );
    Console.WriteLine( FizzBuzz(10) == "Buzz" );
    Console.WriteLine( FizzBuzz(15) == "FizzBuzz" );
    Console.WriteLine( FizzBuzz(30) == "FizzBuzz" );
    
    for (int i=1; i <= 100; i++) {
      Console.WriteLine( i + ": " + FizzBuzz(i) );
    }
  }
}