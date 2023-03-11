using System;
using Raylib_cs; 
using static Raylib_cs.Raylib;

namespace test_project // Note: actual namespace depends on the project name.
{
    internal class Program
    { 
        static void Main(string[] args)
        {
                Director director = new Director();
                director.run(); 
                CloseWindow(); 
        }
    }
}