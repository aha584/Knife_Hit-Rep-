using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenSceneButton : MonoBehaviour
{
    public void OnClick(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
