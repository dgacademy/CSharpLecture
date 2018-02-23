// Double linked list
// 1. 기존의 linked list를 double linked list로 변경하세요.
// 2. 관련 함수 모두 수정하세요: AddLast(), AddFirst(), RemoveFirst()
// 3. RemoveLast() 추가로 구현하세요! 제거된 값을 돌려줘야 합니다.
// 4. 기존의 Count 속성을 제거하세요. 노드를 모두 순회해서 갯수를 알아내는 Count() 만드세요.



























































using System;

class Node {
  public string data;
  public Node next;
  public Node prev;
}

class LinkedList {
  Node head;
  Node tail;
  
  public LinkedList() {
    head = tail = null;
  }
  public void AddLast(string obj) {
    Node newNode = new Node();
    newNode.data = obj;
    
    if (head == null) {
      head = tail = newNode;
      newNode.prev = newNode.next = null;
    } else {
      tail.next = newNode;
      newNode.prev = tail;
      tail = newNode;
    }
  }
  
  public void AddFirst(string obj) {
    Node newNode = new Node();
    newNode.data = obj;

    if (head == null) {
      head = tail = newNode;
      newNode.prev = newNode.next = null;
    } else {
      head.prev = newNode;
      newNode.next = head;
      head = newNode;
    }
  }
  
  public string RemoveFirst() {
    if (head == null)
      return string.Empty;
    else {
      string v = head.data;
      if (head == tail) {
        head = tail = null; 
      } else {
        head = head.next;
        head.prev = null;        
      }
      return v;
    }
  }
  
  public string RemoveLast() {
    if (tail == null)
      return string.Empty;
    else {
      string v = tail.data;
      if (head == tail) {
        head = tail = null;
      } else {
        tail = tail.prev;
        tail.next = null;        
      }
      return v;
    }
  }  
  
  public int Count() {
    Node current = head;
    int count = 0;
    while(current != null) {
      current = current.next;
      count++;
    }
    return count;
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
  
  public string ReverseStringify() {
    Node current = tail;
    string s = string.Empty;
    while(current != null) {
      s += current.data;
      current = current.prev;
    }
    return s;
  }
}

class MainClass {
  public static void Main (string[] args) {
    LinkedList list = new LinkedList();
    
    Console.WriteLine(list.RemoveFirst() == string.Empty);
    list.AddLast("one");
    list.AddLast("two");
    Console.WriteLine(list.Stringify() == "onetwo");
    list.AddLast("three");
    Console.WriteLine(list.Stringify() == "onetwothree");
    Console.WriteLine(list.ReverseStringify() == "threetwoone");

    Console.WriteLine(list.RemoveFirst() == "one");
    Console.WriteLine(list.Stringify() == "twothree");

    list.AddFirst("zero");
    Console.WriteLine(list.Stringify() == "zerotwothree");
    Console.WriteLine(list.Count() == 3);
    
    Console.WriteLine(list.RemoveLast() == "three");
    Console.WriteLine(list.Stringify() == "zerotwo");
    
    list.RemoveFirst();
    list.RemoveFirst();
    Console.WriteLine(list.Stringify() == string.Empty);
    
    Console.WriteLine(list.RemoveFirst() == string.Empty);
    Console.WriteLine(list.RemoveLast() == string.Empty);
    Console.WriteLine(list.Count() == 0);
    
  }
}





