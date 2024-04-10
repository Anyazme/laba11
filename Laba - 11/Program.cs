using Laba10;
using System.Collections;
using laba__11;
using System.Reflection;
using System;
using System.Collections.Immutable;
using System.Diagnostics;


namespace laba11
{
	public class Program
	{
		static void Main(string[] args)
		{
			#region ArrayList
			//ArrayList

			Console.WriteLine("ARRAYLIST");
			Console.WriteLine();

			Random rnd = new Random();
			ArrayList arrayList = new ArrayList();

			for (int i = 0; i < 20; i++)
			{ int num = rnd.Next(1, 5);
				if (num == 1)
				{ 
					Aircraft a = new Aircraft();
					a.RandomInit();
					arrayList.Add(a);
				}
				else 
				if (num == 2)
				{
					Plane p = new Plane();
					p.RandomInit();
					arrayList.Add(p);
				}
				else
				if(num == 3)
				{
					Helicopter h = new Helicopter();
					h.RandomInit();
					arrayList.Add(h);
				}
				else
				if (num == 4)
				{
					Fighter f = new Fighter();
					f.RandomInit();
					arrayList.Add(f);
				}
			}

			arrayList.Sort();
			foreach (object a in arrayList)
			{
				Console.WriteLine(a.ToString());
			}

			Console.WriteLine($"Count = {arrayList.Count}");
			Console.WriteLine($"Capacity = {arrayList.Capacity}");


			Console.WriteLine("Введите, пожалуйста, количество элементов для добавления");
			int addition = GetIntInRange(1, 20);
			for (int i = 0; i < addition; i++)
			{
				int number = rnd.Next(1, 3);
				if (number == 1)
				{
					Aircraft a = new Aircraft();
					a.RandomInit();
					arrayList.Add(a);
				}
				else
				if (number == 2)
				{
					Plane p = new Plane();
					p.RandomInit();
					arrayList.Add(p);
				}
				else
				if (number == 3)
				{
					Helicopter h = new Helicopter();
					h.RandomInit();
					arrayList.Add(h);
				}
				else
				if (number == 4)
				{
					Fighter f = new Fighter();
					f.RandomInit();
					arrayList.Add(f);
				}
			}

			foreach (object item in arrayList)
			{
				Console.WriteLine(item.ToString());
			}
			Console.WriteLine($"Count = {arrayList.Count}");

			//поиск и удаление 
			Console.WriteLine("Введите, пожалуйста, элемент для поиска");
			Aircraft aircraft = new Aircraft();
			aircraft.Init();
			arrayList.Add(aircraft);


			int pos = arrayList.IndexOf(aircraft);

			Console.WriteLine($"Индекс нужного элемента {pos}");
			Console.WriteLine();

			Console.WriteLine("Введите, пожалуйста, индекс элемента для удаления");
			int index = GetIntInRange(1, arrayList.Count);
			arrayList.RemoveAt(index - 1);

			Console.WriteLine("Коллекция после удаления:");
			foreach (object item in arrayList)
			{
				Console.WriteLine(item.ToString());
			}

			//клонирование коллекции
			ArrayList al = (ArrayList)arrayList.Clone();

			//запросы
			Console.WriteLine();
			Console.WriteLine("Запросы");
			string fighterClass = "Палубный";
			Console.WriteLine($"Общее количество членов экипажа по заданному классу: {CrewMembers(arrayList, fighterClass)}");
			AircraftAfter2020(arrayList);
			string maxRange = MaxRange(arrayList);
			Console.WriteLine($"Модель(-и) самолётов с самой максимальной дальностью полёта: {maxRange}");
			#endregion


			Console.WriteLine();
			Console.WriteLine("QUEUE <T>");
		    
			Queue<Aircraft> queue = new Queue<Aircraft>();
			Console.WriteLine($"В очереди {queue.Count} элементов");
			for (int i = 0; i < 5; i++)
			{
				Aircraft aircraft1 = new Aircraft();
				aircraft1.RandomInit();
				queue.Enqueue(aircraft1);
			}
			for (int i = 0; i < 5; i++)
			{
				Helicopter helicopter = new Helicopter();
				helicopter.RandomInit();
				queue.Enqueue(helicopter);
			}

			foreach (Aircraft item in queue)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine($"В очереди {queue.Count} элементов");

			//добавление элементов
			Console.WriteLine("Введите, пожалуйста, количество элементов для добавления");
			int add = GetIntInRange(1, 20);
			for (int i = 0; i < add; i++)
			{
				int ans = rnd.Next(1, 3);
				if (ans == 1)
				{
					Aircraft a = new Aircraft();
					a.RandomInit();
					queue.Enqueue(a);
				}
				else
				if (ans == 2)
				{
					Helicopter h = new Helicopter();
					h.RandomInit();
					queue.Enqueue(h);
				}
				
			}

			foreach (Aircraft item in queue)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine($"В очереди {queue.Count} элементов");

			//поиск и удаление 
			Console.WriteLine("Введите, пожалуйста, вертолет для поиска");
			Helicopter HelicopterSearch = new Helicopter();
			HelicopterSearch.Init();
			if (queue.Contains(HelicopterSearch))
			{
				Console.WriteLine("Найден");
			}

			else
			{
				Console.WriteLine("Не найден");
			}

			
			Queue<Aircraft> temp = new Queue<Aircraft>();
			while (queue.Count > 0)
			{
				Aircraft a = queue.Dequeue();
				if (!a.Equals(HelicopterSearch))
				{
					temp.Enqueue(a);
				}
				else
				{
					Console.WriteLine($"Удаляем {a}");
				}
					
			}
			queue = temp;
			Console.WriteLine();
			Console.WriteLine("Коллекция после удаления:");
			foreach (Aircraft item in queue)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine($"В очереди {queue.Count} элементов");


			//запросы
			Console.WriteLine();
			Console.WriteLine("Запросы");
			Console.WriteLine($"Общее количество членов экипажа по заданному классу: {CrewMembersQueue(queue, fighterClass)}");
			AircraftAfter2020Queue(queue);
			string maxRangeQueue = MaxRangeQueue(queue);
			Console.WriteLine($"Модель(-и) самолётов с самой максимальной дальностью полёта: {maxRangeQueue}");

			Console.WriteLine();
			Console.WriteLine("Задание 3");
			TestCollection testCollection = new TestCollection();

			//элемнты из SortedDictionary
			//первый элемент
			var firstElement = testCollection.collection1.First();
			Aircraft firstAircraft = firstElement.Key;
			Helicopter firstHelicopter = firstElement.Value;

			//серединный элемент
			int middleIndex = testCollection.collection1.Count / 2;
			var middleElement = testCollection.collection1.Skip(middleIndex).First();
			Aircraft middleAircraft = middleElement.Key;
			Helicopter middleHelicopter = middleElement.Value;

			//последний элемент
			var lastElement = testCollection.collection1.Last();
			Aircraft lastAircraft = lastElement.Key;
			Helicopter lastHelicopter = lastElement.Value;

			
			Helicopter first = new Helicopter(firstHelicopter.Model,firstHelicopter.Year, firstHelicopter.Type, firstHelicopter.Number, firstHelicopter.BladesNumber);
			Helicopter middle = new Helicopter(middleHelicopter.Model, middleHelicopter.Year, middleHelicopter.Type, middleHelicopter.Number, middleHelicopter.BladesNumber);
			Helicopter last = new Helicopter(lastHelicopter.Model, lastHelicopter.Year, middleHelicopter.Type, middleHelicopter.Number, lastHelicopter.BladesNumber);
			Helicopter noexist = new Helicopter("Вертолет", 3000, "Дальнолетный", 48, 678);

			//измерение времени
			Stopwatch sw = new Stopwatch();

			Console.WriteLine("SortedDictionary");
			long time = 0;
			for (int i = 0; i < 5; i++)
			{
				sw.Start();
				bool ok = testCollection.collection1.ContainsValue(first);
				sw.Stop();
				time += sw.ElapsedMilliseconds;
			}

			long time1 = 0;
			for (int i = 0; i < 5; i++)
			{
				sw.Start();
				bool ok = testCollection.collection1.ContainsValue(middle);
				sw.Stop();
				time1 += sw.ElapsedMilliseconds;
			}

			long time2 = 0;
			for (int i = 0; i < 5; i++)
			{
				sw.Start();
				bool ok = testCollection.collection1.ContainsValue(last);
				sw.Stop();
				time2 += sw.ElapsedMilliseconds;
			}


			long time3 = 0;
			for (int i = 0; i < 5; i++)
			{
				sw.Start();
				bool ok = testCollection.collection1.ContainsValue(noexist);
				sw.Stop();
				time3 += sw.ElapsedMilliseconds;
			}

			Console.WriteLine($"Первый элемент:{time},\nСерединный элемент: {time1},\nПоследний элемент:{time2},\nНесуществующий элемент: {time3}");

			Console.WriteLine();
			Console.WriteLine("SortedDictionary<string>");
			long time4 = 0;
			for (int i = 0; i < 5; i++)
			{
				sw.Start();
				bool ok = testCollection.collection2.ContainsKey(first.ToString());
				sw.Stop();
				time4 += sw.ElapsedMilliseconds;
			}

			long time5 = 0;
			for (int i = 0; i < 5; i++)
			{
				sw.Start();
				bool ok = testCollection.collection2.ContainsKey(middle.ToString());
				sw.Stop();
				time5 += sw.ElapsedMilliseconds;
			}

			long time6 = 0;
			for (int i = 0; i < 5; i++)
			{
				sw.Start();
				bool ok = testCollection.collection2.ContainsKey(last.ToString());
				sw.Stop();
				time6 += sw.ElapsedMilliseconds;
			}


			long time7 = 0;
			for (int i = 0; i < 5; i++)
			{
				sw.Start();
				bool ok = testCollection.collection2.ContainsKey(noexist.ToString());
				sw.Stop();
				time7 += sw.ElapsedMilliseconds;
			}

			Console.WriteLine($"Первый элемент:{time4},\nСерединный элемент: {time5},\nПоследний элемент:{time6},\nНесуществующий элемент: {time7}");

			Console.WriteLine();
			Console.WriteLine("HashSet");
			long time8 = 0;
			for (int i = 0; i < 5; i++)
			{
				sw.Start();
				bool ok = testCollection.collection3.Contains(first);
				sw.Stop();
				time8 += sw.ElapsedMilliseconds;
			}

			long time9 = 0;
			for (int i = 0; i < 5; i++)
			{
				sw.Start();
				bool ok = testCollection.collection3.Contains(middle);
				sw.Stop();
				time9 += sw.ElapsedMilliseconds;
			}

			long time10 = 0;
			for (int i = 0; i < 5; i++)
			{
				sw.Start();
				bool ok = testCollection.collection3.Contains(last);
				sw.Stop();
				time10 += sw.ElapsedMilliseconds;
			}


			long time11 = 0;
			for (int i = 0; i < 5; i++)
			{
				sw.Start();
				bool ok = testCollection.collection3.Contains(noexist);
				sw.Stop();
				time11 += sw.ElapsedMilliseconds;
			}

			Console.WriteLine($"Первый элемент:{time8},\nСерединный элемент: {time9},\nПоследний элемент:{time10},\nНесуществующий элемент: {time11}");


			Console.WriteLine();
			Console.WriteLine("HashSet <string>");
			long time12 = 0;
			for (int i = 0; i < 5; i++)
			{
				sw.Start();
				bool ok = testCollection.collection4.Contains(first.ToString());
				sw.Stop();
				time12 += sw.ElapsedMilliseconds;
			}

			long time13 = 0;
			for (int i = 0; i < 5; i++)
			{
				sw.Start();
				bool ok = testCollection.collection4.Contains(middle.ToString());
				sw.Stop();
				time13 += sw.ElapsedMilliseconds;
			}

			long time14 = 0;
			for (int i = 0; i < 5; i++)
			{
				sw.Start();
				bool ok = testCollection.collection4.Contains(last.ToString());
				sw.Stop();
				time14 += sw.ElapsedMilliseconds;
			}


			long time15 = 0;
			for (int i = 0; i < 5; i++)
			{
				sw.Start();
				bool ok = testCollection.collection4.Contains(noexist.ToString());
				sw.Stop();
				time15 += sw.ElapsedMilliseconds;
			}

			Console.WriteLine($"Первый элемент:{time12},\nСерединный элемент: {time13},\nПоследний элемент:{time14},\nНесуществующий элемент: {time15}");

		}

