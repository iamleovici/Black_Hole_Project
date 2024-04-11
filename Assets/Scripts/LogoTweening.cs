using UnityEngine;
using DG.Tweening;

public class LogoTweening : MonoBehaviour
{
    public float size;
    public float duration;

    private void Start()
    {
        transform.localScale = this.transform.localScale;
        if (transform != null)
        {
            transform.DOScale(new Vector2(size, size), duration)
                .SetEase(Ease.InOutBack)
                .SetLoops(-1, LoopType.Yoyo);

        }
    }
}
