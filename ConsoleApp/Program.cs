// // See https://aka.ms/new-console-template for more information
// using ConsoleApp;

// Console.WriteLine("Hello, World!");

using ConsoleApp;

Console.WriteLine("---------------------Handle String---------------------------------");
HandleString.ReverseString();
HandleString.ReverseString_v2();
HandleString.ReverseStringUsingStringBuilder();
HandleString.IsPalindrome("madam"); // Output: True
HandleString.IsPalindrome("hello"); // Output: False
HandleString.IsPalindrome_v2("madam"); // Output: True
HandleString.IsPalindrome_v2("hello"); // Output: False
HandleString.IsPalindrome_v2("llll"); // Output: False
HandleString.RemoveExtraSpaces("Hello   guy   "); 
HandleString.RemoveExtraSpaces_v2(" Hello   guy   "); 
HandleString.RemoveExtraSpaces_v3(" Hello   guy   "); 
HandleString.SwapCase("hello"); 


Console.WriteLine("---------------------Handle Number---------------------------------");
HandleNumber.IsPrime(4);
Console.WriteLine(HandleNumber.FindUniqueElement([4, 1, 2, 1, 2, 4, 7, 9]));
Console.WriteLine(HandleNumber.RevertNumber(-12345));

Console.WriteLine("---------------------Handle Sort---------------------------------");
Console.WriteLine(HandleSort.BubbleSort([4, 1, 2, 1, 2, 4, 7, 9]));

Console.WriteLine("---------------------Handle Array---------------------------------");
Console.WriteLine(HandleArray.FindSecondLargest([4, 1, 2, 1, 2, 4, 7, 9]));
Console.WriteLine(HandleArray.FindLargest([4, 1, 2, 1, 2, 4, 7, 9]));
Console.WriteLine(HandleArray.FindLargest([4, 1, 2, 1, 2, 4, 7, 9]));

Console.WriteLine("---------------------Handle Character---------------------------------");
HandleCharacter.CountCharacter("hello", 'o');

//  void DoWork()
// {
//     Console.WriteLine("Bắt đầu công việc 1...");
//     Thread.Sleep(5000); // Chặn luồng trong 5 giây
//     Console.WriteLine("Công việc 1 hoàn thành!");
// }

//  void DoWork2()
// {
//     Console.WriteLine("Bắt đầu công việc 2...");
//     Thread.Sleep(7000); // Chặn luồng trong 5 giây
//     Console.WriteLine("Công việc 2 hoàn thành!");
// }

//  void Run()
// {
//     Console.WriteLine("Trước khi gọi DoWork()");
//     DoWork();
//     Console.WriteLine(A());
//     DoWork2();
//     Console.WriteLine("Sau khi gọi DoWork()");
// }

// Run();



//  async Task DoWorkAsync()
// {
//     Console.WriteLine("Bắt đầu công việc 1...");
//     await Task.Delay(5000); // Chờ 5 giây mà không chặn luồng
//     Console.WriteLine("Công việc 1 hoàn thành!");
// }
//  async Task DoWorkAsync2()
// {
//     Console.WriteLine("Bắt đầu công việc 2...");
//     await Task.Delay(3000); // Chờ 5 giây mà không chặn luồng
//     Console.WriteLine("Công việc 2 hoàn thành!");
// }

//  async Task RunAsync()
// {
//     // Console.WriteLine("Trước khi gọi DoWorkAsync()");
//     // await DoWorkAsync(); 
//     // Console.WriteLine(A());
//     // await DoWorkAsync2();
//     // Console.WriteLine("Sau khi gọi DoWorkAsync()");

//     Console.WriteLine("Trước khi gọi DoWorkAsync()");
//     Task task1= DoWorkAsync(); 
//     Console.WriteLine(A());
//     Task task2= DoWorkAsync2();
//     Console.WriteLine("Sau khi gọi DoWorkAsync()");
//     await task1;
//     await task2;
// }
// await RunAsync();

// string A(){
//     Console.WriteLine("Goi ham A");
//     return "A ne";
// }


