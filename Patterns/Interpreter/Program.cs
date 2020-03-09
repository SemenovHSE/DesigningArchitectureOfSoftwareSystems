using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interpreter.Interpreter;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexCodeToInterpret = "C71A4F3B";
            Context context = new Context(hexCodeToInterpret);
            List<Expression> interpretationTree = new List<Expression>()
            {
                new LetterExpression(),
                new DigitExpression(),
                new DigitExpression(),
                new LetterExpression(),
                new DigitExpression(),
                new LetterExpression(),
                new DigitExpression(),
                new LetterExpression()
            };
            foreach (Expression expression in interpretationTree)
            {
                expression.Interpret(context);
            }
            Console.WriteLine(hexCodeToInterpret + " в шестнадцатиричной системе счисления = " + context.BinaryCode + " в двоичной системе счисления.");
        }
    }
}
