using Raylib_cs;
using Noise();

// hej = new Libnoise.
// noiseMap = new 

Raylib.InitWindow(500, 500, "Labyrint");

while (!Raylib.WindowShouldClose()) {
    draw_game();
}

void draw_game() {
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.BLACK);
    Raylib.EndDrawing();
}