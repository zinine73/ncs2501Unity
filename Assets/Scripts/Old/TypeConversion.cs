using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypeConversion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int i1 = 1;
        float f1 = i1;

        float x = 1.234f;
        int a = (int)x;

        byte[] bytes = {0,1,2,34};
        int i = BitConverter.ToInt32(bytes, 0);

        string s1 = "12345";
        int i2 = int.Parse(s1);
        string s2 = "123.45";
        float f2 = float.Parse(s2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
