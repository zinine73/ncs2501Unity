using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveObject : MonoBehaviour
{
    void Start()
    {
        gameObject.SetActive(false);
        float x = transform.position.x;
    }
}
