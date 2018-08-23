using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class TestAnimationSender : MonoBehaviour {

    [SerializeField]
    string animName;

    Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        anim.Play(animName);
	}
	
}
