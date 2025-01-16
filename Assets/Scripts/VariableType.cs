using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableType : MonoBehaviour
{
    // 필드
    static public bool staticVariable = true; // 정적 변수
    private int m_GlovalVariable = 1; // 전역 변수
    public int abCde = 5; // 유니티 에디터에서 보여진다
    public string STR = "hi!";
    // const / readonly 
    const float pi = 3.14f;

    void Start()
    {
        int localVariable = 1; // 지역 변수
        int localVariable2;
        //Debug.Log(localVariable2.ToString());
        LocalVariable(1/*매개변수*/);
        Debug.Log("abcde:" + abCde);
        Debug.Log(STR);
        
        float npi = pi + 10;
    }

    void LocalVariable(int parameter/*매개 변수*/)
    {
        float localVariable = parameter; // 지역 변수
    }
}
