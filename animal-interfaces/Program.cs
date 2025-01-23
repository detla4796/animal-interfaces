using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animal_interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя животного: ");
            string name = Console.ReadLine();
            Console.Write("Введите координату X: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату Y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Animal animal = new Animal(name, x, y);
            Console.Write("Введите смещение по X: ");
            int dx = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите смещение по Y: ");
            int dy = Convert.ToInt32(Console.ReadLine());
            animal.Move(dx, dy);
            Console.Write("Введите новое имя животного: ");
            string newName = Console.ReadLine();
            animal.ChangeName(newName);
            Console.Write("Хотите ли вы услышать голос животного? (да/нет) ");
            string answer = Console.ReadLine();
            if (answer == "да" || answer == "Да" || answer == "ДА")
            {
                animal.Voice();
            }
            else if (answer == "нет" || answer == "Нет" || answer == "НЕТ")
            {
                Console.Write("Животное молчит");
            }
            else
            {
                Console.Write("Некорректный ввод");
            }
            Console.Write("Хотите клонировать животное? (да/нет) ");
            string answer2 = Console.ReadLine();
            if (answer2 == "да" || answer2 == "Да" || answer2 == "ДА")
            {
                Animal clone = (Animal)animal.Clone();
                Console.WriteLine($"Клон животного: {clone.Name}, {clone.X}, {clone.Y}");
            }
            else if (answer2 == "нет" || answer2 == "Нет" || answer2 == "НЕТ")
            {
                Console.Write("Животное не клонировано");
            }
            else
            {
                Console.Write("Некорректный ввод");
            }
            Console.Write("Сравнение координат животного и клона");
            int result = animal.CompareTo(animal.Clone());
            if (result == 0)
            {
                Console.WriteLine("\nКоординаты животного и клона равны");
            }
            else
            {
                Console.WriteLine("\nКоординаты животного и клона не равны");
            }
        }
    }
    interface IMove
    {
        void Move(int dx, int dy);
    }
    interface IChangeName
    {
        void ChangeName(string newName);
    }
    interface IVoice
    {
        void Voice();
    }
    public class Animal : IMove, IChangeName, IVoice, IComparable, ICloneable
    {
        public string Name { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public Animal(string name, int x, int y)
        {
            Name = name;
            X = x;
            Y = y;
        }
        public void Move(int dx, int dy)
        {
            X += dx;
            Y += dy;
            Console.WriteLine($"Животное переместилось на место: {X}, {Y}");
        }
        public void ChangeName(string newName)
        {
            Name = newName;
            Console.WriteLine($"Животное теперь называется: {Name}");
        }
        public void Voice()
        {
            Console.WriteLine("Животное издает звук");
        }
        public int CompareTo(object obj)
        {
            if (obj is Animal person) return X.CompareTo(person.X);
            else throw new ArgumentException("Некорректное значение параметра");
        }
        public object Clone()
        {
            return new Animal(Name, X, Y);
        }
    }
}

