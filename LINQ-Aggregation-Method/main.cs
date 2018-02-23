// https://msdn.microsoft.com/library/6sh2ey19.aspx
// http://www.csharp-examples.net/linq-aggregation-methods/

// LINQ: Language INtegrated Query
// 일종의 쿼리 표현식
// 컴파일러가 알아서 함수형식으로 변경 시킴

// IEnumerable Extension Method로 정의 되어 있음
// using System.Linq 네임스페이스를 가짐

// public static double Average<TSource>(
// 	this IEnumerable<TSource> source,
// 	Func<TSource, int> selector
// )



using System;
using System.Linq;

class MainClass {
  public static void Main (string[] args) {
    int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

    Console.WriteLine(numbers.Sum() == 55);
    Console.WriteLine(numbers.Average() == 5.5);
    Console.WriteLine(numbers.Max() == 10);
    Console.WriteLine(numbers.Min() == 1);
    Console.WriteLine(numbers.Count() == 10);
    
    Console.WriteLine(numbers.Aggregate( (memo, n) => memo + n) == 55 );    // aka. reduce
    Console.WriteLine(numbers.Aggregate(0, (memo, n) => memo + n) == 55 );    // aka. reduce
    
    Console.WriteLine(numbers.Aggregate( (memo, n) => memo + 1) == 10 );    // Count
    Console.WriteLine(numbers.Aggregate( (memo, n) => n > memo ? n : memo) == 10 );    // Max
    Console.WriteLine(numbers.Aggregate(int.MaxValue, (memo, n) => n < memo ? n : memo) == 1 );    // Min
    
    var str = new []{"a","b","c", "d"};
    var csv = str.Aggregate( (a,b) => a + ',' + b);
    Console.WriteLine(str.Aggregate( (a,b) => a + "," + b) == "a,b,c,d");
  }
}