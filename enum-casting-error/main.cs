using System;

class MainClass {
  public static void Main (string[] args) {
   
  test human = new test();
  human.testing(0);   // cat
  // human.testing(1);   // Compile error!
  
  }
}

class test{
  public enum tester {cat, dog, bird};
  public tester man;
  
  public void testing(tester x){
    this.man = x;
    Console.WriteLine(man);
  }
}