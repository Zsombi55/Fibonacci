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
			Program P = new Program();
			// F_n = Phi^n / sqrt(5) generally rounded up.
			double[] n = {6, 19, 28, 36, 38};
			
			for (int i = 0; i < n.Length; i++)
			{ // I don't know why it gives an error, in JS this worked just fine without making the called method static too.
				Console.WriteLine(P.Fibonacci(n[i]));
			}
			Console.ReadLine();
		}
		
		private double Fibonacci(double n) {
    		double p = (1 + Math.Sqrt(5))/2;
    		double a = Math.Pow(p, n) / Math.Sqrt(5);

   			return Math.Round(a);
		}
	}
}