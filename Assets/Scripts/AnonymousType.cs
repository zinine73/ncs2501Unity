using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnonymousType : MonoBehaviour
{
    delegate int MyDelegate(int a, int b);

    void Start()
    {
        var i = 3;
        var f = 1.0f;
        var s = "abc";
        var t = new {name="Codezero", age=47};

        //Debug.Log($"{i}, {f}, {s}, {t.name}, {t.age}");

        MyDelegate sum;
        sum = Amethod;
        sum = delegate(int a, int b) { return a + b; };
    }

    private int Amethod(int a, int b)
    {
        return a + b;
    }
}
