using System;

namespace dotnet_flow
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 1024;
            int b = 768;
            float res = Minus(a, b);
            Console.WriteLine($"{a} / {b} = {res}");
        }

        public static float Minus(int a, int b)
        {
            return (float)a / b;
        }
    }
}
