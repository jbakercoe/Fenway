//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class firstBreak : MonoBehaviour {

//    [SerializeField] private string animName;
//    [SerializeField] private string idleAnimName;

//    private Animator anim;
//    private bool animHasPlayed;
    

//	// Use this for initialization
//	void Start () {
//        anim = GetComponent<Animator>();
//        animHasPlayed = false;
//	}
	
//	// Update is called once per frame
//	void Update () {
//        if (bunny1.Instance.FenceTrigger && !animHasPlayed)
//        {
//            anim.Play(animName);
//            animHasPlayed = true;
//        }
//        if(!GameManager.Instance.FenceVisible && animHasPlayed)
//        {
//            anim.Play(idleAnimName);
//            animHasPlayed = false;
//        }

//    }

//}
