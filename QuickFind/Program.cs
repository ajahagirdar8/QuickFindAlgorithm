using System;

namespace QuickFind
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Enter size of the array:");
			string s = Console.ReadLine ();
			int n = int.Parse (s);

			QuickFind qf = new QuickFind (n);

			qf.Connect (2, 3);

			bool isConnected = qf.isConnected (2, 3);

			Console.WriteLine ("2 and 3 :" + isConnected);

			isConnected = qf.isConnected (2, 5);

			Console.WriteLine ("2 and 5 :" + isConnected);

			qf.Connect (2, 5);

			isConnected = qf.isConnected (2, 5);
			Console.WriteLine ("2 and 5 :" + isConnected);

			isConnected = qf.isConnected (3, 5);

			Console.WriteLine ("3 and 5 :" + isConnected);

		}
	}
}
