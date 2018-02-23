// http://www.csharp-examples.net/list/
// https://msdn.microsoft.com/ko-kr/library/system.collections.generic(v=vs.110).aspx

using System;
using System.Collections.Generic;

// http://www.csharpstudy.com/CSharp/CSharp-extension-method.aspx
public static class Exclass {
  public static string Stringify(this int[] list) { 
      string s = String.Empty;
      for(int i = 0;i < list.Length; i++)
        s += i != list.Length-1 ? list[i] + " " : list[i].ToString();
      return s;
  }
  public static string Stringify<T>(this List<T> list) { 
      string s = String.Empty;
      for(int i = 0;i < list.Count; i++)
        s += i != list.Count-1 ? list[i] + " " : list[i].ToString();
      return s;
  }  
}

public class MyComparer : IComparer<int>
{
    public int Compare(int x, int y) { return x.CompareTo(y); }
}

class MainClass {
  public static string Stringify(int[] list) { 
      string s = String.Empty;
      for(int i = 0;i < list.Length; i++)
        s += i != list.Length-1 ? list[i] + " " : list[i].ToString();
      return s;
  }  
  
  public static void Main (string[] args) {
    // System.Collections 문제: Boxing/Unboxing의 비효율성
    // Generic programming을 이용한 generic version이 나왔음
    // 앞으로 Generic collections 만 사용하면 된다!
    
    List<int> listA = new List<int>() { 8, 3, 2 };


    int[] arrayA = listA.ToArray();
    Console.WriteLine( Stringify(arrayA) == "8 3 2" );
    Console.WriteLine( listA.ToArray().Stringify() == "8 3 2" );
    Console.WriteLine( listA.Stringify() == "8 3 2" );
    
    List<int> listB = new List<int>( listA );
    Console.WriteLine( listB.Stringify() == "8 3 2" );
    
    listB = new List<int>() { 5, 7 };
    listA.AddRange(listB);
    Console.WriteLine( listA.Stringify() == "8 3 2 5 7" );
    
    listA.Sort();
    Console.WriteLine( listA.ToArray().Stringify() == "2 3 5 7 8" );
    List<int> sortedList = new List<int>( listA );
    Console.WriteLine( sortedList.BinarySearch(3, new MyComparer()) == 1 );
    Console.WriteLine( sortedList.BinarySearch(9, new MyComparer()) < 0);
    
    Console.WriteLine( listA.Contains(3) == true );
    
    Console.WriteLine( listA.Exists(x => x == 3) == true );
    
    listA = new List<int>() { 8, 3, 2 };
    listB = new List<int>() { 8, 3, 2 };
    Console.WriteLine( listA.Equals(listB) == false );  // just reference
    
    Console.WriteLine( listA.Exists(x => x == 3) == true );
    
    Console.WriteLine( listA.Find(x => x > 2) == 8 );
    
    Console.WriteLine( listA.FindAll(x => x > 2).Stringify() == "8 3" ) ;
    
    Console.WriteLine( listA.FindIndex(x => x < 5) == 1 );
    
    Console.WriteLine( listA.FindLast(x => x < 5) == 2 );
    
    Console.WriteLine( listA.FindLastIndex(x => x < 5) == 2);
    
    listA = new List<int>() { 8, 3, 2, 4, 5 };
    Console.WriteLine( listA.GetRange(1, 3).Stringify() == "3 2 4" );
    
    listA.Insert(1, 7);
    Console.WriteLine( listA.Stringify() == "8 7 3 2 4 5" );
    
    Console.WriteLine( listA.TrueForAll(x => x < 10) == true);
  }
}










