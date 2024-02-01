using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BlackHoleRotation : MonoBehaviour
{
    public Transform sprite;
    public int rotateSpeed;
    private int direction;
    void Start()
    {
        sprite = GetComponent<Transform>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
            direction = 1;
        if (Input.GetMouseButtonDown(1))
            direction = -1;
        sprite.Rotate(Vector3.forward, rotateSpeed * direction *Time.deltaTime);
    }
}
