//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class bunny1 : Singleton<bunny1> {

//    private Animator anim;
//    private SpriteRenderer sprite;
//    private bool fenceTrigger;
//    private bool flowerTrigger;
//    private bool bunnyTrigger;
//    private AudioSource motorcycle;

//    public bool FenceTrigger
//    {
//        get
//        {
//            return fenceTrigger;
//        }
//    }

//    public bool FlowerTrigger
//    {
//        get
//        {
//            return flowerTrigger;
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
//        initializeGameVars();
//    }

//    public void initializeGameVars()
//    {
//        fenceTrigger = false;
//        flowerTrigger = false;
//        bunnyTrigger = false;
//    }

//    // Update is called once per frame
//    void Update () {
//        if (GameManager.Instance.BunnyTrigger)
//            anim.Play("Seek&Destroy");

//        if (flowerTrigger)
//        {
//            sprite.sortingLayerName = "guessItems";
//            sprite.sortingOrder = 3;
//        }

//	}

//    public void fenceCrash()
//    {
//        fenceTrigger = true;
//    }

//    public void flowerCrash()
//    {
//        flowerTrigger = true;
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
