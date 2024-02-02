using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    private int currentSceneIndex;
    
    public void LoadNextScene()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
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
    public void PlayFirstScene()
    {
        SceneManager.LoadScene(sceneBuildIndex: 1);
    }
    public void GoToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void QuitGame()
    {
        Application.Quit();
    }


}
