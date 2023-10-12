Shader "AdultLink/HoloShield" {
	Properties {
		_Globalopacity ("Global opacity", Range(0, 1)) = 1
		_Maintexture ("Main texture", 2D) = "black" {}
		_Maintextureintensity ("Main texture intensity", Float) = 1
		_Mainpanningspeed ("Main panning speed", Vector) = (0,0,0,0)
		[Toggle] _Invertmaintexture ("Invert main texture", Range(0, 1)) = 0
		[HDR] _Maincolor ("Main color", Vector) = (0.7941176,0.1284602,0.1284602,0.666)
		_TessValue ("Max Tessellation", Range(1, 32)) = 1
		_TessMin ("Tess Min Distance", Float) = 10
		_TessMax ("Tess Max Distance", Float) = 25
		_TessPhongStrength ("Phong Tess Strength", Range(0, 1)) = 0.5
		[HDR] _Edgecolor ("Edge color", Vector) = (0.7941176,0.1284602,0.1284602,0.666)
		_Bias ("Bias", Float) = 0
		_Scale ("Scale", Float) = 1
		_Power ("Power", Range(0, 5)) = 2
		_Innerfresnelintensity ("Inner fresnel intensity", Range(0, 1)) = 0
		_Outerfresnelintensity ("Outer fresnel intensity", Range(0, 1)) = 1
		_Secondarytexture ("Secondary texture", 2D) = "black" {}
		_Secondarytextureintensity ("Secondary texture intensity", Float) = 1
		_Secondarypanningspeed ("Secondary panning speed", Vector) = (0,0,0,0)
		[Toggle] _Invertsecondarytexture ("Invert secondary texture", Range(0, 1)) = 0
		[HDR] _Secondarycolor ("Secondary color", Vector) = (0,0,0,0)
		[Toggle] _Enabledistortion ("Enable distortion", Range(0, 1)) = 0
		_Distortionscale ("Distortion scale", Range(0, 10)) = 1
		_Distortionspeed ("Distortion speed", Range(0, 5)) = 1
		_Extraroughness ("Extra roughness", Range(0, 10)) = 0
		[Toggle] _Enablepulsation ("Enable pulsation", Range(0, 1)) = 0
		_Pulsephase ("Pulse phase", Float) = 0
		_Pulsefrequency ("Pulse frequency", Float) = 3
		_Pulseamplitude ("Pulse amplitude", Float) = 1
		_Pulseoffset ("Pulse offset", Float) = 0
		[Toggle] _Enablenoise ("Enable noise", Range(0, 1)) = 0
		_Sharpennoise ("Sharpen noise", Range(0, 1)) = 0
		_Noisescale ("Noise scale", Float) = 50
		_Noisespeed ("Noise speed", Vector) = (0,0,0,0)
		[HideInInspector] _texcoord ("", 2D) = "white" {}
		[HideInInspector] __dirty ("", Float) = 1
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
	Fallback "Diffuse"
	//CustomEditor "AdultLink.HoloShieldEditor"
}