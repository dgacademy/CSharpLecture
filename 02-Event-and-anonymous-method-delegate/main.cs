// Event(한정자의 일종)
// https://docs.microsoft.com/ko-kr/dotnet/csharp/programming-guide/events/index
// 게시자/구독자(Publisher/Subscriber) 또는 Observer/Dependents 패턴이라도고 함
// https://docs.microsoft.com/ko-kr/dotnet/csharp/language-reference/keywords/event
// 이벤트는 해당 이벤트가 선언되는 클래스(게시자 클래스) 또는 구조체 내에서만 호출할 수 있는 특수한 멀티캐스트 대리자입니다.
// https://docs.microsoft.com/ko-kr/dotnet/csharp/language-reference/keywords/modifiers
// event keyword가 한정자로 분류되고 있음
// http://nshj.tistory.com/entry/C-기초문법-8-델리게이트delegate와-이벤트-Event
// 델리게이트에 event를 수식해서 선언한 것에 불과하다.
// 이벤트가 델리게이트와 가장 큰 차이점은 이벤트는 외부에서 직접 사용할 수 없다는 데 있습니다. 이벤트는 public 한정자로 선언되어 있어도 자신이 선언되어 있는 클래스 외부에서는 호출이 불가능합니다. 이는 이벤트 기반 프로그래밍을 할 때 안정성을 추구할 수 있게 합니다.

class MathClass
{
    // Declare a delegate
    public delegate void Del(int i, double j);
    public event Del del;


    static void Main()
    {
        MathClass m = new MathClass();

        // Delegate instantiation using "MultiplyNumbers"
        m.del = m.MultiplyNumbers;
        // m.del = delegate(int x, double y){ System.Console.WriteLine("{0} * {1} : {2}", x, y, x * y); };
        
        // event가 아니어도 += 사용가능
        // m.del += delegate(int x, double y){ System.Console.WriteLine("{0} + {1} : {2}", x, y, x + y); };

        // Invoke the delegate object.
        System.Console.WriteLine("Invoking the delegate using 'MultiplyNumbers':");
        for (int i = 1; i <= 5; i++)
        {
            m.del(i, 2);
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
