using UnityEngine;

public class BlackHoleRotation : MonoBehaviour
{
    public Transform sprite;
    public int rotateSpeed;
    private int direction;
    private Vector2 initialInputPos;

    void Start()
    {
        sprite = GetComponent<Transform>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
        {
            if (Input.GetMouseButtonDown(0))
                initialInputPos = Input.mousePosition;
            else if (Input.touchCount > 0)
                initialInputPos = Input.GetTouch(0).position;
        }

        if (Input.GetMouseButton(0) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved))
        {
            Vector2 currentInputPos;
            if (Input.GetMouseButton(0))
                currentInputPos = Input.mousePosition;
            else
                currentInputPos = Input.GetTouch(0).position;

            float distanceX = currentInputPos.x - initialInputPos.x;
            direction = distanceX > 0 ? -1 : 1;
            sprite.Rotate(Vector3.forward, rotateSpeed * direction * Time.deltaTime);
        }
    }
}
