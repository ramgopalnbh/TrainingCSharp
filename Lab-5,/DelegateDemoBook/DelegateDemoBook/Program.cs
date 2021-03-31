using System;

namespace DelegateDemoBook
{
    class Program
    {
        static void Main(string[] args)
        {
           
            BookDB b = new BookDB();
            b.AddBook("Book1","Author1",100,true);
            b.AddBook("Book2", "Author2", 200, true);
            b.AddBook("Book3", "Author3", 400, true);
            b.AddBook("Book4","Author4", 500, true);
            processBookCallBackDelegate d = new processBookCallBackDelegate(sold);
            b.ProcessPaperbackBooks(d);
        }
        static void sold(Book b)
        {
            Console.WriteLine(b.Price);
        }
    }
}
