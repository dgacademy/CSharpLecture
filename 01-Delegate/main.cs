// Delegate(대리자)
// https://docs.microsoft.com/ko-kr/dotnet/csharp/programming-guide/delegates/using-delegates
// 일종의 특별한 type(형) 이다. C++의 함수포인터 래퍼, 다른 언어에서 callback과 유사
// 멀티캐스트: 대리자 호출 시 둘 이상의 메소드 호출, +/+=(-/-=) 연산자로 표현


// Declare a delegate(callback)
delegate void Del(int i, double j);

class MathClass
{
    static void Main()
    {
        MathClass m = new MathClass();

        // Delegate instantiation using "MultiplyNumbers"
        Del d = m.MultiplyNumbers;
        
        // event가 아니어도 += 사용가능
        d += delegate(int x, double y){ 
          System.Console.WriteLine("{0} + {1} : {2}", x, y, x + y); 
        };
        // d -= m.MultiplyNumbers;

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
    void MultiplyNumbers(int m, double n)
    {
        System.Console.WriteLine("{0} * {1} : {2}", m, n, m * n);
    }
}

