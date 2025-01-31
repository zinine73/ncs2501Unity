using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : MonoBehaviour
{
    int numEnemies = 3;
    void Start()
    {
        ForeachLoop();
    }

    void ForLoop()
    {
        int ii = 0, b = 0;
        for (int i = 0; i < 10; i++)
        {
            b++;
        }
        for (int i2 = 0; i2 < numEnemies; i2++)
        {
            Debug.Log("Creating enemy number: " + i2);
        }
        for (int i = numEnemies; i >= 0; i--)
        {
            Debug.Log("minus for : " + i);
        }
    }

    void WhileLoop()
    {
        int cupInTheSink = 4;
        while (cupInTheSink > 0)
        {
            //Debug.Log("I've washed a cup!");
            cupInTheSink--;
        }

        cupInTheSink = 4;
        for (int i = cupInTheSink; i > 0; i--)
        {
            Debug.Log("I've washed a cup!");
        }
    }

    void DoWhile()
    {
        bool shouldContinue = false;
        do
        {
            print("Hello World");
        } while (shouldContinue == true);
    }

    void ForeachLoop()
    {
        var strings = new string[3];
        strings[0] = "First string";
        strings[1] = "Second string";
        strings[2] = "Third string";

        foreach (var item in strings)
        {
            print(item);
        }

        for (int i = 0;i < strings.Length; i++)
        {
            if (i == 0) 
            {
                print("start!");
            }
            print(strings[i]);
        }
    }
}
