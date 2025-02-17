namespace ConsoleApp
{
    public class HandleNumber
    {
        public static void IsPrime(int n)
        {
            if (n < 2)
            {
                Console.WriteLine($"{n} is not a prime number.");
                return;
            }
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine($"{n} is not a prime number.");
                    return;
                }
            }
            Console.WriteLine($"{n} is a prime number.");
        }

        public static bool IsPrimeSqrt(int n)
        {
            if (n < 2) return false;
            if (n == 2) return true; // 2 là số nguyên tố duy nhất chẵn

            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        int[] nums = { 4, 1, 2, 1, 2 };
        public static int FindUniqueElement(int[] nums)
        {
            Dictionary<int, int> freq = new();

            foreach (int num in nums)
            {
                if (freq.ContainsKey(num))
                    freq[num]++;
                else
                    freq[num] = 1;
            }

            foreach (var pair in freq)
            {
                if (pair.Value == 1)
                    return pair.Key;
            }

            return -1; // Không có phần tử đơn lẻ (trường hợp ngoại lệ)
        }

    }
}