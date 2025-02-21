using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TryCatchExample : MonoBehaviour
{
    GameObject go;
    void Start()
    {
        //go = new GameObject();
        try
        {
            Debug.Log(go.name);
        }
        catch(DivideByZeroException dz)
        {
            Debug.Log($"나누기 0 예외 : {dz}");
        }
        catch(IndexOutOfRangeException ne)
        {
            Debug.LogWarning($"IOR~ 발생 : {ne}");
        }
        // Exception 은 마지막에 쓴다
        catch(Exception ex)
        {
            Debug.LogWarning($"예외 발생!!! : {ex}");
        }
        Debug.Log("끝");
    }

    void Example2()
    {
        try
        {
            Debug.Log(go.name);
        }
        catch(Exception ex)
        {
            Debug.LogWarning($"예외 발생!!! : {ex}");
        }
        finally
        {
            Debug.Log("여기는 실행됩니다");
        }
        // 위에 catch가 없고 에러나는 상황이면 실행 안됨
        Debug.Log("여기는 실행될때도 있고 아닐때도 있습니다");
    }

    void Example1()
    {
        try
        {
            Debug.Log(go.name);
        }
        catch (Exception ex)
        {
            Debug.LogWarning($"예외 발생!!! : {ex}");
        }
        Debug.Log("여기도 실행됨");
    }
}
