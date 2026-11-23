#version 330 core

layout (location = 0) in vec3 aPosition; // vertex position in metres

uniform mat4 model;      // object position and size
uniform mat4 view;       // camera position and direction
uniform mat4 projection; // camera lens

out vec3 worldPos; // passed on to the fragment shader (used for the ground grid)

void main()
{
    // OpenTK matrices are row-major, so the vector goes on the left.
    vec4 world = vec4(aPosition, 1.0) * model;
    worldPos = world.xyz;
    gl_Position = world * view * projection;
}
