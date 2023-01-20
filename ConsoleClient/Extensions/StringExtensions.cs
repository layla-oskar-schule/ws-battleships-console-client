using System;
using Lib.GameEntities;

namespace ConsoleClient.Extensions
{
	public static class StringExtentsion
	{
		public static Location ParseLocation(this string value)
		{
			char[] chars = value.Trim().ToCharArray();

			string y = "";
			char? x = null;

			foreach (char c in chars)
			{
				if (!char.IsNumber(c))
				{
					x = c;
				}
				else
				{
					y += Convert.ToInt32(c.ToString());
				}
			}

			if (x == null || string.IsNullOrEmpty(y))
			{
				return new Location();
			}

			return new Location() { X = (char) x, Y = Convert.ToInt32(y) };
		}
	}
}

