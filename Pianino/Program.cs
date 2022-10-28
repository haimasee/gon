internal class Program
    {static void Main()
        {
            Console.WriteLine("В программе есть 2 октавы.\nВыбери октаву через F1, F2 соответственно.\nДля выхода из программы нажми клавишу F3");
            ConsoleKeyInfo octav = Console.ReadKey();
            Console.WriteLine(octav);
            for (; octav.Key != ConsoleKey.F3; octav = Console.ReadKey())
            {
                int[] vibor = new int[0];
                switch (octav.Key)
                {
                    case ConsoleKey.F1:
                        vibor = Changer(1);
                        Octav1(vibor);
                        break;
                    case ConsoleKey.F2:
                        vibor = Changer(2);
                        Octav1(vibor);
                        break;
                    case ConsoleKey.F3:
                        break;
                    default:
                        Console.WriteLine("Ошмбка. Такой команды не существует");
                        break;
                }
            }
            Console.WriteLine("Конец программы");
        }
        static int[] Changer(int vibor)
        {
            if (vibor == 1) return new int[12] { 65, 69, 73, 78, 82, 87, 92, 98, 104, 110, 116, 123 };
            else return new int[] { 523, 554, 587, 622, 659, 698, 740, 784, 831, 880, 932, 988 };
        }
        static void Octav1(int[] not)
        {
            Console.WriteLine("Если хотите выбрать другую октаву, нажмите  F3\nКлавиши: Q,W,E,R,A,S,D,F,Z,X,C,V");
            ConsoleKeyInfo noti = Console.ReadKey();

            for (; noti.Key != ConsoleKey.F3; noti = Console.ReadKey())
                switch (noti.Key)
                {
                    case ConsoleKey.Q:
                        Vivod_beepa(not[0]);
                        break;
                    case ConsoleKey.W:
                        Vivod_beepa(not[1]);
                        break;
                    case ConsoleKey.E:
                        Vivod_beepa(not[2]);
                        break;
                    case ConsoleKey.R:
                        Vivod_beepa(not[3]); ;
                        break;
                    case ConsoleKey.A:
                        Vivod_beepa(not[4]);
                        break;
                    case ConsoleKey.S:
                        Vivod_beepa(not[5]);
                        break;
                    case ConsoleKey.D:
                        Vivod_beepa(not[6]);
                        break;
                    case ConsoleKey.F:
                        Vivod_beepa(not[7]);
                        break;
                    case ConsoleKey.Z:
                        Vivod_beepa(not[8]);
                        break;
                    case ConsoleKey.X:
                        Vivod_beepa(not[9]);
                        break;
                    case ConsoleKey.C:
                        Vivod_beepa(not[10]);
                        break;
                    case ConsoleKey.V:
                        Vivod_beepa(not[11]);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Такой ноты нет");
                        break;
                }
            Console.WriteLine("Введите F1 или F2 для выбора октавы. Для завершения программы введите F5 ");
        }

        static void Vivod_beepa(int rand)
        {
            Console.Beep(rand, 600);
            Console.Clear();
        }
    }