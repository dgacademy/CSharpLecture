
using System;
using System.Collections.Generic;
using System.Linq;

public class Student {                      // must "public"
  public string Name { get; set; }
  public int Height { get; set; }
  
  public override string ToString() { return Name; }
}

public class Score {
  public string Name { get; set; }
  public string Subject { get; set; }
  public int Point { get; set; }
  
}

class MainClass {
  public static void Main (string[] args) {
    List<Student> list = new List<Student> {
      new Student() { Name="ctkim", Height=175 },
      new Student() { Name="Steve", Height=167 },
      new Student() { Name="Brown", Height=180 },
      new Student() { Name="Won",   Height=171 },
      new Student() { Name="JJ",    Height=165 }
    };
    
    List<Score> scores = new List<Score> {
      new Score() { Name="ctkim", Subject="Math", Point=70 },
      new Score() { Name="JJ",    Subject="Math", Point=60 },
      new Score() { Name="Won",   Subject="Math", Point=90 },
      new Score() { Name="Brown", Subject="Math", Point=10 },
      new Score() { Name="Steve", Subject="Math", Point=30 },
      new Score() { Name="ctkim", Subject="English", Point=70 },
      new Score() { Name="JJ",    Subject="English", Point=60 },
      new Score() { Name="Won",   Subject="English", Point=90 },
      new Score() { Name="Brown", Subject="English", Point=10 },
      new Score() { Name="Steve", Subject="English", Point=30 }
    };

    Console.WriteLine( list.Stringify() == "ctkim Steve Brown Won JJ" );

    // Join
    var ss1 = from student in list
              join score in scores on student.Name equals score.Name
              select new { Name=student.Name, Subject=score.Subject, Point=score.Point };
    Console.WriteLine( ss1.Stringify() );
    
    Console.WriteLine( ss1.Count() == 10 );
    Console.WriteLine( ss1.Average( s => s.Point) == 52 );
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
