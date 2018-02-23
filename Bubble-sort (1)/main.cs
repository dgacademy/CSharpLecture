using System;

class MainClass {
  public static void Main (string[] args) {
    int[] list = new int[] {55, 07, 78, 12, 42};
    
    for (int i = 0; i < list.Length-1; i++) {
      for (int j = 0; j < list.Length-1; j++) {
        if (list[j] > list[j+1]) {
          int tmp = list[j];
          list[j] = list[j+1];
          list[j+1] = tmp;
        }
      }
      for (int k = 0; k < list.Length; k++) {
        Console.Write(list[k] + " ");
      }
      Console.WriteLine();
    }
  }
}