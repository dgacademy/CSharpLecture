using System;
using System.Threading;

class MainClass {
  public static void Main (string[] args) {
    DateTime startTime = DateTime.Now;
    Thread.Sleep(1000);
    DateTime endTime = DateTime.Now;
    
    TimeSpan elapsed = endTime - startTime;
    Console.WriteLine(elapsed);
    Console.WriteLine(elapsed.TotalSeconds);
    
  }
}