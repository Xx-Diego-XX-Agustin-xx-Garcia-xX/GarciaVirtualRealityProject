using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clock : MonoBehaviour
{
    public DateTime roomTime;
    void Start()
    {
        
    }
    void Update()
    {
        roomTime = DateTime.Now;
        Debug.Log(roomTime.ToString());
    }
}
