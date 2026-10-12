namespace PracticeCSharpTextRPG
{
    internal class Program
    {
        static void Print(int value)
        {
            Console.WriteLine(value);
        }
        static int AddAndPrint(int a, int b)
        {
            int ret = a + b;
            Print(ret);
            return ret;
        }

        static void Main(string[] args)
        {
            Program.AddAndPrint(12, 20);
            Program.AddAndPrint(13, 20);
            Program.AddAndPrint(14, 20);
            Program.AddAndPrint(15, 20);
            Program.AddAndPrint(10, 20);
        }
    }
}
