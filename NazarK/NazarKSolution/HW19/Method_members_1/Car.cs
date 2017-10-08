using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_members_1
{
	// Design a parent Car class with properties 
	public class Car
	{
		// Year of manufacture should be above 1990 and below 2017.
		private int _yearOfManufacture;
		public int YearOfManufacture
		{
			get
			{
				return _yearOfManufacture;
			}
			set
			{
				if (value > 1990 && value < 2017)
				{
					_yearOfManufacture = value;
				}
				else
				{
					throw new Exception($"Year of manufacture should be above 1990 and below 2017. Value: {value}");
				}
			}
		}

		// Name should not exceed 20 symbols
		private string _name;
		public string Name
		{
			get
			{
				return _name;
			}
			set
			{
				if (value.Length > 20)
				{
					throw new Exception($"Name should not exceed 20 symbols. Length: {value.Length}");
				}
				else
				{
					_name = value;
				}
			}
		}

		// Engine should have capacity from 500 to 3000 cc (cubic centimeters)
		private int _engine;
		public virtual int Engine
		{
			get
			{
				return _engine;
			}
			set
			{
				if (value > 500 && value < 3000)
				{
					_engine = value;
				}
				else
				{
					throw new Exception($"Engine should have capacity from 500 to 3000 cc (cubic centimeters). Value: {value}");
				}
			}
		}
		public override string ToString()
		{
			return $"Year of manufacture: {YearOfManufacture}, Name: {Name}, Engine: {Engine}";
		}
	}
}
