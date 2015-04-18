using System;
using System.Text.RegularExpressions;

namespace hrFind_Hackerrank
{
    class Program
    {
        static void Main()
        {
            var numCases = Int32.Parse(Console.ReadLine());
            var start = new Regex(@"^hackerrank", RegexOptions.Compiled);
            var end = new Regex(@"hackerrank$", RegexOptions.Compiled);
            var both = new Regex(@"^hackerrank.*hackerrank$", RegexOptions.Compiled);
            while (numCases-- > 0)
            {
                var str = Console.ReadLine();
                var answer = -1;
                if (both.IsMatch(str))
                {
                    answer = 0;
                }
                else if (start.IsMatch(str))
                {
                    answer = 1;
                }
                else if (end.IsMatch(str))
                {
                    answer = 2;
                }
                Console.WriteLine(answer);
            }
        }
    }
}
