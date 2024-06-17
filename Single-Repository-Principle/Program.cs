using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Repository_Principle
{

    
    public class Book //class rresponsible for keepong book information
    {
        public string Title { get; private set; } //read from outside but only can be set from within the class
        public string Author { get; private set; }
        public string ISBN { get; private set; }

        public Book(string title, string author, string isbn) //constructor of class book 
        {
            Title = title;  //assign the value of parameter
            Author = author;
            ISBN = isbn;
        }

        public void DisplayInfo() //doesnt return any vlaue but only prints the book details
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, ISBN: {ISBN}");
        }
    }

    
    public class BookPrinter //class for printing book details
    {
        public void PrintBookDetails(Book book) //book detail as parmameter
        {
            Console.WriteLine("Printing Book Details:");
            book.DisplayInfo();
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            
            Book book = new Book("The Great Gatsby", "F. Scott Fitzgerald", "978-0743273565"); //instance of book

            
            BookPrinter printer = new BookPrinter(); // instance of boook printer
            printer.PrintBookDetails(book); //calls print book details method having book as a parameter
        }
    }
}

//ISBN= International Standard Book Number
