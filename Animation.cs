using System;
using Raylib_cs; 
using static Raylib_cs.Raylib;

namespace test_project {
    class Animation {
        int start; 
        int end; 
        string img; 
        public Animation(int startFrame, int endFrame, string image) {
            start = startFrame; 
            end = endFrame; 
            img = image; 
        }

        public int getStart() {
            return start; 
        }

        public int getEnd() {
            return end; 
        }

        public string getImg() {
            return img; 
        }
    }
}