/*
 * Author: Ernest Wambua
 * Email: ernestwambua2@gmail.com
 * GitHub: https://github.com/tallninja
 */

namespace LearnOpenTK.Colors;

public class Color
{
	public Color() : this(0, 0, 0, 0)
	{}

	public Color(float r, float g, float b, float a = 1.0f)
	{
		R = r;
		G = g;
		B = b;
		A = a;
	}

	public float R { get; set; }
	public float G { get; set; }
	public float B { get; set; }
	public float A { get; set; }

	public float this[int index]
	{
		get
		{
			return index switch
			{
				0 => R,
				1 => G,
				2 => B,
				3 => A,
				_ => throw new IndexOutOfRangeException()
			};
		}
		set
		{
			switch (index)
			{
				case 0:
					R = value;
					break;
				case 1:
					G = value;
					break;
				case 2:
					B = value;
					break;
				case 3:
					A = value;
					break;
				default:
					throw new IndexOutOfRangeException();
			}
		}
	}

	public static Color operator /(Color left, int right)
	{
		return new Color
		{
			R = left.R / right,
			G = left.G / right,
			B = left.B / right,
			A = 1.0f
		};
	}

	public static Color operator +(Color left, Color right)
	{
		var c1 = left / 2;
		var c2 = right / 2;

		return new Color
		{
			R = c1.R + c2.R,
			G = c1.G + c2.G,
			B = c1.B + c2.B,
			A = 1.0f
		};
	}

	public void Destruct(out float r, out float g, out float b, out float a)
	{
		r = R;
		g = G;
		b = B;
		a = A;
	}
}