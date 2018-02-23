using System;
using System.Collections;

// https://msdn.microsoft.com/en-us/library/system.collections.stack(v=vs.110).aspx

class MainClass {
  public static void Main (string[] args) {
    Stack stack = new Stack();
    
    stack.Push(100);
    stack.Push(200);
    stack.Push(300);
    stack.Push(400);
    stack.Push(500);
    Console.WriteLine(stack.Count == 5);
    
    Console.WriteLine((int)stack.Peek() == 500);
    Console.WriteLine(stack.Count == 5);
    
    while(stack.Count > 0) {
      Console.WriteLine(stack.Pop());
    }
    Console.WriteLine(stack.Count == 0);
  }
}

