using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class QuestionCanvas : CanvasScript {

    [SerializeField]
    List<Clue> clues;
    [SerializeField]
    InputField inputField;
    [SerializeField]
    Text promptText;
    [SerializeField]
    Text feedbackText;
    [SerializeField]
    GameObject choiceHolder;
    [SerializeField]
    FinalQuestionStuff finalCanvas;
    [SerializeField]
    AudioClip correctSound;
    [SerializeField]
    AudioClip incorrectSound;

    int currentClueIndex;
    Clue currentClue { get { return clues[currentClueIndex]; } }

	// Use this for initialization
	void Start () {
        currentClueIndex = 0;
        promptText.text = currentClue.Question;
        finalCanvas.Deactivate();
        if (GameModeInfo.isMultipleChoiceMode)
        {
            inputField.gameObject.SetActive(false);
            choiceHolder.gameObject.SetActive(true);
            // Assign text value to buttons
            for(int i = 0; i < choiceHolder.transform.childCount; i++)
            {
                GameObject choice = choiceHolder.transform.GetChild(i).gameObject;
                choice.GetComponentInChildren<Text>().text = currentClue.Options[i]; 
            }
        } else
        {
            inputField.gameObject.SetActive(true);
            choiceHolder.gameObject.SetActive(false);
            focusOnInput();
        }
    }

    // Overrides the Activate method to hide the incorrect input option
    public override void Activate(float delay = 0)
    {
        //base.Activate();
        foreach(Transform child in transform)
        {
            child.gameObject.SetActive(true);
        }
        feedbackText.text = "";
        if (GameModeInfo.isMultipleChoiceMode)
            inputField.gameObject.SetActive(false);
        else
        {
            choiceHolder.gameObject.SetActive(false);
            focusOnInput();
        }
    }

    void focusOnInput()
    {
        //not my code focus on input box
        EventSystem.current.SetSelectedGameObject(inputField.gameObject, null);
        inputField.OnPointerClick(new PointerEventData(EventSystem.current));
    }

    public void HandleGuess(int index)
    {
        HandleTheGuess(currentClue.Options[index]);
    }

    public void HandleTheGuess(string guess)
    {
        bool isCorrect = false;
        foreach (string answer in currentClue.Answers)
        {
            if (guess.ToLower().Contains(answer))
            {
                // We Got it right
                isCorrect = true;
                break;
            }
        }
        if (isCorrect)
        {
            // Right answer sequence
            OnCorrectGuess();
        } else
        {
            // Wrong answer sequence
            SoundPlayer.Instance.Play(incorrectSound);
            feedbackText.text = "Ooh, try agian";
            Animator feedbackAnim = feedbackText.gameObject.GetComponent<Animator>();
            feedbackAnim.Play("shake");
        }
    }

    void OnCorrectGuess()
    {
        feedbackText.text = "";
        currentClue.OnCorrectAnswer();
        SoundPlayer.Instance.Play(correctSound);
        GetNextClue();
    }

    void GetNextClue()
    {
        currentClueIndex++;
        if(currentClueIndex < clues.Count)
        {
            promptText.text = currentClue.Question;
            if (GameModeInfo.isMultipleChoiceMode)
            {
                for(int i = 0; i < choiceHolder.transform.childCount; i++)
                {
                    GameObject choice = choiceHolder.transform.GetChild(i).gameObject;
                    string option = currentClue.Options[i];
                    choice.GetComponentInChildren<Text>().text = option;
                    // if text is too long for button
                    if (option.Length > 9)
                    {
                        int fontSize = 20;
                        // reduce font size for every extra letter
                        for (int l = 10; l < option.Length; l++)
                        {
                            fontSize--;
                        }
                        choice.GetComponentInChildren<Text>().fontSize = fontSize;
                    }
                    else
                    {
                        choice.GetComponentInChildren<Text>().fontSize = 25;
                    }

                }
            } else
            {
                inputField.text = "";
                focusOnInput();
            }
        } else
        {
            Deactivate();
            finalCanvas.Activate();
        }
    }

}
