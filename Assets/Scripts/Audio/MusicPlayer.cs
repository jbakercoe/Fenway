using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class MusicPlayer : Singleton<MusicPlayer> {

    [SerializeField]
    AudioClip mainSong;
    [SerializeField]
    AudioClip ebgSong;

    AudioSource audioSource;

	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
	}

    public void StopMusic()
    {
        audioSource.Stop();
    }

    public void PlayEBG()
    {
        audioSource.clip = ebgSong;
        audioSource.Play();
    }

}
