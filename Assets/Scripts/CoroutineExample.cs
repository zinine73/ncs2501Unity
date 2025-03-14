using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineExample : MonoBehaviour
{
    private IEnumerator m_Coroutine;
    public static readonly WaitForSeconds m_waitForSecond2s = new WaitForSeconds(2f);
    private bool m_IsBreak;
    private bool m_IsCoroutineing;
    void Start()
    {
        m_Coroutine = CoroutineMethod();
        //StartCoroutine(m_Coroutine);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            StartCoroutine(m_Coroutine);
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            //StopCoroutine(m_Coroutine);
            m_IsBreak = true;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            //StopAllCoroutines();
            m_IsBreak = false;
            m_Coroutine = CoroutineMethod();
            StartCoroutine(m_Coroutine);
        }

        if (m_IsCoroutineing)
        {
            Debug.Log("코루틴이 실행 전이거나 종료되었음");
        }
    }

    IEnumerator CoroutineMethod()
    {
        int count = 0;
        while (true)
        //while (!m_IsBreak)
        {
            if (m_IsBreak)
                break;

            Debug.Log(count);
            //yield return new WaitForSeconds(1.0f);
            yield return m_waitForSecond2s;
            count++;
        }
        /*
        m_IsCoroutineing = true;
        Debug.Log("시작");
        yield return new WaitForSeconds(1.0f);
        Debug.Log("종료");
        m_IsCoroutineing = false;
        */
    }
}