		static int GetIntInRange(int left, int right)
		{
			int number;
			while (true)
			{
				Console.WriteLine($"Введите число от {left} до {right}:");
				string input = Console.ReadLine();
				if (int.TryParse(input, out number) && number >= left && number <= right)
				{
					return number;
				}
				else
				{
					Console.WriteLine($"Ошибка. Значение должно быть от {left} до {right}");
				}
			}
		}



		static int CrewMembers(ArrayList arr, string fighterClass)
		{
			int crewMembers = 0;
			foreach (object obj in arr)
			{
				if (obj is Plane plane && plane is Fighter fighter && fighter.FighterClass == fighterClass)
				{
					crewMembers += plane.Number;
				}
			}
			return crewMembers;
		}

		public static void AircraftAfter2020(ArrayList list)
		{
			Console.WriteLine("Все воздушные судна, произведенные с 2020 года:");
			foreach (IInit item in list)
			{
				if (item is Aircraft aircraft && aircraft.Year >= 2020)
				{
					Console.WriteLine($"{aircraft.Model} - {aircraft.Year}");
				}
			}
		}

		public static string MaxRange(ArrayList list)
		{
			int maxRange = 0;
			string maxRangeModel = "";

			foreach (IInit item in list)
			{
				if (item is Plane)
				{
					Plane plane = item as Plane;
					if (plane != null && plane.Range > maxRange)
					{
						maxRange = plane.Range;
						maxRangeModel = plane.Model;
					}
				}
			}
			return maxRangeModel;
		}

		public static int CrewMembersQueue(Queue<Aircraft> arr, string fighterClass)
		{
			int crewMembers = 0;
			foreach (object obj in arr)
			{
				if (obj is Plane plane && plane is Fighter fighter && fighter.FighterClass == fighterClass)
				{
					crewMembers += plane.Number;
				}
			}
			return crewMembers;
		}

		public static void AircraftAfter2020Queue(Queue<Aircraft> arr)
		{
			Console.WriteLine("Все воздушные судна, произведенные с 2020 года:");
			foreach (IInit item in arr)
			{
				if (item is Aircraft aircraft && aircraft.Year >= 2020)
				{
					Console.WriteLine($"{aircraft.Model} - {aircraft.Year}");
				}
			}
		}

		public static string MaxRangeQueue(Queue<Aircraft> arr)
		{
			int maxRange = 0;
			string maxRangeModel = "";

			foreach (IInit item in arr)
			{
				if (item is Plane)
				{
					Plane plane = item as Plane;
					if (plane != null && plane.Range > maxRange)
					{
						maxRange = plane.Range;
						maxRangeModel = plane.Model;
					}
				}
			}
			return maxRangeModel;
		}
	}

}



