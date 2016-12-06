using System;
using System.Collections.Generic;

using System.Text;
using System.Threading.Tasks;

namespace Curs_6_Dec_EvaluareExpresie
{
    class Program
    {
        static void Main(string[] args)
        {
            string expresieInfix = "(1+2)*3+((2-7)*5)";

            // Pasul 0
            string expresieInfixParanteze = "(" + expresieInfix + ")";


            // Pasul 1 - transformarea infix --> postfix (forma poloneza)
            string expresiePostfix = Postfix(expresieInfixParanteze);

            Console.WriteLine(expresiePostfix);

            int valoare = EvaluarePostfix(expresiePostfix);
            Console.WriteLine("Valoarea expresiei este: {0}", valoare);
        }

        private static int EvaluarePostfix(string exp)
        {
            int[] stack = new int[exp.Length];
            int top = 0;
            for (int i = 0; i < exp.Length; i++)
            {
                if (IsOperator(exp[i]))
                {
                    int op2 = stack[top - 1]; top--;
                    int op1 = stack[top - 1]; top--;
                    int rez;
                    switch (exp[i])
                    {
                        case '+':
                            rez = op1 + op2;
                            break;
                        case '-':
                            rez = op1 - op2;
                            break;
                        case '*':
                            rez = op1 * op2;
                            break;
                        case '/':
                            rez = op1 / op2;
                            break;
                        case '%':
                            rez = op1 % op2;
                            break;
                        default:
                            rez = 0; // aici nu e voie sa ajungem
                            break;
                    }
                    stack[top] = rez;
                    top++;
                }
                else
                {
                    stack[top] = int.Parse(exp[i].ToString());
                    top++;
                }
            }

            return stack[0];

        }

        private static string Postfix(string exp)
        {
            char[] stack = new char[exp.Length];
            int top = 0;
            string expPostfix = "";            
            for (int i = 0; i < exp.Length; i++)
            {
                if (exp[i] == '(')
                {
                    stack[top] = exp[i];
                    top++;
                }
                else if(exp[i] >= '0' && exp[i] <= '9')
                {
                    expPostfix = expPostfix + exp[i].ToString();
                }
                else if(IsOperator(exp[i]))
                {
                    if (stack[top - 1] == '(')
                    {
                        stack[top] = exp[i];
                        top++;
                    }
                    else
                    {
                        while (IsOperator(stack[top - 1]) &&  Pr(stack[top - 1]) >= Pr(exp[i]))
                        {
                            expPostfix = expPostfix + stack[top - 1].ToString();
                            top--;
                        }
                        stack[top] = exp[i];
                        top++;
                    }
                }
                else if (exp[i] == ')')
                {
                    while (stack[top - 1] != '(')
                    {
                        expPostfix = expPostfix + stack[top - 1].ToString();
                        top--;
                    }
                    top--;
                }
            }
            return expPostfix;
        }

        private static int Pr(char v)
        {
            if (v == '*' || v == '/' || v == '%')
            {
                return 2;
            }
            else if (v == '+' || v == '-')
            {
                return 1;
            }
            else
                throw new UnexpectedOperator(); // aici nu ar trebui sa ajungem.
        }

        private static bool IsOperator(char v)
        {
            char[] ops = {'+', '-', '*', '/', '%'};
            int index = Array.IndexOf(ops, v);

            return index >= 0;
        }
    }
}
