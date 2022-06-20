using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]

public class shaderharder : MonoBehaviour
{

    public Material effectMaterial;

    private void OnRenderImage(RenderTexture src, RenderTexture dest)
    {
       Graphics.Blit(src, dest, effectMaterial);
    }
}
