/*
 * Created by SharpDevelop.
 * User: Zsombor
 * Date: 2020-11-22
 * This is an exercise from the Catalysts Coding Contest webpage.
 * The goal is finding the n-th number of the provided Fibonacci sequence final result(s).
 * Using the Golden Ratio:  F_n = Phi^n / sqrt(5)  generally rounded up.
 * 
 * Excerpt from the test instructions::
 *  "The Fibonacci sequence  (F_0, F_1, ...)  is due to the recursive law of formation  (F_0 = F_n-1 + F_n-2)
 * 	for  (n >= 2) with the initial values  (F_0 = 0)  and  (F_1 = 1)  are defined." [...]
 *  "the first numbers are Zero and One respectively, and each additional number is the sum of their predecessors.
 *  Examples: n = 0 -> 0 |  n = 1 -> 1 |  n = 2 -> 1 |  n = 3 -> 2 |  n = 4 -> 3 |  n = 5 -> 5 ."
 */
using System;
using System.IO;

namespace Fibonacci
{
	class Program
	{
		public static void Main(string[] args)
		{
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
				return new long[0]; // an empty array.
			}
		}
	}
}