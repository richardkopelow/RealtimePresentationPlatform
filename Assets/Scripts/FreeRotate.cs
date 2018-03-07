using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeRotate : MonoBehaviour
{
    public Vector3 AxisCoefficient;
    public float Rate;

    private Transform trans;

    void Start()
    {
        trans = GetComponent<Transform>();
    }

    void Update()
    {
        trans.Rotate(AxisCoefficient * Rate * Time.deltaTime, Space.Self);
    }
}
