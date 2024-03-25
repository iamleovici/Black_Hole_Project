using UnityEngine;

public class GameButton : MonoBehaviour
{
    public GameObject toDeactivate;
    public GameObject toActivate;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Item"))
        {
            DeactivateAction();
            ActivateAction();
        }
        void DeactivateAction() { if (toDeactivate != null) toDeactivate.SetActive(false); }
        void ActivateAction() { if (toActivate != null) toActivate.SetActive(true); }
    }
    
}
