//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class BeeManager : MonoBehaviour {

//    private SpriteRenderer sprite;
//    private Animator anim;
//    private Animator parentAnim;
//    private GameObject parent;
//    [SerializeField] private string animName;
//    private string sortingName = "guessItems";
//    private int sortingOrder = 2;
//    //[SerializeField] private GameObject parent;

//    // Use this for initialization
//    void Start()
//    {

//        sprite = GetComponent<SpriteRenderer>();
//        anim = GetComponent<Animator>();

//    }

//    // Update is called once per frame
//    void Update()
//    {

//        if (GameManager.Instance.BeeVisible)
//        {
//            //showItem();
//            sprite.sortingLayerName = sortingName;
//            sprite.sortingOrder = sortingOrder;
//        }

//        if (GameManager.Instance.CritterTrigger)
//        {
//            flyAway();
//        }

//    }

//    private void flyAway()
//    {
//        anim.Play(animName);
//    }

    
//}
