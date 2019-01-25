// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:0,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:9361,x:34568,y:32328,varname:node_9361,prsc:2|normal-8168-RGB,custl-9951-OUT;n:type:ShaderForge.SFN_LightVector,id:3251,x:32781,y:32794,varname:node_3251,prsc:2;n:type:ShaderForge.SFN_NormalVector,id:2916,x:32781,y:32545,prsc:2,pt:True;n:type:ShaderForge.SFN_Dot,id:3380,x:32962,y:32717,varname:node_3380,prsc:2,dt:0|A-2916-OUT,B-3251-OUT;n:type:ShaderForge.SFN_RemapRange,id:5193,x:33163,y:32951,varname:node_5193,prsc:2,frmn:0,frmx:1,tomn:0.5,tomx:1|IN-3380-OUT;n:type:ShaderForge.SFN_Tex2d,id:3750,x:33163,y:32752,ptovrint:False,ptlb:Texture,ptin:_Texture,varname:node_3750,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:b66bceaf0cc0ace4e9bdc92f14bba709,ntxv:3,isnm:False;n:type:ShaderForge.SFN_HalfVector,id:9099,x:32781,y:32363,varname:node_9099,prsc:2;n:type:ShaderForge.SFN_Dot,id:1511,x:33064,y:32410,varname:node_1511,prsc:2,dt:1|A-9099-OUT,B-2916-OUT;n:type:ShaderForge.SFN_Power,id:2822,x:33262,y:32410,varname:node_2822,prsc:2|VAL-1511-OUT,EXP-8507-OUT;n:type:ShaderForge.SFN_Slider,id:9916,x:32947,y:32607,ptovrint:False,ptlb:light_area,ptin:_light_area,varname:node_9916,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:6.625048,max:10;n:type:ShaderForge.SFN_Exp,id:8507,x:33275,y:32607,varname:node_8507,prsc:2,et:1|IN-9916-OUT;n:type:ShaderForge.SFN_Slider,id:4626,x:33105,y:32330,ptovrint:False,ptlb:light_strength,ptin:_light_strength,varname:node_4626,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:1,cur:1.448339,max:5;n:type:ShaderForge.SFN_Multiply,id:8140,x:33488,y:32391,varname:node_8140,prsc:2|A-4626-OUT,B-2822-OUT;n:type:ShaderForge.SFN_Add,id:2167,x:33915,y:32577,varname:node_2167,prsc:2|A-8062-OUT,B-943-OUT;n:type:ShaderForge.SFN_Desaturate,id:9491,x:33420,y:32751,varname:node_9491,prsc:2|COL-3750-RGB;n:type:ShaderForge.SFN_RemapRange,id:8826,x:33585,y:32575,varname:node_8826,prsc:2,frmn:0,frmx:1,tomn:-2,tomx:2|IN-9491-OUT;n:type:ShaderForge.SFN_Dot,id:8062,x:33750,y:32391,varname:node_8062,prsc:2,dt:0|A-8140-OUT,B-8826-OUT;n:type:ShaderForge.SFN_Tex2d,id:8168,x:33915,y:32334,ptovrint:False,ptlb:NormalTexture,ptin:_NormalTexture,varname:node_8168,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:bbab0a6f7bae9cf42bf057d8ee2755f6,ntxv:3,isnm:True;n:type:ShaderForge.SFN_LightColor,id:1453,x:33915,y:32733,varname:node_1453,prsc:2;n:type:ShaderForge.SFN_LightAttenuation,id:4802,x:33915,y:32887,varname:node_4802,prsc:2;n:type:ShaderForge.SFN_Multiply,id:9951,x:34157,y:32529,varname:node_9951,prsc:2|A-2167-OUT,B-1453-RGB;n:type:ShaderForge.SFN_Fresnel,id:9691,x:33163,y:33185,varname:node_9691,prsc:2|NRM-6801-OUT,EXP-5878-OUT;n:type:ShaderForge.SFN_NormalVector,id:6801,x:32965,y:33185,prsc:2,pt:False;n:type:ShaderForge.SFN_Slider,id:5878,x:32808,y:33369,ptovrint:False,ptlb:FresnelStrength,ptin:_FresnelStrength,varname:node_5878,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:10,max:10;n:type:ShaderForge.SFN_Multiply,id:1047,x:33345,y:33094,varname:node_1047,prsc:2|A-5193-OUT,B-9691-OUT;n:type:ShaderForge.SFN_Add,id:943,x:33552,y:32950,varname:node_943,prsc:2|A-3147-OUT,B-1047-OUT;n:type:ShaderForge.SFN_Multiply,id:3147,x:33345,y:32909,varname:node_3147,prsc:2|A-3750-RGB,B-5193-OUT;proporder:3750-9916-4626-8168-5878;pass:END;sub:END;*/

Shader "Shader Forge/Lighting" {
    Properties {
        _Texture ("Texture", 2D) = "bump" {}
        _light_area ("light_area", Range(0, 10)) = 6.625048
        _light_strength ("light_strength", Range(1, 5)) = 1.448339
        _NormalTexture ("NormalTexture", 2D) = "bump" {}
        _FresnelStrength ("FresnelStrength", Range(0, 10)) = 10
    }
    SubShader {
        Tags {
            "RenderType"="Opaque"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles gles3 
            #pragma target 3.0
            uniform float4 _LightColor0;
            uniform sampler2D _Texture; uniform float4 _Texture_ST;
            uniform float _light_area;
            uniform float _light_strength;
            uniform sampler2D _NormalTexture; uniform float4 _NormalTexture_ST;
            uniform float _FresnelStrength;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float3 tangentDir : TEXCOORD3;
                float3 bitangentDir : TEXCOORD4;
                LIGHTING_COORDS(5,6)
                UNITY_FOG_COORDS(7)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 _NormalTexture_var = UnpackNormal(tex2D(_NormalTexture,TRANSFORM_TEX(i.uv0, _NormalTexture)));
                float3 normalLocal = _NormalTexture_var.rgb;
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float4 _Texture_var = tex2D(_Texture,TRANSFORM_TEX(i.uv0, _Texture));
                float node_5193 = (dot(normalDirection,lightDirection)*0.5+0.5);
                float node_1047 = (node_5193*pow(1.0-max(0,dot(i.normalDir, viewDirection)),_FresnelStrength));
                float3 node_2167 = (dot((_light_strength*pow(max(0,dot(halfDirection,normalDirection)),exp2(_light_area))),(dot(_Texture_var.rgb,float3(0.3,0.59,0.11))*4.0+-2.0))+((_Texture_var.rgb*node_5193)+node_1047));
                float3 node_9951 = (node_2167*_LightColor0.rgb);
                float3 finalColor = node_9951;
                fixed4 finalRGBA = fixed4(finalColor,1);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
