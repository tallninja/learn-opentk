/*
 * Author: Ernest Wambua
 * Email: ernestwambua2@gmail.com
 * GitHub: https://github.com/tallninja
 */

// ReSharper disable RedundantOverriddenMember

using OpenTK.Graphics.OpenGL;
using OpenTK.Windowing.Common;

using static LearnOpenTK.Colors.Colors;

namespace LearnOpenTK;

public class TestWindow1 : BaseWindow
{
	public TestWindow1() : base(800, 600, Yellow + White)
	{
	}

	// This function runs one time, when the window first opens.
	// Any initialization-related code should go here.
	protected override void OnLoad()
	{
		base.OnLoad();
	}

	protected override void OnUpdateFrame(FrameEventArgs args)
	{
		base.OnUpdateFrame(args);
	}

	protected override void OnRenderFrame(FrameEventArgs args)
	{
		base.OnRenderFrame(args);
		GL.Clear(ClearBufferMask.ColorBufferBit);
		SwapBuffers();
	}

}