using System;

namespace WeekTwo
{
	class LabTwo
	{
		enum University
		{
			AIUB,
			SUST,
			BUET,
			NSU
		}
		
		public static void Main(string[] args)
		{
			/*
			1. Print your full name
			*/
			Console.WriteLine("Last, First Middle");

			/*
			2. Print your student id
			*/
			Console.WriteLine("XX-XXXXX-X");

			/*
			3. Implicit type casting (between int and char)
			*/
			char first = 'a';
			int second;
			second = first;
			Console.WriteLine(second);
			//It prints ASCII value of char 'a'

			/*
			4. Explicit type casting (between int and double)
			*/			
			double d = 10.23456;
			int n;
			n = (int) d;
			Console.WriteLine(n);

			/*
			5. Constant variable demonstration
			*/
			const double PI = 3.14159265358979;
			Console.WriteLine(PI);

			/*
			6. Any one enum demonstration (not the ones shown in the class)
			*/
			University name = University.AIUB;

			switch(name)
			{
				case University.AIUB:
					Console.WriteLine("Privet");
					break;
				
				case University.BUET:
					Console.WriteLine("Public");
					break;
				
				case University.SUST:
					Console.WriteLine("Public");
					break;
				
				case University.NSU:
					Console.WriteLine("Privet");
					break;
				
				default:
					Console.WriteLine("Wrong Input");
					break;

			}

		}
	}
}