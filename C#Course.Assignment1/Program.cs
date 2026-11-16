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

            #region Q02. Using the Book class  

            Console.WriteLine(bookObj.ToString());
            Console.WriteLine(bookObj.Equals(bookObj));
            Console.WriteLine(bookObj.GetHashCode());
            Console.WriteLine(bookObj.GetType());

            #endregion

            #region Q03. Look at the line below.
            // int pages = "464"; // compile-time error

            //fix
            int pages = int.Parse("464");


            #endregion



        }
    }

    class Book { public string Title; public int Pages; }
}
