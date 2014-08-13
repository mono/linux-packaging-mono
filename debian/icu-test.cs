
public class MainClass
{
	public static void Main()
	{
		System.Console.WriteLine("This should output (depending in your locales) something like:");
		System.Console.WriteLine("\"Thursday, 27 May 2004 22:14:01\"");
		System.Console.WriteLine("Actual Output:");
		System.Console.WriteLine("\""+System.DateTime.Now.ToString("F")+"\"");
	}
}
