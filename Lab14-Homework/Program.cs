using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14_Homework
{
    class Program
    {
        /*Разработать абстрактный класс Animal, который описывает животное.
         * Класс содержит следующие элементы: */
        static void Main(string[] args)
        {
            //Цикл, чтобы не заходить каждый раз

            while (true)
            {
                //Чтобы небыло бесконечного полотна, очистка консоли
                Console.Clear();

                Console.WriteLine("Сделайте выбор: кошка или собака?");
                string name = Console.ReadLine();
                Cat cat = new Cat(name);
                Dog dog = new Dog(name);

                if (name == "кошка")
                {
                    cat.ShowInfo();
                    Console.WriteLine();
                }
                else if (name == "Кошка")
                {
                    cat.ShowInfo();
                    Console.WriteLine();
                }
                else if (name == "собака")
                {
                    dog.ShowInfo();
                    Console.WriteLine();
                }
                else if (name == "Собака")
                {
                    dog.ShowInfo();
                    Console.WriteLine();
                }
                else Console.WriteLine("Это не кошка и не собака!");

                Console.WriteLine("\nНажмите Enter чтобы ввести другое животное. ");
                Console.ReadKey();
            }
        }
        abstract class Animal
        {
            //абстрактное свойство - название животного.
            public abstract string Name { get; set; }

            //конструктор, устанавливающий значение по умолчанию для названия;
            public Animal(string name)
            {
                Name = name;
            }
            //абстрактный метод Say(), который выводит звук, который издает животное;
            public abstract void Say();

            /*неабстрактный метод ShowInfo(), который выводит на консоль последовательно название, 
             * а затем звук(вызывая метод Say()).*/
            public void ShowInfo()
            {
                Console.WriteLine($"{Name} говорит: ");
                Say();
            }

        }
        /*Разработать классы Cat и Dog, которые реализуют абстрактный класс Animal.
         * В классах реализовать следующие элементы:
         * свойство – название животного;
         * метод Say(), выводящий на экран «Мяу» либо «Гав» соответственно.*/
        class Cat : Animal
        {
            string name;
            public Cat(string name)
            : base(name)
            {

            }
            public override string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }
            public override void Say()
            {
                Console.Write("Мяу!");
            }

        }
        class Dog : Animal
        {
            string name;
            public Dog(string name)
            : base(name)
            {

            }
            public override string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }
            public override void Say()
            {
                Console.Write("Гав!");
            }

        }

    }
}
