using UnityEngine;
using System;
using UnityEngine.EventSystems;

public enum CellState
{
    Locked,
    Unlocked,
}

public class CellNode : MonoBehaviour, IPointerDownHandler
{
    public GameObject lockedFrame;
    public GameObject unlockedFrame;
    public CellState cellState;
    public Action<CellNode> onClick;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        lockedFrame.SetActive(false);
        unlockedFrame.SetActive(false);
    }
    /*private void OnMouseDown()
    {
        Debug.Log("MouseDown");
        onClick?.Invoke(this);
    }*/
    public void ActiveFrame()
    {
        if (cellState == CellState.Locked)
        {
            lockedFrame.SetActive(true);
            unlockedFrame.SetActive(false);
        }
        else if (cellState == CellState.Unlocked)
        {
            lockedFrame.SetActive(false);
            unlockedFrame.SetActive(true);
        }
    }
    public void DeactiveFrame()
    {
        lockedFrame.SetActive(false);
        unlockedFrame.SetActive(false);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        //Debug.Log("MouseDown");
        onClick?.Invoke(this);
    }
}
