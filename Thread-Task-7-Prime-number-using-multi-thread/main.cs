using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public class CheckPrimerNumber {
  List<Task<List<int>>> tasks = new List< Task<List<int>>>();
  
  Func<object, List<int>> FindPrimeFunc;  
  
  public CheckPrimerNumber() {
    FindPrimeFunc = (objRange) => {
      int[] range = (int[])objRange;
      List<int> found = new List<int>();
      
      for(int i = range[0]; i <= range[1]; i++) {
        if (IsPrime(i))
          found.Add(i);
      }
      return found;
    };
  }
  
  public static bool IsPrime(int number) {
    if (number < 2)
      return false;
    if (number % 2 == 0 && number != 2)
      return false;
    for (int i = 2; i < number; i++) {
      if (number % i == 0)
        return false;
    }
    return true;
  }
  
  public void AddTask(int from, int to) {
      tasks.Add( new Task<List<int>>(FindPrimeFunc, new int[]{from, to}) );
  }
  
  List<int> total = new List<int>();
  public void Start() {
    foreach(var task in tasks)
      task.Start();
    
    foreach(var task in tasks) {
      task.Wait();
      total.AddRange(task.Result.ToArray());
    }
  }
  
  public int GetNumberOfPrime() { return total.Count; }
}

class MainClass {

  
  public static void Main (string[] args) {
    Console.WriteLine( CheckPrimerNumber.IsPrime(0) == false );
    Console.WriteLine( CheckPrimerNumber.IsPrime(2) == true );
    Console.WriteLine( CheckPrimerNumber.IsPrime(7) == true );
    
    CheckPrimerNumber p = new CheckPrimerNumber();
    p.AddTask(0, 11);
    p.AddTask(12, 20);
    p.AddTask(21, 1000);
    p.Start();
    
    int n = p.GetNumberOfPrime();
    Console.WriteLine("#PrimeNumber = " + n);
    Console.WriteLine(n == 168);
    
  }
}










































// using System;
// using System.Collections.Generic;
// using System.Threading.Tasks;

// class MainClass {
//   static List<Task<List<int>>> tasks = new List< Task<List<int>>>();
//   static Func<object, List<int>> FindPrimeFunc = (objRange) => {
//     int[] range = (int[])objRange;
//     List<int> found = new List<int>();
    
//     for(int i = range[0]; i <= range[1]; i++) {
//       if (IsPrime(i))
//         found.Add(i);
//     }
//     return found;
//   };

//   public static bool IsPrime(int number) {
//     if (number < 2)
//       return false;
//     if (number % 2 == 0 && number != 2)
//       return false;
//     for (int i = 2; i < number; i++) {
//       if (number % i == 0)
//         return false;
//     }
//     return true;
//   }
  
//   public static void AddTask(int from, int to) {
//       tasks.Add( new Task<List<int>>(FindPrimeFunc, new int[]{from, to}) );
//   }
  
//   public static void Main (string[] args) {
//     Console.WriteLine( IsPrime(0) == false );
//     Console.WriteLine( IsPrime(2) == true );
//     Console.WriteLine( IsPrime(7) == true );
    
//     AddTask(0, 11);
    
//     foreach(var task in tasks)
//       task.Start();
    
//     List<int> total = new List<int>();
//     foreach(var task in tasks) {
//       task.Wait();
//       total.AddRange(task.Result.ToArray());
//     }
    
//     Console.WriteLine("#PrimeNumber = " + total.Count);
//     Console.WriteLine(total.Count == 5);
    
//   }
// }


