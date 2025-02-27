using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateDemo : MonoBehaviour
{
    // delagate 선언
    private delegate float SumHandler(float a, float b);

    // 델리게이트 타임의 변수 선언
    private SumHandler sumHandler;

    // 덧셈연산 함수
    private float Sum(float a, float b)
    {
        return a + b;
    }

    void Start()
    {
        // 델리게이트 변수에 함수(메서드) 연결(할당)
        sumHandler = Sum;

        // 델리게이트 실행
        float sum = sumHandler(10.05f, 5.0f);
        //float sum = Sum(10.05f, 5.0f);

        // 결과값 출력
        Debug.Log($"Sum = {sum}"); 
    }
}
