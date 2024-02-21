using UnityEngine;
using UnityEngine.UI;

public class Progression : MonoBehaviour
{
    public Button[] buttons;

    void Update()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            int buttonLevel = int.Parse(buttons[i].name);
            buttons[i].interactable = buttonLevel <= MainMenu.lastCompletedLevel;
        }
    }

    public void ResetProgress()
    {
        for (int i = 1; i < buttons.Length; i++)
        {
            buttons[i].interactable = false;
        }

        MainMenu.lastCompletedLevel = 1;
        PlayerPrefs.SetInt("LastCompletedLevel", MainMenu.lastCompletedLevel);
    }
}
