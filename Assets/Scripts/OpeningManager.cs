using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpeningManager : Singleton<OpeningManager> {

    private bool hasLoaded;

    private static bool isMultipleChoiceMode = false;

    public static bool IsMultipleChoiceMode
    {
        get
        {
            return isMultipleChoiceMode;
        }
    }

    public bool HasLoaded
    {
        get
        {
            return hasLoaded;
        }
    }

    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void startScene()
    {
        hasLoaded = true;
    }

    public void nextScene()
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void multipleGuessMode()
    {
        isMultipleChoiceMode = true;
        nextScene();
    }

    public void typeMode()
    {
        isMultipleChoiceMode = false;
        nextScene();
    }

}
