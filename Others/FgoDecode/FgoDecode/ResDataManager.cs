﻿// Generated by .NET Reflector from D:\working\temp\2\Managed\Assembly-CSharp.dll
using ICSharpCode.SharpZipLib.BZip2;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
//using UnityEngine;

internal class ResDataManager
{
    private static ResDataManager sInstance;

    private FileStream GetDataFileStream(string fileName)
    {
        string path = fileName;
        Debug.Log("Path ::: " + path);
        if (File.Exists(path))
        {
            return new FileStream(path, FileMode.Open);
        }
        return null;
    }

    public byte[] ReadDataConfig(string FileName)
    {
        FileStream dataFileStream = this.GetDataFileStream(FileName);
        if (dataFileStream != null)
        {
            byte[] array = new byte[(int)dataFileStream.Length];
            dataFileStream.Read(array, 0, (int)dataFileStream.Length);
            dataFileStream.Close();
            return array;
        }
        return null;
    }

    public static ResDataManager Instance
    {
        get
        {
            if (sInstance == null)
            {
                sInstance = new ResDataManager();
            }
            return sInstance;
        }
    }
}
