using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateExample : MonoBehaviour
{
    delegate int CalculateDelegate(int a, int b);
    //delegate T CalculateDelegate<T>(T a, T b);

    void Start()
    {
        CalculateDelegate cd = Add;
        cd += Add;
        cd += Subtract;
        cd -= Add;
        cd += Subtract;
        cd = Add;
        cd(3,2);
        
        CalculateDelegate Plus = new CalculateDelegate(Add);
        CalculateDelegate Minus = Subtract;
        // DebugLog(1, 2, Plus);
        // DebugLog(1, 2, Add);
        // DebugLog(4, 3, Minus);
        // DebugLog(10, 3, Subtract);

        Plus += Add;
        Plus -= Add;
        Plus += Subtract;
        Plus += Add;
        DebugLog(1,2,Plus);
    }

    void DebugLog(int a, int b, CalculateDelegate cd)
    {
        Debug.Log(cd(a,b));
    }

    int Add(int a, int b)
    {
        Debug.Log($"Add:{a}+{b}");
        return a + b;
    }

    int Subtract(int a, int b)
    {
        Debug.Log($"Sub:{a}-{b}");
        return a - b;
    }
}
