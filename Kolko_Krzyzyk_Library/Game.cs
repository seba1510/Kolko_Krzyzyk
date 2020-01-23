using System;
using System.Collections.Generic;
using System.Text;

namespace Kolko_Krzyzyk_Library
{
	public class Game
	{
		
		public int RandomList(int min, int max)
		{
			Random pion = new Random();
			return pion.Next(min, max);
			
		}
	}
}
