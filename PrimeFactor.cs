using System;
class PrimeFactor
{
	public static void ThePrime()
	{
		int n, i, p, k;

		Console.Write("Enter a number:");
		n = Convert.ToInt32(Console.ReadLine());

		for (i = 2; i <= n; i++)
		{
			k = 2;
			p = 1;
			while (k < i)
			{
				if (i % k == 0)
				{
					p = 0;
					break;
				}
				k++;
			}
			if (p == 1)
			{
				Console.WriteLine("Number is prime:" + i);
			}
		}

	}
}