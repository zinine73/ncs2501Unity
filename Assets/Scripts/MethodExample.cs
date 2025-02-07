using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodExample : MonoBehaviour
{
    public object temp;
    void Start()
    {
        int parameter1 = 1, parameter2 = 2;
        int intMethod = IntMethod(parameter1, parameter2);
        Debug.Log(intMethod);

        float parameter3 = 1.2f;
        VoidMethod(parameter3.ToString());
        VoidMethod(parameter3);
    }

    int IntMethod(int p1, int p2)
    {
        return (p1 + p2);
    }

    private void VoidMethod(string message)
    {
        Debug.Log(message);
        return; // 생략 가능
    }

    private void VoidMethod(float fv)
    {
        Debug.Log($"FLOAT:{fv}");
    }

    public void VoidMethod()
    {
        if (temp == string.Empty)
        {
            VoidMethod(temp.ToString());
        }
        else
        {
            VoidMethod((float)temp);
        }
    }
}
