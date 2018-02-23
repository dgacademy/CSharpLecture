// 1 X 1 = 1	2 X 1 = 2	  3 X 1 = 3	  4 X 1 = 4	
// 1 X 2 = 2	2 X 2 = 4	  3 X 2 = 6	  4 X 2 = 8	
// 1 X 3 = 3	2 X 3 = 6	  3 X 3 = 9	  4 X 3 = 12	
// 1 X 4 = 4	2 X 4 = 8	  3 X 4 = 12	4 X 4 = 16	
// 1 X 5 = 5	2 X 5 = 10	3 X 5 = 15	4 X 5 = 20	
// 1 X 6 = 6	2 X 6 = 12	3 X 6 = 18	4 X 6 = 24	
// 1 X 7 = 7	2 X 7 = 14	3 X 7 = 21	4 X 7 = 28	
// 1 X 8 = 8	2 X 8 = 16	3 X 8 = 24	4 X 8 = 32	
// 1 X 9 = 9	2 X 9 = 18	3 X 9 = 27	4 X 9 = 36


using System;

class MainClass {
  public static void Main (string[] args) {
    for( int i=1; i <= 9; i++) {
      for (int j = 1; j <= 4; j++) {
        // Console.Write(j + " X " + i + " = " + j*i + "\t");
        Console.Write("{0} X {1} = {2} \t", j, i, j*i);
      }
      Console.Write("\n"); //  == Console.WriteLine();
    }
  }
}