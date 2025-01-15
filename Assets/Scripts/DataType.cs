using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataType : MonoBehaviour
{
    // 전역변수
    int gv;
    // Start is called before the first frame update
    void Start()
    {
        var i = 1;
        var f = 2f;
        var c = 'c';
        var s = "string";
        // 아래는 에러남
        //var v;

        //int age = 46;
        //int brother = 2;
        int age = 46, brother = 2;
        float f1 = 1.0f, f2 = 2.3f;
        int i1, i2 = 4, i3;
        // var는 한줄에 하나만 정의
        //var v1 = 1, v2 = 2;

        string str = new string("abc");

        int number1;
        number1 = 1;
        int newone = 2;
        float number3 = 3f, number4 = 4f;
        bool isBool = true; // false

        Debug.Log(number1.ToString());
        Debug.Log(newone.ToString());
        Debug.Log(number3.ToString());
        Debug.Log(number4.ToString());
        Debug.Log(isBool.ToString());

        // 값을 지정하지 않은 지역 변수는 사용하면 에러
        //Debug.Log(i1);
        // 전역변수는 값을 지정하지 않고도 사용할 수 있다
        Debug.Log("gv:" + gv);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
