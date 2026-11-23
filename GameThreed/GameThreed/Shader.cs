using OpenTK.Graphics.OpenGL4;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace GameThreed
{
    public sealed class Shader : IDisposable
    {
        public int Handle { get; set; }

        public Shader(string vertexPath,string fragmentPath)
        {
            var vertexShader = Compile(ShaderType.VertexShader, File.ReadAllText(Path.Combine(AppContext.BaseDirectory, vertexPath)));
            var fragmentShader = Compile(ShaderType.FragmentShader, File.ReadAllText(Path.Combine(AppContext.BaseDirectory, fragmentPath)));
        }
        public void Dispose()
        {
            if(Handle != 0)
            {
                GL.DeleteProgram(Handle);
                Handle = 0;

            }
        }
    }
}
