using System;
using Raylib_cs;

namespace PingPong
{
    public class Window
    {
        //WINDOW PROPERTIES
            //Window width
            public static int windowW = 1280;

            //Window height
            public static int windowH = 720;
        
            //Background color
            public static Color backgroundColor = new Color(0, 0, 0, 0);

        public static void Initialize()
        {
            //WINDOW SIZE AND NAME
                Raylib.InitWindow(Window.windowW, Window.windowH, "Ping Pong");
            
            //TARGET FPS
                Raylib.SetTargetFPS(60);

        }
    }
}
