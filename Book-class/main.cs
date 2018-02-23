using System;

class MainClass {
  
  class Book {
    public string title;
    public int    price;
    public string author;
    
    public Book(string _title, int _price, string _author) {
      title = _title;
      price = _price;
      author = _author;
    }
    
    public float GetSalePrice(float sale) {
      return (price - price * sale);
    }
  }
  
  public static void Main (string[] args) {
    Book lor = new Book("The Load Of the Rings", 30000, "J.R.R. Tolkien");
    Book hobbit = new Book("The Hobbit", 20000, "J.R.R. Tolkien");
    Book[] books = new Book[2];
    books[0] = lor;
    books[1] = hobbit;
    
    for (int i = 0; i < books.Length; i++) {
      Console.WriteLine(books[i].title + ": " + books[i].GetSalePrice(0.1f));
    }

    // foreach(Book book in books) {
    //   Console.WriteLine(book.title + ": " + book.GetSalePrice(0.1f));
    // }
    
    
  }
}