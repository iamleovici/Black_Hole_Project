using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class EmailButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Text text;
    public string defaultText = "grgpdd@yandex.ru";

    private void Start()
    {
        text.text = defaultText;
    }

    public void CopyToBuffer()
    {
        GUIUtility.systemCopyBuffer = defaultText;
        text.text = Language.emailCopied;
        Invoke(nameof(ResetText), 1f);
    }

    private void ResetText()
    {
        text.text = defaultText;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        text.text = Language.emailHover;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        text.text = defaultText;
    }
}
