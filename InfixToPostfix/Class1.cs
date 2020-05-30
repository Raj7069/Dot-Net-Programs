using System.Collections.Generic;

namespace InfixToPostfix
{
    class Program
    {
        public string infixtopostfix(string infix, out string postfix)
        {
            Stack<char> stack = new Stack<char>();
            postfix = "";
            for (int i = 0; i < infix.Length; i++)
            {
                char ch = infix[i];
                if (isOperator(ch))
                {
                    if (stack.Count == 0)
                        stack.Push(ch);
                    else
                    {
                        if (ch == '(')
                            stack.Push(ch);
                        else if (ch == ')')
                        {
                            while (stack.Peek() != '(')
                                postfix += stack.Pop();
                            stack.Pop();

                        }
                        else if (priority(ch) > priority(stack.Peek()))
                        {
                            stack.Push(ch);
                        }
                        else
                        {
                            while (stack.Count != 0 && priority(ch) <= priority(stack.Peek()))
                                postfix += stack.Pop();
                            stack.Push(ch);
                        }
                    }
                }
                else
                {
                    postfix += infix[i];
                }
            }
            while (stack.Count > 0)
                postfix += stack.Pop();
            return postfix;
        }

        private int priority(char ch)
        {
            switch (ch)
            {
                case '(':
                    return 0;
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                    return 2;
                default:
                    return -1;
            }
        }

        private bool isOperator(char ch)
        {
            switch (ch)
            {
                case '+':
                case '-':
                case '*':
                case '/':
                case '(':
                case ')':
                    return true;
                default:
                    return false;
            }
        }
    }
}
