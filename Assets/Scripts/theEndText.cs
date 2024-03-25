using UnityEngine;
using UnityEngine.UI;

public class theEndText : MonoBehaviour
{
    public Text endText;
    void Start()
    {
        endText.text = Language.endText;
    }
}
