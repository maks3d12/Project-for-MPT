

namespace Methoth
{
    internal class Games
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в мое приложение, выбирете опцию");
            Console.WriteLine(" 1 - число_угадайка \n 2 - Таблица умножения \n 3 - Узнай на что делится твое число \n 4- Выход из программы");
            
             int g = Convert.ToInt32(Console.ReadLine());
            while (g != 4)
            {

                switch (g)
                {
                    case 1:
                        RundomNumber();
                        break;
                    case 2:
                        Program2();
                        break;
                    case 3:
                        Program3();
                        break;
                    default:
                        Console.WriteLine("Вы явно ошиблись с опцией, прошу введите повторно");
                        break;

                    

                }
                Console.WriteLine(" 1 - число_угадайка \n 2 - Таблица умножения \n 3 - Узнай на что делится твое число \n 4- Выход из программы");
                g = Convert.ToInt32(Console.ReadLine());

            }
            

        }
        static void RundomNumber()
        {
            Random random = new Random();
            int value = random.Next(1, 100);
            Console.WriteLine("Угадайте загадоное мной число от 1 до 100");
            int number = Convert.ToInt32(Console.ReadLine());
            while (number != value)
            {


                if (number > value)
                {
                    Console.WriteLine("Введите меньшее значение");
                }
                if (number < value)
                {
                    Console.WriteLine("Введите большее значение");
                }
                number = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Молодцы! Вы угдали мое число: " + value);
        }
        static void Program2()
        {
            Console.WriteLine("Начало");
            int[,] Multiplicationtable = new int [10, 10];
            for (int i = 0; i < 10; i++)
            {
                
                for (int j = 0; j < 10; j++)
                {
                    int roro = (i+1) * (j+1); // Это переменная произведения j и i
                    Console.Write(Multiplicationtable[i,j] + (i+1) + "x" + (j+1) + "=" + roro + "\t");
                }
                Console.WriteLine();
            }
        }
           static void Program3()
        {
            Console.WriteLine("Пожалуйста введите число, а мы найдем то на что оно делится");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ваше число делится на:");
            for (int i = 1; i <= n; i++)
            {
                
                if (n%i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}