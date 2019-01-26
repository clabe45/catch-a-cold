using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO: input values to this script, rather than creating a shader material

public class DistanceFog : MonoBehaviour {
    public Color fogColor = Color.gray;
    public float fogDensity = 0.1f, fogNearPercent = 0, fogFarPercent = 1;
    private Material material;

    public void Start () {
        // to send depth to shaders? https://www.ronja-tutorials.com/2018/07/01/postprocessing-depth.html
        GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;

        material = new Material(Shader.Find("Custom/DistanceFog"));
    }

    public void OnRenderImage(RenderTexture src, RenderTexture dst) {
        // set shader properties
        material.SetColor("_FogColor", fogColor);
        material.SetFloat("_FogDensity", fogDensity);
        material.SetFloat("_FogNear01", fogNearPercent);
        material.SetFloat("_FogFar01", fogFarPercent);

        // execute shader
        Graphics.Blit(src, dst, material);
    }
}
