using System;

class MainClass {
  public static void Main (string[] args) {
    int[] scores = new int[10];
    
    for (int i = 0; i < scores.Length; i++)
      scores[i] = i+1;
  
    int sum = 0;
    for (int i = 0; i < scores.Length; i++) {
      sum += scores[i];
    }
    
    float avg = sum / (float)scores.Length;
    Console.WriteLine("SUM = " + sum);
    Console.WriteLine("AVG = " + avg);
  }
}