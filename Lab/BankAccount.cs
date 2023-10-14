using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    enum BankType
    {
        Сберегательный,
        Зарплатный,
        Кредитный,

    }
    internal class BankAccount
    {
        Random rnd = new Random();
        private static int id_counter = 0;
        private int id;
        private double balance;
        private BankType type = BankType.Сберегательный;

        /// <summary>
        /// Генерирует уникальный ID
        /// </summary>
        /// <returns></returns>
        private static int GenerateID()
        {
            return id_counter++;
        }

        /// <summary>
        /// Конструктор - создаёт банковский счёт
        /// </summary>
        /// <param name="type"></param>
        public BankAccount(BankType type)
        {
            id = GenerateID();
            balance = 0.0;
            this.type = type;
        }
        
        /// <summary>
        /// Вносит деньги на счёт
        /// </summary>
        /// <param name="money"></param>
        public void DepositMoney(double money)
        {
            balance += money;
            Console.WriteLine($"Счёт пополнен на {money} рублей, текущий баланс {balance}");
        }

        /// <summary>
        /// Снимает деньги со счёта
        /// </summary>
        /// <param name="money"></param>
        public void WithdrawMoney(double money)
        {
            if (money <= balance)
            {
                balance -= money;
                Console.WriteLine($"Со счёта снято {money} рублей, текущий баланс {balance}");
            }
            else
            {
                Console.WriteLine("На счёте недостаточно средств");
            }
        }

        public void Balance()
        {
            Console.WriteLine($"Ваш баланс {balance}");
        }

        /// <summary>
        /// Выводит информацию о счёте
        /// </summary>
        public void Print()
        {
            Console.WriteLine($"Номер вашего счёта: {id}\nБаланс: {balance}\nТип: {type}\n");
        }

    }
}
