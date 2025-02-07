using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class1
{
    public static int staticint;
    public int m_IntVariable;
    private string m_StringVariable;
    private int property;
    // public int Property
    // {
    //     get { return this.property; }
    //     set { this.property = value; }
    // }
    //public int Property { get; set;}
    // readonly
    public int Property { get; private set; }

    public Class1()
    {

    }

    public Class1(int a)
    {
        m_IntVariable = a;
    }

    public void DebugLog(string message)
    {
        m_StringVariable = message;
        Debug.Log(message);
        Debug.Log(m_IntVariable);
    }

    public static void StaticMethod()
    {
        staticint++;
        // static 함수안에서는 static 멤버만 쓸수 있다
        //m_IntVariable++;
    }
}

public class ClassExample : MonoBehaviour
{
    [SerializeField] private int im = 0;
    private Class1 m_Class1 = new Class1();
    private Class1 m_Class2 = new Class1(100);
    [SerializeField] private int pro;
    [SerializeField] private Rigidbody rb;
    public int abcDefGii = 1;
    public int Pro 
    {
        get {return pro;}
        set {pro = value;}    
    }
    void Start()
    {
        Class1.staticint = 1;
        im = Class1.staticint;
        Class1.StaticMethod();
        m_Class1.DebugLog("Example");
        m_Class2.DebugLog("Class2");

        
    }
}
