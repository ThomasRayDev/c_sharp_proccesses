using System; 

public class Program {
  
  class Book {
    private string author;
    private string title;
    private string publisher;
    private int pages;
    private int year;

    private static double price = 9;

    static Book() {
      price = 10;
    }
    
    public Book(string author, string title, string publisher, int pages, int year) {
      this.author = author;
      this.title = title;
      this.publisher = publisher;
      this.pages = pages;
      this.year = year;
    }

    public Book(string author, string title) {
      this.author = author;
      this.title = title;
    }

    public Book() {
      
    }

    public string Author {
      get { return author; }
      set { author = value; }
    }

    public string Title {
      get { return title; }
      set { title = value; }
    }

    public string Publisher {
      get { return publisher; }
      set { publisher = value; }
    }

    public int Pages {
      get { return pages; }
      set { pages = value; }
    }

    public int Year {
      get { return year; }
      set { year = value; }
    }
    
    public void SetBook(string author, string title, string publisher, int pages, int year) {
      this.author = author;
      this.title = title;
      this.publisher = publisher;
      this.pages = pages;
      this.year = year;
    }

    public static void SetPrice(double price) {
      Book.price = price;
    }

    public void Show() {
      Console.WriteLine("\nКнига:\n Автор: {0}\n Название: {1}\n Год издания: {2}\n Издательство: {3}\n {4} стр.\n Стоимость аренды: {5} р.", author, title, year, publisher, pages, Book.price);
    }

    public double PriceBook(int s) {
      double cost = s * price;
      return cost;
    }
  }
  
  public static void Main(string[] args) {
    Book b1 = new Book();
    Book b2 = new Book("Толстой Л.Н.", "Война и мир", "Наука и жизнь", 1234, 2013);
    Book b3 = new Book("Лермонтов М.Ю.", "Мцыри");
    
    b1.SetBook("Пушкин А.С.", "Капитанская дочка", "Вильямс", 123, 2012);
    // Book.SetPrice(12);
    b1.Show();
    Console.WriteLine("\n Итоговая стоимость аренды: {0} р.", b1.PriceBook(3));

    b2.Show();

    b3.Show();
  }
}
