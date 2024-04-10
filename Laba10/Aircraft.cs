using System.Xml.Linq;

namespace Laba10
{
	public class Aircraft : IInit, IComparable<Aircraft>, ICloneable
	{
		protected Random rnd = new Random();
		//инициализация атрибутов
		protected string model;
		protected int year;
		protected string type;
		protected int number;

		//свойство модели (для хранения)
		public string Model { get; set; }

		//свойство для года производства
		public int Year
		{
			get { return year; }
			set
			{
				if (value >= 1900 && value <= DateTime.Now.Year)
				{
					year = value;
				}
				else
				{
					year = 0;
				}
			}
		}
		//свойство типа двигателя (для хранения)
		public string Type { get; set; }

		//свойство для количества членов экипажа
		public int Number
		{
			get { return number; }
			set
			{
				if (value < 0)
				{
					number = 0;
				}
				else
				{
					number = value;
				}
			}
		}

		//конструктор (без параметров)
		public Aircraft()
		{
			Model = "Нет";
			Year = 0;
			Type = "Нет";
			Number = 0;
		}

		//конструктор (с параметрами)
		public Aircraft(string model, int year, string type, int number)
		{
			Model = model;
			Year = year;
			Type = type;
			Number = number;
		}

		//метод для вывод информации
		public virtual void Show()
		{
			Console.WriteLine($"Aircraft: \nМодель = {Model}, \nГод производства = {Year}, \nТип двигателя = {Type}, \nКоличество людей экипажа = {Number}");
		}

		//метод для инициализации атрибутов (ввод с клавиатуры)
		public virtual void Init()
		{
			Console.WriteLine("Введите, пожалуйста, модель:");
			Model = Console.ReadLine().Trim();

			Console.WriteLine("Введите, пожалуйста, год производства:");
			if (!int.TryParse(Console.ReadLine().Trim(), out int year))
			{
				Console.WriteLine("Некорректный ввод. Год установлен по умолчанию: 2000");
				Year = 2000;
			}
			else
			{
				Year = year;
			}

			Console.WriteLine("Введите, пожалуйста, тип двигателя:");
			Type = Console.ReadLine().Trim();

			Console.WriteLine("Введите, пожалуйста, количество членов экипажа:");
			if (!int.TryParse(Console.ReadLine().Trim(), out int number))
			{
				Console.WriteLine("Некорректный ввод. Количество членов экипажа установлено по умолчанию: 6");
				Number = 6;
			}
			else
			{
				Number = number;
			}
		}


		//метод для инициализации атрибутов (случайным датчиком)
		public virtual void RandomInit()
		{

			Model = "Модель" + rnd.Next(1000);
			Year = rnd.Next(1900, DateTime.Now.Year + 1);
			Type = "Двигатель" + rnd.Next(100);
			Number = rnd.Next(1, 100);
		}

		//для вывода информации атрибутов в виде строки
		public override string ToString()
		{
			return $" {Model}, {Year}, {Type}, {Number}";
		}

		//метод возвращения копии (для глубокого копирования)
		public object Clone()
		{
			return new Aircraft(Model, Year, Type, Number);
		}

		public override bool Equals(object obj)
		{
			if (obj == null || GetType() != obj.GetType())
				return false;

			Aircraft other = (Aircraft)obj;
			return Model == other.Model && Year == other.Year && Type == other.Type && Number == other.Number;
		}
		public int CompareTo(Aircraft other)
		{
			return Year.CompareTo(other.Year);
		}
		public override int GetHashCode()
		{
			return Year.GetHashCode();
		}

		public string GetBase()
		{
			return $"Model: {Model}, Year: {Year}, Type: {Type}, Number: {Number}";
		}

	}


}


