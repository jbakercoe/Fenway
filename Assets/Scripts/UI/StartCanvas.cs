using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCanvas : CanvasScript {

    [SerializeField]
    string openingText;
    [SerializeField]
    QuestionCanvas questionCanvas;

	// Use this for initialization
	void Start () {
        questionCanvas.Deactivate();
	}

    public void StartGame()
    {
        Deactivate();
        questionCanvas.Activate();
    }

}
