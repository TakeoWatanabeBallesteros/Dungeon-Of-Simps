﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlurRenderer : MonoBehaviour
{
    [SerializeField]
    Camera blurCamera;
    [SerializeField]
    Material blurMaterial;
    void Start()
    {
        //blurCamera.targetTexture.Release();
        blurCamera.targetTexture = new RenderTexture(Screen.width, Screen.height, 24, RenderTextureFormat.ARGB32, 1);
        blurMaterial.SetTexture("_RenTex", blurCamera.targetTexture);
    }
}
