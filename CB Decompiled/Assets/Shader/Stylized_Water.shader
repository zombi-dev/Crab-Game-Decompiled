Shader "Stylized/Water" {
	Properties {
		[Header(Densities)] _DepthDensity ("Depth", Range(0, 1)) = 0.5
		_DistanceDensity ("Distance", Range(0, 1)) = 0.1
		[Header(Waves)] [NoScaleOffset] _WaveNormalMap ("Normal Map", 2D) = "bump" {}
		_WaveNormalScale ("Scale", Float) = 10
		_WaveNormalSpeed ("Speed", Float) = 1
		[Header(Base Color)] [HDR] _ShallowColor ("Shallow", Vector) = (0.44,0.95,0.36,1)
		[HDR] _DeepColor ("Deep", Vector) = (0,0.05,0.19,1)
		[HDR] _FarColor ("Far", Vector) = (0.04,0.27,0.75,1)
		[Header(Reflections)] _ReflectionContribution ("Contribution", Range(0, 1)) = 1
		[Header(Subsurface Scattering)] [HDR] _SSSColor ("Color", Vector) = (1,1,1,1)
		[Header(Foam)] _FoamContribution ("Contribution", Range(0, 1)) = 1
		[NoScaleOffset] _FoamTexture ("Texture", 2D) = "black" {}
		_FoamScale ("Scale", Float) = 1
		_FoamSpeed ("Speed", Float) = 1
		_FoamNoiseScale ("Noise Contribution", Range(0, 1)) = 0.5
		[Header(Sun Specular)] [HDR] _SunSpecularColor ("Color", Vector) = (1,1,1,1)
		_SunSpecularExponent ("Exponent", Float) = 1000
		[Header(Sparkle)] [NoScaleOffset] _SparklesNormalMap ("Normal Map", 2D) = "bump" {}
		_SparkleScale ("Scale", Float) = 10
		_SparkleSpeed ("Speed", Float) = 0.75
		[HDR] _SparkleColor ("Color", Vector) = (1,1,1,1)
		_SparkleExponent ("Exponent", Float) = 10000
		[Header(Edge Foam)] [HDR] _EdgeFoamColor ("Color", Vector) = (1,1,1,1)
		_EdgeFoamDepth ("Scale", Float) = 10
		[Header(Shadow Mapping)] [Toggle(SHADOWS)] _FancyShadows ("Enabled", Float) = 0
		_MaxShadowDistance ("Maximum Sample Distance", Float) = 50
		_ShadowColor ("Color", Vector) = (0.5,0.5,0.5,1)
		[Header(Vertex Waves #1)] _Wave1Direction ("Direction", Range(0, 1)) = 0
		_Wave1Amplitude ("Amplitude", Float) = 1
		_Wave1Wavelength ("Wavelength", Float) = 1
		_Wave1Speed ("Speed", Float) = 1
		[Header(Vertex Waves #2)] _Wave2Direction ("Direction", Range(0, 1)) = 0
		_Wave2Amplitude ("Amplitude", Float) = 1
		_Wave2Wavelength ("Wavelength", Float) = 1
		_Wave2Speed ("Speed", Float) = 1
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
}