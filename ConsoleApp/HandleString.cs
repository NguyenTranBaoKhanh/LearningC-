using System.Text;

namespace ConsoleApp
{
    public class HandleString
    {
        private static readonly string input = "hello";
        public static void ReverseString()
        {

            string result = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                result += input[i];
            }
            Console.WriteLine($"ReverseString: {result}");

        }

        public static void ReverseString_v2()
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);

            Console.WriteLine($"ReverseString_v2: {new string(charArray)}");
        }

        public static void ReverseStringUsingStringBuilder()
        {
            // StringBuilder sb = new StringBuilder();
            StringBuilder sb = new();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                sb.Append(input[i]);
            }
            Console.WriteLine($"ReverseStringUsingStringBuilder: {sb.ToString()}");

        }

        public static void IsPalindrome(string input)
        {
            int left = 0;
            int right = input.Length - 1;
            while (left < right)
            {
                if (input[left] != input[right])
                {
                    Console.WriteLine($"{input} is not a palindrome.");
                    return;
                }
                left++;
                right--;
            }
            Console.WriteLine($"{input} is a palindrome.");
            return;
        }

        public static void IsPalindrome_v2(string str)
        {
            string reversed = new string(str.Reverse().ToArray());
            if (str == reversed)
            {
                Console.WriteLine($"{str} is a palindrome.");
                return;
            }
            Console.WriteLine($"{str} is not a palindrome.");
            return;
        }

        public static void RemoveExtraSpaces(string str)
        {
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ' || (i > 0 && str[i - 1] != ' '))
                {
                    result += str[i];
                }
            }
            Console.WriteLine($"RemoveExtraSpaces: {result}");
        }

        public static void RemoveExtraSpaces_v2(string str)
        {
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (!char.IsWhiteSpace(str[i]) || (i > 0 && !char.IsWhiteSpace(str[i - 1])))
                {
                    result += str[i];
                }
            }
            Console.WriteLine($"RemoveExtraSpaces_v2: {result}");
        }

        public static void RemoveExtraSpaces_v3(string str)
        {
            StringBuilder result = new StringBuilder();
            bool isSpace = true;

            foreach (char c in str.Trim())
            {
                if (char.IsWhiteSpace(c))
                {
                    if (!isSpace) result.Append(' ');
                    isSpace = true;
                }
                else
                {
                    result.Append(c);
                    isSpace = false;
                }
            }
            Console.WriteLine($"RemoveExtraSpaces_v3: {result.ToString()}");
            return ;
        }

        public static void SwapCase(string str)
        {
            StringBuilder result = new StringBuilder();
            foreach (char c in str)
            {
                if (char.IsLower(c))
                {
                    result.Append(char.ToUpper(c));
                }
                else if (char.IsUpper(c))
                {
                    result.Append(char.ToLower(c));
                }
                else
                {
                    result.Append(c);
                }
            }
            Console.WriteLine($"SwapCase: {result.ToString()}");
        }
    }
}