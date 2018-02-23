using System;

class MainClass {
  public static int FrequencyOf(int[] list, int v) {
      int count = 0;
      for (int i = 0; i < list.Length; i++) {
        if( list[i] == v ) {
          count++;
        }
      }
      return count;
  }
  
  public static int ValueOfMaxFreq(int[] list) {
    int maxValue = 0;
    int maxCount = 0;
    for (int i = 0; i < list.Length; i++) {
      int count = FrequencyOf(list, list[i]);
      if (count > maxCount) {
        maxCount = count;
        maxValue = list[i];
      }
    }
    
    return maxValue;
  }
  
  public static void Main (string[] args) {
    int[] scores = new int[] {1, 1, 1, 2, 1, 2, 3, 3, 3, 3, 1, 1, 3, 4, 4, 1, 1, 4, 4};
    
    Console.WriteLine(FrequencyOf(scores, 1));
    Console.WriteLine(FrequencyOf(scores, 1) == 8);
    
    Console.WriteLine(ValueOfMaxFreq(scores));
    Console.WriteLine(ValueOfMaxFreq(scores) == 1);

    int[] scores2 = new int[] {1, 2, 2, 3, 3, 3};
    
    Console.WriteLine(ValueOfMaxFreq(scores2));
    Console.WriteLine(ValueOfMaxFreq(scores2) == 3);    
  }
}