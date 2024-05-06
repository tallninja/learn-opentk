/*
 * Author: Ernest Wambua
 * Email: ernestwambua2@gmail.com
 * GitHub: https://github.com/tallninja
 */

using LearnOpenTK.Utils;

namespace LearnOpenTK;

public static class Program
{
	public static void Main(string[] _)
	{
		const string filePath = "test.txt";
		var fileContents = FileResourceUtils.ReadAllText(filePath);
		Console.WriteLine(fileContents);
	}
}