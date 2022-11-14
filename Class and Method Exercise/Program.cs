using Class_and_Method_Exercise;
using System.Data;

Console.WriteLine("Class and Method Coding Exercises");

List<Book> books = new List<Book>();      //Creates a list of books
Console.WriteLine("List of Books");
Console.WriteLine("--------------------------------");

Book book1 = new Book("Alchemist", "Paolo Coelo", 163);
Book book2 = new Book("Harry Potter", "JKRowling", 400);
Book book3 = new Book("HThe man who sold his Ferrri", "Robin Sharma", 198);
Book book4 = new Book("The Purpose Driven Life", "Rick Warren", 368);

Book book = new Book();                //Adds items in the list 
books.Add(book);

Console.WriteLine(books.Print());   //Prints out the list of books


Console.ReadLine();


