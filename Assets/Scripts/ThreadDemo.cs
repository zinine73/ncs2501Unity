using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ThreadDemo : MonoBehaviour
{
    void Start()
    {
        Thread thread = new Thread(Run6);
        thread.Start();

        for (int i = 0; i < 3; i++)
        {
            Debug.Log($"main thread : {i}");
            Thread.Sleep(100);
        }

        thread.Abort();
        Debug.Log($"End main thread");
    }

    static void Run6()
    {
        for (int i = 0; i < 5; i++)
        {
            Debug.Log($"Sub thread : {i}");
            Thread.Sleep(100);
        }
    }

    void Start4()
    {
        ThreadPool.QueueUserWorkItem(Run5);    
        ThreadPool.QueueUserWorkItem(Run5, 1);
        ThreadPool.QueueUserWorkItem(Run5, 2);
    }

    static void Run5(object obj)
    {
        Debug.Log(obj);
    }

    void Start3()
    {
        EventWaitHandle ewh = new EventWaitHandle(false, EventResetMode.ManualReset);

        Thread thread = new Thread(Run4);
        thread.Start(ewh);
        Debug.Log("Start sub thread");

        for (int i = 0; i < 1; i++)
        {
            Debug.Log($"Main thread : {i}");
            Thread.Sleep(100);
        }
        ewh.WaitOne();
        Debug.Log("End main thread");
    }

    static void Run4(object obj)
    {
        EventWaitHandle ewh = obj as EventWaitHandle;

        for (int i = 0; i < 2; i++)
        {
            Debug.Log($"Sub thread : {i}");
            Thread.Sleep(100);
        }
        Debug.Log("End sub thread");
        ewh.Set();
    }

    void Start2()
    {
        Thread thread = new Thread(Run3);
        thread.Start();

        for (int i = 0; i < 3; i++)
        {
            Debug.Log($"Main thread : {i}");
            Thread.Sleep(100);
        }
        thread.Join();
        Debug.Log("End main thread");
    }

    static void Run3()
    {
        for (int i = 0; i < 5; i++)
        {
            Debug.Log($"Sub thread : {i}");
            Thread.Sleep(100);
        }
        Debug.Log("End sub thread");
    }

    void oooldStart()
    {
        //Thread thread = new Thread(Run2);
        //thread.Start(1);
        Thread thread = new Thread(() => Sum(1, 2, 3));
        thread.IsBackground = true;
        thread.Start();
    }

    static void Sum(int d1, int d2, int d3)
    {
        int sum = d1 + d2 + d3;
        Debug.Log(sum);
    }

    static void Run2(object obj)
    {
        Debug.Log(obj);
    }

    void OldStart()
    {
        //Thread thread = new Thread(Run);
        //Thread thread = new Thread(new ThreadStart(Run));
        //Thread thread = new Thread(() => Run());
        /*Thread thread = new Thread(delegate ()
        {
            Run();
        });
        thread.Start();*/
        new Thread(() => Run()).Start();
    }

    void Run()
    {
        Debug.Log($"Thread#{Thread.CurrentThread.ManagedThreadId} : Start");
        Thread.Sleep(1000);
        Debug.Log($"Thread#{Thread.CurrentThread.ManagedThreadId} : End");
    }
}
