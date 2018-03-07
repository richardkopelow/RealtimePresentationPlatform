using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotController : MonoBehaviour
{
    private Animator anim;
    
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void Play()
    {
        StartCoroutine(play());
    }

    IEnumerator play()
    {
        yield return new WaitForSeconds(2);
        anim.SetBool("Animate", true);
    }

    public void Stop()
    {
        anim.SetBool("Animate", false);
    }
}
