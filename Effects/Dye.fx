sampler uImage0 : register(s0);
sampler uImage1 : register(s1);
float3 uColor;
float3 uSecondaryColor;
float uOpacity;
float2 uTargetPosition;
float uSaturation;
float uRotation;
float uTime;
float4 uSourceRect;
float2 uWorldPosition;
float uDirection;
float3 uLightSource;
float2 uImageSize0;
float2 uImageSize1;
float4 uLegacyArmorSourceRect;
float2 uLegacyArmorSheetSize;

// This is a shader. You are on your own with shaders. Compile shaders in an XNB project.

float4 ArmorRadar(float4 sampleColor : COLOR0, float2 coords : TEXCOORD0) : COLOR0
{
    float4 color = tex2D(uImage0, coords);
    float wave = 1 - frac(coords.x + uTime);
    color.rgb = color.rgb * wave;
    return color * sampleColor;
}

technique Technique1
{
	pass ExampleDyePass
	{
		PixelShader = compile ps_2_0 ArmorRadar();
	}
}