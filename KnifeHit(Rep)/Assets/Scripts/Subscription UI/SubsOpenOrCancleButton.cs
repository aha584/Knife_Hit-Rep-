using UnityEngine;
using DG.Tweening;

public class SubsOpenOrCancleButton : MonoBehaviour
{
    public GameObject subscriptionCanvas;

    [SerializeField] private float duration = 1f;

    public void OnClick(GameObject targetCanvas)
    {
        Transform subsCanvasTransfrom = subscriptionCanvas.transform;
        Transform targetTransform = targetCanvas.transform;
        subsCanvasTransfrom.DOMove(new Vector3(targetTransform.position.x, targetTransform.position.y, subsCanvasTransfrom.position.z), duration).SetEase(Ease.InCubic);
    }
}
