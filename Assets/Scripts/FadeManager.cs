//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.SceneManagement;

//public class FadeManager : MonoBehaviour {

//    private Animator anim;
//    public GameObject canvasObject;
    
//	// Use this for initialization
//	void Start () {

//        anim = GetComponent<Animator>();

//	}

//    public void fadeOut()
//    {
//        anim.Play("fadeOut");
//    }

//    public void changeScene()
//    {
//        SceneManager.LoadScene("Gameplay");
//    }

//    public void playAgain()
//    {
//        SceneManager.LoadScene("Gameplay");
//        GameManager.Instance.stopEBGMusic();
//        Destroy(GameManager.Instance);
//        Destroy(bunny1.Instance);
//        Destroy(bunny2.Instance);
//        Destroy(bunny3.Instance);
//    }

//    public void changeModes()
//    {
//        SceneManager.LoadScene("Opening");
//        GameManager.Instance.stopEBGMusic();
//        GameManager.Instance.stopMainTheme();
//        //GameManager.Instance.resetGame();
//        Destroy(GameManager.Instance);
//        Destroy(bunny1.Instance);
//        Destroy(bunny2.Instance);
//        Destroy(bunny3.Instance);
//    }

//    public void hideUI()
//    {
//        //GameObject canvas = GameObject.FindGameObjectWithTag("canvas");
//        ////canvas.SetActive(false);
//        //Destroy(canvas);
//        canvasObject.gameObject.SetActive(false);
        
//    }

//    public void showUI()
//    {
//        canvasObject.SetActive(true);
//    }

//}
