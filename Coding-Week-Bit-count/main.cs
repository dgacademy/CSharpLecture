// Bit count
// 양의 정수(uint)를 이진수로 표현했을 때 1의 수를 카운트 하는 Bitcount(uint n) 작성 하세요. 즉 켜진 비트가 몇 개인지 구하세요.








































































using System;

class MainClass {
  
  public static void Main (string[] args) {
    Console.WriteLine (BitCount(0) == 0);
    Console.WriteLine (BitCount(1) == 1);
    Console.WriteLine (BitCount(127) == 7);
    Console.WriteLine (BitCount(128) == 1);
    Console.WriteLine (BitCount((uint)int.MaxValue) == 31);
    Console.WriteLine (BitCount(uint.MaxValue) == 32);
  }

  
  public static int BitCount(uint n) {
    int count = 0;
    for (uint i = n; i > 0; i >>= 1) {
      if ( (i & 1) == 1 )
        count++;
    }
    return count;
  }
  
}




