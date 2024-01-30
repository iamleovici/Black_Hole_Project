using System.Collections;
using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject player;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == player)
            StartCoroutine(WinMessage());
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        StopAllCoroutines();
    }

    IEnumerator WinMessage()
    {
        yield return new WaitForSeconds(1);
        Debug.Log("1");
        yield return new WaitForSeconds(1);
        Debug.Log("2");
        yield return new WaitForSeconds(1);
        Debug.Log("3");
        yield return new WaitForSeconds(1);
        Debug.Log("You Win");
    }
}
