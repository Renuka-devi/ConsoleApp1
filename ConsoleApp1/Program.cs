using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			var a = 10;
			var b = "TEST0";
			var c = 10.10;
			Console.WriteLine("{0} type: {1}", a, a.GetType());
			Console.WriteLine("{0} type: {1}", b, b.GetType());
			Console.WriteLine("{0} type: {1}", c, c.GetType());
			Console.ReadKey();
		}
	}
}
