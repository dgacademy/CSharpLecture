using System;
using System.Collections.Generic;
using System.Linq;

public class Student {                      // must "public"
  public string Name { get; set; }
  public int Height { get; set; }
  public List<int> Scores { get; set; }
  
  public override string ToString() { return Name + " " + Height; }
}

class MainClass {
  public static void Main (string[] args) {
    List<Student> list = new List<Student> {
      new Student() { Name="ctkim", Height=175, Scores = new List<int>() { 100, 70, 90, 77, 88 } },
      new Student() { Name="Steve", Height=167, Scores = new List<int>() { 77, 60, 90, 77, 55 } },
      new Student() { Name="Brown", Height=180, Scores = new List<int>() { 30, 61, 91, 100, 57 } },
      new Student() { Name="Won",   Height=171, Scores = new List<int>() { 100, 100, 91, 100, 100 } },
      new Student() { Name="JJ",    Height=165, Scores = new List<int>() { 10, 100, 9, 100, 100 } }
    };

    Console.WriteLine( list.Stringify() == "ctkim Steve Brown Won JJ" );


    // Linq 이용
    var ss3 = from student in list
              where student.Height < 175
              orderby student.Height
              select student;
    Console.WriteLine(ss3.Stringify() == "JJ Steve Won");
  Console.WriteLine("------------------");
    var ss3_ = list
      .Where( student => student.Height < 175 )
      .OrderBy( student => student.Height )
      .Select( student => student );
    foreach(var v in ss3_)
      Console.WriteLine(v);
    Console.WriteLine("------------------");
    Console.WriteLine(ss3.Stringify() == "JJ Steve Won");
    
    var ss6 = from student in list
              where student.Height < 175
              orderby student.Height
              select new { Name=student.Name, InchHeight=student.Height * 0.393 };
    foreach(var s in ss6)
      Console.WriteLine(s.Name + " " + s.InchHeight);
    Console.WriteLine();

    var ss6_ = list
      .Where( student => student.Height < 175 )
      .OrderBy( student => student.Height )
      .Select( student => new { Name=student.Name, InchHeight=student.Height*0.393 });
    foreach(var s in ss6_)
      Console.WriteLine(s.Name + " " + s.InchHeight);      
  }
}


public static class Exclass {
  public static string Stringify<T>(this IEnumerable<T> list) { 
      string s = String.Empty;
      foreach(var v in list)
        s += v.ToString() + " ";
      if (s.Length > 0)
        s = s.Substring(0, s.Length-1);
      return s;
  }  
}
