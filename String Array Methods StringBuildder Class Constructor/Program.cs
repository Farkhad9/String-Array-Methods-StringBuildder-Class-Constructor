
using System.Text;

namespace String_Array_Methods_StringBuildder_Class_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task7
            //string word = "BakuBus";
            //if (word.Length < 4)
            //{
            //    Console.WriteLine("slovo malenkoye");
            //}
            //else
            //{
            //    string newWord = word.Substring(0, 4);
            //    Console.WriteLine(newWord);
            //}
            #endregion
            #region task5
            //string word = "Azerbaijan!";
            //Console.WriteLine(ReverseStr(word)); 
            #endregion
        }

        #region task5
        private static string ReverseStr(string word)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = word.Length-1; i >= 0; i--)
            { 
            stringBuilder.Append(word[i]);
            }
            return stringBuilder.ToString();
        }
        #endregion
    }
}
