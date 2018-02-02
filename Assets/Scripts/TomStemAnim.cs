using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TomStemAnim : Singleton<TomStemAnim> {

    private Animator anim;
    private bool falling = false;

    public bool isFalling
    {
        get
        {
            return falling;
        }
    }

    [SerializeField] private string animName;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

    }

    public void cutStem()
    {
        anim.Play(animName);
        falling = true;
    }
}
