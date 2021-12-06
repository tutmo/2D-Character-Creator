using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void SelectScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
