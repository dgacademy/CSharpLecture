// Check password
// 주어진 password 문자열이 다음 규칙을 만족하는지 알려주는 CheckPassword(string password) 작성하세요.
// 1. 6 ~ 15 자리까지만 가능
// 2. 연속으로 동일 문자가 나오지 않아야 함
// 3. 적어도 하나의 소문자 포함
// 4. 적어도 하나의 대문자 포함
// 5. 적어도 하나의 특수 문자 포함: !@#$%^&*()?/>.<,:;'\|}]{[_~`+="-
// 6. 공백 문자(white space) 포함 불가 


// <보강>
// String Escaping: http://csharpindepth.com/Articles/General/Strings.aspx





























































using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine( CheckPassword("Abcdefghijk!") == true );
    Console.WriteLine( CheckPassword("Abcde") == false );             // 1
    Console.WriteLine( CheckPassword("Abccefghijk!") == false );      // 2
    Console.WriteLine( CheckPassword("ABCDEFGHIJK!") == false );      // 3
    Console.WriteLine( CheckPassword("abcdefghijk!") == false );      // 4
    Console.WriteLine( CheckPassword("Abcdefghijk") == false );       // 5
    Console.WriteLine( CheckPassword("Abcdefghijk !") == false );     // 6: white space
    
    Console.WriteLine( CheckPassword("Abcdefdfdfdghijk!") == false ); // 1
    Console.WriteLine( CheckPassword("") == false );                  // 1
    Console.WriteLine( CheckPassword("Abcdefghijk\\") == true );
  }
  
  
  public static bool CheckPassword(string password) {
    if ( !(6 <= password.Length && password.Length <= 15) )
      return false;
    
    for (int i = 0; i < password.Length; i++) {
      if (Char.IsLower(password[i]))
        break;
      if (i == password.Length-1)
        return false;
    }

    for (int i = 0; i < password.Length; i++) {
      if (Char.IsUpper(password[i]))
        break;
      if (i == password.Length-1)
        return false;
    }

    for (int i = 0; i < password.Length-1; i++) {
      if (password[i] == password[i+1])
        return false;
    }

    for (int i = 0; i < password.Length-1; i++) {
      if (password[i] == ' ')
      return false;
    }

    char[] specialCharacters = "!@#$%^&*()?/>.<,:;'\\|}]{[_~`+=\"-".ToCharArray();
    // or char[] specialCharacters = @"!@#$%^&*()?/>.<,:;'\\|}]{[_~`+=\""-".ToCharArray();    // Verbatim 방식
    for (int i = 0; i < specialCharacters.Length; i++) {
      for (int j = 0; j < password.Length; j++)
        if (password[j] == specialCharacters[i])
          return true;
    }

    return false;
  }
}