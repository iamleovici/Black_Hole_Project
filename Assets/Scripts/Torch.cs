using UnityEngine;

public class Torch : MonoBehaviour
{
    [SerializeField] private SpriteRenderer sr;
    private bool isActive = false;

    private void OnMouseDown()
    {
        ChangeTorchColor();
    }
    public void ChangeTorchColor()
    {
        if (!isActive)
        {
            sr.color = Color.yellow;
            isActive = true;
        }
        else
        {
            sr.color = Color.white;
            isActive = false;
        }
    }
}
