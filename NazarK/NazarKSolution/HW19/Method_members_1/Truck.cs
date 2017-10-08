using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_members_1
{
	// Create 3 different subclasses with different engines.
	public class Truck : Car
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
				if (value > 4000 && value < 8000)
				{
					_engine = value;
				}
				else
				{
					throw new Exception($"Engine should have capacity from 4000 to 8000 cc (cubic centimeters). Value: {value}");
				}
			}
		}
	}
}
