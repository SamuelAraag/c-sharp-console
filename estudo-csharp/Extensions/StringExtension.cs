using System;
namespace estudo_csharp.Extension
{
	public static class StringExtension
	{
		public static string GetMonth(this string value)
		{
			const int firstValue = 0;
			return value.Split("/")[firstValue];
		}

		public static string GetYear(this string value)
		{
			const int secondValue = 1;
			return value.Split("/")[secondValue];
		}
	}
}

