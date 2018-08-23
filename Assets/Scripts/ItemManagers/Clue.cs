using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[CreateAssetMenu(fileName = "Clue", menuName = "Clue")]
public class Clue : MonoBehaviour
{
    [SerializeField]
    List<string> answers;
    [SerializeField]
    string question;
    [SerializeField]
    List<string> options;
    [SerializeField]
    List<ItemRenderer> items;

    public string Question { get { return question; } }
    public List<string> Answers { get { return answers; } }
    public List<string> Options { get { return options; } }

    public void OnCorrectAnswer()
    {
        foreach(ItemRenderer item in items)
        {
            item.ShowItem();
        }
    }

}
