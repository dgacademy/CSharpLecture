// https://docs.microsoft.com/ko-kr/dotnet/csharp/programming-guide/statements-expressions-operators/lambda-expressions


class MathClass
{
    // Declare a delegate
    public delegate TResult Func<TArg0, TArg1, TResult>(TArg0 x, TArg1 y);
    
    static void Main()
    {
        MathClass m = new MathClass();

        // Delegate instantiation using "MultiplyNumbers"
        Func<int, int, int> d = (x, y) => x * y;
        Func<float, float, float> f = (x, y) => x * y;
        
        // Invoke the delegate object.
        System.Console.WriteLine("Invoking the delegate using 'MultiplyNumbers':");
        for (int i = 1; i <= 5; i++)
        {
          // 결괏값 주의: 마지막 delegate 호출 결괏값임
          System.Console.WriteLine(d(i, 2));
          System.Console.WriteLine(f(i, 2.1f));
        }

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
