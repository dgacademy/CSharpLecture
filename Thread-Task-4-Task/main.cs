// Task: 비동기 코드를 쉽게 작성하기 만든 라이브러리
// 네임스페이스로 알 수 있듯이 하부는 Thread로 구현되어 있다.
// using System.Threading.Tasks;


using System;
using System.Threading;
using System.Threading.Tasks;


class MainClass {
  public static void Main (string[] args) {
    
    DateTime startTime = DateTime.Now;
    
    Task task3 = Task.Run( () => Console.WriteLine("Hello from task3") );
    
    // 1
    Task task = new Task( () => {
      Thread.Sleep(1000);
      Console.WriteLine("in Task: " + Thread.CurrentThread.ManagedThreadId);
    } );
    task.Start();
    
    // 2
    Task task1 = new Task( (param) => {
      Thread.Sleep(1500);
      Console.WriteLine("in Task({0}): {1}", param, Thread.CurrentThread.ManagedThreadId);
    }, "param" );

    task1.Start();
    // task1.RunSynchronously();   // 동기식으로 작동하게, task1 thread가 완전히 종료될 때까지 대기
    
    // 3
    Task task2 = Task.Run( () => {
      for (int i=0; i < 5; i++) {
        Thread.Sleep(500);  
        Console.WriteLine("in Task2: " + Thread.CurrentThread.ManagedThreadId);        
      }
    } );
    
    
  
    // 4
    // Task task3 = Task.Factory.StartNew( () => Console.WriteLine("Hello from task3") );
    // Task task3 = Task.Run( () => Console.WriteLine("Hello from task3") );

    DateTime endTime = DateTime.Now;
    TimeSpan elapsed = endTime - startTime;
    Console.WriteLine(elapsed);

    task3.Wait();

    task.Wait();

    task1.Wait();
    
    task2.Wait();
    
    // task3.Wait();
    
    Console.WriteLine("after Waiting");
  }
}
