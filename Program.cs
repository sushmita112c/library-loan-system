using System;
using System.Collections.Generic;

namespace LibraryConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create books
            var books = new List<Book>
            {
                new Book("The Hobbit", "J.R.R. Tolkien", "123"),
                new Book("1984", "George Orwell", "456"),
                new Book("The Silmarillion", "J.R.R. Tolkien", "789")
            };

            // Create customers
            var alice = new Customer("Alice", "C1");
            var bob = new Customer("Bob", "C2");

            ILoanService loanService = new LoanService();

            // Simple demo
            loanService.BorrowBook(alice, books[0]);
            loanService.BorrowBook(bob, books[0]); // should fail
            loanService.ReturnBook(books[0]);
            loanService.BorrowBook(bob, books[0]);

            Console.WriteLine("\nCurrent books:");
            foreach (var book in books)
                Console.WriteLine(book);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
