using System;

class Calc {
  public float divide(int x, int y) {
    float z = 0;
    int[] arr = new int[10];
    try {
      z = x / y;
      int b = arr[100];
      return z;
    } catch(Exception e) {
      Console.WriteLine(e.Message);
    } finally {
      Console.WriteLine("Finally");
    }
    return 0;
  }
}

class MainClass {
  public static void Main (string[] args) {
    Calc c = new Calc();
    Console.WriteLine(c.divide(10, 1) == 10);
    // c.divide(10, 0);
  }
}




// using System;

// class Calc {
//   public float divide(int x, int y) {
//     float z = 0;
//     try {
//       z = x / y;
//       return z;
//     } catch(Exception e) {
//       Console.WriteLine(e.Message);
//       throw e;
//     }
//   }
// }

// class MainClass {
//   public static void Main (string[] args) {
//     Calc c = new Calc();

//     try {
//       Console.WriteLine(c.divide(10, 1) == 10);
//       c.divide(10, 0);
//     } catch(Exception e) {
//       Console.WriteLine(e.Message);
//     }
//   }
// }