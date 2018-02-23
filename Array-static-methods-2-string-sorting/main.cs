using System;

class User {
  public string Name { get; set; }
  public int Age { get; set; }
  public User(string name, int age) {
    Name = name; Age = age;
  }
}

class MainClass {

  public static string Stringify(string[] list) { 
      string s = String.Empty;
      for(int i = 0;i < list.Length; i++)
        s += i != list.Length-1 ? list[i] + " " : list[i];
      return s;
  }

  public static void Main (string[] args) {
    string[] names = new string[] { "c", "b", "a", "d" };
    
    Console.WriteLine(names.GetType().ToString() == "System.String[]");
    Console.WriteLine(names.GetType().BaseType.ToString() == "System.Array");
    
    Console.WriteLine(Stringify(new string[] {"a"}) == "a");
    Console.WriteLine(Stringify(new string[] {}) == string.Empty);
    Console.WriteLine(Stringify(names) == "c b a d");

    // Sorting: 오름차순(Ascending order)
    Console.WriteLine("\tSorting");
    Array.Sort( names );
    Array.Sort( names, (x, y) => x.CompareTo(y) );
    Console.WriteLine("a".CompareTo("b") < 0);
    Console.WriteLine("b".CompareTo("a") > 0);
    Console.WriteLine("a".CompareTo("a") == 0);
    Console.WriteLine(Stringify(names) == "a b c d");

    // Sorting: 내림차순(Descending order)
    Array.Sort( names, (x, y) => y.CompareTo(x) );
    Console.WriteLine(Stringify(names) == "d c b a");
    // Array.Sort( names, (x, y) => y - x ); // x < y:음수, x == y:0, x > y:양수
    // Console.WriteLine(Stringify(names) == "8 7 6 5 4 3 2 1");
    
    //Sorting
    // https://support.microsoft.com/ko-kr/help/320727/how-to-use-the-icomparable-and-icomparer-interfaces-in-visual-c
    // http://www.csharp-examples.net/sort-array/
    
    User[] users = new User[3] {  new User("Betty", 23),  // name, age
                                  new User("Susan", 20),
                                  new User("Lisa", 25) };    
    Array.Sort( users, (user1, user2) => user1.Age.CompareTo(user2.Age) ); // (user1.Age - user2.Age)
    
    foreach (User user in users) 
      Console.Write(user.Name + user.Age + " ");
    Console.WriteLine();

    Array.Sort( users, (user1, user2) => user1.Name.CompareTo(user2.Name) );
    
    foreach (User user in users) 
      Console.Write(user.Name + user.Age + " ");
    Console.WriteLine();    
  }
  
  
  
  
  
  
  
  
  
  
}