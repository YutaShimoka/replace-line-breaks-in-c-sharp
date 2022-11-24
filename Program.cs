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
        private static readonly string Pattern = ConfigurationManager.AppSettings["Pattern"];
        private static readonly string Replacement = ConfigurationManager.AppSettings["Replacement"];

        static void Main(string[] args)
        {
            string input = "a\r\nb\rc\nd";
            System.Diagnostics.Debug.WriteLine("[debug] input: " + input);

            System.Diagnostics.Debug.WriteLine("[debug] pattern: " + Pattern);
            System.Diagnostics.Debug.WriteLine("[debug] replacement: " + Replacement);

            string output = Regex.Replace(input, Pattern, Replacement);
            System.Diagnostics.Debug.WriteLine("[debug] output: " + output);

            System.Diagnostics.Debug.WriteLine("[debug] result: " + AssertEquals("a<br>b<br>c<br>d", output));
        }

        private static string AssertEquals(string expected, string actual)
        {
            return expected.Equals(actual) ? "ok" : "ng";
        }
    }
}
