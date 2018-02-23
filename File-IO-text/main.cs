using System;
using System.IO;


class MainClass {
  public static void Main (string[] args) {
    FileStream fs;
    fs = new FileStream("Alpha.txt", FileMode.Create);
    StreamWriter w = new StreamWriter(fs);
    w.Write("test file");
    w.Close();
    
    FileStream fs2 = new FileStream("Alpha.txt", FileMode.Open);
    StreamReader r = new StreamReader(fs2);
    string line = r.ReadLine();
    Console.WriteLine(line);
    r.Close();
    
  }
}