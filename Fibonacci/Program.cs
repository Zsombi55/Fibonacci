/*
 * Created by SharpDevelop.
 * User: Zsombor
 * Date: 2020-11-22
 * Time: 16:22
 */
using System;
using System.IO;

namespace Fibonacci
{
	class Program
	{
		public static void Main(string[] args)
		{
			Program P = new Program();
			// F_n = Phi^n / sqrt(5) generally rounded up.
			double[] n = {6, 19, 28, 36, 38};
			ReadFromFile(@"D:\SULI\C# .NET\Fibonacci\Fibonacci\InputFile.txt");
			
			Console.WriteLine();
			for (int i = 0; i < n.Length; i++)
			{ // In JS this worked just fine without making the called method static too.
				Console.WriteLine(P.MakeFibonacci(n[i]));
			}
									
			Console.ReadKey();
		}
		
		private double MakeFibonacci(double n) {
    		double p = (1 + Math.Sqrt(5))/2;
    		double a = Math.Pow(p, n) / Math.Sqrt(5);

   			return Math.Round(a);
		}
		
		static void ReadFromFile(string path) {
			if(File.Exists(path)) {
				string[] dataFromFile = File.ReadAllLines(path);
				
				foreach(string d in dataFromFile) {
					Console.Write(d + " ");					
				}
				Console.WriteLine();
//				double[] n = new double[dataFromFile.Length];
//
//				for(int i = 0; i < dataFromFile.Length; i++)
//				{
//					n[i] = Double.Parse(dataFromFile[i]);
//				}
			}
			else {
				Console.WriteLine("The file doesn't exist or path is wrong.");
			}
		}
	}
}