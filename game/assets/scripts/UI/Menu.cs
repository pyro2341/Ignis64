using Raylib_cs;
using System.Numerics;
namespace Ignis64.UI;

public class Menu{
    public Button[] buttons;
    public Panel[] panels;
    public Text[] text;
    public bool active;

#pragma warning disable 8618
    public Menu(Button[]? buttons, Panel[]? panels, Text[]? text, bool active){
        if (buttons != null)
        {
            this.buttons=buttons;
        }
        if (panels != null)
        {
            this.panels=panels;
        }
        if (text != null)
        {
            this.text = text;
        }
        this.active = active;
    }

    public void Draw(){
        if(!active) { return; }
        if (buttons != null){
            foreach (Button button in buttons){
                Raylib.DrawRectangleRec(button.GetRect(), button.color);
            }
        }
        if (panels != null){
            foreach (Panel panel in panels){
                Raylib.DrawRectangleRec(panel.GetRect(), panel.color);
            }
        }
        if (text != null){
            foreach (Text textobj in text)
            {
                Raylib.DrawTextEx(textobj.font, textobj.value, textobj.position, textobj.scale, 1, textobj.color);
            }
        }
    }

    
}