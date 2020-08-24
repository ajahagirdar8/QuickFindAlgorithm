using System;

namespace QuickFind
{
	public class QuickFind
	{
		private int[] ID;

		public QuickFind (int N)
		{
			ID = new int[N];
			for(int i=0; i < N; i++) {

				ID [i] = i;
			}
		}

		public bool isConnected(int p, int q)
		{
			return ID [p] == ID [q];
		}

		public void Connect(int p, int q)
		{
			if(!isConnected(p,q))
				{
					int valAtP = ID [p];
					int valAtQ = ID [q];

					for(int i =0;i< ID.Length;i++)
					{
					if (ID [i] == valAtP)
						ID [i] = valAtQ;
					}
				}

		}
	}
}

