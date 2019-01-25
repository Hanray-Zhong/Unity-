// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:9361,x:33367,y:32766,varname:node_9361,prsc:2|custl-7915-OUT;n:type:ShaderForge.SFN_Fresnel,id:923,x:32724,y:32953,varname:node_923,prsc:2|NRM-8670-OUT,EXP-3186-OUT;n:type:ShaderForge.SFN_NormalVector,id:8670,x:32559,y:32852,prsc:2,pt:False;n:type:ShaderForge.SFN_Slider,id:3186,x:32402,y:33089,ptovrint:False,ptlb:Area,ptin:_Area,varname:node_3186,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:2.393162,max:5;n:type:ShaderForge.SFN_Color,id:3392,x:32724,y:33120,ptovrint:False,ptlb:color,ptin:_color,varname:node_3392,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.9811321,c2:0.9275804,c3:0,c4:1;n:type:ShaderForge.SFN_Multiply,id:8730,x:32931,y:33017,varname:node_8730,prsc:2|A-923-OUT,B-3392-RGB,C-2444-OUT;n:type:ShaderForge.SFN_Tex2d,id:4171,x:32931,y:32812,ptovrint:False,ptlb:Texture,ptin:_Texture,varname:node_4171,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:b66bceaf0cc0ace4e9bdc92f14bba709,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Add,id:7915,x:33138,y:32921,varname:node_7915,prsc:2|A-4171-RGB,B-8730-OUT;n:type:ShaderForge.SFN_Slider,id:2444,x:32567,y:33308,ptovrint:False,ptlb:Strength,ptin:_Strength,varname:node_2444,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:2.094017,max:5;proporder:3186-3392-4171-2444;pass:END;sub:END;*/

Shader "Shader Forge/Fresnel" {
    Properties {
        _Area ("Area", Range(0, 5)) = 2.393162
        _color ("color", Color) = (0.9811321,0.9275804,0,1)
        _Texture ("Texture", 2D) = "white" {}
        _Strength ("Strength", Range(0, 5)) = 2.094017
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
            #pragma multi_compile_fwdbase_fullshadows
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform float _Area;
            uniform float4 _color;
            uniform sampler2D _Texture; uniform float4 _Texture_ST;
            uniform float _Strength;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                UNITY_FOG_COORDS(3)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
////// Lighting:
                float4 _Texture_var = tex2D(_Texture,TRANSFORM_TEX(i.uv0, _Texture));
                float3 finalColor = (_Texture_var.rgb+(pow(1.0-max(0,dot(i.normalDir, viewDirection)),_Area)*_color.rgb*_Strength));
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
