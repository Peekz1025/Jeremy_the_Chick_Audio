using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music_Script : MonoBehaviour
{

    FMOD.Studio.EventInstance backgroundMusic;
    public bool isplaying = false;
    public bool isPaused = false;

    public GameObject gameOverUI;
    public GameObject pausePanel;

    void Start()
    {
        backgroundMusic = FMODUnity.RuntimeManager.CreateInstance("event:/Music/Background Music");
        PlayBackgroundSound();
    }

    void Update()
    {
        if (pausePanel.activeSelf == true)
        {
            PauseBackgroundSound();
        }
        if (gameOverUI.activeSelf == true)
        {
            StopBackgroundSound();
        }
        if (isPaused && pausePanel.activeSelf == false)
        {
            UnpauseBackgroundSound();
        }
    }
    
    public void PlayBackgroundSound()
    {
        if (isplaying == false) {
            backgroundMusic.start();
            isplaying = true;
        }
    }

    public void StopBackgroundSound()
    {
        backgroundMusic.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
        isplaying = false;
    }

    public void PauseBackgroundSound()
    {
        backgroundMusic.setPaused(true);
        isPaused = true;
        isplaying = false;
    }

    public void UnpauseBackgroundSound()
    {
        backgroundMusic.setPaused(false);
        isPaused = false;
        isplaying = true;
    }

    void OnDestroy()
    {
        backgroundMusic.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
        backgroundMusic.release();
    }
}
