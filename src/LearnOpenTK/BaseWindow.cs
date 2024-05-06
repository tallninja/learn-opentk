/*
 * Author: Ernest Wambua
 * Email: ernestwambua2@gmail.com
 * GitHub: https://github.com/tallninja
 */

using LearnOpenTK.Colors;
using OpenTK.Graphics.OpenGL;
using OpenTK.Mathematics;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;

using static LearnOpenTK.Colors.Colors;

namespace LearnOpenTK;

public abstract class BaseWindow : GameWindow
{
	protected BaseWindow() : base(GameWindowSettings.Default, NativeWindowSettings.Default)
	{}

	protected BaseWindow(string title, int width, int height, Color color)
		: base(
			GameWindowSettings.Default,
			new NativeWindowSettings
			{
				Title = title,
				ClientSize = new Vector2i(width, height)
			})
	{
		Title = title;
		Width = width;
		Height = height;
		BgColor = color;
	}

	protected BaseWindow(int width, int height, Color color) : this("OpenGL Window", width, height, color)
	{}

	protected BaseWindow(int width, int height) : this("OpenGL Window", width, height, Black)
	{}

	public new string Title { get; set; }
	public int Width { get; set; }
	public int Height { get; set; }
	public Color BgColor { get; set; }

	protected override void OnLoad()
	{
		base.OnLoad();
		GL.ClearColor(BgColor.R, BgColor.G, BgColor.B, BgColor.A);
	}

	// This function runs every time the windows framebuffer gets resized.
	// When this happens the NDC (Normalized Device Coordinates) to window coordinate
	// transformation is not automatically updated, causing rendering be done at the old
	// framebuffer size. With GL.Viewport we can update this transformation so that we
	// correctly render to the entire framebuffer.
	protected override void OnFramebufferResize(FramebufferResizeEventArgs e)
	{
		base.OnFramebufferResize(e);
		GL.Viewport(0, 0, e.Width, e.Height);
	}
}