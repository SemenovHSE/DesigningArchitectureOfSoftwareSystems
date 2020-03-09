using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter.Interpreter
{
    public class Context
    {
        private string input;
        public string HexCode
        {
            get
            {
                return input;
            }
            set
            {
                input = value;
            }
        }
        private string output;
        public string BinaryCode
        {
            get
            {
                return output;
            }
            set
            {
                output = value;
            }
        }
        public Context(string code)
        {
            HexCode = code;
        }
    }

    interface Expression
    {
        void Interpret(Context context);
    }

    public class DigitExpression : Expression
    {
        private string[] digitCodes = new string[] { "0000", "0001", "0010", "0011", "0100", "0101", "0110", "0111", "1000", "1001" };
        public void Interpret(Context context)
        {
            char currentDigit = context.HexCode[0];
            string digitBinaryCode = digitCodes[currentDigit - '0'];
            context.BinaryCode += digitBinaryCode;
            context.HexCode = context.HexCode.Remove(0, 1);
        }
    }

    public class LetterExpression : Expression
    {
        private Dictionary<char, string> letterCodes = new Dictionary<char, string>()
        {
            ['A'] = "1010",
            ['B'] = "1011",
            ['C'] = "1100",
            ['D'] = "1101",
            ['E'] = "1110",
            ['F'] = "1111"
        };
        public void Interpret(Context context)
        {
            char currentLetter = context.HexCode[0];
            string letterBinaryCode = letterCodes[currentLetter];
            context.BinaryCode += letterBinaryCode;
            context.HexCode = context.HexCode.Remove(0, 1);
        }
    }
}
