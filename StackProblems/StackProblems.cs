using System;
using System.Collections.Generic;
namespace logicBuilding.StackProblems
{
    public static class StackProblems
    {
        /// <summary>
        /// ({})[]
        ///  if it is open bracket, push it to stack.
        ///  if it is close bracket, pop the element from the stack, if the popped element is not the associated symbol of closed bracket then not valid.
        ///
        ///  After looping through all the elements in the expression, if the queue is empty, then it is valid. 
        /// {xx(xx())xx) => valid expression
        /// {xx(xx())(()))) => invalid expressions.
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public static bool IsExpressionValid(string expression)
        {
            var stackResult = new Stack<char>();
            var isExpressionBalanced = true;
            foreach(var e in expression)
            {
                if (!isExpressionBalanced) break;
                if(IsOpen(e))
                {
                    stackResult.Push(e);
                } else
                {
                    if(stackResult.Count == 0 && IsClose(e))
                    {
                        isExpressionBalanced = false;
                        break;
                    }

                    else if(IsClose(e))
                    {
                        var poppedElement = stackResult.Pop();
                        var isValid = CheckValidity(poppedElement, e);
                        if(!isValid)
                        {
                            isExpressionBalanced = false;
                            break;
                        }
                    }
                }
            }

            if (stackResult.Count == 0 && isExpressionBalanced) return true;
            return false;
        }

        private static bool IsOpen(char c)
        {
            if (c == '(' || c == '[' || c == '{') return true;
            return false;
        }

        private static bool IsClose(char c)
        {
            if (c == ')' || c == ']' || c == '}') return true;
            return false;
        }

        private static bool CheckValidity(char openSymbol, char closeSymbol)
        {
            if ((openSymbol == '(' && closeSymbol == ')') ||
               (openSymbol == '[' && closeSymbol == ']') ||
               (openSymbol == '{' && closeSymbol == '}')) return true;

            return false;
        }
    }
}
