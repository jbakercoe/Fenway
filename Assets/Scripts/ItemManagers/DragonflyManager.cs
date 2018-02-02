using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonflyManager : MonoBehaviour {

    private SpriteRenderer sprite;
    private string sortingName = "guessItems";
    private int sortingOrder = 0;
    private Animator anim;
    private Animator parentAnim;
    private GameObject parent;
    private bool hasFlown;
    [SerializeField] private string left;
    [SerializeField] private string right;

    // Use this for initialization
    void Start()
    {

        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        hasFlown = false;

    }

    // Update is called once per frame
    void Update()
    {

        if (GameManager.Instance.DragonflyVisible)
        {
            //showItem();
            sprite.sortingLayerName = sortingName;
            sprite.sortingOrder = sortingOrder;
        }

        if (GameManager.Instance.CritterTrigger && !hasFlown)
        {
            if (sprite.flipX)
            {
                //Debug.Log("flipX");
                flyAway(left);
            }
            else
            {
                //Debug.Log("!flipX");
                flyAway(right);
            }
        }

    }

    private void flyAway(string animName)
    {
        //Debug.Log("fly away");
        anim.Play(animName);
        hasFlown = true;
    }

    public void endAnim()
    {
        GameManager.Instance.killDragonfly();
    }

    public void kill()
    {
        //Debug.Log("Kill");
        Destroy(gameObject);
    }

}
