using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdditionalSound : MonoBehaviour {

    [SerializeField]
    AudioClip clip;

    public void PlaySoundEffect()
    {
        SoundPlayer.Instance.Play(clip);
    }

}
