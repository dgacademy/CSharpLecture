using System;
using System.Collections;

class User {
  public string Name { get; set; }
  public int Age { get; set; }
  public User(string name, int age) {
    Name = name; Age = age;
  }
}


class MainClass {
  public static void Main (string[] args) {
    Hashtable ht  = new Hashtable();
    
    ht.Add("txt", "notepad.exe");
    ht.Add("bmp", "paint.exe");
    ht.Add("dib", "paint.exe");
    ht.Add("rtf", "wordpad.exe");
    Console.WriteLine(ht.Count == 4);

    try
    {
      ht.Add("txt", "winword.exe");
    }
    catch
    {
      Console.WriteLine("The Key = \"txt\" already exists.");
    }
    Console.WriteLine(ht.Count == 4);
    
    ht["max"] = "3dsmax.exe";
    Console.WriteLine(ht.Count == 5);
    
    Console.WriteLine(ht.ContainsKey("bmp") == true);
    
    ht.Remove("bmp");
    Console.WriteLine(ht.ContainsKey("bmp") == false);

    //숙제: (주민번호, User) 로 hashtable 만들기
    Hashtable users = new Hashtable();
    users["1111"] = new User("ctkim", 20);
    users["2222"] = new User("Brown", 30);
    users["3333"] = new User("Fox", 17);
    Console.WriteLine(users.Count == 3);
    
    if (users.ContainsKey("4444") == false) {
      users["4444"] = new User("John", 17);  
    }
    Console.WriteLine(users.Count == 4);
    
  }
}