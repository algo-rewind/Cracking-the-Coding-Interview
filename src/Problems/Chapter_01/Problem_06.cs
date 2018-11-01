using System.Collections.Generic;
using System.Text;

namespace Problems.Chapter_01
{
    public class Problem_06
    {
        public static string StringCompression(string uncompressed)
        {
            var stack = new Stack<char>();
            var compressed = new StringBuilder();

            foreach (char ch in uncompressed)
            {
                // If the stack is empty or the previous character matches the current one, push.
                if (stack.Count == 0 || stack.Peek() == ch)
                    stack.Push(ch);
                else
                // The current character doesn't match the previous character (even though the stack
                // is occupied), append the character frequency of the previous character, clear the stack,
                // and push this new character.
                {
                    compressed.Append($"{stack.Peek()}{stack.Count}");
                    stack.Clear();
                    stack.Push(ch);
                }
                    
            }

            // Finally, if the stack contains another character, we add its frequency to the compressed string.
            if (stack.Count > 0)
                compressed.Append($"{stack.Peek()}{stack.Count}");
            
            return compressed.ToString();
        }
    }
}