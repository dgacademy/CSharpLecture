
using System;
using System.Threading;
using System.Threading.Tasks;

class MainClass {
  public static void Main (string[] args) {

    Task<string> taskChain = Task<int>.Run( () => {     // Func<string> delegate임
      Console.WriteLine("1 Task Chain({0})", Thread.CurrentThread.ManagedThreadId);
      Thread.Sleep(100);
      return 100;
    }).ContinueWith( task => {
      Console.WriteLine();
      Console.WriteLine(task.Result);
      Console.WriteLine("2 Task Chain({0})", Thread.CurrentThread.ManagedThreadId);
      Thread.Sleep(100);
      return 200;
    }).ContinueWith( task => {
      Console.WriteLine();
      Console.WriteLine(task.Result);
      Console.WriteLine("3 Task Chain({0})", Thread.CurrentThread.ManagedThreadId);
      Thread.Sleep(100);
      return 300.ToString();
    });
    
    // task.Start();
    Console.WriteLine("in Main");
    
    // task.Wait(); 생략 가능
    Console.WriteLine( taskChain.Result == "300" );    // 작업이 완료될때까지 블럭됨
  }
}
