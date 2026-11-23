using OpenTK.Graphics.ES11;
using OpenTK.Windowing.Desktop;
using OpenTK.Windowing.Common;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace GameThreed;
public class Window : GameWindow
{
    private const float MoveSpeed = 20f;  //meters per second
    private const float MouseSensitivity = 0.1f;  //degree per pixel of mouse movement 

    private static readonly Vector3 GroundColor = new(0.36f, 0.42f, 0.34f);

    //private readonly Camera() _camera = new();
    
    // private CubeMesh _ground = null;

    private Shader _shader = null;


    public Window(GameWindowSettings gameWindowSettings, NativeWindowSettings nativeWindowSettings)
        : base(gameWindowSettings, nativeWindowSettings)
    { 
    }

    protected override void OnLoad()
    {
        base.OnLoad();
        GL.ClearColor(0.53f, 0.71f, 0.85f, 1.0f);   //sky blue 
        GL.Enable(EnableCap.DepthTest);             //nearer things

        // The ground is a big flat box: 1 km wide, 1 m thick, 1 km deep.
        //_ground = new CubeMesh(Width); _ground = new CubeMesh(width: 1000f, height: 1f, depth: 1000f);
        //_shader = new Shader("Shaders/shader.vert", "Shaders/shader.frag");

        CursorState = CursorState.Grabbed;

    }
    protected override void OnRenderFrame(FrameEventArgs e)
    {
        base.OnRenderFrame(e);

        GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

        _shader.Use();
        
    }

}

