using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerSalary
{
	abstract class WorkerSalary
	{
		protected string Name  { get; set; }
		protected double Salary;
		public WorkerSalary(string name)
		{
			this.Name = name;
			Salary = salary();
		}
		public abstract double salary();

	}
}
