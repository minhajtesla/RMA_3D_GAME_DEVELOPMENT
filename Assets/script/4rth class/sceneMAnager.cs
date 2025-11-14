using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class sceneMAnager : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
