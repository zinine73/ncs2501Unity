using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class StringExample : MonoBehaviour
{
    void Start()
    {
        string msg1 = "message1";
        string msg2 = null;
        string msg3 = "";
        string msg4 = string.Empty;

        string name = "Coder Zero";
        char[] charArray = name.ToCharArray();
        //Debug.Log(charArray[1]);

        string s = new string(charArray);
        //Debug.Log(s);

        StringBuilder sb = new StringBuilder("stringBuilder1");
        sb.Append("stringBuilder1");
        //Debug.Log(sb);

        var sb1 = new StringBuilder("Coder ");
        sb1.Append("Zero");
        Debug.Log(sb1);
        var sb2 = new StringBuilder("Unity #");
        sb2.Insert(6, "C");
        Debug.Log(sb2);
        var sb3 = new StringBuilder("Coder Zero");
        sb3.Remove(6, 3);
        Debug.Log(sb3);
        var sb4 = new StringBuilder("Coder zero");
        sb4.Replace('z', 'Z');
        Debug.Log(sb4);
        var sb5 = new StringBuilder("Coder Zero Visual C#");
        sb5.Replace("Visual", "Unity");
        Debug.Log(sb5);
        var sb6 = new StringBuilder("Coder Zero unity C#");
        sb6.Replace('u', 'U', 0, 12);
        Debug.Log(sb6);
    }

    void Update()
    {
        
    }
}
