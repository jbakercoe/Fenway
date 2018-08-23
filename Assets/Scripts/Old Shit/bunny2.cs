//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class bunny2 : Singleton<bunny2> {

//    private Animator anim;
//    private SpriteRenderer sprite;
//    private AudioSource motorcycle;
//    private string sortingName;
//    private int sortingOrder;
//    private bool fenceTrigger;
//    private bool tomatoTrigger;
//    private bool bunnyTrigger;

//    public bool FenceTrigger
//    {
//        get
//        {
//            return fenceTrigger;
//        }
//    }

//    public bool TomatoTrigger
//    {
//        get
//        {
//            return tomatoTrigger;
//        }
//    }

//    public bool BunnyTrigger
//    {
//        get
//        {
//            return bunnyTrigger;
//        }
//    }

//	// Use this for initialization
//	void Start () {
//        anim = GetComponent<Animator>();
//        sprite = GetComponent<SpriteRenderer>();
//        motorcycle = GetComponent<AudioSource>();
//        sortingName = "guessItems";
//        sortingOrder = 3;
//        initializeGameVars();
//    }

//    public void initializeGameVars()
//    {
//        fenceTrigger = false;
//        tomatoTrigger = false;
//        bunnyTrigger = false;
//    }

//    // Update is called once per frame
//    void Update () {

//        if (bunny1.Instance.BunnyTrigger)
//        {
//            anim.Play("Seek&Destroy");
//        }

//	}

//    public void fenceCrash()
//    {
//        fenceTrigger = true;
//    }

//    public void tomatoHit()
//    {
//        tomatoTrigger = true;
//        sprite.sortingLayerName = sortingName;
//        sprite.sortingOrder = sortingOrder;
//    }

//    public void nextBunny()
//    {
//        bunnyTrigger = true;
//    }

//    public void CycleSound()
//    {
//        motorcycle.PlayOneShot(motorcycle.clip);
//    }

//}
