using System;
using SmartHouseLibrary;
namespace SmartHouse2
{
    class Menu
    {
        static void backMenu()
        {
            bool backMenu = true;
            while (backMenu)
            {
                Console.WriteLine("Введите 1, чтобы вернуться в меню");
                int back = int.Parse(Console.ReadLine());
                switch (back)
                {
                    case 1:
                        {
                            backMenu = false;
                            Console.Clear();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Вы ввели не единицу\n");
                            break;
                        }
                }
            }
        }
        static void Main(string[] args)
        {
            BuisnessLogic bl = new BuisnessLogic();
            bl.DataCreation();
            bl.Update();
            bool endPoint = true;
            while (endPoint)
            {
                Console.WriteLine("             Меню\n");
                Console.WriteLine("1- Вывести содержимое файла на экран\n");  //+
                Console.WriteLine("2- Вывести отдельную строчку на экран\n"); //+
                Console.WriteLine("3- Редактирование записи\n");
                Console.WriteLine("4- Удаление записи\n");
                Console.WriteLine("5- Добавление записи\n");
                Console.WriteLine("6- Вычислить среднее за выбранный период\n");
                Console.WriteLine("7- Вычислить пики за указанный период\n");
                Console.WriteLine("8- Вычислить средние значения за шаг за период\n");
                Console.WriteLine("0- Выход из меню\n"); //+
                Console.WriteLine("\n");
                Console.WriteLine("Введите номер операции для выполнения: ");

                int switch_on = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");
                switch (switch_on)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("\t ВЫВОД БАЗЫ ДАННЫХ НА ЭКРАН");
                            Console.WriteLine("  №       Дата              Комната     Показатель          \n");
                            Console.WriteLine(bl.Print());
                            backMenu();
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("Всего строк в базе данных: " + bl.PrintListSize());
                            Console.WriteLine("\t ВЫВОД ЗАПИСИ НА ЭКРАН\n");
                            Console.WriteLine("введите номер записи: ");
                            int num = int.Parse(Console.ReadLine());
                            Console.WriteLine(bl.PrintLine(num));
                            backMenu();
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine(bl.Print());
                            Console.WriteLine("\t РЕЖИМ ИЗМЕНЕНИЯ ЗАПИСИ\n");
                            Console.WriteLine("Какую строку вы хотите изменить");
                            int num = int.Parse(Console.ReadLine());
                            bool setCheck = true;
                            while (setCheck)
                            {
                                Console.WriteLine("Введите номер команды");
                                Console.WriteLine("1- смениить дату");
                                Console.WriteLine("2- сменить комнату");
                                Console.WriteLine("3- сменить назначение датчика");
                                Console.WriteLine("4- сменить значение");
                                Console.WriteLine("0- Exit");
                                int comand_on = int.Parse(Console.ReadLine());
                                switch (comand_on)
                                {
                                    case 1:
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Введите новую дату(в формате дд.мм.гг)");
                                            string newDate = Console.ReadLine();
                                            bl.ChangeDate(num, newDate);

                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Введите новую комнату");
                                            string newRoom = Console.ReadLine();
                                            bl.ChangeRoom(num, newRoom);
                                            break;
                                        }
                                    case 3:
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Введите номер датчика(1-Температура, 2-Влажность, 3-Давление)");
                                            int newDetector = int.Parse(Console.ReadLine());
                                            bl.ChangeDetector(num, newDetector);
                                            break;
                                        }
                                    case 4:
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Введите новый показатель");
                                            int newSignal = int.Parse(Console.ReadLine());
                                            bl.ChangeSignal(num, newSignal);
                                            break;
                                        }
                                    case 0:
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Вы действительно хотите выйти?\n");
                                            Console.WriteLine("1-yes, 0-no");
                                            int signal = int.Parse(Console.ReadLine());
                                            if (signal == 1)
                                            {
                                                setCheck = false;
                                            }
                                            break;
                                        }
                                    default:
                                        {
                                            Console.WriteLine("Ошибка при вводе названия команды, повторите");
                                            break;
                                        }
                                }
                            }
                            Console.WriteLine("Запись была обновлена!");
                            bl.Update();
                            backMenu();
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();

                            Console.WriteLine(bl.Print());
                            Console.WriteLine("\t РЕЖИМ УДАЛЕНИЯ ЗАПИСИ\n");
                            Console.WriteLine("Какую строку вы хотите удалить");
                            int num = int.Parse(Console.ReadLine());
                            bl.Delete(num);
                            Console.WriteLine("Запись была удалена!");
                            break;
                        }
                    case 5:
                        {
                            Console.Clear();
                            Console.WriteLine("\t РЕЖИМ ДОБАВЛЕНИЕ ЗАПИСИ\n");
                            Console.WriteLine("Введите новую дату(в формате дд.мм.гг)");
                            string newDate = Console.ReadLine();
                            Console.WriteLine("Введите новую комнату");
                            string newRoom = Console.ReadLine();
                            Console.WriteLine("Введите номер датчика(1-Температура, 2-Влажность, 3-Давление)");
                            int newDetector = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введите новый показатель");
                            int newSignal = int.Parse(Console.ReadLine());
                            bl.Add(newDate, newRoom, newDetector, newSignal);
                            break;
                        }
                    case 6:
                        {
                            Console.Clear();
                            Console.WriteLine("\t СРЕДНЕЕ ЗНАЧЕНИЕ ЗА ПЕРИОД\n");
                            Console.WriteLine("1- Средние значения по дням\n");
                            Console.WriteLine("2- Среднее значение по месяцам\n");
                            Console.WriteLine("3- Среднее значение по годам \n");
                            Console.WriteLine("Выберите подпункт, введите нужное число\n");
                            int checkAver = int.Parse(Console.ReadLine());
                            switch (checkAver)
                            {
                                case 1:
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Введите новую дату(в формате дд.мм.гг)");
                                        string date = Console.ReadLine();
                                        Console.WriteLine("Введите название комнаты\n");
                                        string place = Console.ReadLine();
                                        Console.Clear();
                                        Console.WriteLine(bl.AverageDays(date, place));
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Введите месяц и год (с новой строки в числовом представлении)\n");
                                        Console.WriteLine("Месяц ");
                                        string month = Console.ReadLine();
                                        Console.WriteLine("\nГод ");
                                        string year = Console.ReadLine();
                                        Console.WriteLine("Введите название комнаты\n");
                                        string place = Console.ReadLine();
                                        string dateString = "1." + month + "." + year;
                                        DateTime dateValue = Convert.ToDateTime(dateString);
                                        Console.WriteLine(bl.AverageMonth(dateValue, place));
                                        break;
                                    }
                                case 3:
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Введите год в числовом представлении\n");
                                        string year = Console.ReadLine();
                                        Console.WriteLine("Введите название комнаты\n");
                                        string place = Console.ReadLine();
                                        string dateDtring = "1.1." + year;
                                        DateTime dateValue = Convert.ToDateTime(dateDtring);
                                        Console.WriteLine(bl.AverageYear(dateValue, place));
                                        break;
                                    }
                            }
                            break;
                        }
                    case 7:
                        {
                            Console.Clear();
                            Console.WriteLine("\t ПИКИ ПОКАЗАТЕЛЕЙ ЗА ПЕРИОД");
                            Console.WriteLine("Введите начальную дату: ");
                            DateTime dateTimeStart = Convert.ToDateTime(Console.ReadLine());
                            Console.WriteLine("Введите конечную дату дату: ");
                            DateTime dateTimeEnd = Convert.ToDateTime(Console.ReadLine());
                            Console.WriteLine("Введите название комнаты: ");
                            string exactRoom = Console.ReadLine();
                            Console.WriteLine(bl.Peaks(dateTimeStart, dateTimeEnd, exactRoom));
                            backMenu();
                            break;
                        }
                    case 8:
                        {
                            Console.Clear();
                            Console.WriteLine("\t ПОКАЗАТЕЛИ ЗА ПЕРИОДЫ С ОПРЕДЕЛЕННЫМ ШАГОМ");
                            Console.WriteLine("Введите начальную дату: ");
                            DateTime dateTimeStart = Convert.ToDateTime(Console.ReadLine());
                            Console.WriteLine("Введите конечную дату дату: ");
                            DateTime dateTimeEnd = Convert.ToDateTime(Console.ReadLine());
                            Console.WriteLine("Введите название комнаты(датчика): ");
                            string exactRoom = Console.ReadLine();
                            Console.WriteLine("Введите шаг: ");
                            double step = double.Parse(Console.ReadLine());
                            Console.WriteLine(bl.AverageInSteps(dateTimeStart, dateTimeEnd, exactRoom, step));
                            break;
                        }
                    case 0:
                        {
                            Console.Clear();
                            Console.WriteLine("Вы действительно хотите выйти?\n");
                            Console.WriteLine("1-yes, 0-no");
                            int signal = int.Parse(Console.ReadLine());
                            if (signal == 1)
                            {
                                endPoint = false;
                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Ошибка при вводе названия команды, повторите");
                            break;
                        }
                }
            }
        }
    }
}