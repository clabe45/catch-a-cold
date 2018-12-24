using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// https://blog.theknightsofunity.com/make-it-snow-fast-screen-space-snow-shader/
public class AccumSnow : MonoBehaviour {
    public Texture2D snowTexture;
    public Color snowColor = Color.white;
    public float snowTextureScale = 0.1f;

    [Range(0, 1)]
    public float bottomThreshold = 0f;
    [Range(0, 1)]
    public float topThreshold = 1f;

    public Material material;

    public void Start () {
        // send normals to shader
        GetComponent<Camera>().depthTextureMode |= DepthTextureMode.DepthNormals;
    }

    public void OnRenderImage(RenderTexture src, RenderTexture dst) {
        // set shader properties (uniforms, no?)
        material.SetMatrix("_CamToWorld", GetComponent<Camera>().cameraToWorldMatrix);
        material.SetColor("_SnowColor", snowColor);
        material.SetFloat("_BottomThreshold", bottomThreshold);
        material.SetFloat("_TopThreshold", topThreshold);
        material.SetTexture("_SnowTex", snowTexture);
        material.SetFloat("_SnowTexScale", snowTextureScale);

        // execute shader
        Graphics.Blit(src, dst, material);
    }
}
