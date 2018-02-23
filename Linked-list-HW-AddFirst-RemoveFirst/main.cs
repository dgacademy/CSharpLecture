using System;

class Node {
  public string data;
  public Node next;
}

class LinkedList {
  Node head;
  Node tail;
  
  public int Count { get; private set; }
  
  public LinkedList() {
    head = tail = null;
    Count = 0;
  }
  public void AddLast(string obj) {
    Node newNode = new Node();
    newNode.data = obj;
    newNode.next = null;
    
    if (head == null)
      head = newNode;
    else {
      tail.next = newNode;
    }
    tail = newNode;
    Count++;
  }
  
  public void AddFirst(string obj) {
    Node newNode = new Node();
    newNode.data = obj;
    if (head == null) {
      head = tail = newNode;
    } else {
      newNode.next = head;
      head = newNode;
    }
    Count++;
  }
  
  public string RemoveFirst() {
    if (head == null)
      return string.Empty;
    else {
      string v = head.data;
      head = head.next;
      Count--;
      return v;
    }
  }
  
  public string Stringify() {
    Node current = head;
    string s = string.Empty;
    while(current != null) {
      s += current.data;
      current = current.next;
    }
    return s;
  }
}

class MainClass {
  public static void Main (string[] args) {
    LinkedList list = new LinkedList();
    
    Console.WriteLine(list.RemoveFirst() == string.Empty);
    Console.WriteLine(list.Count == 0);
    list.AddLast("one");
    Console.WriteLine(list.Count == 1);
    list.AddLast("two");
    Console.WriteLine(list.Count == 2);
    Console.WriteLine(list.Stringify() == "onetwo");
    list.AddLast("three");
    Console.WriteLine(list.Stringify() == "onetwothree");
    Console.WriteLine(list.Count == 3);

    Console.WriteLine(list.RemoveFirst() == "one");
    Console.WriteLine(list.Count == 2);
    Console.WriteLine(list.Stringify() == "twothree");

    list.AddFirst("zero");
    Console.WriteLine(list.Count == 3);
    Console.WriteLine(list.Stringify() == "zerotwothree");
    list.RemoveFirst();
    list.RemoveFirst();
    list.RemoveFirst();
    Console.WriteLine(list.Count == 0);
    Console.WriteLine(list.RemoveFirst() == string.Empty);
    
  }
}





