using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasScript : MonoBehaviour {

    public void Deactivate(float delay = 0f)
    {
        StartCoroutine(SetChildren(false, delay));
    }

    public virtual void Activate(float delay = 0f)
    {
        StartCoroutine(SetChildren(true, delay));
    }

    IEnumerator SetChildren(bool isActive, float delay = 0f)
    {
        yield return new WaitForSeconds(delay);
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(isActive);
        }
    }

}
