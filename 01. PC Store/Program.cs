using System;

namespace _01._PC_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cpuPriceDollar = double.Parse(Console.ReadLine());
            double gpuPriceDollar = double.Parse(Console.ReadLine());
            double ramPriceDollar = double.Parse(Console.ReadLine());
            int ramAmount = int.Parse(Console.ReadLine());
            double discountPercentage = double.Parse(Console.ReadLine());



            double cpuPriceLev = cpuPriceDollar * 1.57;
            double gpuPriceLev = gpuPriceDollar * 1.57;
            double ramPriceLev = ramPriceDollar * (double)ramAmount * 1.57;
            double discountedCpu = cpuPriceLev - (cpuPriceLev * discountPercentage);
            double discountedGpu = gpuPriceLev - (gpuPriceLev * discountPercentage);


            Console.WriteLine($"Money needed - {(discountedCpu + discountedGpu + ramPriceLev):f2} leva.");
        }
    }
}
