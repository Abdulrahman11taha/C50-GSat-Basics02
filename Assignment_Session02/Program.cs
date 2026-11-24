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
             Book B1 = new Book();
            B1.Title = "Programming";
            B1.Pages = 400 ;
            object objBook = B1;
            Console.WriteLine(B1);

            #endregion
        }
    }
}
