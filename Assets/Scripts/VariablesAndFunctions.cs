using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{
    int myInt = 5;

    void Start()
    {
        myInt = MultiplyByTwo(myInt);
        Debug.Log("myInt : " + myInt);
        // 에러보이고 싶으면 LogError 사용
        Debug.LogError("Error!!!");
    }
    
    int MultiplyByTwo(int number)
    {
        int result;
        result = number * 2;
        return result;
    }
}
