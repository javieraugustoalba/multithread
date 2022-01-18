using System;
using System.Threading;

namespace MyFirstProgram
{
	class Program
	{
		public static void Main(string[] args)
		{
			// thread = a thread is an execution path of a program
			//          We can use multiple threads to perform different tasks of our program at once.
			//          "main" is our current thread

			Thread mainThread = Thread.CurrentThread;
			mainThread.Name = "Main Thread is our current thread"; //You can change name by Thread property "Name"
			Console.WriteLine(mainThread.Name);

			Thread thread1 = new Thread(() => CountDown("Timer #1"));
			Thread thread2 = new Thread(() => CountUp("Timer #2"));

			thread1.Start();
			thread2.Start();

			Console.WriteLine(mainThread.Name + " is complete!");

			Console.ReadKey();
		}
		public static void CountDown(String name)
		{
			for (int i = 10; i >= 0; i--)
			{
				Console.WriteLine(name + i + " seconds");
				Thread.Sleep(1000);
			}
			Console.WriteLine(name + "is complete!");
		}
		public static void CountUp(String name)
		{
			for (int i = 0; i <= 10; i++)
			{
				Console.WriteLine(name + i + " seconds");
				Thread.Sleep(1000);
			}
			Console.WriteLine(name + "is complete!");
		}
	}
}