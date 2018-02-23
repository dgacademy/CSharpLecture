using System;

class Stack {
  int[] data;
  int top = -1;
  int size;
  public int Count { get; private set; }
  
  public Stack(int size) {
    data = new int[size];
    this.size = size;
    Count = 0;
  }
  
  public void push(int value) {
    if (top == size-1)
      return;
    data[++top] = value;
    Count++;
  }
  public int pop() {
    if (top == -1)
      return -1;
    Count--;
    return data[top--];
  }
}

class MainClass {
  public static void Main (string[] args) {
    Stack s = new Stack(3);
    Console.WriteLine(s.Count == 0);
    s.push(10);
    Console.WriteLine(s.Count == 1);
    s.push(20);
    Console.WriteLine(s.Count == 2);    
    s.push(30);
    Console.WriteLine(s.Count == 3);
    s.push(40);
    Console.WriteLine(s.Count == 3);
    Console.WriteLine(s.pop() == 30);
    Console.WriteLine(s.pop() == 20);
    Console.WriteLine(s.pop() == 10);
    Console.WriteLine(s.Count == 0);
    Console.WriteLine(s.pop() == -1);     // empty
    
    // s.Count = 10; // Error !!!
  }
}













