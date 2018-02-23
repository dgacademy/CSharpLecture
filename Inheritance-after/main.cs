using System;

class MainClass {
  class Book {
    public string title;
    public string genre;
    
    public void printBook() {
      Console.WriteLine("Title: " + title);
      Console.WriteLine("Genre: " + genre);
    }
  }

  class Novel : Book {
    public string writer;
    public void printNov() {
      printBook();
      Console.WriteLine("Writer: " + writer);
    }
  }
  
  class Magazine : Book {
    public int releaseDay;
    public void printMag() {
      printBook();
      Console.WriteLine("Release Day: " + releaseDay);
    }
  }

  public static void Main (string[] args) {
    Novel nov = new Novel(); 
    nov.title = "The Hobbit"; nov.genre = "Fantasy";
    nov.writer = "J.R.R. Tolkien";
    nov.printNov();
    Console.WriteLine();
    
    Magazine mag = new Magazine();
    mag.title = "Hello Computer Magazine"; mag.genre = "Computer";
    mag.releaseDay = 1;
    mag.printMag();
    
  }
}