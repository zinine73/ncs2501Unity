using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericClassExample : MonoBehaviour
{
    public class GenericsClass<T>
    {
        private T value;
        public GenericsClass(T value)
        {
            this.value = value;
        }
        public void Method1()
        {
            Debug.Log(value);
        }
    }

    void StartOld()
    {
        GenericsClass<int> genericsClass1 = new GenericsClass<int>(5);
        genericsClass1.Method1();
        GenericsClass<float> genericsClass2 = new GenericsClass<float>(5.1f);
        genericsClass2.Method1();
    }

    void Swap<T>(ref T x, ref T y)
    {
        var temp = y;
        y = x;
        x = temp;
    }

    void Start()
    {
        int ix = 1, iy = 2;
        Debug.Log($"before : ix:{ix}, iy:{iy}");
        Swap(ref ix, ref iy);
        Debug.Log($"after  : ix:{ix}, iy:{iy}");

        string sx = "ab", sy = "cd";
        Debug.Log($"before : sx:{sx}, sy:{sy}");
        Swap(ref sx, ref sy);
        Debug.Log($"after  : sx:{sx}, sy:{sy}");
    }
}
