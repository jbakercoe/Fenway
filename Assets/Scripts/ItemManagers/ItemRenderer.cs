using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class ItemRenderer : MonoBehaviour
{
    [SerializeField]
    bool ignoreScript;

    SpriteRenderer spriteRenderer;
    Vector3 startPosition;

    void Awake()
    {
        if (!ignoreScript)
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
            spriteRenderer.enabled = false;
        }
        startPosition = transform.position;
    }

    public void ShowItem()
    {
        spriteRenderer.enabled = true;
    }

    public void ResetPosition()
    {
        Animator anim = GetComponent<Animator>();
        if (anim != null)
            anim.SetTrigger("Reset");
    }
}
