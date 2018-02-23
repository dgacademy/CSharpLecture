// Lamda expression
// 익명함수 표현식: callback 함수의 경우 굳이 이름이 존재할 필요가 없음(간단한 조건이거나 함수 그 자체가 의미 있는 것임), 이름 짓는 스트레스 해방
// 람다 연산자: =>
// https://docs.microsoft.com/ko-kr/dotnet/csharp/programming-guide/statements-expressions-operators/lambda-expressions


// Declare a delegate
delegate void Del(int i, double j);

class MathClass
{
    static void Main()
    {
        MathClass m = new MathClass();

        // Delegate instantiation using "MultiplyNumbers"
        Del d = (x, y) => System.Console.WriteLine("{0} * {1} : {2}", x, y, x * y);
        
        // event가 아니어도 += 사용가능
        d += (x, y) => System.Console.WriteLine("{0} + {1} : {2}", x, y, x + y);

        // Invoke the delegate object.
        System.Console.WriteLine("Invoking the delegate using 'MultiplyNumbers':");
        for (int i = 1; i <= 5; i++)
        {
            d(i, 2);
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
