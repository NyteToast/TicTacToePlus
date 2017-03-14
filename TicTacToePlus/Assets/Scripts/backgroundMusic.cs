using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundMusic : MonoBehaviour {

    public AudioClip[] audioclip;
    private AudioSource source;
    public int trackNumber = 0;
    static bool AudioBegin = false;

    void Awake()
    {
        Debug.Log(AudioBegin);
        Debug.Log(audioclip.Length);
        source = GetComponent<AudioSource>();

        if (!AudioBegin)
        {
            PlaySound(trackNumber);
            DontDestroyOnLoad(gameObject);
            AudioBegin = true;
        }
    }

    void Update()
    {
        if (!source.isPlaying)
        {
            if (trackNumber == audioclip.Length)
            {
                trackNumber = 0;
            }
            else {
                PlaySound(trackNumber);
                trackNumber++;
            }
        }

        if (Application.loadedLevelName == "gameScene" && AudioBegin == true)
        {
            source.volume = 0.1f;
            //Destroy(this.gameObject);
        }


    }


    public void PlaySound(int clip)
    {
        source.clip = audioclip[clip];
        source.Play();
    }


}

