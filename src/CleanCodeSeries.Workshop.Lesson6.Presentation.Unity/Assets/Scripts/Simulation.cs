using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CleanCodeSeries.Workshop.Lesson4.EasyOOP;
using CleanCodeSeries.Workshop.Lesson4.SOLID;

public class Simulation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var war = new War(new SoldierGenerator());
        LoggingService.Instance.SetLogger(new UnityLogger());
        war.Simulate();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
