using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_BMI
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("請輸入身高(公尺)");
			string input = Console.ReadLine();
			if (string.IsNullOrEmpty(input))
			{
				Console.WriteLine("你沒有輸入");
				return;
			}
			Console.WriteLine("請輸入體重(公斤)");
			string input1 = Console.ReadLine();
			if (string.IsNullOrEmpty(input1))
			{
				Console.WriteLine("你沒有輸入");
				return;
			}

			double bmi = (Convert.ToDouble(input1)) / (Convert.ToDouble(input) * Convert.ToDouble(input));

			if (bmi < 18)
			{
				Console.WriteLine("你體重過輕!");
			}
			else if (bmi > 24)
			{
				Console.WriteLine("你體重過重!");
			}
			else
			{
				Console.WriteLine("你很健康!");
			}

		}
	}
}
