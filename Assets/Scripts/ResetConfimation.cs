using UnityEngine;
using UnityEngine.UI;

public class ResetConfimation : MonoBehaviour
{
    public Text text;

    private void Start()
    {
        text.text = Language.resetConfirmation;

    }
    private void Update()
    {
        text.text = Language.resetConfirmation;

    }
}
