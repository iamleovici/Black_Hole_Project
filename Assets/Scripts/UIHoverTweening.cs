using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;

public class UIHoverTweening : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public float sizePercentage = 5f;
    public float duration = 0.5f;

    private Vector2 originalScale;

    private void Start()
    {
        originalScale = transform.localScale;
    }
    

    public void OnPointerEnter(PointerEventData eventData)
    {

        if (transform != null)
        {
            float newSizeX = originalScale.x * (1f + sizePercentage / 100f);
            float newSizeY = originalScale.y * (1f + sizePercentage / 100f);
            transform.DOScale(new Vector2(newSizeX, newSizeY), duration)
                .SetEase(Ease.OutElastic);

        }

    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (transform != null)
        {
            transform.DOScale(originalScale, duration)
                .SetEase(Ease.OutExpo);

        }
    }
    private void OnDisable()
    {
        DOTween.KillAll();
    }
}

