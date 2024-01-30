using UnityEngine;

public class CircleGravity : MonoBehaviour
{
    public float gravityStrength = 500;
    public float maxSpeed = 5f;
    public float centerAttractionSpeed = 0.3f;
    public float centreRadius = 0.5f;

    private float gravityRadius;
    private float newGravDir;

    private void Update()
    {
        newGravDir = Input.GetMouseButton(0) ? -1f : Input.GetMouseButton(1) ? 1f : 0f;
    }

    void FixedUpdate()
    {
        if(Input.GetMouseButton(0) || Input.GetMouseButton(1))
            ApplyGravity();
        gravityRadius = transform.localScale.x / 2;
    }

    void ApplyGravity()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, gravityRadius);

        foreach (Collider2D collider in colliders)
        {
            Rigidbody2D rb = collider.GetComponent<Rigidbody2D>();

            if (rb)
            {
                Vector2 directionToCenter = (Vector2)transform.position - rb.position;
                float distance = directionToCenter.magnitude;

                if (distance > centreRadius)
                {
                    Vector2 gravityDirection = directionToCenter.normalized;

                    Vector2 tangentVector = new(-gravityDirection.y, gravityDirection.x);

                    Vector2 gravityTowardsCenter = gravityDirection * gravityStrength / (distance * distance) * centerAttractionSpeed;
                    Vector2 gravityAlongTangent = ((tangentVector * newGravDir) * gravityStrength) / (distance * distance);

                    rb.AddForce(gravityTowardsCenter + gravityAlongTangent, ForceMode2D.Force);

                    rb.velocity = Vector2.ClampMagnitude(rb.velocity, maxSpeed);
                    float angle = Mathf.Atan2(directionToCenter.y, directionToCenter.x) * Mathf.Rad2Deg;
                    rb.MoveRotation(angle);
                }
                else { }

            }
        }
    }
}
