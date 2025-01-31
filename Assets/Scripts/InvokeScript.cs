using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class InvokeScript : MonoBehaviour
{
    enum State { make, stop };
    State state = State.make;
    public GameObject target;
    void Start()
    {
        InvokeRepeating("SpawnObject", 2, 1);
        state = State.make;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (state == State.make)
            {
                CancelInvoke("SpawnObject");
                state = State.stop;
            }
            else if (state == State.stop)
            {
                InvokeRepeating("SpawnObject", 1, 1);
                state = State.make;
            }
        }
    }

    void SpawnObject()
    {
        int a = Random.Range(1, 10);
        float x = Random.Range(-2.0f, 2.0f);
        float z = Random.Range(-2.0f, 2.0f);
        Instantiate(target, new Vector3(x,3,z), Quaternion.identity);
    }
}
