// Remove duplicate chars
// 1. 주어진 문자열에서 중복되는 문자를 제거해서 돌려주는 RemoveDuplicateChars(string str) 만들기
// 2. Console.WriteLine( RemoveDuplicateChars("abcdabe") == "abcde" );





























































using System;

class MainClass {
  public static int IndexOf(string str, char c) {
    for (int i=0; i < str.Length; i++) {
      if (str[i] == c)
        return i;
    }
    return -1;
  }
  public static string RemoveDuplicateChars(string str) {
    string uniqueString = String.Empty;

    for (int i=0; i < str.Length; i++) {
      if (IndexOf(uniqueString, str[i]) == -1) {
        uniqueString += str[i];
      }
    }
    // or
    // foreach(char c in str) {
    //   if (uniqueString.IndexOf(c) == -1) {
    //     uniqueString += c;
    //   }
    // }
    return uniqueString;
  }
  
  public static void Main (string[] args) {
    Console.WriteLine( IndexOf("abcdabe", 'c') == 2 );
    Console.WriteLine( IndexOf("", 'c') == -1 );
    Console.WriteLine( IndexOf("abcd", 'e') == -1 );
    Console.WriteLine( RemoveDuplicateChars("abcdabe") == "abcde" );
    Console.WriteLine( RemoveDuplicateChars("gogo!") == "go!" );
    Console.WriteLine( RemoveDuplicateChars("DaeguGameAcademy") == "DaeguGmAcdy" );
  }
  
}