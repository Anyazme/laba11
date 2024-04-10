
using Laba10;

namespace Test___laba10
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void Test1()
		{
			//Arrange
			string expectedModel = "���";
			int expectedYear = 0;
			string expectedType = "���";
			int expectedNumber = 0;
			//Act
			Aircraft aircraft1 = new Aircraft(expectedModel, expectedYear, expectedType, expectedNumber);

			//Assert
			Assert.AreEqual(expectedModel, aircraft1.Model); //��������� �������� �� ���������
			Assert.AreEqual(expectedYear, aircraft1.Year);
			Assert.AreEqual(expectedType, aircraft1.Type);
			Assert.AreEqual(expectedNumber, aircraft1.Number);
		}


		[TestMethod]
		public void Test2()
		{
			//Arrange
			string expectedModel = "Boeing 737";
			int expectedYear = 2015;
			string expectedType = "GMF-67";
			int expectedNumber = 15;
			//Act
			Aircraft aircraft2 = new Aircraft(expectedModel, expectedYear, expectedType, expectedNumber);

			//Assert
			Assert.AreEqual(expectedModel, aircraft2.Model); //��������� �������� �� ���������
			Assert.AreEqual(expectedYear, aircraft2.Year);
			Assert.AreEqual(expectedType, aircraft2.Type);
			Assert.AreEqual(expectedNumber, aircraft2.Number);
		}

		[TestMethod]
		public void Test3()
		{
			//Arrange
			string expectedModel = "���";
			int expectedYear = 0;
			string expectedType = "���";
			int expectedNumber = 0;
			int expectedBladesNumber = 0;

			//Act
			Helicopter helicopter1 = new Helicopter(expectedModel, expectedYear, expectedType, expectedNumber, expectedBladesNumber);

			//Assert
			Assert.AreEqual(expectedModel, helicopter1.Model); //��������� �������� �� ���������
			Assert.AreEqual(expectedYear, helicopter1.Year);
			Assert.AreEqual(expectedType, helicopter1.Type);
			Assert.AreEqual(expectedNumber, helicopter1.Number);
			Assert.AreEqual(expectedBladesNumber, helicopter1.BladesNumber);
		}


		[TestMethod]
		public void Test4()
		{
			//Arrange
			string expectedModel = "������ 456";
			int expectedYear = 2001;
			string expectedType = "JUFC - 7";
			int expectedNumber = 15;
			int expectedBladesNumber = 7;

			//Act
			Helicopter helicopter2 = new Helicopter(expectedModel, expectedYear, expectedType, expectedNumber, expectedBladesNumber);

			//Assert
			Assert.AreEqual(expectedModel, helicopter2.Model); //��������� �������� �� ���������
			Assert.AreEqual(expectedYear, helicopter2.Year);
			Assert.AreEqual(expectedType, helicopter2.Type);
			Assert.AreEqual(expectedNumber, helicopter2.Number);
			Assert.AreEqual(expectedBladesNumber, helicopter2.BladesNumber);
		}

		[TestMethod]
		public void Test5()
		{
			//Arrange
			string expectedModel = "���";
			int expectedYear = 0;
			string expectedType = "���";
			int expectedNumber = 0;
			int expectedPassengersNumber = 0;
			int expectedRange = 0;


			//Act
			Plane plane1 = new Plane(expectedModel, expectedYear, expectedType, expectedNumber, expectedPassengersNumber, expectedRange);

			//Assert
			Assert.AreEqual(expectedModel, plane1.Model); //��������� �������� �� ���������
			Assert.AreEqual(expectedYear, plane1.Year);
			Assert.AreEqual(expectedType, plane1.Type);
			Assert.AreEqual(expectedNumber, plane1.Number);
			Assert.AreEqual(expectedPassengersNumber, plane1.PassengersNumber);
			Assert.AreEqual(expectedRange, plane1.Range);
		}

		[TestMethod]
		public void Test6()
		{
			//Arrange
			string expectedModel = "Boing 666";
			int expectedYear = 2021;
			string expectedType = "ZHFBR - 234";
			int expectedNumber = 9;
			int expectedPassengersNumber = 230;
			int expectedRange = 1500;


			//Act
			Plane plane1 = new Plane(expectedModel, expectedYear, expectedType, expectedNumber, expectedPassengersNumber, expectedRange);

			//Assert
			Assert.AreEqual(expectedModel, plane1.Model); //��������� �������� �� ���������
			Assert.AreEqual(expectedYear, plane1.Year);
			Assert.AreEqual(expectedType, plane1.Type);
			Assert.AreEqual(expectedNumber, plane1.Number);
			Assert.AreEqual(expectedPassengersNumber, plane1.PassengersNumber);
			Assert.AreEqual(expectedRange, plane1.Range);
		}

		[TestMethod]
		public void Test7()
		{
			//Arrange
			string expectedModel = "���";
			int expectedYear = 0;
			string expectedType = "���";
			int expectedNumber = 0;
			int expectedPassengersNumber = 0;
			int expectedRange = 0;
			string expectedFighterClass = "���";


			//Act
			Fighter fighter1 = new Fighter(expectedModel, expectedYear, expectedType, expectedNumber, expectedPassengersNumber, expectedRange, expectedFighterClass);

			//Assert
			Assert.AreEqual(expectedModel, fighter1.Model); //��������� �������� �� ���������
			Assert.AreEqual(expectedYear, fighter1.Year);
			Assert.AreEqual(expectedType, fighter1.Type);
			Assert.AreEqual(expectedNumber, fighter1.Number);
			Assert.AreEqual(expectedPassengersNumber, fighter1.PassengersNumber);
			Assert.AreEqual(expectedRange, fighter1.Range);
			Assert.AreEqual(expectedFighterClass, fighter1.FighterClass);
		}

		[TestMethod]
		public void Test8()
		{
			//Arrange
			string expectedModel = "������ 595";
			int expectedYear = 1947;
			string expectedType = "Smash";
			int expectedNumber = 3;
			int expectedPassengersNumber = 200;
			int expectedRange = 4000;
			string expectedFighterClass = "�����������";


			//Act
			Fighter fighter2 = new Fighter(expectedModel, expectedYear, expectedType, expectedNumber, expectedPassengersNumber, expectedRange, expectedFighterClass);

			//Assert
			Assert.AreEqual(expectedModel, fighter2.Model); //��������� �������� �� ���������
			Assert.AreEqual(expectedYear, fighter2.Year);
			Assert.AreEqual(expectedType, fighter2.Type);
			Assert.AreEqual(expectedNumber, fighter2.Number);
			Assert.AreEqual(expectedPassengersNumber, fighter2.PassengersNumber);
			Assert.AreEqual(expectedRange, fighter2.Range);
			Assert.AreEqual(expectedFighterClass, fighter2.FighterClass);

		}

		[TestMethod]
		public void Test9()
		{
			// Arrange (��������� �������� �������� ���������)
			double expectedSpeed1 = 0;
			double expectedDistance1 = 0;

			// Act (�������� ������ �������)
			Runner runner1 = new Runner();

			// Assert 
			Assert.AreEqual(expectedSpeed1, runner1.Speed); //��������� �������� �� ���������
			Assert.AreEqual(expectedDistance1, runner1.Distance);
		}

		[TestMethod]
		public void Test10()
		{
			//Arrange
			double expectedSpeed = 10;
			double expectedDistance = 10;

			//Act
			Runner runner = new Runner(expectedSpeed, expectedDistance);

			//Assert
			Assert.AreEqual(expectedSpeed, runner.Speed);
			Assert.AreEqual(expectedDistance, runner.Distance);
		}

		[TestMethod]
		public void Test11()
		{
			// Arrange
			int Count = Runner.count;

			// Act
			Runner runner1 = new Runner();
			Runner runner2 = new Runner();
			int newCount = Runner.OutputCount();

			// Assert
			Assert.AreEqual(Count + 2, newCount);
		}

		[TestMethod]
		public void Test12()
		{
			// Arrange
			Aircraft aircraft1 = new Aircraft("Boeing 747", 2000, "������", 5);
			Aircraft aircraft2 = new Aircraft("Boeing 747", 2000, "������", 5);
			Aircraft aircraft3 = new Aircraft("Airbus A380", 2010, "������", 4);

			// Act & Assert
			Assert.IsTrue(aircraft1.Equals(aircraft2));
			Assert.IsFalse(aircraft1.Equals(aircraft3));
		}

		[TestMethod]
		public void Test13()
		{
			// Arrange
			Plane plane1 = new Plane("Boeing 747", 2000, "������������", 5, 100, 1000);
			Plane plane2 = new Plane("Boeing 747", 2000, "������������", 5, 100, 1000);
			Plane plane3 = new Plane("Airbus A380", 2010, "������������", 4, 100, 1000);

			// Act & Assert
			Assert.IsTrue(plane1.Equals(plane2));
			Assert.IsFalse(plane1.Equals(plane3));
		}

		[TestMethod]
		public void Test14()
		{
			// Arrange
			Helicopter helicopter1 = new Helicopter("Boeing 747", 2000, "�������", 5, 6);
			Helicopter helicopter2 = new Helicopter("Boeing 747", 2000, "�������", 5, 6);
			Helicopter helicopter3 = new Helicopter("Boeing 747", 205, "�������", 5, 50);

			// Act & Assert
			Assert.IsTrue(helicopter1.Equals(helicopter2));
			Assert.IsFalse(helicopter1.Equals(helicopter3));
		}

		[TestMethod]
		public void Test15()
		{
			// Arrange
			Fighter fighter1 = new Fighter("Boeing 747", 2000, "Passenger", 5, 100, 1000, "�����������");
			Fighter fighter2 = new Fighter("Boeing 747", 2000, "Passenger", 5, 100, 1000, "�����������");
			Fighter fighter3 = new Fighter("Boeing 747", 2000, "Passenger", 5, 100, 1000, "���������");

			// Act & Assert
			Assert.IsTrue(fighter1.Equals(fighter2));
			Assert.IsFalse(fighter1.Equals(fighter3));
		}

		[TestMethod]
		public void Test16()
		{
			// Arrange
			Aircraft aircraft = new Aircraft("Boeing 747", 2000, "������������", 5);

			// Act
			string result = aircraft.ToString();

			// Assert
			Assert.AreEqual(" Boeing 747, 2000, ������������, 5", result);
		}

		[TestMethod]
		public void Test17()
		{
			// Arrange
			Helicopter helicopter = new Helicopter("Boeing 747", 2000, "������������", 5, 6);
			string expected = "Boeing 747, 2000, ������������, 5, 6";

			// Act
			string result = helicopter.ToString();

			// Assert
			Assert.AreEqual(expected, result.Trim()); //  ����� Trim() ��� �������� ��������
		}


		[TestMethod]
		public void Test18()
		{
			// Arrange
			Plane plane = new Plane("Boeing 747", 2000, "������������", 5, 200, 5000);
			string expected = "Boeing 747, 2000, ������������, 5, ���������� ���������� 200, ��������� ����� 5000";

			// Act
			string result = plane.ToString();

			// Assert
			Assert.AreEqual(expected, result.Trim());
		}

		[TestMethod]
		public void Test19()
		{
			// Arrange
			Fighter fighter = new Fighter("F-16", 1990, "�����������", 10, 1, 1500, "���������");
			string expected = "F-16, 1990, �����������, 10, ���������� ���������� 1, ��������� ����� 1500, ����� ���������";

			// Act
			string result = fighter.ToString();

			// Assert
			Assert.AreEqual(expected, result.Trim());
		}

		[TestMethod]
		public void Test20()
		{
			// Arrange
			Aircraft aircraft1 = new Aircraft("Boeing 747", 2000, "������������", 5);
			Aircraft aircraft2 = new Aircraft("Airbus A320", 2005, "������������", 6);

			// Act & Assert
			Assert.IsTrue(aircraft1.CompareTo(aircraft2) < 0);
		}

		//[TestMethod]
		//public void Test21()
		//{
		//	// Arrange
		//	IInit[] arr = new IInit[]
		//	{
		//	new Plane("Boeing 737", 2015, "������������", 150, 200, 5000),
		//	new Plane("Airbus A320", 2020, "������������", 200, 180, 6000),
		//	new Plane("Boeing 747", 2019, "������������", 180, 220, 5500)
		//	};

		//	// Act
		//	string result = Program.MaxRange(arr);

		//	// Assert
		//	Assert.AreEqual("Airbus A320", result);
		//}


		//[TestMethod]
		//public void Test23()
		//{
		//	// Arrange
		//	IInit[] arr = new IInit[]
		//	{
		//	new Fighter("F-16", 2000, "�����������", 10, 5, 1500, "��������"),
		//	new Fighter("Su-27", 2005, "�����������", 15, 6, 1800, "��������"),
		//	new Fighter("MiG-29", 2010, "�����������", 12, 7, 2000, "���������")
		//	};
		//	string fighterClass = "��������";

		//	// Act
		//	int result = Program.CrewMembers(arr, fighterClass);

		//	// Assert
		//	Assert.AreEqual(25, result);
		//}

		[TestMethod]
		public void Test26()
		{
			// Arrange
			Runner runner = new Runner();

			// Act
			runner.RandomInit();

			// Assert
			Assert.IsTrue(runner.Speed >= 1 && runner.Speed <= 20);
			Assert.IsTrue(runner.Distance >= 1 && runner.Distance <= 100);
		}

		[TestMethod]
		public void Test27()
		{
			// Arrange
			Runner runner = new Runner();

			// Act
			runner.RandomInit();

			// Assert
			Assert.IsTrue(runner.Speed > 0); // ���������, ������������� �����
			Assert.IsTrue(runner.Distance > 0); // ���������, ������������� �����
		}

		[TestMethod]
		public void Test29()
		{
			// Arrange
			Plane plane = new Plane();

			// Act
			plane.Range = -100;

			// Assert
			Assert.AreEqual(0, plane.Range);
		}

		[TestMethod]
		public void Test30()
		{
			// Arrange
			Plane plane = new Plane();

			// Act
			plane.Range = -100;

			// Assert
			Assert.AreEqual(0, plane.Range);
		}


	}
}