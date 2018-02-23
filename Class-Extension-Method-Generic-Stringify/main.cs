using System;
using System.Collections.Generic;

// http://www.csharpstudy.com/CSharp/CSharp-extension-method.aspx
public static class Exclass {
  // public static string Stringify(this int[] list) { 
  //     string s = String.Empty;
  //     for(int i = 0;i < list.Length; i++)
  //       s += i != list.Length-1 ? list[i] + " " : list[i].ToString();
  //     return s;
  // }

  // public static string Stringify<T>(this List<T> list) { 
  //     string s = String.Empty;
  //     for(int i = 0;i < list.Count; i++)
  //       s += i != list.Count-1 ? list[i] + " " : list[i].ToString();
  //     return s;
  // }
  
  public static string Stringify<T>(this IEnumerable<T> list) { 
      string s = String.Empty;
      foreach(var v in list) {
        s += v.ToString() + " ";
      }
      if (s.Length > 0)
        s = s.Substring(0, s.Length-1);
      return s;
  }
}

class MainClass {
  public static string Stringify(int[] list) { 
      string s = String.Empty;
      for(int i = 0;i < list.Length; i++)
        s += i != list.Length-1 ? list[i] + " " : list[i].ToString();
      return s;
  }  
  
  class Student {
    public string Name;
    public int[] Scores;
    
    public override string ToString() { return Name; }
  }
  
  public static void Main (string[] args) {

    List<int> list = new List<int>() { 8, 3, 2 };
    int[] arrayA = list.ToArray();
    
    Console.WriteLine( Stringify(arrayA) == "8 3 2" );
    
    Console.WriteLine( arrayA.Stringify() == "8 3 2" );

    Console.WriteLine( list.ToArray().Stringify() == "8 3 2" );

    Console.WriteLine( list.Stringify() == "8 3 2" );
      
    List<Student> students = new List<Student>() {
      new Student() { Name="ctkim", Scores = new int[] { 100, 70, 90, 77, 88 } },
      new Student() { Name="Steve", Scores = new int[] { 77, 60, 90, 77, 55 } },
      new Student() { Name="Brown", Scores = new int[] { 30, 61, 91, 100, 57 } },
      new Student() { Name="Won", Scores = new int[] { 100, 100, 91, 100, 100 } },
      new Student() { Name="JJ", Scores = new int[] { 10, 100, 91, 100, 100 } }
    };
    
    Console.WriteLine( ("ctkim").Stringify() == "c t k i m" );
    Console.WriteLine( (new char[] {'c', 't', 'k', 'i', 'm'}).Stringify() == "c t k i m" );
    
    Console.WriteLine( (new int[] {1}).Stringify() == "1" );
    
    Console.WriteLine( (new string[] {}).Stringify() == string.Empty );
    Console.WriteLine( (new string[] {"A", "B", "C", "D"}).Stringify() == "A B C D" );
    
    Console.WriteLine( students.Stringify() == "ctkim Steve Brown Won JJ" );
    
  }
}






