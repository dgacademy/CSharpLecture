using System;

class MainClass {
  class Book {
    string title;
    public string Title {
      get { Console.WriteLine("get()"); return title; }
      set { title = value != "" ? value : "N/A"; }
    }
    int month;
    public int Month {
      get { return month; }
      set { month = 1 <= value && value <=12 ? value : 1; }
    }
  }
  public static void Main (string[] args) {
    Book aBook = new Book();
    aBook.Title = "";
    Console.WriteLine(aBook.Title == "N/A");
    aBook.Title = "The Hobbit";
    Console.WriteLine(aBook.Title == "The Hobbit");
    
    aBook.Month = 100;
    Console.WriteLine(aBook.Month == 1);
    aBook.Month = 7;
    Console.WriteLine(aBook.Month == 7);    
  }
}






