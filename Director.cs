using System;
using Raylib_cs; 
using static Raylib_cs.Raylib;

namespace test_project {
    class Director {
        OutputServices output = new OutputServices(); 
        public Director() {
            
        }

        public void run() {
            output.startGame(); 
            while(!WindowShouldClose()) {
                output.beginDrawing();
                output.endDrawing(); 
            }
        }
    }
}