using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private static AudioManager instance;
    public AudioClip BGM;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);

            GetComponent<AudioSource>().PlayOneShot(BGM);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Other audio management code here...
}