using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakSounds : MonoBehaviour {

    private AudioSource audioSource;
    // Use this for initialization
    void Start () {

        audioSource = GetComponent<AudioSource>();
    }

    public void BreakSound()
    {
        if (audioSource != null)
        {
            audioSource.PlayOneShot(audioSource.clip);
        }
    }
}
