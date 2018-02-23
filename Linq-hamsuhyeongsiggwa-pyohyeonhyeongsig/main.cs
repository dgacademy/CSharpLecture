// https://docs.microsoft.com/ko-kr/dotnet/csharp/programming-guide/concepts/linq/introduction-to-linq-queries


using System;
using System.Linq;

class MathClass
{

    static void Main()
    {
        int[] numbers = {0, 1, 2, 3, 4, 5, 6, 7};
        int oddNumbers = numbers.Count(n => n % 2 == 1);
        // int[] odds = (from n in numbers where (n % 2) == 1 select n).ToArray();
        int [] odds = numbers.Where(n => (n % 2) == 1).ToArray();

        double avg = numbers.Average();
        
        Console.WriteLine("#odds: {0}", oddNumbers);
        Console.WriteLine("avg of odd numbers: {0}", avg);
        foreach(int n in odds) {
          Console.WriteLine(n);
        }
        
        // Keep the console window open in debug mode.
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }

}
