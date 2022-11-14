using Class_and_Method_Exercise;
using System.Data;
using static System.Reflection.Metadata.BlobBuilder;

Console.WriteLine("Class and Method Coding Exercises");

//List<Book> books = new List<Book>();      //Create a list books. 

Console.WriteLine("List of Books");
Console.WriteLine("--------------------------------");

Book book1 = new Book("Alchemist", "Paolo Coelo", 163);
Console.WriteLine(book1.Print());

Book book2 = new Book("Harry Potter", "JKRowling", 400);
Console.WriteLine(book2.Print());

Book book3 = new Book("HThe man who sold his Ferrri", "Robin Sharma", 198);
Console.WriteLine(book3.Print());

Book book4 = new Book("The Purpose Driven Life", "Rick Warren", 368);
Console.WriteLine(book4.Print());

//Book book = new Book();                //Adds items in the list 
//books.Add(book);

//Console.WriteLine(books.Print());   //Prints out the list of books


Console.ReadLine();


