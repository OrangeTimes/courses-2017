using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_members_1
{
	// Create 3 different subclasses with different engines.
	public class Bus : Car
	{
		private int _engine;
		public override int Engine
		{
			get
			{
				return _engine;
			}
			set
			{
				if (value > 3000 & value < 4000)
				{
					_engine = value;
				}
				else
				{
					throw new Exception($"Engine should have capacity from 3000 to 4000 cc (cubic centimeters). Value: {value}");
				}
			}
		}
	}
}
