using System.Collections;
using UnityEngine;

public class WaitXSeconds : MonoBehaviour
{
    public GameObject howToPlay;
    public GameObject howToPlayCanvas;
    public int timer;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Wait3Seconds());

    }

    IEnumerator Wait3Seconds()
    {
        yield return new WaitForSeconds(timer);
        howToPlay.SetActive(true);
        howToPlayCanvas.SetActive(true);
    }
}
