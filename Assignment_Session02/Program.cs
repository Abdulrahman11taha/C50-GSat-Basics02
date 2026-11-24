using System.Drawing;
using System.Dynamic;

namespace Assignment_Session02
{
    class Book
    {
        public string Title;
        public int Pages;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            //Q01.  Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in a
            //variable of type object.Print it
            // Book B1 = new Book();
            //B1.Title = "Programming";
            //B1.Pages = 400 ;
            //object objBook = B1;
            //Console.WriteLine(B1);

            #endregion

            #region Question 2
            // Q02.Using the Book class above, print the result of calling ToString(), Equals() (compare book with itself), GetHashCode(), and GetType() on book
            //Book book = new Book();
            //Console.WriteLine(book.ToString());
            //Console.WriteLine(book.Equals(book));
            //Console.WriteLine(book.GetHashCode());
            //Console.WriteLine(book.GetType());

            #endregion

            #region Question 3
            //Q03.  Look at the line below. Is it a compile-time error, a runtime error, or a logical error? Fix it. int pages = "464";
            // It is a compile-time Error
            int pages = 464 ;
            #endregion
        }
    }
}
