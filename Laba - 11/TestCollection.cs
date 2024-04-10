using Laba10;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using laba11;

namespace laba__11
{
	public class TestCollection
	{
		public SortedDictionary<Aircraft, Helicopter> collection1 = new SortedDictionary<Aircraft, Helicopter>();
		public SortedDictionary<string, Helicopter> collection2 = new ();
		
		
		public HashSet<Helicopter> collection3 = new HashSet<Helicopter>();
		public HashSet<string> collection4 = new HashSet<string>();

		Aircraft first, middle, last, noexist;

		public TestCollection()
		{
			for (int i = 0; i < 1000; i++)// перебор заданного количества элементов
			{
				try
				{
					Helicopter h = new Helicopter();
					h.RandomInit();

					h.Model += i.ToString();

					collection1.Add(h, h);
					collection2.Add(h.ToString(), h);

					collection3.Add(h);
					collection4.Add(h.ToString());
				}

				catch (Exception e)
				{
					Console.WriteLine($"Ошибка {e.Message}");
				}
			}
		}
	}
}

