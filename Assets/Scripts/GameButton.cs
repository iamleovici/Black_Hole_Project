using UnityEngine;

public class GameButton : MonoBehaviour
{
    public GameObject[] toDeactivate;
    public GameObject[] toActivate;
    public bool isButtonPressed = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Item"))
        {
            if (!isButtonPressed)
            {
                AudioManager.ButtonPushSFX();
                isButtonPressed = true;
            }
            DeactivateAction();
            ActivateAction();
        }
        void DeactivateAction()
        {
            if (toDeactivate != null)
            {
                foreach (GameObject obj in toDeactivate)
                {
                    obj.SetActive(false);
                };
            }
            else return;
        }
        void ActivateAction() 
        {
            if (toActivate != null)
            {
                foreach(GameObject obj in toActivate)
                {
                    if(obj)
                        obj.SetActive(true); 
                }
            }
            else return;
        }
    }

}
