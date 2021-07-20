using UnityEngine;

public class HpBar : MonoBehaviour
{
    [SerializeField] public Texture2D healthbarBG;
    [SerializeField] public Texture2D healthbarFill;
    [SerializeField] public float health;
    private void OnGUI()
    {
        GUI.DrawTexture(new Rect(Screen.width * 0.5f, 15, 200, 20), healthbarBG);
        GUI.DrawTexture(new Rect(Screen.width * 0.5f, 15, health, 20), healthbarFill);
    }
}