#version 330 core

in vec3 worldPos;

uniform vec3 color; // ground colour, set from C#

out vec4 FragColor;

void main()
{
    vec3 lineColor = vec3(0.20, 0.24, 0.19);

    // Draw a grid line every 10 metres so you can see yourself moving.
    vec2 cell = worldPos.xz / 10.0;
    vec2 pixelsToLine = abs(fract(cell - 0.5) - 0.5) / fwidth(cell); // distance to nearest line, in pixels
    float onLine = 1.0 - min(min(pixelsToLine.x, pixelsToLine.y), 1.0);  // 1 on a line, 0 elsewhere

    FragColor = vec4(mix(color, lineColor, onLine), 1.0);
}
