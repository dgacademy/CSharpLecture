using System;

class Kazul {
  int[] suji = new int[4];
  public int this[int i] {
    get { return suji[i]; }
    set { suji[i] = value; }
  }
}

class MainClass {
  public static void Main (string[] args) {
    Kazul kz = new Kazul();
    kz[0] = 1;
    kz[1] = 2;
    kz[2] = 3;
    kz[3] = 4;
    for (int i=0; i < 4; i++)
      Console.WriteLine(kz[i]);
  }
}