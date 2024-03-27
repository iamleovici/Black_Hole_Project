using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public static int lastCompletedLevel = 1;

    private int currentSceneIndex;

    private void Start()
    {
        lastCompletedLevel = PlayerPrefs.GetInt("LastCompletedLevel", 1);
    }

    public void LoadNextScene()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextLevel = currentSceneIndex + 1;
        if (nextLevel > lastCompletedLevel)
        {
            lastCompletedLevel = nextLevel;
            PlayerPrefs.SetInt("LastCompletedLevel", lastCompletedLevel);
        }
        SceneManager.LoadScene(nextLevel);
    }

    public void RestartScene()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }

    public void LoadSelectedLevel(Button button)
    {
        string name = button.name;
        int intName = int.Parse(name);
        SceneManager.LoadScene(intName);
    }
    public void PlayLastScene()
    {
        PlayerPrefs.SetInt("LastCompletedLevel", lastCompletedLevel);
        SceneManager.LoadScene(sceneBuildIndex: lastCompletedLevel);
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
