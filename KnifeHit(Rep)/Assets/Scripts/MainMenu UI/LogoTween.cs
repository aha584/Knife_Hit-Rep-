using UnityEngine;
using DG.Tweening;
using System.Collections.Generic;

public class LogoTween : MonoBehaviour
{
    public List<GameObject> pathPoints = new();
    public Vector3 endValue;

    private float duration = 1f;
    private List<Vector3> path = new();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foreach(var waypoint in pathPoints)
        {
            path.Add(waypoint.transform.position);
        }
        transform.DOPath(path.ToArray(), duration, PathType.Linear).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
        transform.DORotate(endValue, duration).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
    }
}
