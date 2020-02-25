using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerSalary
{
	class WorkerSalaryMonth : WorkerSalary
	{
		private double monthSalary = 80000;
		public WorkerSalaryMonth(string name) : base(name) { }
		public override double salary() => Salary = monthSalary;

	}
}
