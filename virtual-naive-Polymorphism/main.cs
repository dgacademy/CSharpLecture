// using System;

// class GoodBye {
//   public virtual string bye() {
//     return "good bye";
//   }
// }

// class GG : GoodBye {
//   public override string bye() {
//     return "GG";
//   }  
// }

// class GGG : GG {
//   public override string bye() {
//     return "GGG";
//   }  
// }


// class MainClass {
//   public static void Main (string[] args) {
//     GoodBye g = new GoodBye();
//     Console.WriteLine(g.bye() == "good bye");
    
//     GG gg = new GG();
//     Console.WriteLine(gg.bye() == "GG");
    
//     GoodBye g1 = new GG();
//     Console.WriteLine(g1.bye() == "GG");

//     GG ggg = new GGG();
//     Console.WriteLine(ggg.bye() == "GGG");
    
//     GGG ggg2 = new GGG();
//     Console.WriteLine(ggg2.bye() == "GGG");
    
//     GoodBye g2 = new GGG();
//     Console.WriteLine(g2.bye() == "GGG");
    
//     GG gg2 = new GGG();
//     Console.WriteLine(gg2.bye() == "GGG");
    
//   }
// }


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

class GGG : GG {
  public string bye() {
    return "GGG";
  }  
}


class MainClass {
  public static void Main (string[] args) {
    GoodBye g = new GoodBye();
    Console.WriteLine(g.bye() == "good bye");
    
    GG gg = new GG();
    Console.WriteLine(gg.bye() == "GG");
    
    GoodBye g1 = new GG();
    Console.WriteLine(g1.bye() == "good bye");

    GG ggg = new GGG();
    Console.WriteLine(ggg.bye() == "GG");
    
    GGG ggg2 = new GGG();
    Console.WriteLine(ggg2.bye() == "GGG");
    
    GoodBye g2 = new GGG();
    Console.WriteLine(g2.bye() == "good bye");
    
    GG gg2 = new GGG();
    Console.WriteLine(gg2.bye() == "GG");
    
    // GG gg3 = new GoodBye();               // 문법적으로 오류    
  }
}


// using System;

// class GoodBye {
//   public string bye() {
//     return "good bye";
//   }
// }

// class GG : GoodBye {
//   public string bye() {
//     return "GG";
//   }  
// }

// class MainClass {
//   public static void Main (string[] args) {
//     GoodBye g = new GoodBye();
//     Console.WriteLine(g.bye() == "good bye");
    
//     GG gg = new GG();
//     Console.WriteLine(gg.bye() == "GG");
    
//     GoodBye g1 = new GG();         // Type 보고 결정
//     Console.WriteLine(g1.bye() == "good bye");
    
//     // GG gg2 = new GoodBye();               // 문법적으로 오류
//     // Console.WriteLine(gg2.bye() == "GG");    
//   }
// }


// 상속 시 동일 이름의 멤버함수가 존재할 때 객체를 변수에 할당한 경우에 어떠한 함수가 호출 되는가?
// 1. 하위 타임의 변수에 상위 객체를 할당할 수 없다!: B b = new A(); // 문법 오류
// 2. 함수에 virtual/override 가 존재하면 변수에 들어있는 객체의 함수가 호출이 됨
//    아니면, 변수형에 따라 함수가 결정이 됨


