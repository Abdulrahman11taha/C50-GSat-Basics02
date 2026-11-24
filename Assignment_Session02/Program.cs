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
            //int pages = 464 ;
            #endregion

            #region Question 4
            //Q04.  Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide by zero", and then prints "Done" in a finally block
            //try
            //{
            //    int zero = 0;
            //    int result = 10 / zero;
            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("Cannot divide by zero");
            //}
            //finally
            //{
            //    Console.WriteLine("Done");
            //}
            #endregion

            #region Question 5
            //Q05.  Declare an int pages = 300; then store it in a double variable without using a cast
            //int pages = 300;
            //double Pages = pages;
            //Console.WriteLine(Pages);
            #endregion

            #region Question 6
            //Q06.  Declare a double price = 49.99; then convert it into an int using a cast
            double price = 49.99; 
            int result = (int)price;
            Console.WriteLine(result);
            #endregion
        }
    }
}
