using System;
using System.Numerics;
using Raylib_cs; 
using static Raylib_cs.Raylib;

namespace test_project {
    class Director {
        OutputServices output = new OutputServices(); 
        static Vector2 startingPos = new Vector2((float)1600, (float)900);
        Player player = new Player(startingPos, "C:/Users/jrzal/OneDrive/Desktop/test_project/assets/dinos/DinoSprites - doux.png", 1);

        
        public Director() {}

        public void run() {
            output.startGame(); 
            output.loadPlayerSkin(player);
            while(!WindowShouldClose()) {
                output.beginDrawing();
                output.endDrawing();
                output.drawPlayer(player); 
            }
        }
    }
}