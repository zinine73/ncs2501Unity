using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class CancelationTokenExample : MonoBehaviour
{
    CancellationTokenSource m_CTS;
    Task<int> m_Task;

    void Start()
    {
        m_CTS = new CancellationTokenSource();
        CancellationToken ct = m_CTS.Token;
        m_Task = Task.Factory.StartNew(TaskMethod, ct);    
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            m_CTS.Cancel();
            if (m_Task != null)
            {
                Debug.Log($"Count : {m_Task.Result}");
            }
        }
    }

    int TaskMethod()
    {
        int count = 0;
        for (int i = 0; i < 10; i++)
        {
            if (m_CTS.Token.IsCancellationRequested)
            {
                break;
            }
            ++count;
            Thread.Sleep(1000);
        }
        return count;
    }
}
