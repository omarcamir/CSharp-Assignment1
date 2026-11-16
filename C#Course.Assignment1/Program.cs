using static System.Runtime.InteropServices.JavaScript.JSType;

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

            #region Q04. Write code that divides 10 by 0 

            try
            {
                int zero = 0;
                int result = 10 / zero;

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by\r\nzero");
            }
            finally
            {
                Console.WriteLine("Done");
            }


            #endregion

            #region Q05. Declare then convert without using a cast.
            int pagesNum = 300;
            double dPages = pagesNum;
            Console.WriteLine(dPages);
            Console.WriteLine(dPages.GetType());


            #endregion

            #region Q06. Declare then convert using a cast.
            double price = 49.99;
            int priceInt = (int)price;

            Console.WriteLine(priceInt);
            Console.WriteLine(priceInt.GetType());


            #endregion

            #region Q07.using the Convert class.

            string pagesText = "464";
            int pagesInt = Convert.ToInt32(pagesText);

            Console.WriteLine(pagesInt);
            Console.WriteLine(pagesInt.GetType());

            #endregion

            #region Q08. using int.parse

            string yearText = "2023";
            int yearInt = int.Parse(yearText);

            Console.WriteLine(yearInt);
            //==============

            string badText = "abc";
            if (int.TryParse(badText, out int badInt))
            {
                Console.WriteLine(badInt);
            }
            else
            {
                Console.WriteLine("Invalid number");
            }


            #endregion

            #region Q09.convert into a string using ToString() 

            int newpages = 464;
            string newpagesString = newpages.ToString();
            Console.WriteLine(newpagesString.GetType());


            #endregion

            #region Q10. box and unbox
            int copies = 100;
            object objs = copies;

            Console.WriteLine(objs);

            int unboxObjs = (int)objs;

            Console.WriteLine(unboxObjs);

            #endregion

            #region Q11
            int? year = null;
            if (year.HasValue)
            {
                Console.WriteLine(year);
            }
            else
            {
                Console.WriteLine("year has no Value");
            }
            year = 2023;
            Console.WriteLine(year);

            #endregion

            #region Q12 print wwther null

            string? reviewer = null;
            if (reviewer == null)
            {
                Console.WriteLine("review == null");
            }
            #endregion

            #region Q13 Use ?. to safely read book
            Book? book = null;
            Console.WriteLine(book?.Title);
            #endregion

        }
    }

    class Book { public string Title; public int Pages; }
}
