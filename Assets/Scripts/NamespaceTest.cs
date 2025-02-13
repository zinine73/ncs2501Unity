using UnityEngine;
using System.Diagnostics;
using Debug = UnityEngine.Debug;

namespace zinine
{
    public class GetData
    {
        public void Debuglog(string message)
        {
            Debug.Log(message);
        }

        public static void StaticSample()
        {
            Debug.Log("Static");
        }

        public static int GetDataA(int a)
        {
            return 0;
        }
    }
}