using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningManager : MonoBehaviour {

    private bool hasLoaded;

    public bool HasLoaded
    {
        get
        {
            return hasLoaded;
        }
    }

    public void startScene()
    {
        hasLoaded = true;
    }

    public void nextScene()
    {
        SceneLoader.LoadScene(1);
    }

    public void multipleGuessMode()
    {
        GameModeInfo.isMultipleChoiceMode = true;
        nextScene();
    }

    public void typeMode()
    {
        GameModeInfo.isMultipleChoiceMode = false;
        nextScene();
    }

}
