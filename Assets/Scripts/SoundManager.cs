using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : Singleton<SoundManager>
{
    
    [SerializeField] Sprite[] sprites;
    [SerializeField] GameObject buttonObject;

    private bool isMuted;
    private int spriteOn = 0;
    private Image buttonImage;

    public void startSounds()
    {
        isMuted = false;
        spriteOn = 0;
        AudioListener.volume = 1;
    }

    public bool IsMuted
    {
        get
        {
            return isMuted;
        }
    }

    private void Start()
    {
        buttonImage = buttonObject.GetComponent<Image>();
        isMuted = false;
    }

    public void toggleSounds()
    {
        isMuted = !isMuted;
        spriteOn = 1 - spriteOn;
        buttonImage.sprite = sprites[spriteOn];
        AudioListener.volume = isMuted ? 0 : 1;
    }
}
