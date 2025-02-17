// See https://aka.ms/new-console-template for more information
using ConsoleApp;

Console.WriteLine("Hello, World!");

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


HandleNumber.IsPrime(4);

Console.WriteLine(HandleNumber.FindUniqueElement([4, 1, 2, 1, 2, 4, 7, 9]));


Console.WriteLine(HandleSort.BubbleSort([4, 1, 2, 1, 2, 4, 7, 9]));

Console.WriteLine(HandleArray.FindSecondLargest([4, 1, 2, 1, 2, 4, 7, 9]));
Console.WriteLine(HandleArray.FindLargest([4, 1, 2, 1, 2, 4, 7, 9]));


HandleCharacter.CountCharacter("hello", 'o');



