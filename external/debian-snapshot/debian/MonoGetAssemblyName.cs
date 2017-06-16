using System;
using System.Reflection;

public class GetAssemblyName
{
	public static void Main(string [] args)
	{
		if (args.Length == 0)
			throw new Exception("You must supply an assembly name");

		Assembly assembly = Assembly.LoadFile(args[0]);
		Console.WriteLine("{0}", assembly.FullName);
	}
}
