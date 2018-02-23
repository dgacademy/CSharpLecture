using System;

class GoodBye {
  public string bye() {
    return "good bye";
  }
}

class GG : GoodBye {
  public string bye() {
    return "GG";
  }  
}

class MainClass {
  public static void Main (string[] args) {
    GoodBye g = new GoodBye();
    Console.WriteLine(g.bye() == "good bye");
    
    GG gg = new GG();
    Console.WriteLine(gg.bye() == "GG");
    
    GoodBye g1 = new GG();
    Console.WriteLine(gg.bye() == "GG");
    
    GG gg2 = new GoodBye();
    Console.WriteLine(gg2.bye() == "GG");    
  }
}




