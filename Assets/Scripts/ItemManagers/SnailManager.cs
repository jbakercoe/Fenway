using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnailManager : MonoBehaviour {

    private SpriteRenderer sprite;
    private string sortingName = "guessItems";
    private int sortingOrder = 3;

    // Use this for initialization
    void Start()
    {

        sprite = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {

        if (GameManager.Instance.SnailVisible)
        {
            //showItem();
            sprite.sortingLayerName = sortingName;
            sprite.sortingOrder = sortingOrder;
        }

    }
}
