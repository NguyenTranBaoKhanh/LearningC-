namespace ConsoleApp
{
    public class HandleCharacter
    {
        public static void CountCharacter(string str, char character){
            int count = 0;
            foreach(char c in str){
                if(c ==character){
                    count++;
                }
            }
            Console.WriteLine($"{count} {character} in {str}");
            // return count;
        }
    }
}