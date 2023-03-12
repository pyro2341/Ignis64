using Raylib_cs;
using System.Numerics;
namespace Ignis64.UI;

public class InputField{
    public Vector2 position;
    public Vector2 scale;
    public Color color;
    public Text text;
    public bool selected = false;

    public InputField(float X, float Y, float W, float H, Color color, Text text){
        position = new Vector2(X, Y);
        scale = new Vector2(W, H);
        this.color = color;
        this.text = text;
    }

    public void Select(int input){
        selected = true;
    }
}