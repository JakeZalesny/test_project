using System;
using Raylib_cs; 
using static Raylib_cs.Raylib;

namespace test_project {
    class OutputServices {
        private int screenWidth {get; set;} 
        private int screenHeight {get; set;} 
        private int targetFPS {get; set;}
        public OutputServices() {
            screenWidth = 3200; 
            screenHeight = 1800; 
            targetFPS = 60; 
        }

        public void startGame() {
            InitWindow(screenWidth, screenHeight, "Dino Run");
            SetTargetFPS(targetFPS);
        }

        public void beginDrawing() {
            BeginDrawing(); 
            ClearBackground(Color.WHITE);
        }

        public void endDrawing() {
            EndDrawing(); 
        }
    }
}