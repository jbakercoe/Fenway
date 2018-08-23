using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class CrashReceiver : MonoBehaviour {

    [SerializeField]
    Bunny bunny;
    [SerializeField]
    float crashDelay;
    [SerializeField]
    string animationName;

    Animator anim;

	// Use this for initialization
	void Start () {
        if(bunny != null)
            bunny.NotifyOfCrash += OnImpact;
        anim = GetComponent<Animator>();
	}
	
    void OnImpact()
    {
        StartCoroutine(ReactToCrash());
    }

    IEnumerator ReactToCrash()
    {
        yield return new WaitForSeconds(crashDelay);
        anim.Play(animationName);
    }

}
