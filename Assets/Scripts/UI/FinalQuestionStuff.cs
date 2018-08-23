using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalQuestionStuff : CanvasScript {

    #region Serialized Variables

    [SerializeField]
    List<string> texts;
    [SerializeField]
    InputField inputField;
    [SerializeField]
    Text prompt;
    [SerializeField]
    Button nextButton;
    [SerializeField]
    Button submitButton;
    [SerializeField]
    List<Bunny> bunnies;
    [SerializeField]
    AudioClip recordScratch;

    #endregion

    int textIndex;

    public delegate void EndSignal();
    public EndSignal SendTheBunnies;
    
	// Use this for initialization
	void Start () {
        textIndex = 0;
        prompt.text = texts[textIndex];
        inputField.gameObject.SetActive(false);
        submitButton.gameObject.SetActive(false);
	}

    public override void Activate(float delay = 0)
    {
        foreach(Transform child in transform)
        {
            child.gameObject.SetActive(true);
        }
        inputField.gameObject.SetActive(false);
        submitButton.gameObject.SetActive(false);
    }

    /// <summary>
    /// Called when clicked on Next Arrow.
    /// Changes the text that the user sees.
    /// Pulls up UI when done
    /// </summary>
    public void Advance()
    {
        textIndex++;
        if(textIndex < texts.Count)
        {
            prompt.text = texts[textIndex];
            if(textIndex == texts.Count - 1)
            {
                nextButton.gameObject.SetActive(false);
                StartCoroutine(MakeInputAppear());
            }
        }
    }

    /// <summary>
    /// Waits 2 seconds then renders the inputField and Submit Button
    /// </summary>
    IEnumerator MakeInputAppear()
    {
        yield return new WaitForSeconds(2f);
        inputField.gameObject.SetActive(true);
        submitButton.gameObject.SetActive(true);
    }

    /// <summary>
    /// Starts Bunny scene after player answers the final question
    /// </summary>
    public void OnFinalSubmit()
    {
        Deactivate();
        // Shakes the main camera
        Camera.main.GetComponent<Animator>().Play("shake");
        MusicPlayer.Instance.StopMusic();
        SoundPlayer.Instance.Play(recordScratch);
        foreach(Bunny bunny in bunnies)
        {
            bunny.Enter();
        }
    }

}
