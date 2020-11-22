/*
 * Created by SharpDevelop.
 * User: Zsombor
 * Date: 2020-11-22
 * Time: 16:22
 */
using System;

namespace Fibonacci
{
	class Program
	{
		public static void Main(string[] args)
		{
			// F_n = Phi^n / sqrt(5) generally rounded up.
			int[] n = {6, 19, 28, 36, 38};
			
			for (var i = 0; i < n.Length; i++)
			{
				Console.WriteLine(Program.Fibonacci(n[i]));
			}
		}
		
		private int Fibonacci(int n) {
    		let p = (1 + Math.sqrt(5))/2;
    		let a = Math.pow(p, n) / Math.sqrt(5);

   			return Math.round(a);
		}
	}
}