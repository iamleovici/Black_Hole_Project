using UnityEngine;

public class UINavigationButtons : MonoBehaviour
{
    public GameObject[] levels;
    private int currentIndex = 0;

    public void Next()
    {
        levels[currentIndex].SetActive(false);
        currentIndex = (currentIndex + 1) % levels.Length;
        levels[currentIndex].SetActive(true);
    }

    public void Previous()
    {
        levels[currentIndex].SetActive(false);
        currentIndex = (currentIndex - 1 + levels.Length) % levels.Length;
        levels[currentIndex].SetActive(true);
    }
}
