using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Win : MonoBehaviour
{
    public Text timerText;
    public Text helperText;
    public Image blackFade;
    public Button nextButon;
    public int currentSceneIndex;
    public string DefaultText = "TOUCH TO WIN";

    public GameObject player;

    private void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == player)
        {
            helperText.text = "STAY HERE";
            StartCoroutine(WinMessage());
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject == player)
        {
            if (helperText != null)
                helperText.text = DefaultText;
            if (timerText != null)
                timerText.text = "";
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
        timerText.text = "You Win!";

        blackFade.gameObject.SetActive(true);
        nextButon.gameObject.SetActive(true);
    }
    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex +1);
    }
    public void RestartScene()
    {
        SceneManager.LoadScene(currentSceneIndex);
    }
}
