using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;
using UnityEngine;

public class JumpExample : MonoBehaviour
{
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            if (i == 3)
            {
                goto label;
            }
            if (i < 7)
            {
                Debug.Log($"i:{i}");
                continue;
                //Debug.Log("under continue");
            }
            Debug.Log(i);
        }

        Debug.Log("upper label");
        label:
        Debug.Log($"last");
        /*
        int n = 2;
        switch (n)
        {
            case 1:
                break;

            case 2:
                for (int i = 0; i < 5; i++)
                {
                    if (i == 3)
                    {
                        break;
                    }
                    Debug.Log($"n:{n}, i:{i}");
                }
                break;

            default:
                break;
        }

        for (int k = 0; k < 2; k++)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i == 5)
                {
                    break;
                }
                Debug.Log($"k:{k}, i:{i}");
            }
        }
        */
    }
}
