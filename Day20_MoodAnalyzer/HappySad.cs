using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20_MoodAnalyzer
{
    public class HappySad
    {
        string Message;
       
        public HappySad(string message)
        {
            this.Message = message;
        }

        public string AnalysingMood()
        {
            if (Message.ToUpper().Contains("HAPPY"))
            {
                return "HAPPY";
            }
            if (Message.ToUpper().Contains("SAD"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }
    }
}
