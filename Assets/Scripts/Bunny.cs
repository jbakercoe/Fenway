using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bunny : MonoBehaviour {

    [SerializeField]
    float enterDelay = 0;
    [SerializeField]
    AudioClip soundClip;
    [SerializeField]
    AudioClip crashSound;

    Animator anim;
    SpriteRenderer spriteRenderer;

    public delegate void OnCrash();
    public OnCrash NotifyOfCrash;

    public delegate void OnFinished();
    public OnFinished NotifyOfFinish;

    public bool ignoreScript = false;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        if(!ignoreScript)
            Enter();
	}

    public void Enter()
    {
        StartCoroutine(WaitThenEnter(enterDelay));
    }

    IEnumerator WaitThenEnter(float delay)
    {
        yield return new WaitForSeconds(delay);
        anim.Play("Seek&Destroy");
    }

    public void Crash()
    {
        NotifyOfCrash();
        SoundPlayer.Instance.Play(crashSound);
        spriteRenderer.sortingLayerName = "guessItems";
        spriteRenderer.sortingOrder = 4;
    }
    
    public void PlaySound()
    {
        SoundPlayer.Instance.Play(soundClip);
    }

    public void Finish()
    {
        NotifyOfFinish();
    }

}
