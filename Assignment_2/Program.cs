using System.Text;

namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#region 1st answerr
            //string title = "clean code";
            //string upperTitle = title.ToUpper();

            //Console.WriteLine(title);
            //Console.WriteLine(upperTitle);
            //#endregion

            #region 2st answer 
            string title1 = "clean code";
            string title2 = "clean code";

            Console.WriteLine(ReferenceEquals(title1, title2));
            #endregion

        }
    }
}
