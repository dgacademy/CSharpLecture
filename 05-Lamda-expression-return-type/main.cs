class MathClass
{
    // Declare a delegate
    public delegate int Del(int i, int j);
    
    static void Main()
    {
        MathClass m = new MathClass();

        Del d = (x, y) => {
          System.Console.WriteLine("{0} * {1} : {2}", x, y, x * y);
          return x * y;
        };
        
        d += (x, y) => { 
          System.Console.WriteLine("{0} + {1} : {2}", x, y, x + y);
          return x+y;
        };

        d += (x, y) => { 
          System.Console.WriteLine("{0} ** 2 : {1}", x, x * x);
          return x*x;
        };

        d += (x, y) => { 
          System.Console.WriteLine("{0}", y);
          return y;
        };

        int result = d(1, 2);
        System.Console.WriteLine("Result: {0}", result);

        // Invoke the delegate object.
        // System.Console.WriteLine("Invoking the delegate using 'MultiplyNumbers':");
        // for (int i = 1; i <= 5; i++)
        // {
        //   // 결괏값 주의: 마지막 delegate 호출 결괏값임
        //   System.Console.WriteLine(d(i, 2));
        // }

        // Keep the console window open in debug mode.
        System.Console.WriteLine("Press any key to exit.");
        System.Console.ReadKey();
    }

    // Declare the associated method.
    // void MultiplyNumbers(int m, double n)
    // {
    //     System.Console.WriteLine("{0} * {1} : {2}", m, n, m * n);
    // }
}
