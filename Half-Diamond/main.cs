using System;

class MainClass {
  public static void Main (string[] args) {
    for (int i = 0; i < 20; i++) {
    	for (int j = 0; j <= i; j++) {
    		Console.Write ("*");
	    }
	    Console.WriteLine ();
    } 
    for (int i = 19; i > 0; i--) {
      for (int j = i ; j > 0 ; j--)
    		Console.Write ("*");
    	Console.WriteLine ();
    }
  }
}