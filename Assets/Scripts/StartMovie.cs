using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartMovie : MonoBehaviour
{
    private MovieTexture movie;

    void Start()
    {
        movie = (MovieTexture)GetComponent<RawImage>().texture;
        movie.loop = true;
    }

    public void Play()
    {
        movie.Play();
    }

    public void Stop()
    {
        movie.Stop();
    }
}
