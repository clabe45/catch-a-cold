using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO: input values to this script, rather than creating a shader material

public class DistanceFog : MonoBehaviour {
    public Material shaderMaterial;

    public void Start () {
        Camera cam = GetComponent<Camera>();
        // send depth to shaders? https://www.ronja-tutorials.com/2018/07/01/postprocessing-depth.html
        cam.depthTextureMode = cam.depthTextureMode | DepthTextureMode.Depth;
    }

    public void OnRenderImage(RenderTexture src, RenderTexture dst) {
        Graphics.Blit(src, dst, shaderMaterial);
    }
}
