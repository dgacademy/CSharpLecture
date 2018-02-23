// Swap
// 1. int형 Swap(int a, int b)를 작성하세요.
// 2. int[]형 Swap(int[] arrayA, int[] arrayB)를 작성하세요. 배열 사이즈가 서로 다른 경우 호출자에게 알려주세요.
// 3. Book(멤버가 Title, Price)형 Swap(Book a, Book b)를 작성하세요.
// 4. 하나의 int[]를 주어졌을 때 min, max 값을 서로 swap 시키는 SwapMinMax(int[] array)를 작성하세요.








































































using System;
using System.Collections.Generic;

class Book {
  public string Title { get; set; }
  public int Price { get; set; }
}

class MainClass {

  public static void Swap(ref int a, ref int b) {
    int temp = a;
    a = b;
    b = temp;
  }
  
  public static bool Swap(int[] a, int[] b) {
    if (a.Length == b.Length && a.Length > 0) {
      for( int i=0; i < a.Length; i++) {
        int temp = a[i];
        a[i] = b[i];
        b[i] = temp;
      }
      return true;
    } else 
      return false;
  }
  
  public static void Swap(Book a, Book b) {
    string tempTitle = a.Title;
    a.Title = b.Title;
    b.Title = tempTitle;
    
    int tempPrice = a.Price;
    a.Price = b.Price;
    b.Price = tempPrice;
  }
  
  public static void SwapMinMax(int[] array) {
    int minIndex = 0;
    int maxIndex = 0;

    for (int i = 1; i < array.Length; i++) {
      if (array[i] > array[maxIndex])
        maxIndex = i;
      if (array[i] < array[minIndex])
        minIndex = i;
    }
    int temp = array[minIndex];
    array[minIndex] = array[maxIndex];
    array[maxIndex] = temp;
  }
  
  public static void Main (string[] args) {
    int a = 10, b = 20;
    Swap(ref a, ref b);
    Console.WriteLine( a == 20 && b == 10 );
    
    int[] arrayA = { 1, 2, 3, 4, 5 };
    int[] arrayB = { 10, 20, 30, 40, 50 };
    Console.WriteLine( Swap(arrayA, arrayB) == true );
    Console.WriteLine( arrayA.Stringify() == "10 20 30 40 50" );
    Console.WriteLine( arrayB.Stringify() == "1 2 3 4 5" );
    
    int[] arrayC = { 1, 2, 3, 4};           // Notice! array length
    int[] arrayD = { 10, 20, 30, 40, 50 };
    Console.WriteLine( Swap(arrayC, arrayD) == false );
    Console.WriteLine( arrayC.Stringify() == "1 2 3 4" );
    Console.WriteLine( arrayD.Stringify() == "10 20 30 40 50" );
    
    Book bookA = new Book() { Title = "Onepiece", Price=7000 };
    Book bookB = new Book() { Title = "Airgear", Price=5000 };
    Swap(bookA, bookB);
    Console.WriteLine( bookA.Title == "Airgear" && bookB.Title == "Onepiece" );
    
    int[] arrayE = { 7, 2, 100, 4, 1 };
    SwapMinMax(arrayE);
    Console.WriteLine( arrayE.Stringify() == "7 2 1 4 100" );
  }
}

public static class Exclass {
  public static string Stringify<T>(this IEnumerable<T> list) { 
      string s = String.Empty;
      foreach(var v in list) {
        s += v.ToString() + " ";
      }
      if (s.Length > 0)
        s = s.Substring(0, s.Length-1);
      return s;
  }
}