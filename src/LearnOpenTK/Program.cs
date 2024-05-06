/*
 * Author: Ernest Wambua
 * Email: ernestwambua2@gmail.com
 * GitHub: https://github.com/tallninja
 */

namespace LearnOpenTK;

public static class Program
{
	public static void Main(string[] _)
	{
		using var window = new TestWindow1();
		window.Run();
	}
}