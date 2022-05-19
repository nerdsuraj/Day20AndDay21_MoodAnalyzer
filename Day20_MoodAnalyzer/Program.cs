using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20_MoodAnalyzer
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("mood analyser");
            HappySad happySad = new HappySad("iam in happy a mood");
            Console.WriteLine(happySad.AnalysingMood());
            Console.ReadKey();
        }
    }
}
