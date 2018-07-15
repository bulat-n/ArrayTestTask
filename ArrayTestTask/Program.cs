using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTestTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Укажите размер:");
            int Size = Int32.Parse(Console.ReadLine());
            //int Size = 10;
            int[] Numbers = new int[Size];
            Random rnd = new Random();
            for (int i = 0; i < Size; i++)
            {
                Numbers[i] = rnd.Next(1, 10);
            }
            Console.WriteLine("Массив изначально:");
            ShowArray(Numbers, Size);

            bool Found = false;
            var MaxNumber = -1;
            var MaxPlace = -1;
            Console.Write("Изменены: ");
            for (int i = 0; i < Numbers.Length; i++)
            {
                if (Numbers[i] % 2 == 0 && i % 2 != 0)
                {
                    Console.Write(i + "; ");
                    Numbers[i] *= 2;
                    Found = true;
                }
                if (Numbers[i] % 2 != 0 && i % 2 == 0 && MaxNumber < Numbers[i])
                {
                    MaxNumber = Numbers[i];
                    MaxPlace = i;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Измененный массив:");
            ShowArray(Numbers, Size);
            if (!Found)
                Console.WriteLine("Не найдено ни одного четного элемента на нечетном месте");
            if (MaxNumber != -1)
                Console.WriteLine($"Максимальный нечетный элемент на четном месте: {MaxNumber}. Место: {MaxPlace}");
            Console.ReadKey();
        }

        static void ShowArray(int[] Numbers, int Size)
        {
            for (int i = 0; i < Size; i++)
            {
                Console.WriteLine($"Элемент {i}: {Numbers[i]}");
            }
        }
    }
}
