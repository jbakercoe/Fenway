using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class FleeSpotPicker : MonoBehaviour {

    [SerializeField]
    CritterFlee fleeScript;
    [SerializeField]
    CritterFlee reverseFleeScript;

    public float delayTime;

    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (spriteRenderer.flipY)
        {
            fleeScript.enabled = true;
            reverseFleeScript.enabled = false;
        } else
        {
            reverseFleeScript.enabled = true;
            fleeScript.enabled = false;
        }
    }
    
}
