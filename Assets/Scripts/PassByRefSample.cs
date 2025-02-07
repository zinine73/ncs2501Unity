using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class PassByRefSample : MonoBehaviour
{
    void Start()
    {
        int a = 1, b = 2;
        int c = 0;
        bool b1 = PassByValue(a, b, c);
        Debug.Log($"PassByValue c:{c}");
        b1 = RefMethod(a, b, ref c);
        Debug.Log($"PassByRef c:{c}");

        int d = 3, e = 4;
        int f;
        bool b2 = OutMethod(d, e, out f);
    }

    bool PassByValue(int a, int b, int c)
    {
        c = a + b;
        return true;
    }

    bool RefMethod(int a, int b, ref int c)
    {
        c = a + b;
        return true;
    }

    bool OutMethod(int d, int e, out int f)
    {
        f = d + e;
        return true;
    }
}
