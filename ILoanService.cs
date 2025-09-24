namespace LibraryConsoleApp
{
    public interface ILoanService
    {
        void BorrowBook(Customer customer, Book book);
        void ReturnBook(Book book);
    }
}
