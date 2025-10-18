
using System.Text;

namespace String_Array_Methods_StringBuildder_Class_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task 9
            //Console.Write("vvedite stroku: ");
            //string RandomText = Console.ReadLine();

            //if (IsOnlyLetters(RandomText))
            //{
            //    Console.WriteLine("stroka iz bukv");
            //}
            //else
            //{
            //    Console.WriteLine("stroka ne tolko iz bukv");
            //}
#endregion

            #region task6
            //string sentence = "Salam Hormetli Mushteri";
            //string [] words = sentence.Split(' ');
            //foreach (string word in words)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion
            #region task8
            //Console.Write("введите свою почту: ");
            // string gmail = Console.ReadLine();
            //int index = gmail.IndexOf('@');
            //string domain = gmail.Substring(index + 1);
            //Console.WriteLine(domain);
            #endregion
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
            for (int i = word.Length - 1; i >= 0; i--)
            {
                stringBuilder.Append(word[i]);
            }
            return stringBuilder.ToString();
        }
        #endregion
        #region task 9
        static bool IsOnlyLetters(string str)
        {
            foreach (char c in str)
            {
                if (!char.IsLetter(c))
                    return false;
            }
            return true;
            #endregion
        }
        
    }
}
