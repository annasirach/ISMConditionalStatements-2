using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchProjectConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("1.Расшифровка дня недели.\n2.Расшифровка месяца.\n3.Выполнение операций над числами.\n4.Выход\nНомер задание: ");
            int h = Convert.ToInt32(Console.ReadLine());
            switch (h)
            {
                case 1:
                    {
                        Console.Write("День:");
                        int день = Convert.ToInt32(Console.ReadLine());
                        switch (день)
                        {
                            case 1: Console.WriteLine("Понедельник");
                                break;
                            case 2:
                                Console.WriteLine("Вторник");
                                break;
                            case 3:
                                Console.WriteLine("Среда");
                                break;
                            case 4:
                                Console.WriteLine("Четверг");
                                break;
                            case 5:
                                Console.WriteLine("Пятница");
                                break;
                            case 6:
                                Console.WriteLine("Субота");
                                break;
                            case 7:
                                Console.WriteLine("Воскресенье");
                                break;
                            default: Console.WriteLine("Такого дня не существует");break;
                        }
                        break;
                      
                    }
                case 2:
                    {
                        Console.Write("Месяц:");
                        int месяц = Convert.ToInt32(Console.ReadLine());
                        switch (месяц)
                        {
                            case 1:
                                Console.WriteLine("Январь");
                                break;
                            case 2:
                                Console.WriteLine("Февраль");
                                break;
                            case 3:
                                Console.WriteLine("Март");
                                break;
                            case 4:
                                Console.WriteLine("Апрель");
                                break;
                            case 5:
                                Console.WriteLine("Май");
                                break;
                            case 6:
                                Console.WriteLine("Июнь");
                                break;
                            case 7:
                                Console.WriteLine("Июль");
                                break;
                            case 8:
                                Console.WriteLine("Август");
                                break;
                            case 9:
                                Console.WriteLine("Сентябрь");
                                break;
                            case 10:
                                Console.WriteLine("Октябрь");
                                break;
                            case 11:
                                Console.WriteLine("Ноябрь");
                                break;
                            case 12:
                                Console.WriteLine("Декабрь");
                                break;
                            default: Console.WriteLine("Такого месяца не существует"); break;
                        }
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("1.Сложение\n2.Умножение\n3.Вычитание\n4.Деление\nНомер задание: ");
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.Write("A=");
                        float a = Convert.ToSingle(Console.ReadLine());
                        Console.Write("B= ");
                        float b = Convert.ToSingle(Console.ReadLine());

                        switch(c)
                        {
                            case 1:
                                Console.WriteLine($"a+b={a + b}"); break;
                            case 2:
                                Console.WriteLine($"a*b={a * b}"); break;
                            case 3:
                                Console.WriteLine($"a-b={a - b}"); break;
                            case 4:
                                Console.WriteLine($"a/b={a / b}"); break;
                            default: Console.WriteLine("Ошибка"); break;
                        }
                        break;

                    }
                case 4:
                    { Environment.Exit(0); break; }
                default: Console.WriteLine("Помилка"); break;
            }

        }
    }
}
