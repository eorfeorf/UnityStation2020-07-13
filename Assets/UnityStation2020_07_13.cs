using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class UnityStation2020_07_13 : MonoBehaviour
{
    private MeshRenderer renderer;
    
    private void Awake()
    {
        renderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        renderer.material.SetFloat("_Fader", math.abs(math.sin(Time.time)));
    }
}
