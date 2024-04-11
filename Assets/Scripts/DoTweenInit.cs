using UnityEngine;
using DG.Tweening;

public class DOTweenInit : MonoBehaviour
{
    private void Awake()
    {
        DOTween.Init(true, true, LogBehaviour.Verbose);
        DOTween.SetTweensCapacity(200, 10);
        DontDestroyOnLoad(this.gameObject);
    }


}
