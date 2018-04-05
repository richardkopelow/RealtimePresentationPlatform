using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Prefab;

    private Transform trans;

    private void Start()
    {
        trans = GetComponent<Transform>();
    }

    public void Spawn()
    {
        Instantiate(Prefab, trans.position, Quaternion.identity);
    }
}
