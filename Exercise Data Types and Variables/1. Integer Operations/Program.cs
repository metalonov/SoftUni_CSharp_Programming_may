namespace _1._Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());

            int op1 = num1 + num2;
            int op2 = op1/num3;
            int op3 = op2 * num4;
            Console.WriteLine(op3);
        }
    }
}