﻿using System;
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
            HappySad happySad = new HappySad("i am in sad a mood");
            Console.WriteLine(happySad.AnalysingMood());

            Console.WriteLine("----------------------------------------------");

            Console.WriteLine();
            InvalidMood invalidMood = new InvalidMood(" ");
            Console.WriteLine(invalidMood.AnalysingMood());

            Console.ReadKey();
        }
    }
}
