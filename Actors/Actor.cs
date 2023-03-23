using System;
using System.Numerics; 
using Raylib_cs; 
using static Raylib_cs.Raylib;
using static Raylib_cs.KeyboardKey;
using static Raylib_cs.Color;

namespace test_project {
    interface Actor {
        Vector2 getPosition();
        void updateX(float dx);
        void updateY(float dy);

    }
}