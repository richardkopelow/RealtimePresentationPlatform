using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Cinemachine;

public class Slide : MonoBehaviour
{

    public GameObject VCam;

    public UnityEvent OnShow;
    public UnityEvent OnHide;

    public void Show()
    {
        VCam.SetActive(true);
        StartCoroutine(show());
    }

    private IEnumerator show()
    {
        yield return null;
        CinemachineBrain brain = Camera.main.GetComponent<CinemachineBrain>();
        yield return new WaitWhile(() => brain.IsBlending);
        OnShow.Invoke();
    }

    public void Hide()
    {
        VCam.SetActive(false);
        OnHide.Invoke();
    }
}
