using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Presentation/Presentation Manager")]
public class PresentationManager : MonoBehaviour
{
    private Slide[] Slides;
    private int slideIndex;

    void Start()
    {
        Slides = GetComponent<Transform>().GetComponentsInChildren<Slide>();
        Slides[0].Show();
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.RightArrow) && slideIndex < Slides.Length - 1)
        {
            Slides[slideIndex].Hide();
            slideIndex++;
            Slides[slideIndex].Show();
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow) && slideIndex > 0)
        {
            Slides[slideIndex].Hide();
            slideIndex--;
            Slides[slideIndex].Show();
        }
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Quit();
        }
    }

    public void Quit()
    {
        Application.Quit();
    }
}
