using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace replace_line_breaks_in_c_sharp
{
    internal class Program
    {
        private static readonly string PATTERN = ConfigurationManager.AppSettings["PATTERN"];
        private static readonly string REPLACEMENT = ConfigurationManager.AppSettings["REPLACEMENT"];

        static void Main(string[] args)
        {
            string input = "a\r\nb\rc\nd";
            System.Diagnostics.Debug.WriteLine("[debug] input: " + input);

            System.Diagnostics.Debug.WriteLine("[debug] pattern: " + PATTERN);
            System.Diagnostics.Debug.WriteLine("[debug] replacement: " + REPLACEMENT);

            string output = Regex.Replace(input, PATTERN, REPLACEMENT);
            System.Diagnostics.Debug.WriteLine("[debug] output: " + output);

            System.Diagnostics.Debug.WriteLine("[debug] result: " + assertEquals("a<br>b<br>c<br>d", output));
        }

        private static string assertEquals(string expacted, string actual)
        {
            return expacted.Equals(actual) ? "ok" : "ng";
        }
    }
}
