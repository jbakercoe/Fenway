//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class WormManager : MonoBehaviour {

//    private SpriteRenderer sprite;
//    private Animator anim;
//    private string sortingName = "guessItems";
//    private int sortingOrder = 1;

//    [SerializeField] private string animName;

//    // Use this for initialization
//    void Start()
//    {

//        sprite = GetComponent<SpriteRenderer>();
//        anim = GetComponent<Animator>();

//    }

//    // Update is called once per frame
//    void Update()
//    {

//        if (GameManager.Instance.WormVisible)
//        {
//            //showItem();
//            sprite.sortingLayerName = sortingName;
//            sprite.sortingOrder = sortingOrder;
//        }

//        if (GameManager.Instance.CritterTrigger)
//        {
//            hide();
//        }

//    }

//    private void hide()
//    {
//        anim.Play(animName);
//    }

//}
