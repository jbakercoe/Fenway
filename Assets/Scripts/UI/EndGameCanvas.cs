using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameCanvas : CanvasScript {

    [SerializeField]
    Bunny lastBunny;
    [SerializeField]
    StartCanvas startCanvas;

    void Start()
    {
        lastBunny.NotifyOfFinish += ReadyToLoad;
        foreach(Transform child in transform)
        {
            child.gameObject.SetActive(false);
        }
    }

    void ReadyToLoad()
    {
        Activate(4f);
    }

    //void Activate()
    //{
    //    StartCoroutine(Pause());
    //}

    //IEnumerator Pause()
    //{
    //    yield return new WaitForSeconds(2f);
    //    foreach (Transform child in transform)
    //    {
    //        child.gameObject.SetActive(true);
    //    }
    //}

    public void BackToMenu()
    {
        SceneLoader.LoadScene(0);
    }

    public void ResetGame()
    {
        Deactivate();
        ItemRenderer[] objects = GameObject.FindObjectsOfType<ItemRenderer>();
        foreach (ItemRenderer item in objects)
        {
            print("Resseting " + item.gameObject.name);
            item.ResetPosition();
        }
        startCanvas.Activate(0.5f);
    }

}
