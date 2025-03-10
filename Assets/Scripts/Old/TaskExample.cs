using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using System;

public class TaskExample : MonoBehaviour
{
    void Start()
    {
        Task.Factory.StartNew(() => { Debug.Log("Task"); }); // 직접 호출
        Task task2 = new Task(new Action(DebugLog)); // Action delegate
        task2.Start(); // Task 스레드 시작

        Task task3 = new Task(delegate { DebugLog(); }); // Delagate
        task3.Start();

        Task task4 = new Task(() => { DebugLog(); });
        task4.Start();

        Task task5 = new Task(() => DebugLog());
        task5.Start();

        task2.Wait();
        task3.Wait();
        task4.Wait();
        task5.Wait();

        Task<int> task6 = Task.Factory.StartNew<int>(() => GetSize("GenericTask"));
        int result = task6.Result;
        Debug.Log(result);
    }

    int GetSize(string data)
    {
        return data.Length;
    }

    void DebugLog()
    {
        Debug.Log("Task");
    }
}
