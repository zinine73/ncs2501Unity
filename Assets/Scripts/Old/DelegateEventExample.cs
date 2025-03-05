using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class DelegateEventClass
{
    public delegate void DelegateMethod(string message);
    public event DelegateMethod EventMethod;

    public void Mutiple0f5(int number)
    {
        if (number % 5 == 0 && number != 0)
        {
            EventMethod($"{number}는 5의 배수");
        }
    }
}

public class DelegateEventExample : MonoBehaviour
{
    int sum = 0;
    void Start()
    {
        DelegateEventClass deClass = new DelegateEventClass();
        deClass.EventMethod += DebugLog;

        for (int i = 0; i < 30; i++)
        {
            deClass.Mutiple0f5(i);
        }
        Debug.Log($"5의 배수 갯수는 {sum}개");
    }

    void DebugLog(string message)
    {
        sum++;
        Debug.Log($"{message}, sum = {sum}");
    }
}
