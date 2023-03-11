using Raylib_cs;
using System.Numerics;
namespace Ignis64.UI;

public class Panel{
    public Vector2 position;
    public Vector2 scale;
    public Color color;
    public Image texture;
    

    public Panel(float X, float Y, float W, float H, Color color, Image texture = new Image()){
        position = new Vector2(X, Y);
        scale = new Vector2(W, H);
        this.color = color;
        this.texture = texture;
    }

    public Rectangle GetRect(){
        return new Rectangle(position.X-(scale.X/2), position.Y-(scale.Y/2), scale.X, scale.Y);
    }
}