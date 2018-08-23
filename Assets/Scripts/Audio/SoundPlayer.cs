using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SoundPlayer : Singleton<SoundPlayer> {

    AudioSource audioSource;

	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
	}
	
    public void Play(AudioClip clip)
    {
        audioSource.clip = clip;
        audioSource.Play();
    }

}
