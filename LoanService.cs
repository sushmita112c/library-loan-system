using System;
using System.Collections.Generic;

namespace LibraryConsoleApp
{
    public class LoanService : ILoanService
    {
        private readonly List<(Customer customer, Book book)> _loans = new();

        public void BorrowBook(Customer customer, Book book)
        {
            if (book.IsBorrowed)
            {
                Console.WriteLine($"❌ '{book.Title}' is already borrowed.");
                return;
            }

            book.Borrow();
            _loans.Add((customer, book));
            Console.WriteLine($"✅ {customer.Name} borrowed '{book.Title}'.");
        }

        public void ReturnBook(Book book)
        {
            var loan = _loans.Find(l => l.book == book);
            if (loan.book == null)
            {
                Console.WriteLine($"⚠️ '{book.Title}' is not currently borrowed.");
                return;
            }

            book.Return();
            _loans.Remove(loan);
            Console.WriteLine($"✅ '{book.Title}' has been returned.");
        }
    }
}
