using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Language : MonoBehaviour
{
    public static string winHelperTextMain;
    public static string winHelperTextTouched;
    public static string winHelperTextWin;
    public static string emailCopied;
    public static string emailHover;
    public static string resetConfirmation;

    public string language;

    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        language = PlayerPrefs.GetString("language", "ru");
        if(language == "ru")
            SetRuLanguage();
        if(language == "en")
            SetEnLanguage();
    }
    public void SetRuLanguage()
    {
        winHelperTextMain = "бярюмэ ячдю";
        winHelperTextTouched = "ярни гдеяэ";
        winHelperTextWin = "онаедю!";
        emailHover = "яйнохпнбюрэ";
        emailCopied = "янохпнбюмн";
        resetConfirmation = "сдюкхрэ опнцпеяя?";
        PlayerPrefs.SetString("language", "ru");
    }
    public void SetEnLanguage()
    {
        winHelperTextMain = "PLACE HERE";
        winHelperTextTouched = "STAY HERE";
        winHelperTextWin = "YOU WIN!";
        emailHover = "COPY TO CLIPBOARD";
        emailCopied = "COPIED";
        resetConfirmation = "RESET PROGRESS?";

        PlayerPrefs.SetString("language", "en");

    }

}
