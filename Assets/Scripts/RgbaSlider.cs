using UnityEngine;

public class RgbaSlider : MonoBehaviour
{
    public Color myColor;
    void OnGUI()
    {
        myColor = RGBSlider(new Rect(0, 30, 200, 20), myColor);
    }
    Color RGBSlider(Rect screenRect, Color rgba)
    {
        rgba.r = LabelSlider(screenRect, rgba.r, 0.0f, 1.0f, "Red");
        screenRect.y += 20;
        rgba.g = LabelSlider(screenRect, rgba.g, 0.0f, 1.0f, "Green");
        screenRect.y += 20;
        rgba.b = LabelSlider(screenRect, rgba.b, 0.0f, 1.0f, "Blue");
        screenRect.y += 20;
        rgba.a = LabelSlider(screenRect, rgba.a, 0.0f, 1.0f, "Alpha");
        return rgba;
    }
    float LabelSlider(Rect screenRect, float sliderValue, float sliderMinValue, float sliderMaxValue, string labelText)
    {
        GUI.Label(screenRect, labelText);
        screenRect.x += screenRect.width;
        sliderValue = GUI.HorizontalSlider(screenRect, sliderValue, sliderMinValue, sliderMaxValue);
        return sliderValue;
    }
}
