using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bunny3 : Singleton<bunny3> {

    private Animator anim;
    private SpriteRenderer sprite;
    private AudioSource motorcycle;
    private string sortingName;
    private int sortingOrder;
    private bool fenceTrigger;
    private bool lettuceTrigger;
    
    public bool FenceTrigger
    {
        get
        {
            return fenceTrigger;
        }
    }

    public bool LettuceTrigger
    {
        get
        {
            return lettuceTrigger;
        }
    }

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        motorcycle = GetComponent<AudioSource>();
        initializeGameVars();
        sortingName = "guessItems";
        sortingOrder = 2;
    }

    public void initializeGameVars()
    {
        fenceTrigger = false;
        lettuceTrigger = false;
    }

    // Update is called once per frame
    void Update () {
        if (bunny2.Instance.BunnyTrigger)
            anim.Play("Seek&Destroy");
	}

    public void fenceCrash()
    {
        fenceTrigger = true;
    }

    public void lettuceCrash()
    {
        lettuceTrigger = true;
        sprite.sortingLayerName = sortingName;
        sprite.sortingOrder = sortingOrder;
    }

    public void CycleSound()
    {
        motorcycle.PlayOneShot(motorcycle.clip);
    }

}
