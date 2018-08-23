//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class FenceManager : MonoBehaviour
//{
//    public static bool needToReset = false;
//    private SpriteRenderer sprite;
//    private string sortingName = "Default";
//    private bool isShowing;
//    [SerializeField] private int sortingOrder = 1;
//    [SerializeField] private float xPos;
//    [SerializeField] private float yPos;

//    //private ItemManager fence;

//    //public FenceManager(int idNum, string layerName, int order) : base(idNum, layerName, order)
//    //{

//    //}

//    // Use this for initialization
//    void Start()
//    {

//        //fence = new ItemManager(0, "Default", 1);
//        sprite = GetComponent<SpriteRenderer>();
//        isShowing = false;

//    }

//    // Update is called once per frame
//    void Update()
//    {

//        if (GameManager.Instance.FenceVisible && !isShowing)
//        {
//            //showItem();
//            sprite.sortingLayerName = sortingName;
//            sprite.sortingOrder = sortingOrder;
//            isShowing = true;
//        } 

//        //if (needToReset)
//        //{
//        //    needToReset = false;
//        //    isShowing = false;
//        //}

//    }

//}
