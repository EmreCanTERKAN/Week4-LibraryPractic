using System;
using System.Security.Cryptography.X509Certificates;

class Program
{

    static void Main(string[] args)
    {

        
        //Create new book
        Library book1 = new ()
        {
            BookName = "Kürk Mantolu Madonna",
            AuthorName = "Sabahattin",
            AuthorLastName = "Ali",
            PagesNumber = 177,
            Publisher = "Yapı Kredi Yayınları"
        };
        Console.WriteLine($" Book Name :  {book1.BookName}\n Author Name : {book1.AuthorName}\n Author Last Name: {book1.AuthorLastName}\n Pages Number : {book1.PagesNumber}\n Publisher Name : {book1.Publisher}\n");
        // Add Books Number
        Library.BookCount_++;
        // Create Second Book
        Library book2 = new ("Kendime Düşünceler","Marcus","Aurelius",156, "İş Bankası Kültür Yayınları");
        Console.WriteLine($" Book Name :  {book2.BookName}\n Author Name : {book2.AuthorName}\n Author Last Name: {book2.AuthorLastName}\n Pages Number : {book2.PagesNumber}\n Publisher Name : {book2.Publisher}\n");
        // Add Books Number
        Library.BookCount_++;
        //Show Display Book
        Library.DisplayBookCount();
    }
}

// Libary class
public class Library
{
    public string BookName { get; set; }
    public string AuthorName { get; set; }
    public string AuthorLastName { get; set; }   
    public int PagesNumber { get; set; }
    public string Publisher { get; set; }
    public DateTime RegistrationDate { get; set; }

 
    static private int BookCount;

    static public int BookCount_
    {
        get { return BookCount; }
        set { BookCount = value; }
    }

    static Library()
    {
          BookCount = 0;
    }

   static public  void DisplayBookCount()
    {
        Console.WriteLine($"Total Book's Number : {BookCount}");
    }

    //Default Constructor
    public Library()
    {
        Console.WriteLine($" Date Of Registration : {DateTime.Now}");
    }

//Params Constructor
    public Library(string bookname, string authorname, string authorlastname,int pagenumber , string publisher ) :this()
    {
        BookName = bookname;
        AuthorName = authorname;
        AuthorLastName = authorlastname;
        Publisher = publisher;
        PagesNumber = pagenumber;
    }


}
