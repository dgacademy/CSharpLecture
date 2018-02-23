// Critical section(CS): 한 번에 하나의 thread만 접근 가능한 코드 영역, 여기서는 Increase() 임
// lock에 사용하면 안 되는 object
// 1. this
// 2. GetType()의 결과형: Type형
// 3. string



// CS 처리를 하지 않아서 side effct가 발생한 경우
using System;
using System.Threading;

class Counter {
  public int Count { get; set; }
  private readonly object thisLock = new object();
  public void Increase() { 
    lock( thisLock ) {
      int temp = Count;
      Console.WriteLine("Thread {0} : {1} ", Thread.CurrentThread.ManagedThreadId, temp);
      temp = temp + 1;
      Thread.Sleep(1);
      Count = temp;
    }
  }
}

class MainClass {
  public static void Main (string[] args) {
    Counter c = new Counter();
    Thread t = new Thread(new ThreadStart(c.Increase));
    Thread t2 = new Thread(new ThreadStart(c.Increase));
    Thread t3 = new Thread(new ThreadStart(c.Increase));
    
    t.Start(); 
    // Thread.Sleep(100);
    t2.Start();
    // Thread.Sleep(100);
    t3.Start();
    // Thread.Sleep(100);
    
    t.Join();
    t2.Join();
    t3.Join();
    
    Console.WriteLine(c.Count);
  }
}


// using System;
// using System.Threading;

// class Counter {
//   public int Count { get; set; }
//   private readonly object thisLock = new object();
//   public void Increase() { 
//     lock( thisLock ) {
//       int temp = Count;
//       Console.WriteLine("Thread {0} : {1} ", Thread.CurrentThread.ManagedThreadId, temp);
//       temp = temp + 1;
//       Thread.Sleep(1);
//       Count = temp;
//     }
//   }
// }



// class Counter {
//   public int Count { get; set; }
//   public void Increase() { 
//     Count++;
//   }
// }

// class MainClass {
//   public static void Main (string[] args) {
//     Counter c = new Counter();
//     Thread t = new Thread(new ThreadStart(c.Increase));
//     Thread t2 = new Thread(new ThreadStart(c.Increase));
//     Thread t3 = new Thread(new ThreadStart(c.Increase));
    
//     t.Start();
//     t2.Start();
//     t3.Start();
    
//     t.Join();
//     t2.Join();
//     t3.Join();
    
//     Console.WriteLine(c.Count);
//   }
// }
