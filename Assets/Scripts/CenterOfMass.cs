using UnityEngine;

public class CenterOfMass : MonoBehaviour
{
    public Transform CenterOfMassTransform;
    public GameObject blackHole;

    private bool isIdle = false;
    private float idleStartTime;
    private float idleThreshold = 0.1f;
    private float idleCheckThreshold = 0.01f;

    private void Update()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        SpriteRenderer blackHoleRenderer = blackHole.GetComponent<SpriteRenderer>();

        if (IsOverlapping(rb.position, blackHole.transform.position, blackHoleRenderer))
        {
            isIdle = false;
            rb.centerOfMass = Vector2.zero;
        }
        else
        {
            if (Mathf.Abs(rb.velocity.magnitude) < idleCheckThreshold)
            {
                if (!isIdle)
                {
                    idleStartTime = Time.time;
                    isIdle = true;
                }

                if (Time.time - idleStartTime > idleThreshold)
                    rb.centerOfMass = Vector2.Scale(CenterOfMassTransform.localPosition, transform.localScale);
            }
            else
            {
                isIdle = false;
            }
        }
    }

    private bool IsOverlapping(Vector2 playerPosition, Vector2 blackHolePosition, SpriteRenderer blackHoleRenderer)
    {
        Bounds playerBounds = new Bounds(playerPosition, Vector3.one);
        Bounds blackHoleBounds = new Bounds(blackHolePosition, blackHoleRenderer.bounds.size);
        return playerBounds.Intersects(blackHoleBounds);
    }
}

