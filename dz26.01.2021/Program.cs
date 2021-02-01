//дз1

//using System;

//namespace ConsoleAp
//{
//    public class Rectangle
//    {
//        public double side1, side2;
//        public Rectangle(double side1, double side2)
//        {
//            this.side1 = side1;
//            this.side2 = side2;
//        }
//        public double AreaCalculator()
//        {

//            return side1 * side2;

//        }
//        public double PerimeterCalculator()
//        {
//            return 2 * (side1 + side2);
//        }
//        public void Print()
//        {
//            Console.WriteLine($"площадь:{AreaCalculator()}, периметр: {PerimeterCalculator()}");
//        }
//    }


//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            double a, b;
//            Console.WriteLine($"Длинна прямоугольника: { a = double.Parse(Console.ReadLine())}");
//            Console.WriteLine($"Ширина прямоуголӣника: { b = double.Parse(Console.ReadLine())}");
//            Rectangle rect = new Rectangle(a, b);
//            rect.Print();
//            Console.ReadLine();
//        }
//    }
//}


//дз2

//using System;

//namespace _232323
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var book = new Book(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
//            book.show();

//        }
//    }

//    class Book
//    {
//        public Title title;
//        public Author author;
//        public Content content;
//        public Book(string title, string author, string content)
//        {
//            this.title = new Title(title);
//            this.author = new Author(author);
//            this.content = new Content(content);
//        }

//        public void show()
//        {
//            title.show();
//            author.show();
//            content.show();
//        }

//    }

//    class Title
//    {
//        public string title;
//        public void show()
//        {
//            Console.ForegroundColor = ConsoleColor.Yellow;
//            Console.WriteLine(title);
//        }
//        public Title(string title)
//        {
//            this.title = title;
//        }

//    }


//    class Author
//    {
//        public string author;
//        public void show()
//        {
//            Console.ForegroundColor = ConsoleColor.Red;
//            Console.WriteLine(author);
//        }
//        public Author(string author)
//        {
//            this.author = author;
//        }
//    }
//    class Content
//    {
//        public string content;
//        public void show()
//        {
//            Console.ForegroundColor = ConsoleColor.Green;
//            Console.WriteLine(content);
//        }
//        public Content(string content)
//        {
//            this.content = content;
//        }
//    }
//}


//дз3

//using System;

//namespace _232323
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string name = Console.ReadLine();
//            int age = Convert.ToInt32(Console.ReadLine());
//            string color = Console.ReadLine();

//            var cat = new Animal(name, age, color);

//            Console.WriteLine(" Cat ");
//            Console.WriteLine($"name: {cat.name}");
//            Console.WriteLine($"age: {cat.age}");
//            Console.WriteLine($"color: {cat.color}");
//        }

//    }
//    class Animal
//    {

//        public string name { get; set; }
//        public int age { get; set; }
//        public string color { get; set; }
//        public Animal(string name, int age, string color)
//        {
//            this.name = name;
//            this.age = age;
//            this.color = color;
//        }
//    }
//}



//дз4

//using System;

//namespace _28._1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var conv = new Converter(11.3, 0.15, 13.2);



//            Console.WriteLine($"1000 usd-tjk: {conv.UsdToTjk(1000)}");
//            Console.WriteLine($"1000 tjk-usd: {conv.TjkToUsd(1000)}");
//            Console.WriteLine($"1000 eur-tjk: {conv.EurToTjk(1000)}");
//            Console.WriteLine($"1000 tjk-eur: {conv.TjkToEur(1000)}");
//            Console.WriteLine($"1000 rub-tjk: {conv.RubToTjk(1000)}");
//            Console.WriteLine($"1000 tjk=rub: {conv.TjkToRub(1000)}");
//        }
//    }
//    class Converter
//    {
//        public Converter()
//        {

//        }
//        public Converter(double usd, double rub, double eur)
//        {
//            this.usd = usd;
//            this.rub = rub;
//            this.eur = eur;
//        }
//        public double usd { get; set; }
//        public double rub { get; set; }
//        public double eur { get; set; }

//        public double TjkToUsd(double tjk)
//        {
//            return tjk / usd;
//        }
//        public double TjkToEur(double tjk)
//        {
//            return tjk / eur;
//        }
//        public double TjkToRub(double tjk)
//        {
//            return tjk / rub;
//        }
//        public double RubToTjk(double tjk)
//        {
//            return rub * tjk;
//        }
//        public double UsdToTjk(double tjk)
//        {
//            return usd * tjk;
//        }
//        public double EurToTjk(double tjk)
//        {
//            return eur * tjk;
//        }

//    }
//}


//дз5

using System;

namespace dz26.01.2021

{
    class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"У нас есть эта вакансия: \n" +
            $"Разработчик\n" +
            $"Тестер\n" +
            $"Владелец продукта\n" +
            $"Счетчикn" +
            $"Скрам Мастер n");

        Console.WriteLine($"Пожалуйста, введите свои данные и должность, на которую вы претендуете \n");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"пожалуйста, введите свою фамилию: ");
        string lastName = Console.ReadLine();
        Console.WriteLine($"Пожалуйста, введите свое Имя: ");
        string firstName = Console.ReadLine();
        Console.WriteLine($"Пожалуйста, введите позицию: ");
        string position = Console.ReadLine();
        Console.WriteLine($"Пожалуйста, укажите годы вашего опыта: ");
        int expierence = Convert.ToInt32(Console.ReadLine());
        Employee employee1 = new Employee(lastName, firstName, position, expierence);
        employee1.positionInfo();
        employee1.getInfo();
    }
}
class Employee
{
    public string lastName { get; set; }
    public string firstName { get; set; }
    public string position { get; set; }
    public int expierence { get; set; }
    public Employee(string lastName, string firstName, string position, int expierence)
    {
        this.lastName = lastName;
        this.firstName = firstName;
        this.position = position;
        this.expierence = expierence;
    }
    public double salary;
    public void getInfo()
    {
        Console.WriteLine($"Фамилия: {lastName} \n" +
            $"Имя: {firstName}\n" +
            $"Позиция: {position} \n" +
            $"Зарплата: {salary}");
    }
    public void positionInfo()
    {
        if (position == "Разработчик")
        {
            if (expierence <= 1)
            {
                salary = 1500 - (1500 * 14 / 100);
                Console.WriteLine($"Ваша зарплата с вычетом налога и пенсионного фонда составляет = {salary}");
            }
            else if (expierence >= 2)
            {
                salary = 2500 - (2500 * 14 / 100);
                Console.WriteLine($"Ваша зарплата с вычетом налога и пенсионного фонда составляет = {salary}");
            }
        }
        else if (position == "Тестер")
        {
            if (expierence <= 1)
            {
                salary = 1000 - (1000 * 14 / 100);
                Console.WriteLine($"Ваша зарплата с вычетом налога и пенсионного фонда составляет = {salary}");
            }
            else if (expierence >= 2)
            {
                salary = 2000 - (2000 * 14 / 100);
                Console.WriteLine($"Ваша зарплата с вычетом налога и пенсионного фонда составляет = {salary}");
            }
        }
        else if (position == "Владелец продукта")
        {
            if (expierence <= 1)
            {
                salary = 800 - (800 * 14 / 100);
                Console.WriteLine($"Ваша зарплата с вычетом налога и пенсионного фонда составляет = {salary}");
            }
            else if (expierence >= 2)
            {
                salary = 1600 - (1600 * 14 / 100);
                Console.WriteLine($"Ваша зарплата с вычетом налога и пенсионного фонда составляет = {salary}");
            }
        }
        else if (position == "Счетчик")
        {
            if (expierence <= 1)
            {
                salary = 1100 - (1100 * 14 / 100);
                Console.WriteLine($"Ваша зарплата с вычетом налога и пенсионного фонда составляет = {salary}");
            }
            else if (expierence >= 2)
            {
                salary = 2200 - (2200 * 14 / 100);
                Console.WriteLine($"Ваша зарплата с вычетом налога и пенсионного фонда составляет = {salary}");
            }
            //else if(опыт)
        }
        else if (position == "Скрам Мастер")
        {
            if (expierence <= 1)
            {
                salary = 900 - (900 * 14 / 100);
                Console.WriteLine($"Ваша зарплата с вычетом налога и пенсионного фонда составляет = {salary}");
            }
            else if (expierence >= 2)
            {
                salary = 1800 - (1800 * 14 / 100);
                Console.WriteLine($"Ваша зарплата с вычетом налога и пенсионного фонда составляет = {salary}");
            }
        }
        else
            Console.WriteLine($"Эта позиция  не существует");
    }
}
}




