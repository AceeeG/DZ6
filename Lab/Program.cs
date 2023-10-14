using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    internal class Program
    {
        /// <summary>
        /// Выполняет упражнения 1-3
        /// </summary>
        static void DoExercises()
        {
            Console.WriteLine("Упражнения с 1 - 3 обьеденены");

            BankType type = BankType.Сберегательный;
            BankAccount account = new BankAccount(type);
            account.Print();
            BankAccount account1 = new BankAccount(type);
            account.Print();
            Console.WriteLine("Команды:\n<Внести> - если хотите пополнить счёт\n<Снять> - если хотите снять деньги со счёта\n" +
                    "<Баланс> - если хотите посмотреть баланс\n<Выход> - если хотите выйти\n");

            string command;
            do
            {
                Console.WriteLine("Введите команду");
                command = Console.ReadLine().ToLower();
                switch (command)
                {
                    case "внести":

                        Console.WriteLine("Введите сумму, которую хотите внести\n");
                        bool dep_money_flag = double.TryParse(Console.ReadLine(), out double dep_money);
                        if (!dep_money_flag)
                        {
                            Console.WriteLine("Вы не ввели число");
                            do
                            {
                                dep_money_flag = double.TryParse(Console.ReadLine(), out dep_money);
                            } while (!dep_money_flag);
                        }
                        account.DepositMoney(dep_money);
                        break;
                    case "снять":
                        Console.WriteLine("Введите сумму, которую хотите снять\n");
                        bool take_money_flag = double.TryParse(Console.ReadLine(), out double take_money);
                        if (!take_money_flag)
                        {
                            Console.WriteLine("Вы не ввели число");
                            do
                            {
                                take_money_flag = double.TryParse(Console.ReadLine(), out take_money);
                            } while (!take_money_flag);
                        }
                        account.WithdrawMoney(take_money);
                        break;
                    case "баланс":
                        account.Balance();
                        break;
                    case "выход":
                        break;
                    default:
                        Console.WriteLine("Вы ввели неверную команду\n");
                        break;
                }

            } while (!command.Equals("выход"));
        }

        static void DoHomeWork()
        {
            Console.WriteLine("Домашнее задание 1\n");
            Building building = new Building();
            building.Print();

            Console.WriteLine("Команды:\n<Высота этажа> - если хотите найти высоту этажа\n<Комнаты в подьезде> - если хотите узнать сколько комнат в подьезде\n" +
                "<Комнат на этаже> - если хотите узнать сколько комнат на этаже\n<Выход> - если хотите выйти\n");
            string command;
            do
            {
                Console.WriteLine("Введите команду\n");
                command = Console.ReadLine().ToLower();
                switch (command)
                {
                    case "высота этажа":
                        Console.WriteLine("Введите номер этажа\n");
                        bool floor_flag = int.TryParse(Console.ReadLine(), out int floor);
                        building.CalculateHeightOfLevel(floor);
                        break;

                    case "комнаты в подьезде":
                        building.CalculateRoomsInEnterance();
                        break;
                    case "комнат на этаже":
                        building.CalculateRoomsInFloor();
                        break;
                    case "выход":
                        break;
                    default:
                        Console.WriteLine("Неверная команда");
                        break;
                }

            } while (!command.Equals("выход"));
        }

        


        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа 7\n");
            DoExercises();
            DoHomeWork();


            Console.ReadKey();
        }
    }
}
