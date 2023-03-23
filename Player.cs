using System;
using System.Numerics; 
using Raylib_cs; 
using static Raylib_cs.Raylib;
using static Raylib_cs.KeyboardKey;
using static Raylib_cs.Color;

namespace test_project {

    class Player : Actor{
        private string skin; 
        private int number; 

        private bool moving;

        private Vector2 playerPosition = new Vector2((1600), (900));   

        private Animation idleFrames; 

        private Animation runFrames; 

        private Animation kickFrames; 

        private Animation hurtFrames; 

        private Animation duckFrames;

        private Animation[] animations;  

        public Player(Vector2 position, string skinFile, int playerNumber) {
            skin = skinFile; 
            number = playerNumber;
            idleFrames = new Animation(0, 3, skin);
            runFrames = new Animation(4, 10, skin);
            kickFrames = new Animation(10, 12, skin);
            hurtFrames = new Animation(13, 15, skin);
            duckFrames = new Animation(16, 22, skin);
            animations = new Animation[5] {idleFrames, runFrames, kickFrames, hurtFrames, duckFrames};
        }

        public string getSkin() {
            return skin; 
        }

        public void setSkin(string newSkin) {
            skin = newSkin; 
        }

        public int getNumber() {
            return number; 
        }

        public void setNumber(int newNumber) {
            number = newNumber; 
        }

        public void setMoving(bool moved) {
            moving = moved; 
        }

        public bool getMoving() {
            return moving; 
        }

        public bool isMoving() {
            if(getMoving() == true) {
                return true; 
            }

            else {
                return false; 
            }
        }

        public Animation[] getAnimations() {
            return animations; 
        }

        public float getX() {
            return playerPosition.X; 
        }

        public float getY() {
            return playerPosition.Y; 
        }

        public Vector2 getPosition() {
            return playerPosition; 
            
        }

        public void updateY(float dy) {
            playerPosition.Y += dy; 
        }

        public void updateX(float dx) {
            playerPosition.X += dx; 
        }

    }
}