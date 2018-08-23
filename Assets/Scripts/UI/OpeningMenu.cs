using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningMenu : MonoBehaviour {

    [SerializeField]
    GameObject blackImage;

    public void LoadMultipleChoice()
    {
        GameModeInfo.isMultipleChoiceMode = true;
        blackImage.GetComponent<Animator>().SetTrigger("EndScene");
        SceneLoader.LoadScene(1);
    }

    public void LoadTyping()
    {
        GameModeInfo.isMultipleChoiceMode = false;
        blackImage.GetComponent<Animator>().SetTrigger("EndScene");
        SceneLoader.LoadScene(1);
    }

}
