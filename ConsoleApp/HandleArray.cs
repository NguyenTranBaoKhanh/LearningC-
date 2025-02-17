namespace ConsoleApp
{
    public class HandleArray
    {
        public static int FindSecondLargest(int[] arr)
        {
            if (arr.Length < 2)
                throw new ArgumentException("Mảng phải có ít nhất 2 phần tử");

            Array.Sort(arr);
            Array.Reverse(arr); // Sắp xếp giảm dần

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < arr[0])
                    return arr[i]; // Tìm phần tử khác với max1
            }

            throw new InvalidOperationException("Không có phần tử lớn thứ hai");
        }

        public static int FindLargest(int[] arr)
        {
            if (arr.Length == 0)
                throw new ArgumentException("Mảng không được rỗng");

            int largest = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > largest)
                {
                    largest = arr[i];
                }
            }
            return largest;
        }
    }
}