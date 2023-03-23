using System;
using System.Numerics;
using Raylib_cs; 
using static Raylib_cs.Raylib;

namespace test_project {
    class HandlePlayerMovementServices : HandleMovementServices { 

        public HandlePlayerMovementServices() {

        }

        public void checkMovements(Actor actor) {
            if(IsKeyDown(KeyboardKey.KEY_D)) {
                moveRight(actor); 
            }

            else if(IsKeyDown(KeyboardKey.KEY_A)) {
                moveLeft(actor);
            }
        }

        protected override void moveRight(Actor actor)
        {
            actor.updateX(20.0f);
        }

        protected override void moveLeft(Actor actor)
        {
            actor.updateX(-20.0f);
        }

    }
}