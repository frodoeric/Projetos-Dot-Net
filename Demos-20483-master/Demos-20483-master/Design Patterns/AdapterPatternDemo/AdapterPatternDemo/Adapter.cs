using System;

namespace AdapterPatternDemo
{
	public class Adapter : Adaptee, ITarget
	{
		public string Request(int i)
		{
			return "A estimativa aproximada é " + (int)Math.Round(SpecificRequest(i, 3));
		}
	}
}