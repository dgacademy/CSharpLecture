// Min, Max, First, Last, Sum and Average of array
// 주어진 int[]형의 array 변수에 대해 
//     1. array.Min() 형태로 함수를 호출해서 사용할 수 있게 int[] class Extension를 작성하세요.
//     2. Max, First, Last, Sum, Average 도 추가하세요.
//     3. array는 empty가 아니라고 가정하고 하세요.









































































using System;

public static class Exclass {
  public static int First(this int[] array) { 
    return array[0];
  }
  public static int Last(this int[] array) { 
    return array[array.Length-1];
  }
  public static int Min(this int[] array) { 
    int min = array[0];
    for (int i=1; i < array.Length; i++)
      if (array[i] < min)
        min = array[i];
    return min;
  }
  public static int Max(this int[] array) { 
    int max = array[0];
    for (int i=1; i < array.Length; i++)
      if (array[i] > max)
        max = array[i];
    return max;
  }
  public static int Sum(this int[] array) { 
    int sum = 0;
    for (int i=0; i < array.Length; i++)
      sum += array[i];
    return sum;
  }
  public static double Average(this int[] array) { 
    return array.Sum() / (double)array.Length;
  }   
}



class MainClass {
  public static void Main (string[] args) {
    int[] array = { 30, 40, 70, 100, 20, 10};
    Console.WriteLine( array.First() == 30 );
    Console.WriteLine( array.Last() == 10 );
    Console.WriteLine( array.Min() == 10 );
    Console.WriteLine( array.Max() == 100 );
    Console.WriteLine( array.Sum() == 30+40+70+100+20+10 );
    Console.WriteLine( array.Average() == array.Sum()/6 );
  }
}

