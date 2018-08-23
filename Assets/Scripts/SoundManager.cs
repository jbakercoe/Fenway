using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : Singleton<SoundManager>
{
    
    [SerializeField]
    List<Sprite> sprites;
    [SerializeField] GameObject buttonObject;

    private bool isMuted;
    private int spriteIndex = 0;
    private Image buttonImage;

    public void startSounds()
    {
        isMuted = false;
        spriteIndex = 0;
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
        spriteIndex = 1 - spriteIndex;
        buttonImage.sprite = sprites[spriteIndex];
        AudioListener.volume = isMuted ? 0 : 1;
    }
}
