using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_classes_1
{
	internal enum Suite
	{
		Clubs = 0,
		Diamonds,
		Hearts,
		Spades
	}

	internal class StandardCard
	{
		private readonly Suite suite;

		private readonly int rank;

		private static readonly Dictionary<int, string> rankNames = new Dictionary<int, string>()
		{
			{ 9, "Jack" },
			{ 10, "Queen"},
			{ 11, "King"},
			{ 12, "Ace"}
		};

		internal StandardCard(Suite suite, int rank)
		{
			this.suite = suite;
			this.rank = rank;
		}

		public override string ToString()
		{
			// check if rank has a name if not increase by 2 as deck starts from 2
			if (rank < 9)
			{
				return $"{rank + 2} of {suite}";
			}
			else
			{
				rankNames.TryGetValue(rank, out string rankName);
				return $"{rankName} of {suite}";
			}
		}
	}
}
