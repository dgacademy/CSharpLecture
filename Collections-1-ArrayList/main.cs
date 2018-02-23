using System;
using System.Collections;

// in Google: "ArrayList in C#"
// https://msdn.microsoft.com/ko-kr/library/system.collections.arraylist(v=vs.110).aspx

class MainClass {
  public static void Main (string[] args) {
    ArrayList list = new ArrayList();
    list.Add(100);
    Console.WriteLine((int)list[0] == 100);
    list.Add(200);
    Console.WriteLine((int)list[1] == 200);
    Console.WriteLine(list.Count == 2);
    
    // list.Insert(5, 500);   // Error: System.ArgumentOutOfRangeException
    
    list.Insert(2, 300);
    Console.WriteLine((int)list[2] == 300);
    
    list.Remove(100);   // 제일 먼저 발견 된 100 삭제
    Console.WriteLine(list.Count == 2);
    Console.WriteLine((int)list[0] == 200);
    Console.WriteLine((int)list[1] == 300);
    
    Console.WriteLine(list.ToString() == "System.Collections.ArrayList");
    
    foreach(int v in list)
      Console.WriteLine(v);
    
    list.Add(10);
    list.Add(5);
    Console.WriteLine(list.Count == 4);
    
    // Todo: Cotains(), Sort()에 대한 Test case를 추가 하시오!
    Console.WriteLine(list.Contains(200) == true);
    Console.WriteLine(list.Contains(700) == false);
  }
}





