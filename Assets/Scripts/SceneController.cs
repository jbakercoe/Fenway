using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {

    private Animator anim;

    private int sceneIndex = 1;
    private string[] scenes = { "Opening", "Gameplay" };

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}    

    public void fadeIn()
    {

        anim.Play("FadeIN");

    }

    public void fadeOut()
    {
        Debug.Log("fadeOUT");
        anim.Play("FadeOUT");

    }

    public void changeScene()
    {
        SceneManager.LoadScene("Gameplay");
    }

}
