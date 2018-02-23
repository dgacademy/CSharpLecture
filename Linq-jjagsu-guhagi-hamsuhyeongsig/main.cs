// https://stackoverflow.com/questions/35800716/print-array-with-linq

// what error message if there are not Linq namespace
using System.Linq;

class MathClass
{
    static void Main()
    {
        MathClass m = new MathClass();

        int[] numbers = {0, 1, 2, 3, 4, 5};

        int[] evens;
        evens = numbers.Where( num => (num%2) == 0)
                       .ToArray();
        foreach(int v in evens) {
           System.Console.WriteLine(v);
        }

        numbers.Where( num => (num%2) == 0)
              .ToList()
              .ForEach(v => { System.Console.WriteLine(v);});

        System.Console.WriteLine("Even Count: {0}", numbers.Count(n => n % 2 == 0));

        // Keep the console window open in debug mode.
        System.Console.WriteLine("Press any key to exit.");
        System.Console.ReadKey();
    }

}
