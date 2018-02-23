using System;
using System.Collections.Generic;
using System.Linq;

public class Student {                      // must "public"
  public string Name { get; set; }
  public int Height { get; set; }
  public List<int> Scores { get; set; }
  
  public override string ToString() { return Name; }
}

class MainClass {
  public static void Main (string[] args) {
    List<Student> list = new List<Student> {
      new Student() { Name="ctkim", Height=175, Scores = new List<int>() { 100, 70, 90, 77, 88 } },
      new Student() { Name="Steve", Height=167, Scores = new List<int>() { 77, 60, 90, 77, 55 } },
      new Student() { Name="Brown", Height=180, Scores = new List<int>() { 30, 61, 91, 100, 57 } },
      new Student() { Name="Won",   Height=171, Scores = new List<int>() { 100, 100, 59, 100, 100 } },
      new Student() { Name="JJ",    Height=165, Scores = new List<int>() { 10, 100, 9, 100, 100 } }
    };

    var r1 = list.FindAll(student => student.Scores.Average() > 80);
    Console.WriteLine(r1.Stringify() == "ctkim Won");
    
    var r2 = list.FindAll(student => student.Scores.Average() > 80 && student.Scores.TrueForAll(score => score > 60));
    Console.WriteLine(r2.Stringify() == "ctkim");    
    
    var r3 = list
      .Where( student => student.Scores.Average() > 80 && student.Scores.Min() > 60)
      .Select( student => student );
    Console.WriteLine(r3.Stringify() == "ctkim");
    
    var r4 = from student in list
             where student.Scores.Average() > 80 && student.Scores.Min() > 60
             select student;
    Console.WriteLine(r4.Stringify() == "ctkim");             
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
