using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Xml.Serialization;
using System;

public class FileDemo : MonoBehaviour
{
    //public string m_FilePath = @"C:\temp\MyTest.txt";
    public string m_FilePath = Path.GetTempFileName();
    private FileInfo m_FileInfori1;

    void Start()
    {
        m_FileInfori1 = new FileInfo(m_FilePath);

        using (StreamWriter sw = m_FileInfori1.CreateText())
        {
            sw.WriteLine("Hello");
            sw.WriteLine("And");
            sw.WriteLine("Welcome");
        }

        using (StreamReader sr = m_FileInfori1.OpenText())
        {
            var s = "";
            while ((s = sr.ReadLine()) != null)
            {
                Debug.Log(s);
            }
        }

        try
        {
            string filePath2 = Path.GetTempFileName();
            var fileInfo2 = new FileInfo(filePath2);
            fileInfo2.Delete();
            m_FileInfori1.CopyTo(filePath2);
            Debug.Log($"{m_FilePath} was copied to {filePath2}.");
            fileInfo2.Delete();
            Debug.Log($"{filePath2} was successfully deleted.");
        }
        catch (Exception e)
        {
            Debug.Log($"The process failed: {e.ToString()}");
        }
    }

    void Start1()
    {
        if (!File.Exists(m_FilePath))
        {
            using (StreamWriter sw = File.CreateText(m_FilePath))
            {
                sw.WriteLine("zzHello");
                sw.WriteLine("Anzzd");
                sw.WriteLine("Welczzzome");
            }
        }

        using (StreamReader sr = File.OpenText(m_FilePath))
        {
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                Debug.Log(s);
            }
        }
    }
}
