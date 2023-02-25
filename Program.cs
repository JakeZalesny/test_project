using System;
using Raylib_cs; 
using static Raylib_cs.Raylib;

namespace test_project // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

                InitWindow(1600, 900, "Dino Run");
                SetTargetFPS(60);

                while(!WindowShouldClose()) {
                    BeginDrawing(); 
                    ClearBackground(Color.RAYWHITE);
                    DrawText("I made my First Window", 190, 200, 20, Color.LIGHTGRAY);
                    EndDrawing();
                }

                CloseWindow(); 
        }
    }
}