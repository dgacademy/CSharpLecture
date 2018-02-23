// http://www.csharp-examples.net/foreach/

using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    var names = new List<string>() { "John", "Tom", "Peter" };
    
    string s = String.Empty;
    foreach(var name in names)
      s += name + " ";
    Console.WriteLine(s == "John Tom Peter ");
    
    
    s = String.Empty;
    var enumerator = names.GetEnumerator(); // or List<string>.Enumerator enumerator = names.GetEnumerator();
    while( enumerator.MoveNext() ) {
      s += enumerator.Current + " ";
    }
    Console.WriteLine(s == "John Tom Peter ");
    
    
    string nick = "ctkim";  // or string nick = new string(new char[] {'c', 't', 'k', 'i', 'm'});
    s = String.Empty;
    var stringEnumerator = nick.GetEnumerator(); // or CharEnumerator stringEnumerator = nick.GetEnumerator();
    while( stringEnumerator.MoveNext() ) {
      s += stringEnumerator.Current;
    }
    Console.WriteLine( s == "ctkim" );
    
  }
}





