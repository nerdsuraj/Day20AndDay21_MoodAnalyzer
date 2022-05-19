using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20_MoodAnalyzer
{
    public class UC3_CustomException : Exception
    {
        public enum ExceptionType
        {
            NULL_MESSAGE, EMPTY_MESSAGE,
            CLASS_NOT_FOUND,
            CONSTRUCTOR_NOT_FOUND,
            WRONG_FIELD,
            WRONG_MESSAGE
        }
        public ExceptionType Type;

        public UC3_CustomException(ExceptionType type, string message) : base(message)
        {
            Type = type;
        }
    }
}
