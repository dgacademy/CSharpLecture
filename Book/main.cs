using System;

class Book {
  public string title;
  public string author;
  public int    price;
  
  public Book(string title, string author, int price) {
    this.title = title;
    this.author = author;
    this.price = price;
  }
}

class MainClass {
  public static void Main (string[] args) {
    Book lor;
    lor = new Book("The lord of the Rings", "J.R.R. Tolkien", 50000);
    lor.title = "cktim";
    Console.WriteLine(lor.title);
    
    Book hobbit;
    hobbit = new Book("The Hobbit", "J.R.R. Tolkien", 40000);
    Console.WriteLine(hobbit.title);
  }
}




