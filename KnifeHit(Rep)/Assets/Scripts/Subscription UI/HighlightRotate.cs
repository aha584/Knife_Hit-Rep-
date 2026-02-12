using UnityEngine;
using DG.Tweening;

public class HighlightRotate : MonoBehaviour
{
    [SerializeField] private float duration = 18f;
    [SerializeField] private Vector3 endValue = new Vector3(0, 0, 360f);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.DORotate(endValue, duration, RotateMode.LocalAxisAdd).SetLoops(-1, LoopType.Incremental).SetEase(Ease.Linear);
    }
}
