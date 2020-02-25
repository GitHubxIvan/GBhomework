using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerSalary
{
	 class Sort 
	{
		public static WorkerSalary[] _wrsl;
		public Sort()
		{ }
		public static void ArrayData()
		{
			string name = "User";
			int i = 0;
			_wrsl = new WorkerSalary[4];
			foreach (WorkerSalary ws in _wrsl)
			{
				if ((i + 1) % 2 == 0)
				{
					_wrsl[i] = new WorkerSalaryHour(name);
					Console.WriteLine(name + (i + 1) + "  salary hour - " + _wrsl[i].salary());
				}
				else
				{
					_wrsl[i] = new WorkerSalaryMonth(name);
					Console.WriteLine(name + (i + 1) + "  salary month - " + _wrsl[i].salary());
				}
				i++;
			}
		}
	}
}
