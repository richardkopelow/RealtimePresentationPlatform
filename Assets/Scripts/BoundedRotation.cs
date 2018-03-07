using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundedRotation : MonoBehaviour
{
    public Vector3 Axis;
    public float Angle;
    public float Duration = 1;

    public bool AtMax;

    private Transform trans;
    private bool isRotating;

    private void Start()
    {
        trans = GetComponent<Transform>();
    }

    public void Rotate()
    {
        if (!isRotating)
        {
            StartCoroutine(rotate());
        }
    }

    private IEnumerator rotate()
    {
        isRotating = true;
        float rotation = 0;
        float direction = AtMax ? -1 : 1;

        while (rotation < Angle)
        {
            float delta = Angle * Time.deltaTime / Duration;
            rotation += delta;
            trans.Rotate(Axis, delta * direction);
            yield return null;
        }
        isRotating = false;
        AtMax = !AtMax;
    }
}
