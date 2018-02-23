using System;

class A {
  public virtual string bye() {
    return "A";
  }
}
class B : A {
  public override string bye() {
    return base.bye() + "B";
  }
}
class C : B {
  public override string bye() {
    return "C";
  }
}

class MainClass {
  public static void Main (string[] args) {
    A a = new A();
    Console.WriteLine(a.bye() == "A");
    B b = new B();
    Console.WriteLine(b.bye() == "AB");
    C c = new C();
    Console.WriteLine(c.bye() == "C");

    A aa = new B(); 
    Console.WriteLine(aa.bye() == "AB");
    B bb = new C();
    Console.WriteLine(bb.bye() == "C");
    // C cc = new A();        // Error

  }
}
















