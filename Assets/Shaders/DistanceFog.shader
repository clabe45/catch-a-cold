Shader "Custom/DistanceFog"
{
	Properties
	{
        _FogColor ("Fog Color", Color) = (1,1,1)
        _FogDensity ("Fog Density", range(0, 1)) = 0.1
        _FogNear01 ("Fog Near", range(0, 1)) = .05
        _FogFar01 ("Fog Far", range(0, 1)) = 1
        _MainTex ("Texture", 2D) = "white" {}
	}
	SubShader
	{
		// No culling or depth
		Cull Off ZWrite Off ZTest Always

		Pass
		{
			CGPROGRAM
// Upgrade NOTE: excluded shader from DX11; has structs without semantics (struct v2f members depth)
#pragma exclude_renderers d3d11
			#pragma vertex vert
			#pragma fragment frag
			
			#include "UnityCG.cginc"

			struct appdata
			{
				float4 vertex : POSITION;
				float2 uv : TEXCOORD0;
			};

			struct v2f
			{
                float4 vertex : SV_POSITION;
                float2 uv : TEXCOORD0;
			};

			v2f vert (appdata v)
			{
				v2f o;
				o.vertex = UnityObjectToClipPos(v.vertex);
				o.uv = v.uv;
				return o;
			}
			
            float _FogNear01;
            float _FogFar01;
            float _FogDensity;
            fixed3 _FogColor;
            sampler2D _MainTex;
            sampler2D _CameraDepthTexture;

			fixed4 frag (v2f i) : SV_Target
			{
				fixed4 col = tex2D(_MainTex, i.uv);
                // distance from camera as percentage (of `far`)
                float depth = tex2D(_CameraDepthTexture, i.uv).r;
                depth = Linear01Depth(depth);x
                float oneMinusFog = saturate((_FogFar01 - depth) / (_FogFar01 - _FogNear01));
                col.rgb = lerp(_FogColor, col.rgb, oneMinusFog);
				return col;
			}
			ENDCG
		}
	}
}
