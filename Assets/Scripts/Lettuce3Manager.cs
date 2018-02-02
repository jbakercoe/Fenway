using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lettuce3Manager : MonoBehaviour
{

    private SpriteRenderer sprite;
    private Animator anim;
    [SerializeField] private string sortingName;
    [SerializeField] private int sortingOrder;
    [SerializeField] private string animName;

    // Use this for initialization
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.LettuceVisible)
        {
            sprite.sortingLayerName = sortingName;
            sprite.sortingOrder = sortingOrder;
        }

        if (bunny2.Instance.FenceTrigger)
        {
            anim.Play(animName);
        }

    }
}