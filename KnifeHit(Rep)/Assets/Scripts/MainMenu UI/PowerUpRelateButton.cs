using UnityEngine;

public class PowerUpRelateButton : MonoBehaviour
{
    public GameObject powerUpCanvas;
    public void OnClick()
    {
        powerUpCanvas.SetActive(true);
    }
    public void OnBackClick()
    {
        powerUpCanvas.SetActive(false);
    }
}
