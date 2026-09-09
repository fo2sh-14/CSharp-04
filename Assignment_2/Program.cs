using System.Text;

namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
