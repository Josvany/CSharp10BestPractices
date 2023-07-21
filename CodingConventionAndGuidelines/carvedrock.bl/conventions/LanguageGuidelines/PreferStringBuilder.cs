using System.Diagnostics;
using System.Text;

namespace carvedrock.bl.Conventions.LanguageGuidelines
{
    public class PreferStringBuilder
    {
        public PreferStringBuilder()
        {
            Stopwatch stopwatch = new();
            stopwatch.Start();

            StringBuilder manySymbols = new();
            for (var i = 0; i < 1000; i++)
            {
                manySymbols.Append(i).Append(',');
            }

            stopwatch.Stop();
            Console.WriteLine("Elapsed Time is {0} ms", stopwatch.ElapsedMilliseconds);
        }
    }
}