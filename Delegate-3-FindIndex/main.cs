using System;

class MainClass {

  delegate bool Condition(int i, int v);
  
  static bool exist(int i, int v) {
    return v == 7;
  }
  
  public static void Main (string[] args) {
    int[] scores = new int[] { 1, 2, 3, 5, 10, 7, 8 };
    Console.WriteLine(FindIndex(scores, (i, v) => v == 7) == 5);
    Console.WriteLine(FindIndex(scores, exist) == 5);
    Console.WriteLine(FindIndex(scores, (i, v) => v == 100) == -1);
    Console.WriteLine(FindIndex(scores, (i, v) => v > 3) == 3);
    // Console.WriteLine(FindIndexGT(scores, 3) == 3);
    // Console.WriteLine(FindIndexGTE(scores, 3) == 3);
    // Console.WriteLine(FindIndexLT(scores, 3) == 3);
    // Console.WriteLine(FindIndexLTE(scores, 3) == 3);
    
    Console.WriteLine(FindIndex(scores, (i, v) => i > 5 && v > 3) == 6);
  }
  
  static int FindIndex(int[] list, Condition callback) {
    for (int i = 0; i < list.Length; i++) {
      if (callback(i, list[i]))
        return i;
    }
    return -1;
  }
}

