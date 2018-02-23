using System;
using System.Collections.Generic;

public class Student {                      // must "public"
  public string Name { get; set; }
  public List<int> Scores { get; set; }
  
  public override string ToString() { return Name; }
}

// 숙제
// public class Student {
//   public string Name { get; set; }
//   public List<int> Scores { get; set; }
// }
// 점수 중에 60점 미만이 하나라도 있으면 낙제생 리스트(이름) 넣기
// 낙제생이 아닌 사람들 리스트(이름) 구하기
// Console.WriteLine(nonRepeaters.Stringify() == "ctkim Won");
// Console.WriteLine(repeaters.Stringify() == "Steve Brown");


class MainClass {
  public static void Main (string[] args) {
    List<Student> list = new List<Student> {
      new Student() { Name="ctkim", Scores = new List<int>() { 100, 70, 90, 77, 88 } },
      new Student() { Name="Steve", Scores = new List<int>() { 77, 60, 90, 77, 55 } },
      new Student() { Name="Brown", Scores = new List<int>() { 30, 61, 91, 100, 57 } },
      new Student() { Name="Won",   Scores = new List<int>() { 100, 100, 91, 100, 100 } },
      new Student() { Name="JJ",    Scores = new List<int>() { 10, 100, 91, 100, 100 } }
    };

    Console.WriteLine( list.Stringify() == "ctkim Steve Brown Won JJ" );

    List<Student> nonRepeaters = 
      list.FindAll(student => student.Scores.TrueForAll(score => score >= 60));
    Console.WriteLine(nonRepeaters.Stringify() == "ctkim Won");

    List<Student> repeaters = 
      list.FindAll(student => !student.Scores.TrueForAll(score => score >= 60));
    Console.WriteLine(repeaters.Stringify() == "Steve Brown JJ");

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
