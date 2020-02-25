using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerSalary
{
	class WorkerSalaryHour : WorkerSalary
	{
		private double hourSalary = 100;
		public WorkerSalaryHour(string name) : base(name) { }
		public override double salary()=> Salary = 20.8 * 8 * hourSalary;
	}
}
