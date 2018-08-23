//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class LadybugManager : MonoBehaviour {

//    private SpriteRenderer sprite;
//    private string sortingName = "guessItems";
//    private int sortingOrder = 3;
//    private Animator anim;
//    private Animator parentAnim;
//    private bool didFlee;
//    [SerializeField] private string animName;

//    // Use this for initialization
//    void Start()
//    {
//        //Debug.Log("Start");
//        sprite = GetComponent<SpriteRenderer>();
//        anim = GetComponent<Animator>();
//        didFlee = false;

//    }

//    // Update is called once per frame
//    void Update()
//    {

//        if (GameManager.Instance.LadybugVisible)
//        {
//            //showItem();
//            sprite.sortingLayerName = sortingName;
//            sprite.sortingOrder = sortingOrder;
//        }

//        if (GameManager.Instance.CritterTrigger && !didFlee)
//        {
//            flyAway();
//        } 

//    }

//    private void flyAway()
//    {
//        anim.Play(animName);
//        didFlee = true;
//    }

//}
