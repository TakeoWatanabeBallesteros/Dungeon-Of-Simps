using System;
using System.Collections.Generic;
using UnityEngine.Serialization;
using UnityEngine.Rendering;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class FireIlumination : MonoBehaviour
{
    Light2D Light;
    void Start()
    {
        Light = gameObject.GetComponent<Light2D>();
        InvokeRepeating("FireLight", 0f, .3f);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void FireLight(){
        Light.pointLightInnerRadius = UnityEngine.Random.Range(0f, 0.5f);
    }
}
