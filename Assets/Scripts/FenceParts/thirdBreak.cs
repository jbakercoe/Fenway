//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class thirdBreak : MonoBehaviour {

//    public TomStemAnim stem;

//    private Animator anim;
//    private bool hasCalled;
//    private AudioSource audioSource;

//    [SerializeField] private string animName;
//    [SerializeField] private AudioSource boing;

//    // Use this for initialization
//    void Start () {
//        anim = GetComponent<Animator>();
//        hasCalled = false;
//        audioSource = GetComponent<AudioSource>();
//    }
	
//	// Update is called once per frame
//	void Update () {
//        if (bunny3.Instance.FenceTrigger && !hasCalled)
//        {
//            anim.Play(animName);
//            hasCalled = true;
//        }
//    }

//    public void cutTomatoPlant()
//    {
//        stem.cutStem();
//        playBoingSound();
//    }

//    private void playBoingSound()
//    {
//        boing.PlayOneShot(boing.clip);
//    }

//}
