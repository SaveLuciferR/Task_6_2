using System;

namespace Task_6_2
{
	class Program
	{
		static void Main()
		{
			try
			{
				double[] mas;
				Console.Write("Введите размер массива: ");
				int n = Convert.ToInt32(Console.ReadLine());

				if (n < 1) throw new Exception();
				
				mas = new double[n];

				Console.WriteLine("Введите элементы массива");
				for (int i = 0; i < n; i++)
				{
					mas[i] = Convert.ToDouble(Console.ReadLine());
				}

				int index = 0;
				double max = mas[0];
				for (int i = 1; i < n; i++)
				{
					if (max <= mas[i])
					{
						max = mas[i];
						index = i;
					}
				}

				Console.WriteLine("Номер последнего максимального значения: {0}", index);
			}
			catch (FormatException)
			{
				Console.WriteLine("Введены некорректные значения");
			}
			catch
			{
				Console.WriteLine("Кол-во элементов массива должен быть больше 0");
			}
		}
	}
}
