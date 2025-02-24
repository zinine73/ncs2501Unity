#if UNITY_ANDROID
    #define DEBUG_TEST
    #undef PRODUCT
#else
    #undef DEBUG_TEST
    #define PRODUCT
#endif

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreprocessExample : MonoBehaviour
{
    //bool isTest = false;
    void Start()
    {
//#if DEBUG_TEST
//#if (DEBUG_TEST == true) // && || != !
#if (DEBUG_TEST && !UNITY_ANDROID)
        //if (isTest)
        //{
            Debug.Log("Password:12345");
        //}
#elif (!DEBUG_TEST && UNITY_ANDROID)
        Debug.Log("");
#elif (DEBUG_TEST && UNITY_ANDROID)
        Debug.Log("");
#else
        Debug.Log("");
#endif

#if (UNITY_EDITOR || UNITY_STANDALONE_WIN || UNITY_IOS || UNITY_ANDROID)

#endif

#region Platform divide
    #if UNITY_STANDALONE_WIN
    #region PC
    #if UNITY_EDITOR
            Debug.Log("Input Manager");
    #else
                    Debug.Log("Input Manager");
    #endif
    #endregion PC
#elif UNITY_ANDROID
    #region Android
    #if UNITY_EDITOR
            Debug.Log("Input Manager");
    #else
            Debug.Log("Input System");
    #endif
    #endregion Android
    #endif
#endregion Platform divide
    }
}
