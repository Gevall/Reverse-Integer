namespace Reverse_Integer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(int.MaxValue + "     " + int.MinValue);
            Console.WriteLine("Число до преобразования 122. Число после преобразования " + ReverseInt(122));
            Console.WriteLine("Число до преобразования 120. Число после преобразования " + ReverseInt(120));
            Console.WriteLine("Число до преобразования -122. Число после преобразования " + ReverseInt(-122));
            Console.WriteLine("Число до преобразования -122. Число после преобразования " + ReverseInt(-122));
            Console.WriteLine("Число до преобразования -130. Число после преобразования " + ReverseInt(-130));
            Console.ReadKey();
        }

        private static int ReverseInt(int x)
        {
            string? outx = null; // Строка для преобразования числа
            string str = x.ToString(); // Число преобразованное в стркоу
            bool isNegative = false; // Проверка на отрицательное число
            if (str[0] == '-') isNegative = true; // Проверка на отрицатльное число

            for (int i = 1; i <= str.Length; i++) // Метод обратной записи числа
            {
                if (isNegative && str.Length == i ) continue;
                if (str[str.Length - 1] == 0) continue;
                else outx += str[str.Length - i];
            }

            try
            {
                if (Int32.TryParse(outx, out x)) // Преобразование строки в число
                {
                    if (isNegative)  // Если изначальное число отрицательное, то умножам на -1
                    {
                        x = x * -1;
                    }
                }
                else if (Int64.TryParse(outx, out long tmp)) // Если число больше int.MaxValue то возвращаем 0
                {
                    return 0;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return x;
        }
    }
}