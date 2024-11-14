using System;

namespace Pozhaluistapomogiteyanehochudelatlabu
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 1
            Task1();

            // Задача 2
            Task2();

            // Задача 3
            Task3();

            // Задача 4
            Task4();

            // Задача 5
            Task5();

            // Задача 6
            Task6();
        }

        static void Task1()
        {
            Console.WriteLine("Задача 1: Вывести информацию о типах данных.");

            Console.WriteLine($"int - max: {int.MaxValue}, min: {int.MinValue}");
            Console.WriteLine($"long - max: {long.MaxValue}, min: {long.MinValue}");
            Console.WriteLine($"float - max: {float.MaxValue}, min: {float.MinValue}");
            Console.WriteLine($"double - max: {double.MaxValue}, min: {double.MinValue}");
            Console.WriteLine($"char - max: {char.MaxValue}, min: {char.MinValue}");
            Console.WriteLine($"byte - max: {byte.MaxValue}, min: {byte.MinValue}");
            Console.WriteLine();
        }

        static void Task2()
        {
            Console.WriteLine("Задача 2: Ввести имя, город, возраст и PIN-код.");
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите город: ");
            string city = Console.ReadLine();
            Console.Write("Введите возраст: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Введите PIN-код: ");
            string pin = Console.ReadLine();

            Console.WriteLine($"Имя: {name}, Город: {city}, Возраст: {age}, PIN-код: {pin}");
            Console.WriteLine();
        }

        static void Task3()
        {
            Console.WriteLine("Задача 3: Преобразование регистра строки.");
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();
            string transformed = TransformCase(input);
            Console.WriteLine($"Преобразованная строка: {transformed}");
            Console.WriteLine();
        }

        static string TransformCase(string input)
        {
            char[] chars = input.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsUpper(chars[i]))
                {
                    chars[i] = char.ToLower(chars[i]);
                }
                else if (char.IsLower(chars[i]))
                {
                    chars[i] = char.ToUpper(chars[i]);
                }
            }
            return new string(chars);
        }

        static void Task4()
        {
            Console.WriteLine("Задача 4: Найти количество вхождений подстроки.");
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();
            Console.Write("Введите подстроку: ");
            string substring = Console.ReadLine();

            int count = CountOccurrences(str, substring);
            Console.WriteLine($"Количество вхождений подстроки '{substring}': {count}");
            Console.WriteLine();
        }

        static int CountOccurrences(string str, string substring)
        {
            int count = 0;
            int index = 0;

            while ((index = str.IndexOf(substring, index)) != -1)
            {
                count++;
                index += substring.Length;
            }
            return count;
        }

        static void Task5()
        {
            Console.WriteLine("Задача 5: Расчет количества бутылок виски.");
            Console.Write("Введите стандартную цену (normPrice): ");
            int normPrice = int.Parse(Console.ReadLine());
            Console.Write("Введите скидку в Duty Free (в процентах - salePrice): ");
            int salePrice = int.Parse(Console.ReadLine());
            Console.Write("Введите стоимость отпуска (holidayPrice): ");
            int holidayPrice = int.Parse(Console.ReadLine());

            int savingsPerBottle = normPrice * salePrice / 100;
            int bottlesNeeded = holidayPrice / savingsPerBottle;
            Console.WriteLine($"Необходимое количество бутылок: {bottlesNeeded}");
            Console.WriteLine();
        }

        static void Task6()
        {
            Console.WriteLine("Задача 6: Информация о студентах и их потреблении алкоголя.");
            Student[] students = new Student[5];

            students[0] = new Student("Иванов", "Иван", "001", new DateTime(2000, 1, 1), 'a', "Водка", 40, 2);
            students[1] = new Student("Петров", "Петр", "002", new DateTime(2001, 2, 2), 'b', "Пиво", 5, 5);
            students[2] = new Student("Сидоров", "Сидор", "003", new DateTime(2002, 3, 3), 'c', "Вино", 12, 1);
            students[3] = new Student("Федоров", "Федор", "004", new DateTime(2003, 4, 4), 'd', "Коньяк", 20, 4);
            students[4] = new Student("Кузнецов", "Михаил", "005", new DateTime(2004, 5, 5), 'a', "Пиво", 5, 3);

            double totalConsumed = 0;
            double totalAlcohol = 0;

            foreach (var student in students)
            {
                totalConsumed += student.LiquidAmount;
                totalAlcohol += student.CalculateAlcoholVolume();
            }

            Console.WriteLine($"Общий объем выпитого: {totalConsumed} л");
            Console.WriteLine($"Общий объем алкоголя: {totalAlcohol} л");

            foreach (var student in students)
            {
                double percentageAlcohol = (student.CalculateAlcoholVolume() / totalAlcohol) * 100;
                double percentageLiquid = (student.LiquidAmount / totalConsumed) * 100;
                Console.WriteLine($"{student.LastName} {student.FirstName} выпил {percentageAlcohol:F2}% алкоголя и {percentageLiquid:F2}% жидкости.");
            }
        }
    }

    struct Student
    {
        public string LastName;
        public string FirstName;
        public string ID;
        public DateTime DateOfBirth;
        public char AlcoholismCategory; // 'a', 'b', 'c', 'd'
        public string DrinkName;
        public double AlcoholPercentage; // в процентах
        public double LiquidAmount; // в литрах

        public Student(string lastName, string firstName, string id, DateTime dateOfBirth, char alcoholismCategory, string drinkName, double alcoholPercentage, double liquidAmount)
        {
            LastName = lastName;
            FirstName = firstName;
            ID = id;
            DateOfBirth = dateOfBirth;
            AlcoholismCategory = alcoholismCategory;
            DrinkName = drinkName;
            AlcoholPercentage = alcoholPercentage;
            LiquidAmount = liquidAmount;
        }

        public double CalculateAlcoholVolume()
        {
            return (AlcoholPercentage / 100) * LiquidAmount;
        }
    }
}