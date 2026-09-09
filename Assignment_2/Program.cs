using System.Drawing;
using System.Text;

namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            #region 1st answer
            string title = "clean code";
            string upperTitle = title.ToUpper();

            Console.WriteLine(title);
            Console.WriteLine(upperTitle);
            #endregion

            #region 2st answer 
            string title1 = "clean code";
            string title2 = "clean code";

            Console.WriteLine(ReferenceEquals(title1, title2));
            #endregion

            #region 3st answer
            StringBuilder sb = new StringBuilder("Book List");
            sb.Append(" - Updated");
            Console.WriteLine(sb.ToString());
            #endregion

            #region 4st answer
            sb.Replace("Book List", "Library");
            Console.WriteLine(sb.ToString());
            #endregion

            #region 5st answer
            string title3 = "Clean Code";
            int pages = 464;
            string sentence = "Book:" + " " + "Clean Code," + "Pages: " + 464;
            Console.WriteLine(sentence);
            #endregion

            #region 6st answer
            Console.WriteLine($"Book: {title3},Pages: {pages}");
            #endregion

            #region 7st answer
            Console.WriteLine(string.Format("Book: {0},Pages: {1}", title3, pages));
            #endregion
            */

            #region 8st answer
            int pages = 464;
            Console.WriteLine(pages > 300 ? "Long Book" : "Short Book");
            #endregion

            #region 9st answer
            bool isAvailable = true;
            if (pages > 300 && isAvailable == true)
            {
                Console.WriteLine("You can borrow this book");
            }
            #endregion

            #region 10st answer
            string title = "Refactoring";
            switch(title)
            {
                case "Clean Code" :
                    Console.WriteLine("Great choice!");
                    break;
                case "Refactoring":
                    Console.WriteLine("Nice pick!");
                    break;
                default: Console.WriteLine("Never heard of it");
                    break;  
            }
            #endregion

            #region 11st answer
            // Solve in question 8
            Console.WriteLine(pages > 300 ? "Long Book" : "Short Book");
            #endregion

            Console.WriteLine("--------------------------------------------");

            #region 12st answer
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            for(int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {books[i]}");
            }
            #endregion

            #region 13st answer
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            int j = 0;
            while( j < books.Length)
            {
                Console.WriteLine($"{j + 1}. {books[j]}");
                j++;
            }
            #endregion

            #region 14st answer
            int k = 0;
            do
            {
                Console.WriteLine("Checking book...");
                k++;
            } while (k < 3);
            #endregion

            #region 15st answer
            string[] books_2 = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            foreach (string book in books_2)
            {
                Console.WriteLine(book);
            }
            #endregion
        }
    }
}

















