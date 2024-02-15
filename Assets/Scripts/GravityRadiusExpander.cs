using UnityEngine;
using UnityEngine.UI;

public class GravityRadiusExpander : MonoBehaviour
{
    private Vector2 maxScale = new(15f, 15f);
    private Vector2 defaultScale = new(0f, 0f);

    public Image blackFade;

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
        if (!blackFade.isActiveAndEnabled)
        {

            if ((Input.GetMouseButtonDown(0)
                || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
                && !isBlackHoleExist)
            {
                NewPosition();
                isBlackHoleExist = true;
            }

            if (Input.GetMouseButton(0)
                || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved))
                Expanding();



            else if ((Vector2)transform.localScale != defaultScale)
            {
                isBlackHoleExist = true;
                Reducing();
                if ((Vector2)transform.localScale == defaultScale)
                    isBlackHoleExist = false;
            }
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
        Vector3 newPosition;
        if (Input.touchCount > 0)
        {
            newPosition = mainCamera.ScreenToWorldPoint(Input.GetTouch(0).position);
        }
        else
        {
            newPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        }
        transform.position = new Vector3(newPosition.x, newPosition.y, 1);
    }
}
