using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatementSample : MonoBehaviour
{
    enum EAvengers { IronMan, SpiderMan, Hulk };
    void Start()
    {
        EAvengers avengers = EAvengers.SpiderMan;
        switch (avengers)
        {
            case EAvengers.IronMan:
            case EAvengers.Hulk:
                Debug.Log(avengers);
                break;
            case EAvengers.SpiderMan:
                Debug.Log(avengers.ToString());
                break;
            default:
                Debug.Log("no avengers");
                break;
        }

        if ((avengers == EAvengers.IronMan) 
            || (avengers == EAvengers.Hulk))
        {
            Debug.Log(avengers);
        }
        else if (avengers == EAvengers.SpiderMan)
        {
            Debug.Log(avengers.ToString());
        }
        else
        {
            Debug.Log("no avengers");
        }
        // int i1 = 1, i2 = 2;
        // if (i1 < i2)
        // { 
        //     Debug.Log("It's true.");
        // }
        // else if (i1 > i2)
        // {
        //     Debug.Log("....");
        // }
        // else 
        // {
        //     Debug.Log("False.");
        //     return;
        // }
    }

    void Update()
    {
        
    }
}
