using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonContainer : MonoBehaviour
{

    private Animator anim;
    private bool hasRan;
    [SerializeField] private string animName;


    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        hasRan = false;
    }

    void Update()
    {
        if (GameManager.Instance.FlyIsStopped && !hasRan)
        {
            anim.Play(animName);
            hasRan = true;
        }
    }

}
