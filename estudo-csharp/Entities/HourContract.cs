﻿using System;
namespace estudo_csharp.Entities
{
	public class HourContract
	{
		public HourContract()
		{
		}

		public DateTime Date { get; set; }
		public double ValuePerHour { get; set; }
		public int Hours { get; set; }

        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

		public double TotalValue()
		{
			return Hours * ValuePerHour;
		}
    }
}

