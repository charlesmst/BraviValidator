using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace App
{
    public class Validator : IValidator
    {
        public bool IsSequenceValid(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }
            if (!Regex.IsMatch(input, @"^[\{\}\[\]\(\)]*$"))
            {
                throw new ArgumentException($"Bracket has invalid characters");

            }
            var charStack = new Stack<char>();
            foreach (var c in input)
            {
                switch (c)
                {
                    case '(':
                    case '{':
                    case '[':
                        charStack.Push(c);
                        break;
                    case ')':
                        if (charStack.Count == 0 || charStack.Pop() != '(')
                        {
                            return false;
                        }
                        break;
                    case ']':
                        if (charStack.Count == 0 || charStack.Pop() != '[')
                        {
                            return false;
                        }
                        break;
                    case '}':
                        if (charStack.Count == 0 || charStack.Pop() != '{')
                        {
                            return false;
                        }
                        break;
                }

            }
            if (charStack.Count != 0)
            {
                return false;
            }
            return true;
        }
    }
}
