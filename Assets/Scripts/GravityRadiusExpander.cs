using UnityEngine;

public class GravityRadiusExpander : MonoBehaviour
{
    private Vector2 maxScale = new(15f, 15f);
    private Vector2 defaultScale = new(0f, 0f);
    public float expandSpeed = 0.3f;
    public float reduceSpeed = 1f;

    bool isBlackHoleExist = false;

    private Camera mainCamera;


    private void Start()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
        if ((Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1)) && !isBlackHoleExist)
        {
            //Vector3 mousePos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
            //transform.localPosition = new Vector3(mousePos.x, mousePos.y, 0);
            NewPosition();
            isBlackHoleExist = true;
        }

        if (Input.GetMouseButton(0) || Input.GetMouseButton(1))
            Expanding();
            //transform.localScale = Vector2.Lerp(transform.localScale, maxScale, Time.deltaTime * expandSpeed);



        else if ((Vector2)transform.localScale != defaultScale)
        {
            isBlackHoleExist = true;
            //transform.localScale = Vector2.MoveTowards(transform.localScale, defaultScale, Time.deltaTime * reduceSpeed);
            Reducing();
            if ((Vector2)transform.localScale == defaultScale)
                isBlackHoleExist = false;
        }
    }

    void Expanding()
    {
        transform.localScale = Vector2.Lerp(transform.localScale, maxScale, Time.deltaTime * expandSpeed);
    }
    void Reducing()
    {
        transform.localScale = Vector2.MoveTowards(transform.localScale, defaultScale, Time.deltaTime * reduceSpeed);
    }
    void NewPosition()
    {
        Vector3 mousePos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        transform.localPosition = new Vector3(mousePos.x, mousePos.y, 0);
    }
}