//using System;

//namespace dz26._01._2021
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine($"У нас есть эта вакансия: \n" +
//                $"Разработчик\n" +
//                $"Тестер\n" +
//                $"Владелец продукта\n" +
//                $"Счетчикn" +
//                $"Скрам Мастер n");

//            Console.WriteLine($"Пожалуйста, введите свои данные и должность, на которую вы претендуете \n");
//            Console.ForegroundColor = ConsoleColor.Red;
//            Console.WriteLine($"пожалуйста, введите свою фамилию: ");
//            string lastName = Console.ReadLine();
//            Console.WriteLine($"Пожалуйста, введите свое Имя: ");
//            string firstName = Console.ReadLine();
//            Console.WriteLine($"Пожалуйста, введите позицию: ");
//            string position = Console.ReadLine();
//            Console.WriteLine($"Пожалуйста, укажите годы вашего опыта: ");
//            int expierence = Convert.ToInt32(Console.ReadLine());
//            Employee employee1 = new Employee(lastName, firstName, position, expierence);
//            employee1.positionInfo();
//            employee1.getInfo();
//        }
//    }
//    class Employee
//    {
//        public string lastName { get; set; }
//        public string firstName { get; set; }
//        public string position { get; set; }
//        public int expierence { get; set; }
//        public Employee(string lastName, string firstName, string position, int expierence)
//        {
//            this.lastName = lastName;
//            this.firstName = firstName;
//            this.position = position;
//            this.expierence = expierence;
//        }
//        public double salary;
//        public void getInfo()
//        {
//            Console.WriteLine($"Фамилия: {lastName} \n" +
//                $"Имя: {firstName}\n" +
//                $"Позиция: {position} \n" +
//                $"Зарплата: {salary}");
//        }
//        public void positionInfo()
//        {
//            if (position == "Разработчик")
//            {
//                if (expierence <= 1)
//                {
//                    salary = 1500 - (1500 * 14 / 100);
//                    Console.WriteLine($"Ваша зарплата с вычетом налога и пенсионного фонда составляет = {salary}");
//                }
//                else if (expierence >= 2)
//                {
//                    salary = 2500 - (2500 * 14 / 100);
//                    Console.WriteLine($"Ваша зарплата с вычетом налога и пенсионного фонда составляет = {salary}");
//                }
//            }
//            else if (position == "Тестер")
//            {
//                if (expierence <= 1)
//                {
//                    salary = 1000 - (1000 * 14 / 100);
//                    Console.WriteLine($"Ваша зарплата с вычетом налога и пенсионного фонда составляет = {salary}");
//                }
//                else if (expierence >= 2)
//                {
//                    salary = 2000 - (2000 * 14 / 100);
//                    Console.WriteLine($"Ваша зарплата с вычетом налога и пенсионного фонда составляет = {salary}");
//                }
//            }
//            else if (position == "Владелец продукта")
//            {
//                if (expierence <= 1)
//                {
//                    salary = 800 - (800 * 14 / 100);
//                    Console.WriteLine($"Ваша зарплата с вычетом налога и пенсионного фонда составляет = {salary}");
//                }
//                else if (expierence >= 2)
//                {
//                    salary = 1600 - (1600 * 14 / 100);
//                    Console.WriteLine($"Ваша зарплата с вычетом налога и пенсионного фонда составляет = {salary}");
//                }
//            }
//            else if (position == "Счетчик")
//            {
//                if (expierence <= 1)
//                {
//                    salary = 1100 - (1100 * 14 / 100);
//                    Console.WriteLine($"Ваша зарплата с вычетом налога и пенсионного фонда составляет = {salary}");
//                }
//                else if (expierence >= 2)
//                {
//                    salary = 2200 - (2200 * 14 / 100);
//                    Console.WriteLine($"Ваша зарплата с вычетом налога и пенсионного фонда составляет = {salary}");
//                }
//                //else if(опыт)
//            }
//            else if (position == "Скрам Мастер")
//            {
//                if (expierence <= 1)
//                {
//                    salary = 900 - (900 * 14 / 100);
//                    Console.WriteLine($"Ваша зарплата с вычетом налога и пенсионного фонда составляет = {salary}");
//                }
//                else if (expierence >= 2)
//                {
//                    salary = 1800 - (1800 * 14 / 100);
//                    Console.WriteLine($"Ваша зарплата с вычетом налога и пенсионного фонда составляет = {salary}");
//                }
//            }
//            else
//                Console.WriteLine($"Эта позиция  не существует");
//        }
//    }
//}
