using System;
using Raylib_cs; 
using static Raylib_cs.Raylib;

namespace test_project {
    class OutputServices {
        private int screenWidth {get; set;} 
        private int screenHeight {get; set;} 
        private int targetFPS {get; set;}

        private int framesCounter = 0; 

        Texture2D dino; 
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

        public void loadPlayerSkin(Player player) {
            dino = LoadTexture(player.getSkin());
        }

        public void drawPlayer(Player player) {

            Animation[] animations = player.getAnimations(); 

            Rectangle frameRec = new Rectangle(0.0f, 0.0f, (float)dino.width / 24, (float)dino.height); 
            int currentFrame = animations[0].getStart(); 
            int frameSpeed = 3; 
            framesCounter++; 
            if(framesCounter >= (60/frameSpeed)) {
                framesCounter = 0; 
                currentFrame++; 
                
                if(currentFrame > animations[0].getEnd()) {
                    currentFrame = 0; 
                }

                frameRec.x = (float)currentFrame * (float)dino.width / 24;
            }
        }
    }
}