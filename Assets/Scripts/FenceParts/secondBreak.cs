using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secondBreak : MonoBehaviour {

    [SerializeField] private string animName;
    private Animator anim;
    private bool hasCalled = false;

	// Use this for initialization
	void Start ()
    {
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {

        if (bunny2.Instance.FenceTrigger && !hasCalled)
        {
            anim.Play(animName);
            hasCalled = true;
        }

	}

}
