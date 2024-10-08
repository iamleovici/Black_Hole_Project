using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Win : MonoBehaviour
{
    public Text timerText;
    public Text helperText;
    public Image blackFade;
    public Button nextButon;

    public GameObject player;
    public GameObject timerSound;

    private void Start()
    {
       helperText.text = Language.winHelperTextMain;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == player)
        {
            helperText.text = Language.winHelperTextTouched;
            timerSound.gameObject.SetActive(true);
            StartCoroutine(WinMessage());
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject == player)
        {
            if (helperText != null)
            {
                helperText.text = Language.winHelperTextMain;
            }

            if (timerText != null)
                timerText.text = "";
            if(timerSound != null)
                timerSound.gameObject.SetActive(false);
            StopAllCoroutines();
        }
    }

    IEnumerator WinMessage()
    {
        yield return new WaitForSeconds(1);
        timerText.text = "1";
        yield return new WaitForSeconds(1);
        timerText.text = "2";
        yield return new WaitForSeconds(1);
        timerText.text = "3";
        yield return new WaitForSeconds(1);
        timerText.text = Language.winHelperTextWin;
        AudioManager.WinSFX();
        PlayPause.PauseGame();


        blackFade.gameObject.SetActive(true);
        nextButon.gameObject.SetActive(true);

        
    }
}
