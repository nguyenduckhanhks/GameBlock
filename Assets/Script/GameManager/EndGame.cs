using UnityEngine.SceneManagement;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public void restart()
    {
        SceneManager.LoadScene("Play");
    }
    public void quit()
    {
        Application.Quit();
    }
}
