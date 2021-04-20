using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Scene_Changer : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene("game");
        PlayBackgroundSound();
    }

    public void LoadHome()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("home");
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
        PlayBackgroundSound();
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void PlayUISound()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/UI Click");
    }

    public void PlayBackgroundSound()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/Background Music");
    }
}
