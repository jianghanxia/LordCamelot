﻿// Generated by .NET Reflector from D:\working\temp\2\Managed\Assembly-CSharp.dll
using System;

public static class Debug
{
    private static bool IsEnable()
    {
        return false;
    }

    public static void Log(object message)
    {
        if (IsEnable())
        {
            //UnityEngine.Debug.Log(message);
        }
    }

    public static void LogError(object message)
    {
        if (IsEnable())
        {
            //UnityEngine.Debug.LogError(message);
        }
    }
}