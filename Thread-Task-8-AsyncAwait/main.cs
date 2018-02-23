// 일반 함수를 Async 하게 처리 가능하게 만든 한정자
// Method 나 Task/Task<>를 async로 한정하면 비동기 코드가 만들어진다.

using System;
using System.Threading;
using System.Threading.Tasks;

class MainClass {
  public static async void Chain() {
    await Task<int>.Run( () => {     // Func<string> delegate임
      Console.WriteLine("1 Task Chain({0})", Thread.CurrentThread.ManagedThreadId);
      Thread.Sleep(100);
      return 100;
    });
    
    await Task<int>.Run( () => {
      Console.WriteLine();
      Console.WriteLine("2 Task Chain({0})", Thread.CurrentThread.ManagedThreadId);
      Thread.Sleep(100);
      return 200;
    });
    
    string result = await Task<int>.Run( () => {
      Console.WriteLine();
      Console.WriteLine("3 Task Chain({0})", Thread.CurrentThread.ManagedThreadId);
      Thread.Sleep(100);
      return 300.ToString();
    });
    Console.WriteLine(result);
  }
  
  public static void Main (string[] args) {
    Chain();
    Console.ReadLine();
  }
}