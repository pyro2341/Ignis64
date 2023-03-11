using Raylib_cs;
using System.Numerics;
namespace Ignis64.UI;

public class Text{
    public Vector2 position;
    public int scale;
    public Color color;
    public Image font;
    

    public Text(float X, float Y, int scale, Image font, Color color){
        position = new Vector2(X, Y);
        this.scale = scale;
        this.color = color;
        this.font = font;
    }

    
}