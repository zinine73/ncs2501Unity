using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DictionaryExample : MonoBehaviour
{
    void Start()
    {
        var dic = new Dictionary<int, string>();
        dic.Add(101, "1번째");
        dic.Add(102, "2번째");
        dic.Add(103, "3번째");
        dic.Add(104, "4번째");

        foreach (var item in dic)
        {
            Debug.Log($"{item.Key} {item.Value}");
        }

        foreach (var key in dic.Keys)
        {
            Debug.Log(key);
        }

        foreach (var value in dic.Values)
        {
            Debug.Log(value);
        }

        Debug.Log($"{dic[102]}");
        bool result = dic.TryGetValue(103, out string str);
        Debug.Log($"Result:{result}, str:{str}");
        bool result2 = dic.TryGetValue(106, out string str2);
        Debug.Log($"Result:{result2}, str:{str2}");
    }
}
