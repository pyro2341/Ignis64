using Raylib_cs;
using System.Numerics;
using Newtonsoft.Json;
namespace Ignis64.UI;

public class Text
{
    public Vector2 position;
    public int scale;
    public Color color;
    public string value;
    public Font font;

    public Text(float X, float Y, int scale, Color color, string value, string FileName)
    {
        position = new Vector2(X, Y);
        this.scale = scale;
        this.color = color;
        this.value = value;
        this.font = Raylib.LoadFont("assets/textures/fonts/"+FileName);
    }
}