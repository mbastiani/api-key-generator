using System;
using System.Security.Cryptography;

namespace api_key_generator
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Quantidades de chaves que deseja gerar? (default 1)");
            var line = Console.ReadLine();
            int quantidade = Convert.ToInt32(string.IsNullOrWhiteSpace(line)? "1" : line);

            for (int i = 0; i < quantidade; i++)
            {
                var key = new byte[64];
                using (var generator = RandomNumberGenerator.Create())
                    generator.GetBytes(key);

                Console.WriteLine();
                Console.WriteLine(Convert.ToBase64String(key));
            }
            Console.ReadKey();
        }
    }
}