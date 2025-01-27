using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataTypeScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // value type
        Vector3 pos = transform.position;
        //Debug.Log($"pos:{pos}");
        pos = new Vector3(0, 2, 0);
        //Debug.Log($"pos:{pos}");

        // reference type
        Transform tran = transform;
        tran.position = new Vector3(0, 2, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
