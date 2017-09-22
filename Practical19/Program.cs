using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical19
{
	class Program
	{
		static void Main(string[] args)
		{
			ChildClass myChild = new ChildClass();
			int myValue = myChild.MyLuckyNumber;
			myChild.MyLuckyNumber = 42;

		}
	}

	class ParentClass
	{
		private const int luckyNumber = 12;

		public ParentClass()
		{
			// luckyNumber = 13;
		}

		public void ParentMethod()
		{
			
		}
	}

	class ChildClass : ParentClass
	{
		private int luckyNumber = 12;
		public void ParentMethod()
		{

		}
		public int MyLuckyNumber
		{
			get
			{
				if (luckyNumber > 0)
				{
					return luckyNumber;
				}
				else
				{
					return 0;
				}
			}
			set
			{
				luckyNumber = value;
			}
		}
	
		// Background property equivalent code
		//public void set_LuckyNumber(int value)
		//{
		//	luckyNumber = value;
		//}

		//public int get_LuckyNumber(int value)
		//{
		//	if (luckyNumber > 0)
		//	{
		//		return luckyNumber;
		//	}
		//	else
		//	{
		//		return 0;
		//	}
		//}

		public void ChildMethod()
		{
			base.ParentMethod();
			// code here
			this.ParentMethod();
		}

		public void Save()
		{
			ChildClassEvaluator childClassEvaluator = new ChildClassEvaluator();
			childClassEvaluator.DoSomething(this);
		}
	}


	class ChildClassEvaluator
	{
		public void DoSomething(ChildClass childClass)
		{
			childClass.ChildMethod();
		}
	}
}
