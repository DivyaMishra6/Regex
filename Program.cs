using System.Text.RegularExpressions;

namespace RegexExpression
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = "abbb";


            string pattern = "^a{1}b{2,3}$";


            Regex regex = new Regex(pattern);


            if (regex.IsMatch(input))
            {
                Console.WriteLine("String matched the pattern!");
            }
            else
            {
                Console.WriteLine("String did not match the pattern!");
            }

        }
    }

}
