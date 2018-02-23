using System;

class MainClass {
  public static void Main (string[] args) {
    // float p1 = 1f;
    // float p2 = 3f;
    // float q1 = 5f;
    // float q2 = 7f;
    
    // float p1 = 4f;
    // float p2 = 12f;
    // float q1 = 1f;
    // float q2 = 3f;

    float p1 = 1f;
    float p2 = 3f;
    float q1 = 2f;
    float q2 = 4f;

// non overlapped case
// case 1
// p1~~~~~~~~~~~~~p2  q1``````````````q2

// case 2
// q1`````````````q2  p1~~~~~~~~~~~~~~p2







    if (p1 > p2 || q1 > q2) {
      Console.WriteLine("Input error!");
      return;
    }

    if (p2 < q1 || q2 < p1)
    		Console.WriteLine ("Two line is not overlapped.");
    	else
    		Console.WriteLine ("Two line is overlapped.");



    if (p1 < q1) {
      if (p2 < q1)
    		Console.WriteLine ("Two line is not overlapped.");
    	else
    		Console.WriteLine ("Two line is overlapped.");
    } else {
      if ( p1 > q2 )
    		Console.WriteLine ("Two line is not overlapped.");
    	else
    		Console.WriteLine ("Two line is overlapped.");
    }  
    
    
    
    
    
    
    
    
    
    
    
  }
}

