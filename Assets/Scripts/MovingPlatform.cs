using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float speed;

    void Update()
    {
        Vector3 currentPosition = transform.position;
        Vector3 newPosition = currentPosition + Vector3.right * speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
