using UnityEngine;

public class DeathBox : MonoBehaviour
{
    public GameObject restartButton;
    public GameObject vfx;
    public float remainingTime;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Item") || collision.gameObject.CompareTag("Player"))
            DestroyAndShowEffects(collision.gameObject);
    }

    void DestroyAndShowEffects(GameObject obj)
    {
        Vector3 destroyPosition = obj.transform.position;
        Destroy(obj);
        Instantiate(vfx, destroyPosition, Quaternion.identity);
        if (obj.CompareTag("Player"))
            Invoke("RestartApperas", remainingTime);
    }

    void RestartApperas()
    {
        restartButton.SetActive(true);
    }
}
