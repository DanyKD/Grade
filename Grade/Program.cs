using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer syth = new SpeechSynthesizer();
            syth.Speak("Hello this is dany's program");
            GradeBook book=new GradeBook();
            book.AddGrade(91);
            book.AddGrade(85.35f);
            book.AddGrade(66);
            GradeStatistics stats = book.ComputeStatistics();
            //Console.WriteLine("The Average is: "+ stats.AverageGrade);
            //syth.Speak("The Average is: ");
            //Console.WriteLine("The Lowest value is: "+stats.LowestGrade);
            //syth.Speak("The lowest value is: ");
            //Console.WriteLine("The Highest value is :"+stats.HighestGrade);
            //syth.Speak("The Highest value is: ");
            WriteResult("The average value is", stats.AverageGrade);
            WriteResult("The Highest value is", stats.HighestGrade);
            WriteResult("The lowest value is", stats.LowestGrade);
            WriteResult("The Grade is", stats.LetterGrade);
            syth.Speak(stats.LetterGrade);
            WriteResult("The Grade is", stats.Description);
            syth.Speak(stats.Description);
        }
        static void WriteResult(string description ,string result)
        {
            SpeechSynthesizer syth = new SpeechSynthesizer();
            Console.WriteLine($"{description}: {result}");
            syth.Speak(description);
        }
        static void WriteResult(string description, float result)
        {
            SpeechSynthesizer syth = new SpeechSynthesizer();
            Console.WriteLine($"{description}: {result:f2}");
            syth.Speak(description);
            syth.Speak(result.ToString());
        }

    }
}
