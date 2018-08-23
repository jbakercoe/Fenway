using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CritterFlee : MonoBehaviour {
    
    [SerializeField]
    Transform target;
    [SerializeField] [Range(0f, 3f)]
    float moveSpeed = 1f;
    [SerializeField]
    List<string> animNames;

    float startTime;
    float journeyLength;
    Animator anim;
    SpriteRenderer spriteRenderer;

    void Start()
    {
        anim = GetComponent<Animator>();
        Camera.main.GetComponent<CameraAnimatorController>().NotifyOfDanger += RunAway;
        spriteRenderer = GetComponent<SpriteRenderer>();
        //StartCoroutine(TestRunAway());
    }

    IEnumerator TestRunAway()
    {
        yield return new WaitForSeconds(3f);
        print("Runnint!!!wd");
        RunAway();
    }

    /// <summary>
    /// Disables any animators and starts Coroutine that Lerps critter offscreen
    /// </summary>
    public void RunAway()
    {
        print("RunAway()");
        //anim.enabled = false;
        transform.parent.gameObject.GetComponent<Animator>().enabled = false;
        if(animNames.Count == 1 || !spriteRenderer.flipX)
        {
            anim.Play(animNames[0]);
        } else if (spriteRenderer.flipX)
        {
            anim.Play(animNames[1]);
        }
        //StartCoroutine(MoveToLocation());
    }

    IEnumerator MoveToLocation()
    {
        startTime = Time.deltaTime;
        Vector3 startPosition = transform.position;
        journeyLength = Vector3.Distance(startPosition, target.position);
        float distCovered = 0f;

        print(gameObject.name + " Start position " + startPosition);

        while(journeyLength - distCovered > 0.1f)
        {
            //Debug.Break();
            print("Moving Critter: " + gameObject.name);
            distCovered = (Time.time - startTime) * moveSpeed;
            float fracJourney = distCovered / journeyLength;
            transform.position = Vector3.Lerp(startPosition, target.position, fracJourney);
            print(gameObject.name + " new position " + transform.position);
            yield return null;
        }
    }

}
