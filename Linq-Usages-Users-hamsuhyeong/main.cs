using System;
using System.Linq;

class Users
{

    static void Main()
    {
        User[] users = {new User("gfriend", 20), new User("blackpink", 27), new User("mamamoo", 25), new User("pink", 17)};
        
        users.Where(u => u.name == "blackpink").ToList().ForEach(u => Console.WriteLine("Name:{0}, Age:{1}", u.name, u.age));
        
        // System.Linq.Enumerable+<CreateWhereIterator>c__Iterator1F`1[Users+User]
        Console.WriteLine(users.Where(u => u.name == "blackpink"));
        
        // 제일 나이 많은 사람 누구?
        Console.WriteLine( users.OrderBy(u => u.age).Last().name );
        

        // Console.WriteLine(oddNumbers);
        // Console.WriteLine(avg);
        // foreach(int n in odds) {
        //   Console.WriteLine(n);
        // }
        
        // Keep the console window open in debug mode.
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }

    class User {
      public string name;
      public int age;
      
      public User(string name, int age) 
      { 
        this.name = name; 
        this.age = age; 
      }
    }
}
