#version 330 core
layout(location=0) in vec3 aPosition;

void main()
{
	gl_Position = vev4(aPosition, 1.0);
}