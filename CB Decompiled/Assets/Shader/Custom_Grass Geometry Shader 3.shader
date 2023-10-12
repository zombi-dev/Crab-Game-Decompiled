Shader "Custom/Grass Geometry Shader 3" {
	Properties {
		_BottomColor ("Bottom Color", Vector) = (0,1,0,1)
		_TopColor ("Top Color", Vector) = (1,1,0,1)
		_GrassHeight ("Grass Height", Float) = 1
		_GrassWidth ("Grass Width", Float) = 0.06
		_RandomHeight ("Grass Height Randomness", Float) = 0.25
		_WindSpeed ("Wind Speed", Float) = 100
		_WindStrength ("Wind Strength", Float) = 0.05
		_Radius ("Interactor Radius", Float) = 0.3
		_Strength ("Interactor Strength", Float) = 5
		_Rad ("Blade Radius", Range(0, 1)) = 0.6
		_BladeForward ("Blade Forward Amount", Float) = 0.38
		_BladeCurve ("Blade Curvature Amount", Range(1, 4)) = 2
		_AmbientStrength ("Ambient Strength", Range(0, 1)) = 0.5
		_MinDist ("Min Distance", Float) = 40
		_MaxDist ("Max Distance", Float) = 60
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType" = "Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Standard
#pragma target 3.0

		struct Input
		{
			float2 uv_MainTex;
		};

		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			o.Albedo = 1;
		}
		ENDCG
	}
	Fallback "VertexLit"
}