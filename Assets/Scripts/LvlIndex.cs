using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LvlIndex : MonoBehaviour
{
    public Text text;
    private void Start()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        text.text = currentSceneIndex.ToString();
    }
}
