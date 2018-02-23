// 예전에 배운 ValueOfMaxFreq()의 내부 구현을 Dictionary<>를 이용하도록 변경하세요.

































using System;
using System.Collections.Generic;

class MainClass {

  public static void Main (string[] args) {
    int[] scores = new int[] {1, 1, 1, 2, 1, 2, 3, 3, 3, 3, 1, 1, 3, 4, 4, 1, 1, 4, 4};
    Console.WriteLine(ValueOfMaxFreq(scores) == 1);

    int[] scores2 = new int[] {1, 2, 2, 3, 3, 3};
    Console.WriteLine(ValueOfMaxFreq(scores2) == 3);    
  }
  
  



  
  
  public static int ValueOfMaxFreq(int[] list) {
    Dictionary<int, int> dict = new Dictionary<int, int>();
    
    for (int i=0; i < list.Length; i++) {
      if (dict.ContainsKey(list[i]))
        dict[list[i]] += 1;
      else 
        dict[list[i]] = 1;
    }
    
    int maxKey = 0;
    int maxValue = 0;
    foreach(var v in dict)
      if (v.Value > maxValue) {
        maxKey = v.Key;
        maxValue = v.Value;
      }
    
    return maxKey;
  }
  
}