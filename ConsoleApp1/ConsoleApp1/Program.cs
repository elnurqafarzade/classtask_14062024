using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {

            #region Her Herf Nece Defe Tekrar Olub
            //    string input = Console.ReadLine();
            //    Dictionary<char, int> charCount = CountChar(input);

            //    foreach (var item in charCount)
            //    {
            //        Console.WriteLine($"{item.Key}: {item.Value}");
            //    }
            //}

            //static Dictionary<char, int> CountChar(string input)
            //{
            //    Dictionary<char, int> characterCounts = new Dictionary<char, int>();

            //    foreach (char c in input)
            //    {
            //        if (char.IsLetter(c))
            //        {
            //            if (characterCounts.ContainsKey(c))
            //            {
            //                characterCounts[c]++;
            //            }
            //            else
            //            {
            //                characterCounts[c] = 1;
            //            }
            //        }
            //    }

            //    return characterCounts;
            #endregion
            #region Ulduz ve Ulduzdan Onceki Chari Silir




            string input = "A*ze*rb*ay*ca*n";
            string result = RemoveStarsAndPrecedingChars(input);
            Console.WriteLine(result);
        }

        static string RemoveStarsAndPrecedingChars(string input)
        {
            StringBuilder sb = new StringBuilder();
            int length = input.Length;

            for (int i = 0; i < length; i++)
            {
                if (input[i] == '*')
                {

                    if (sb.Length > 0)
                    {
                        sb.Length--;
                    }
                }
                else
                {

                    sb.Append(input[i]);
                }
            }

            return sb.ToString();
        }
    }
}



        #endregion
   