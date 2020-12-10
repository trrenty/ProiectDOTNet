using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpressionParser.Parser
{
    public class EqParser
    {
        public static string ConvertToPostfix(string expression)
        {
            int prioriy = 0;
            string converted = "";
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < expression.Length; i++)
            {
                char current = expression[i];
                if (current == '+' ||
                    current == '-' ||
                    current == '*' ||
                    current == '/')
                {
                    if (stack.Count <= 0)
                        stack.Push(current);
                    else
                    {
                        if (stack.Peek() == '*' ||
                            stack.Peek() == '/')
                            prioriy = 1;
                        else
                            prioriy = 0;
                        if (prioriy == 1)
                        {
                            if (current == '+' || current == '-')
                            {
                                converted += stack.Pop();
                                i--;
                            }
                            else
                            {
                                converted += stack.Pop();
                                i--;
                            }
                        }
                        else
                        {
                            if (current == '+' || current == '-')
                            {
                                converted += stack.Pop();
                                stack.Push(current);

                            }
                            else
                                stack.Push(current);
                        }
                    }
                }
                else
                {
                    converted += current;
                }
            }
            int len = stack.Count;
            for (int j = 0; j < len; j++)
                converted += stack.Pop();
            return converted;
        }
           
        public static double EvaluateExpr(string expr)
        {
            string aux = expr + ')';
            char current;
            Stack<double> stack = new Stack<double>();
            double val = 0;
            double x , y ;

            for (int i = 0; aux[i] != ')'; i++)
            {
                current = aux[i];
                if (Char.IsDigit(current))
                {
                    stack.Push(current - '0');

                }
                else if (current == '+' || 
                    current == '-' ||
                    current == '*' || 
                    current == '/')
                {
                    x = stack.Pop();
                    y = stack.Pop();

                    switch (current) /* ch is an operator */
                    {
                        case '*':
                            val = y * x;
                            break;

                        case '/':
                            val = y / x;
                            break;

                        case '+':
                            val = y + x;
                            break;

                        case '-':
                            val = y - x;
                            break;
                    }

                    /* push the value obtained above onto the stack */
                    stack.Push(val);
                }
                    
             }
            return val;
        }
    }
}
