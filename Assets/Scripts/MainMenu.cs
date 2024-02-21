//using UnityEngine;
//using UnityEngine.SceneManagement;
//using UnityEngine.UI;

//public class MainMenu : MonoBehaviour
//{
//    private int currentSceneIndex;

//    public void LoadNextScene()
//    {
//        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
//        SceneManager.LoadScene(currentSceneIndex + 1);
//    }
//    public void RestartScene()
//    {
//        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
//        SceneManager.LoadScene(currentSceneIndex);
//    }

//    public void LoadSelectedLevel(Button button)
//    {
//        string name = button.name;
//        int intName = int.Parse(name);
//        SceneManager.LoadScene(intName);

//    }
//    public void PlayFirstScene()
//    {
//        SceneManager.LoadScene(sceneBuildIndex: 1);
//    }
//    public void GoToMainMenu()
//    {
//        SceneManager.LoadScene(0);
//    }
//    public void QuitGame()
//    {
//        Application.Quit();
//    }


//}

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
        lastCompletedLevel = currentSceneIndex + 1;
        PlayerPrefs.SetInt("LastCompletedLevel", lastCompletedLevel);
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void RestartScene()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        lastCompletedLevel = currentSceneIndex;
        PlayerPrefs.SetInt("LastCompletedLevel", lastCompletedLevel);
        SceneManager.LoadScene(currentSceneIndex);
    }

    public void LoadSelectedLevel(Button button)
    {
        string name = button.name;
        int intName = int.Parse(name);
        lastCompletedLevel = intName;
        PlayerPrefs.SetInt("LastCompletedLevel", lastCompletedLevel);
        SceneManager.LoadScene(intName);
    }

    public void PlayFirstScene()
    {
        lastCompletedLevel = 1;
        PlayerPrefs.SetInt("LastCompletedLevel", lastCompletedLevel);
        SceneManager.LoadScene(sceneBuildIndex: 1);
    }public void PlayLastScene()
    {
        PlayerPrefs.SetInt("LastCompletedLevel", lastCompletedLevel);
        SceneManager.LoadScene(sceneBuildIndex: lastCompletedLevel);
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    //public void QuitGame()
    //{
    //    Application.Quit();
    //}
}
