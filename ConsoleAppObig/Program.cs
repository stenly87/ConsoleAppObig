using System.Xml;

namespace ConsoleAppObig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Нотация О Большое
            // O(1)
            // O(log n) 
            // O(n)
            // O(2n)
            // O(m+n)
            // O(n log(n))
            // O(n*n)
            // O(n*n*n)

            // определить сколько можно купить быков, коров и телят
            // если есть 100 рублей, бык = 10р, корова = 5р, теленок = 0.5р
            // O(n * m * t) = O(nmt)
            for (int i = 0; i <= 10; i++) // O(n * n * n)  
            {
                for (int j = 0; j <= 20; j++) // O(n)
                {
                    for (int w = 0; w <= 200; w++) // O(n)
                    {
                        if (i + w + j == 100 && i * 10 + j * 5 + w * 0.5 == 100)
                        {
                            Console.WriteLine($"быки {i} коровы {j} телята {w}");
                        }
                    }
                }
            }

            return;
            int.TryParse(Console.ReadLine(), out int n);
            for (int i = 0; i < n; i++) // O(n * n * n)  
            {
                //i += i / 2;
                for (int j = 0; j < n; j++) // O(n)
                {
                    for (int w = 0; w < n; w++) // O(n)
                        Console.WriteLine("hello"); // O(1)
                }
            }

            Console.WriteLine(Mult(1, 1));// O(1)

        }

        static int Mult(int x, int y) // O(1)
        {
            return x * y; // O(1)
        }

        static int Mult1(int x, int y) // O(1)
        {
            if (x < 0 || y > 0) // O(1)
                return 0;
            return x * y; // O(1)
        }

        static int Mult2(int x, int y) // O(2n)
        {
            for (var i = 0; i < x; i++) // O(n)
            { 
                Console.WriteLine();
            }

            for (var i = 0; i < x; i++) // O(n)
            {
                Console.WriteLine();
            }
            return 0;
        }

        static int Mult3(int x, int y) // O(m + n)
        {
            for (var i = 0; i < x; i++) // O(m)
            {
                Console.WriteLine();
            }

            for (var i = 0; i < y; i++) // O(n)
            {
                Console.WriteLine();
            }
            return 0;
        }
    }
}
