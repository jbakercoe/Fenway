using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    protected int id;
    protected SpriteRenderer sprite;
    protected string sortingName;
    protected int sortingOrder;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public ItemManager(int idNum, string layerName, int order)
    {
        id = idNum;
        sprite = GetComponent<SpriteRenderer>();
        sortingName = layerName;
        sortingOrder = order;
    }

    protected void showItem()
    {
        sprite.sortingLayerName = sortingName;
        sprite.sortingOrder = sortingOrder;
    }
}
