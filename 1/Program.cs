namespace AYNUR_pract2
{
    internal class Program
    {
        static void PervayaIgra()
        {
            Random random = new Random();
            Console.WriteLine("Угадай число");
            int randomnoyeChislo = random.Next(0, 100);
            while (0 == 0)
            {
                Console.Write("Ввод числа: ");
                int vvodPolzovatelya = Convert.ToInt32(Console.ReadLine());
                if (vvodPolzovatelya > randomnoyeChislo)
                    Console.WriteLine("Загаданное число меньше!");
                else if (vvodPolzovatelya < randomnoyeChislo)
                    Console.WriteLine("Загаданное число больше!");
                else
                {
                    Console.WriteLine("Вы угадали число!");
                    break;
                }
            }
        }
        static void VtorayaIgra()
        {
            int[,] tablicaUmnijeniya = new int[10, 10];
            string ots;
            for (int stroka = 1; stroka < 10; stroka++)
            {
                for (int ryad = 1; ryad < 10; ryad++)
                {
                    tablicaUmnijeniya[stroka, ryad] = stroka * ryad;
                }
            }
            for (int stroka = 1; stroka < 10; stroka++)
            {
                for (int ryad = 1; ryad < 10; ryad++)
                {
                    if (tablicaUmnijeniya[stroka, ryad] > 9)
                        Console.Write(tablicaUmnijeniya[stroka, ryad] + " ");
                    else
                        Console.Write(tablicaUmnijeniya[stroka, ryad] + "  ");
                }
                Console.WriteLine();
            }

        }
        static void TretyaIgra()
        {
            while (true)
            {
                Console.Write("Введите число или \"Выход\": ");
                string vvodChisla = Console.ReadLine();
                if (vvodChisla == "выход")
                {
                    break;
                }
                int chislo = Convert.ToInt32(vvodChisla);
                for (int i = 1; i <= chislo; i++)
                {
                    if (chislo % i == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Выбор игры: ");
                int igra = Convert.ToInt32(Console.ReadLine());
                switch (igra)
                {
                    case 1:
                        PervayaIgra();
                        break;
                    case 2:
                        VtorayaIgra();
                        break;
                    case 3:
                        TretyaIgra();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}