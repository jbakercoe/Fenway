using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Quit {

    public static void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }

}
