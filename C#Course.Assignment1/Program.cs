namespace C_Course.Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01. Create a Book class 

            Book firstBook = new Book { Title = "The Notebook", Pages = 300 };
            object bookObj = firstBook;
            Console.WriteLine(firstBook);
            Console.WriteLine(bookObj);

            #endregion

        }
    }

    class Book { public string Title; public int Pages; }
}
