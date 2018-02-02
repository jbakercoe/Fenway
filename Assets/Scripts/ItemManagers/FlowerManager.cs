using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerManager : MonoBehaviour
{
    private SpriteRenderer sprite;
    private Animator anim;
    private string sortingName = "guessItems";
    [SerializeField] private int sortingOrder = 0;
    [SerializeField] private string animName = "";
    //private int id = 2;

    //private ItemManager carrot;

    //public CarrotManager(int idNum, string layerName, int order) : base(idNum, layerName, order)
    //{

    //}

    // Use this for initialization
    void Start()
    {

        //carrot = gameObject.AddComponent<ItemManager>();
        //carrot.id = 4;
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

        if (GameManager.Instance.FlowerVisible)
        {
            //showItem();
            sprite.sortingLayerName = sortingName;
            sprite.sortingOrder = sortingOrder;
        }

        if (bunny1.Instance.FlowerTrigger)
        {
            anim.Play(animName);
        }

    }

}
