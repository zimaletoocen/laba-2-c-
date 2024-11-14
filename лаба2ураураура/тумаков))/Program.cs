using System;

namespace lublyKFU
{
    // Упражнение 3.1: Перечисляемый тип для видов банковского счета
    enum AccountType
    {
        Current, // Текущий
        Savings   // Сберегательный
    }

    // Упражнение 3.2: Структура для хранения информации о банковском счете
    struct BankAccount
    {
        public string AccountNumber;
        public AccountType Type;
        public decimal Balance;

        public BankAccount(string accountNumber, AccountType type, decimal balance)
        {
            AccountNumber = accountNumber;
            Type = type;
            Balance = balance;
        }
    }

    // Домашнее задание 3.1: Перечисляемый тип для ВУЗов
    enum University
    {
        KGU, 
        KAI,
        KHTI 
    }

    // Структура работника
    struct Worker
    {
        public string Name;
        public University University;

        public Worker(string name, University university)
        {
            Name = name;
            University = university;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Упражнение 3.1: Создаем переменную типа перечисления и выводим значение
            AccountType myAccountType = AccountType.Current;
            Console.WriteLine($"Тип банковского счета: {myAccountType}");

            // Упражнение 3.2: Создаем переменную типа структуры и заполняем данными
            BankAccount myAccount = new BankAccount("123456789", AccountType.Savings, 1500.75m);
            Console.WriteLine($"Номер счета: {myAccount.AccountNumber}");
            Console.WriteLine($"Тип счета: {myAccount.Type}");
            Console.WriteLine($"Баланс: {myAccount.Balance} рублей");

            // Домашнее задание 3.1: Создаем переменную типа структуры работник и заполняем данными
            Worker worker = new Worker("Иванов Иван", University.KGU);
            Console.WriteLine($"Имя работника: {worker.Name}");
            Console.WriteLine($"ВУЗ: {worker.University}");
        }
    }
}