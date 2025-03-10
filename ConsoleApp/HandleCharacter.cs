namespace ConsoleApp
{
    public class HandleCharacter
    {
        public static void CountCharacter(string str, char character)
        {
            int count = 0;
            foreach (char c in str)
            {
                if (c == character)
                {
                    count++;
                }
            }
            Console.WriteLine($"{count} {character} in {str}");
            // return count;
        }





        static bool IsValidParentheses(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c); // Thêm dấu ngoặc mở vào stack
                }
                else
                {
                    if (stack.Count == 0) return false; // Không có dấu mở để ghép

                    char top = stack.Pop(); // Lấy dấu mở gần nhất
                    if (!IsMatching(top, c)) return false; // Kiểm tra có khớp không
                }
            }

            return stack.Count == 0; // Nếu stack rỗng thì hợp lệ
        }

        static bool IsMatching(char open, char close)
        {
            return (open == '(' && close == ')') ||
                   (open == '{' && close == '}') ||
                   (open == '[' && close == ']');
        }
    }

}