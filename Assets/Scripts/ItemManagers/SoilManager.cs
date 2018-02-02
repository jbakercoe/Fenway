using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoilManager : MonoBehaviour
{
    //private ItemManager soil;
    private SpriteRenderer sprite;
    // can serialize these two and then can get rid of 
    [SerializeField] private string sortingName;// = "Default";
    [SerializeField] private int sortingOrder;// = 2;

    //public SoilManager(int idNum, string layerName, int order) : base(idNum, layerName, order)
    //{
    //    //    sprite = GetComponent<SpriteRenderer>();
    //    //    sortingName = layerName;
    //    //    sortingOrder = order;
    //}

    // Use this for initialization
    void Start()
    {

        //soil = new ItemManager(1, "Default", 2);
        sprite = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {

        if (GameManager.Instance.SoilVisible)
        {
            //showItem();
            sprite.sortingLayerName = sortingName;
            sprite.sortingOrder = sortingOrder;
        }

    }
}
