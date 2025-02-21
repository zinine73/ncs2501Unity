using UnityEngine;
using zinine;
using Another;
using GetData = zinine.GetData;

public class NamespaceExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(GetData.GetDataA(1));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
