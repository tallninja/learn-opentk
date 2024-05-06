/*
 * Author: Ernest Wambua
 * Email: ernestwambua2@gmail.com
 * GitHub: https://github.com/tallninja
 */

using System.Text;

namespace LearnOpenTK.Utils;

public static class FileResourceUtils
{
	private static readonly DirectoryInfo CurrentDirectory = new (Directory.GetCurrentDirectory());
	private static readonly string ResourcesDirectory = GetProjectRootPath() + "/res";
	
	
	public static StreamReader ReadText(string path)
	{
		return File.OpenText(Path.Join(ResourcesDirectory, path));
	}

	public static string ReadAllText(string path)
	{
		var sr = File.OpenText(Path.Join(ResourcesDirectory, path));
		var sb = new StringBuilder();

		while (sr.ReadLine() is { } line)
		{
			sb.Append(line);
		}

		return sb.ToString();
	}

	private static string? GetProjectRootPath()
	{
		var srcIndex = CurrentDirectory.FullName.IndexOf(
			"/src/LearnOpenTK/",
			StringComparison.Ordinal);
		return srcIndex != -1 ? CurrentDirectory.FullName[..srcIndex] : null;
	}
}