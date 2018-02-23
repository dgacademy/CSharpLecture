using System;

class Car {
}

class Stack<T> {
  T[] data;
  int top = -1;
  int size;
  public int Count { get; private set; }
  
  public Stack(int size) {
    data = new T[size];
    this.size = size;
    Count = 0;
  }
  
  public void push(T value) {
    if (top == size-1)
      return;
    data[++top] = value;
    Count++;
  }
  public T pop() {
    if (top == -1)
      return (T)Convert.ChangeType(-1, typeof(T));// default(T);
    Count--;
    return data[top--];
  }
}

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("\tStack<int>");
    Stack<int> s = new Stack<int>(3);
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
    Console.WriteLine(s.pop() == -1);     // empty case, default(int) == 0
    
    // s.Count = 10; // Error !!!
    
    Console.WriteLine("\tStack<string>");
    Stack<string> s2 = new Stack<string>(3);
    Console.WriteLine(s2.Count == 0);
    s2.push("one");
    Console.WriteLine(s2.Count == 1);
    s2.push("two");
    Console.WriteLine(s2.Count == 2);    
    s2.push("three");
    Console.WriteLine(s2.Count == 3);
    s2.push("four");
    Console.WriteLine(s2.Count == 3);
    Console.WriteLine(s2.pop() == "three");
    Console.WriteLine(s2.pop() == "two");
    Console.WriteLine(s2.pop() == "one");
    Console.WriteLine(s2.Count == 0);
    Console.WriteLine(s2.pop() == "-1");     // empty case, default(string) == null

    Console.WriteLine("\tStack<Car>");
    Stack<Car> s3 = new Stack<Car>(3);
    Console.WriteLine(s3.Count == 0);
    Car car = new Car();
    s3.push(car);
    Console.WriteLine(s3.Count == 1);
    Console.WriteLine(s3.pop() == car);
    Console.WriteLine(s3.Count == 0);
    Console.WriteLine(s3.pop() == default(Car));     // empty case, default(Car) == null

    
  }
}













