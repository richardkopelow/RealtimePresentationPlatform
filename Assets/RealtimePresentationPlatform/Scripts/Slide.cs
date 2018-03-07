using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Slide : MonoBehaviour
{

    public GameObject VCam;

    public UnityEvent OnShow;
    public UnityEvent OnHide;

    public void Show()
    {
        VCam.SetActive(true);
        OnShow.Invoke();
    }

    public void Hide()
    {
        VCam.SetActive(false);
        OnHide.Invoke();
    }
}
