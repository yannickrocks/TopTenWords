using System.Linq;
using System.Text.RegularExpressions;

namespace TopTenWords
{
    class Program
    {
        public static void Main(string[] args)
        {
            var counter = 0;
            string text = Properties.Resources.LOTR;

            //Assumption: Words of length less than 3 are not words
            System.Console.WriteLine("Reading the contents of LOTR");
            System.Console.WriteLine("Top 10 words are: ");

            var result = Regex.Split(text.ToLower(), @"\W+")
            .Where(s => s.Length > 3)
            .GroupBy(s => s)
            .OrderByDescending(g => g.Count());

            foreach (var value in result)
            {
                if (counter > 10)
                {
                    break;
                }
                System.Console.WriteLine(value.Key + " : " + value.Count<string>());
                counter++;
            }

            System.Console.ReadKey();
        }
    }
}
