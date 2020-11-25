/*
 * Created by SharpDevelop.
 * User: Zsombor
 * Date: 2020-11-22
 * This is an exercise from the Catalysts Coding Contest webpage.
 * The goal is not making a Fibonacci sequence as usual, but estimating certain results based on a given series of numbers.
 */
using System;
using System.IO;

namespace Fibonacci
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			// F_n = Phi^n / sqrt(5) generally rounded up.
			//long[] n = {6, 19, 28, 36, 38};
			long[] nr = ReadFromFile(@"D:\SULI\C# .NET\Fibonacci\Fibonacci\InputFile.txt");
			
			Console.WriteLine();
			for (int i = 0; i < nr.Length; i++)
			{ // In JS this worked just fine without making the called method static too.
				Console.WriteLine(MakeFibonacci(nr[i]));
			}
									
			Console.ReadKey();
		}
		
		private static long MakeFibonacci(long nr) {
    		double p = (1 + Math.Sqrt(5))/2;
    		double a = Math.Pow(p, nr) / Math.Sqrt(5);

    		return (long)Math.Round(a);
		}
		
		static long[] ReadFromFile(string path) {
			if(File.Exists(path)) {
				string[] dataFromFile = File.ReadAllLines(path);
				long[] n = new long[dataFromFile.Length];
				
				for(int i = 0; i < dataFromFile.Length; i++) {
					Console.Write(dataFromFile[i] + " ");
					Console.WriteLine();
					n[i] = long.Parse(dataFromFile[i]);
				}
				
				return n;
			}
			else {
				Console.WriteLine("The file doesn't exist or path is wrong.");
				return new long[0];
			}
		}
	}
}