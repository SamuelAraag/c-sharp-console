using System;
using estudo_csharp.Entities.Enums;

namespace estudo_csharp.Entities
{
	public class Worker
	{
		public Worker()
		{
		}

		public string Name { get; set; }
		public WorkerLevel Level { get; set; }
		public double BaseSalary { get; set; }
		public Departament Departament { get; set; }
		public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker(string name, WorkerLevel level, double baseLalary, Departament departament)
        {
            Name = name;
            Level = level;
            BaseSalary = baseLalary;
            Departament = departament;
        }

		public void AddContract(HourContract contract)
		{
			Contracts.Add(contract);
		}

		public void RemoveContract(HourContract contract)
		{
			Contracts.Remove(contract);
		}

		public double Income(int year, int month)
		{
			var sum = BaseSalary;

			foreach(HourContract contract in Contracts)
			{
				if(contract.Date.Year == year && contract.Date.Month == month)
				{
					sum += contract.TotalValue();
				}
			}

			return sum;
		}
    }

}

