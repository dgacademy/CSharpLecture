using System;

class Cat {
  string name = "Shiro";
  
  public string GetName() {
    return name;
  }
  public void SetName(string name) {
    this.name = name;
  }

}

class MainClass {
  public static void Main (string[] args) {
    Cat tongky = new Cat();
    // tongky.name = "dfdfd";
    tongky.SetName("Tongky");
    Console.WriteLine(tongky.GetName());
  }
}



