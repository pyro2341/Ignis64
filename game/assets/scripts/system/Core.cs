using Raylib_cs;
using System.Numerics;
namespace Ignis64;

public static class Core
{
    public static Vector2 AspectRatio = new Vector2(16, 9);
    public static UI.Menu menu = new UI.Menu(null, null, new UI.Text[] { new UI.Text(100, 100, 50, Color.WHITE, "HELLO WORLD!") }, true);
    public static int Resolution = 50;
    private static void Main(string[] args){
        Raylib.InitWindow((int)AspectRatio.X*Resolution, (int)AspectRatio.Y*Resolution, " Ignis-64 : The Game Engine");
        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            menu.Draw();
            Raylib.ClearBackground(Color.BLACK);
            Raylib.EndDrawing();
        }
        Environment.Exit(0);
    }
}