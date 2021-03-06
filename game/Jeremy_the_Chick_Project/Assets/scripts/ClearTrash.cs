using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearTrash : MonoBehaviour
{
    GameObject[] currentLogs;
    GameObject[] currentRocks;
    GameObject[] currentSprings;
    public ParticleSystem explosion;
    
    public void DestroyItems()
    {
        bool playedsound = false;

        currentLogs = GameObject.FindGameObjectsWithTag("Log");
        currentRocks = GameObject.FindGameObjectsWithTag("Spring");
        currentSprings = GameObject.FindGameObjectsWithTag("Rock");

        foreach (GameObject item in currentLogs)
        {
            Instantiate(explosion, item.transform.position, item.transform.rotation);
            Destroy(item);
            if (playedsound == false)
            {
                PlayDestroySound();
                playedsound = true;
            }
        }

        foreach (GameObject item in currentRocks)
        {
            Instantiate(explosion, item.transform.position, item.transform.rotation);
            Destroy(item);
            if (playedsound == false)
            {
                PlayDestroySound();
                playedsound = true;
            }
        }

        foreach (GameObject item in currentSprings)
        {
            Instantiate(explosion, item.transform.position, item.transform.rotation);
            Destroy(item);
            if (playedsound == false)
            {
                PlayDestroySound();
                playedsound = true;
            }
        }
    }

    void PlayDestroySound()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/Effects/Item Destroyed");
    }
}
