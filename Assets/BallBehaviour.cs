using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class BallBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Rotate(Vector3.up, 180 * Time.deltaTime);
        ///////
        
        Console.WriteLine($"adf{Time.deltaTime}");
    }
}
