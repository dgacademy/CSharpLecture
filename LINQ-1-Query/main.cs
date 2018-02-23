// https://msdn.microsoft.com/library/6sh2ey19.aspx

// LINQ: Language INtegrated Query
// 일종의 쿼리 표현식
// 컴파일러가 알아서 함수형식으로 변경 시킴

// IEnumerable Extension Method로 정의 되어 있음
// using System.Linq 네임스페이스를 가짐


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
      new Student() { Name="Won",   Height=171, Scores = new List<int>() { 100, 100, 91, 100, 100 } },
      new Student() { Name="JJ",    Height=165, Scores = new List<int>() { 10, 100, 9, 100, 100 } }
    };

    Console.WriteLine( list.Stringify() == "ctkim Steve Brown Won JJ" );

    // Height가 175 미만인 학생들 구하기
    // List 함수 이용
    List<Student> ss1 = list.FindAll( student => student.Height < 175 );
    Console.WriteLine(ss1.Stringify() == "Steve Won JJ");
    
    
    // Linq 이용
    var ss2 = from student in list                        // list: must be IEnumerable<T> type
              where student.Height < 175                  // 조건
              select student;                             // ss2 type: IEnumerable<Student>
    Console.WriteLine(ss2.Stringify() == "Steve Won JJ");
    
    
    // 짝수구하기
    int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
    var evens = from n in numbers                         // var or IEnumerable<int>
                where n % 2 == 0
                select n;
    Console.WriteLine(evens.Stringify() == "2 4 6 8 10");
    
    evens = numbers.Where(n => n%2 == 0).Select(n => n);
    Console.WriteLine( evens.Stringify() );
    
    
    var ss3 = from student in list
              where student.Height < 175
              orderby student.Height                      // 오름차순 정렬: or orderby student.Height ascending
              select student;
    Console.WriteLine(ss3.Stringify() == "JJ Steve Won");


    var ss4 = from student in list                        // var or IEnumerable<Student> 
              where student.Height < 175
              orderby student.Height descending           // 내림차순 정렬
              select student;                             // ss4 type: IEnumerable<Student>
    Console.WriteLine(ss4.Stringify() == "Won Steve JJ");

    
    IEnumerable<string> ss5 = from student in list
              where student.Height < 175
              orderby student.Height descending           // 내림차순 정렬
              select student.Name;                        // ss5 type: IEnumerable<string>
    Console.WriteLine(ss5.Stringify() == "Won Steve JJ");

    
    var ss6 = from student in list
              where student.Height < 175
              orderby student.Height
              select new { Name=student.Name, InchHeight=student.Height * 0.393 };
    foreach(var s in ss6)
      Console.WriteLine(s.Name + " " + s.InchHeight);
    Console.WriteLine();
    
    
    // 익명 객체 생성
    var ct = new {Name="ctkim", Height=170};
    Console.WriteLine(ct.Name);
    Console.WriteLine(ct.GetType().ToString());

    // 60점 미만 점수를 가진 사람의 (이름, 미만점수) 리스트
    // var ss7 = from student in list
    //             from score in student.Scores
    //             where score < 60
    //             orderby score
    //           select new { student.Name, Lowest = score };
    // foreach(var s in ss7)
    //   Console.WriteLine(s.Name + " " + s.Lowest);
      
      
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
