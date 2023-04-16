namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Sum sum = new Sum();
            sum.doSum(0, 0);
            Console.WriteLine("Check Logdata File");
        }
    }
}