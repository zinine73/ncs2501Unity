using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] Avengers = new string[] {"Iron Man", "Captain America", "Spider Man"};
        string[] DCComics = new string[4];
        DCComics[0] = "Super Man";
        DCComics[1] = "Bat Man";
        DCComics[2] = "Aqua Man";
        DCComics[3] = "Wonder Woman";

        //string[,] Heroes = new string[2, 3]{{"IM","CA","SM"},{"SM","BM","AM"}};
        //string[,] Heroes = new string[,]{{"IM","CA","SM"},{"SM","BM","AM"}};
        var Heroes = new string[,]{{"IM","CA","SM"},{"SM","BM","AM"}};

        //string[][] NewHeroes = new string[2][];
        //NewHeroes[0] = new string[3]{"IM","CA","SM"};
        //NewHeroes[1] = new string[4]{"SM","BM","AM","WW"};
        // string[][] NewHeroes = new string[][]
        // {
        //     new string[]{"IM","CA","SM"},
        //     new string[]{"SM","BM","AM","WW"}
        // };
        string[][] NewHeroes = 
        {
            new string[]{"IM","CA","SM"},
            new string[]{"SM","BM","AM","WW"}
        };
        
        {
            Debug.Log(Heroes[1,1]);
            Debug.Log(NewHeroes[1][1]);
        }
    }

    public void TwoDA2OneDA()
    {
        int[,] array2d = new int[,]{{1,2},{3,4},{5,6}};
        int[] array1d 
        = new int[array2d.GetLength(0) * array2d.GetLength(1)];

        // 2D -> 1D
        for (int i = 0; i < array2d.GetLength(0); i++)
        {
            for (int k = 0; k < array2d.GetLength(1); k++)
            {
                array1d[array2d.GetLength(1) * i + k]
                = array2d[i, k];
            }
        }
    }
}
