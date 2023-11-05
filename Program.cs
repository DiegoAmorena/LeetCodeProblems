namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            _2659MakeArrayEmpty a = new();
            var b = new int[] { 3, 4, -1 };
            Console.WriteLine(
                a.CountOperationsToEmptyArray(b)
                ) ;
        }
    }
}