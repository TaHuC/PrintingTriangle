using System;

namespace PrintingTriangle
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int num = int.Parse(Console.ReadLine());

			for (int i = 1; i <= num; i++)
			{
				PrintLine(1, i);
			}

			for (int j = num - 1; j >= 0; j--)
			{
				PrintLine(1, j);
			}
		}

		public static void PrintLine(int start, int end)
		{
			for (int i = start; i <= end; i++)
			{
				Console.Write(i + " ");
			}

			Console.WriteLine();
		}
	}
}
