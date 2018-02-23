// Task<TResult>: 비동기 코드의 실행 결과를 받을 수 있는 클래스!!!
// https://docs.microsoft.com/en-us/dotnet/standard/parallel-programming/task-based-asynchronous-programming



using System;
using System.Threading;
using System.Threading.Tasks;

class MainClass {
  public static void Main (string[] args) {

    Task<string> task = new Task<string>( () => {     // Func<string> delegate임
      Thread.Sleep(100);
      Console.WriteLine("in Task: " + Thread.CurrentThread.ManagedThreadId);
      return "Task result";
    } );
    task.Start();
    Console.WriteLine("in Main");
    
    // task.Wait(); 생략 가능
    Console.WriteLine( task.Result == "Task result" );    // 작업이 완료될때까지 블럭됨
  }
}






