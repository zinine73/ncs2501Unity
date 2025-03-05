using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuncActionExample : MonoBehaviour
{
    void Start()
    {
        Func<int> f1 = () => 1;
        Debug.Log($"f1:{f1()}");

        //Func<int, int> f2o = (a) => { return a * 2; };
        Func<int, int> f2 = (a) => a * 2;
        Debug.Log($"f2:{f2(3)}");
        
        Debug.Log($"f3:{ff3(1.2f)}");
        Func<float, int> f3 = (f) => (int)f + 3;
        Debug.Log($"f3:{f3(1.2f)}");
       
        Action a1 = () => Debug.Log("Action");
        a1();

        Action<int, int> a2 = (x, y) => Debug.Log($"{x} + {y} : {x + y}");
        a2(4, 6);
    }

    private int ff3(float f)
    {
        return (int)f + 3;
    }
}
