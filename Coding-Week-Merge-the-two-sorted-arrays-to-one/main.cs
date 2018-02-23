// 두 개의 이미 정렬된 int[] 주어졌을 때 하나로 합쳐주는 MergeArrays(int[] A, int[] B) 함수를 작성하라.
// 함수 결과물은 int[] 이다.
// 이미 정렬되었다는 이점을 이용해서 즉 소팅 함수를 사용하지 않고 작성해야 한다.









































































using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    int[] arrayA = { 1, 3, 5, 7, 9 };
    int[] arrayB = { 2, 4, 6, 8 };
    
    Console.WriteLine( MergeArrays(arrayA, arrayB).Stringify() == "1 2 3 4 5 6 7 8 9" );
    
    int[] arrayC = { 1, 2, 5, 7, 9 };
    int[] arrayD = { 2, 4, 6, 8, 10, 11, 12 };
    Console.WriteLine( MergeArrays(arrayC, arrayD).Stringify() == "1 2 2 4 5 6 7 8 9 10 11 12" );
    
    Console.WriteLine( MergeArrays(new int[] {}, new int[] {}).Stringify() == "" );
    Console.WriteLine( MergeArrays(new int[] {}, new int[] {1, 5, 10}).Stringify() == "1 5 10" );
    
    Console.WriteLine( MergeArrays(new int[] {1,1,1}, new int[] {2,2,2,2}).Stringify() == "1 1 1 2 2 2 2" );
  }












  
  public static int[] MergeArrays(int[] A, int[] B) {
    int[] C = new int[A.Length + B.Length];
    
    int indexA = 0, indexB = 0;
    for( int i = 0; i < A.Length+B.Length; i++) {
      if (indexA == A.Length) {
        C[i] = B[indexB++];
        continue;
      }
      if (indexB == B.Length) {
        C[i] = A[indexA++];
        continue;
      }
      
      if (A[indexA] < B[indexB]) {
        C[i] = A[indexA++];
      } else {
        C[i] = B[indexB++];
      }
    }
    
    return C;
  }
  
}

public static class Exclass {
  public static string Stringify<T>(this IEnumerable<T> list) { 
      string s = String.Empty;
      foreach(var v in list) {
        s += v.ToString() + " ";
      }
      if (s.Length > 0)
        s = s.Substring(0, s.Length-1);
      return s;
  }
}