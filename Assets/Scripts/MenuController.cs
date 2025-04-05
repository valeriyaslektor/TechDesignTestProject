using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void LoadHomeScene()
    {
        SceneManager.LoadScene("home_in_forest");
    }

    public void LoadForestScene()
    {
        SceneManager.LoadScene("shadow_forest");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Игра завершена.");
    }
}

