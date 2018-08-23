using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class CameraAnimatorController : MonoBehaviour {

    //[SerializeField]
    //FinalQuestionStuff canvas;

    //Animator anim;

    //void Start()
    //{
    //    anim = GetComponent<Animator>();
    //    canvas.SendTheBunnies += Shake;
    //}

    ///// <summary>
    ///// Plays the animation to shake the camera
    ///// </summary>
    //void Shake()
    //{
    //    anim.Play("shake");
    //}

    public delegate void DangerSignal();
    public DangerSignal NotifyOfDanger;

    public void NotifyCritters()
    {
        NotifyOfDanger();
    }

    public void PlayBunnyTheme()
    {
        MusicPlayer.Instance.PlayEBG();
    }

}
