using Raylib_cs;
using System.Numerics;
namespace Ignis64.UI;

public class Button{
    
    public Interact onClick;
    public Vector2 position;
    public Vector2 scale;
    public Color color;
    public Image texture;
    

    public Button(float X, float Y, float W, float H, Color color, Interact onClick, Image texture = new Image()){
        position = new Vector2(X, Y);
        scale = new Vector2(W, H);
        this.color = color;
        this.texture = texture;
        this.onClick = onClick;
    }

    public void GetClick(int value = 0){
        Vector2 mpos = Raylib.GetMousePosition();
        if(Raylib.IsMouseButtonPressed((MouseButton)value)&& Raylib.CheckCollisionRecs(GetRect(), new Rectangle(mpos.X, mpos.Y, 1, 1))){
            onClick.Invoke(value);
        }
    }

    public Rectangle GetRect(){
        return new Rectangle(position.X-(scale.X/2), position.Y-(scale.Y/2), scale.X, scale.Y);
    }
}
public delegate void Interact(int value);