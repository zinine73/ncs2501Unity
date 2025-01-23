using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class StandardDateTime : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DateTime dt = new DateTime(2025, 1, 22, 13, 24, 35);

        Debug.Log(dt.ToString("d", CultureInfo.CreateSpecificCulture("en-US")));
        Debug.Log(string.Format(CultureInfo.CreateSpecificCulture("ko-KR"), "한국 {0:d}", dt));
        Debug.Log(string.Format(CultureInfo.CreateSpecificCulture("ko-KR"), 
            $"한국 {dt:d}"));

        Debug.Log(dt.ToString("D", CultureInfo.CreateSpecificCulture("ja-JP")));
        Debug.Log(string.Format(CultureInfo.CreateSpecificCulture("ko-KR"),
            $"korea {dt:D}"));

        Debug.Log(dt.ToString("F", CultureInfo.CreateSpecificCulture("en-US")));
        Debug.Log(string.Format(CultureInfo.CreateSpecificCulture("ko-KR"),
            $"korea {dt:F}"));

        Debug.Log(dt.ToString("U", CultureInfo.CreateSpecificCulture("en-US")));
        Debug.Log(string.Format(CultureInfo.CreateSpecificCulture("ko-KR"),
            $"korea {dt:U}"));

        Debug.Log(string.Format("{0:yyyyMMdd_HHmmss}", dt));
        Debug.Log($"{dt:yyyyMMdd_HHmmss}");
        Debug.Log($"{dt:d}   {dt:ddd}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
