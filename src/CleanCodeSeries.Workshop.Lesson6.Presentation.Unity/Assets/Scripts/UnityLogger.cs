using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CleanCodeSeries.Workshop.Lesson4.EasyOOP;
using CleanCodeSeries.Workshop.Lesson4.SOLID;

/// <summary>
/// Implementation of logging to console in unity.
/// </summary>
public class UnityLogger : CleanCodeSeries.Workshop.Lesson4.SOLID.ILogger
{
    public void Log(string message)
    {
        Debug.Log(message);
    }
}
