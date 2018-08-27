#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using XLua;
using System.Collections.Generic;


namespace XLua.CSObjectWrap
{
    using Utils = XLua.Utils;
    public class KEngineKToolWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(KEngine.KTool), L, translator, 0, 0, 0, 0);
			
			
			
			
			
			Utils.EndObjectRegister(typeof(KEngine.KTool), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(KEngine.KTool), L, __CreateInstance, 65, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "IsWifi", _m_IsWifi_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetNearestPower2", _m_GetNearestPower2_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CheckPow2", _m_CheckPow2_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ResetLocalTransform", _m_ResetLocalTransform_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetGCD", _m_GetGCD_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "FindType", _m_FindType_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DestroyGameObjectChildren", _m_DestroyGameObjectChildren_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetWaveRandomNumberInt", _m_GetWaveRandomNumberInt_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetWaveRandomNumber", _m_GetWaveRandomNumber_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ParseMinMaxNumber", _m_ParseMinMaxNumber_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "IsBetweenWave", _m_IsBetweenWave_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "IsContains", _m_IsContains_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "FindShader", _m_FindShader_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "StructToBytes", _m_StructToBytes_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "MakeDword", _m_MakeDword_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LoWord", _m_LoWord_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "HiWord", _m_HiWord_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "FormatToAssetUrl", _m_FormatToAssetUrl_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "MakeLong", _m_MakeLong_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "HiInt", _m_HiInt_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LowInt", _m_LowInt_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "HumanizeTimeString", _m_HumanizeTimeString_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetUtcDay", _m_GetUtcDay_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetDeltaMinutes", _m_GetDeltaMinutes_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetDeltaHours", _m_GetDeltaHours_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetDeltaDay", _m_GetDeltaDay_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetDateTimeByUtcMilliseconds", _m_GetDateTimeByUtcMilliseconds_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetDateTimeByUtcSeconds", _m_GetDateTimeByUtcSeconds_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetUtcMilliseconds", _m_GetUtcMilliseconds_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetUtcSeconds", _m_GetUtcSeconds_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "HumanizeNumber", _m_HumanizeNumber_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Match", _m_Match_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Format", _m_Format_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "FormatArgs", _m_FormatArgs_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetLayer", _m_SetLayer_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DFSFindObject", _m_DFSFindObject_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetGameObject", _m_GetGameObject_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetChild", _m_SetChild_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ResetTransform", _m_ResetTransform_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetRootPathName", _m_GetRootPathName_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "MD5_Stream", _m_MD5_Stream_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "MD5_File", _m_MD5_File_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "MD5_bytes", _m_MD5_bytes_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "MD5_16bit", _m_MD5_16bit_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "IntLerp", _m_IntLerp_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ScaleParticleSystem", _m_ScaleParticleSystem_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetParticleSystemRenderQueue", _m_SetParticleSystemRenderQueue_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CopyTransformToTarget", _m_CopyTransformToTarget_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "HasWriteAccessToFolder", _m_HasWriteAccessToFolder_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetStaticRecursively", _m_SetStaticRecursively_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetNormalizedAngle", _m_GetNormalizedAngle_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "AdjustCollidersCenterZ", _m_AdjustCollidersCenterZ_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ToTitleCase", _m_ToTitleCase_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ToSentenceCase", _m_ToSentenceCase_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Probability", _m_Probability_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetSmartNpcPoints", _m_GetSmartNpcPoints_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetParallelPoints", _m_GetParallelPoints_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LineIntersectionPoint", _m_LineIntersectionPoint_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "IsNumber", _m_IsNumber_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetRelativePositionOfEllipse", _m_GetRelativePositionOfEllipse_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Angle", _m_Angle_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "NumberFormatTo3", _m_NumberFormatTo3_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetIpAddressFromIpHostEntry", _m_GetIpAddressFromIpHostEntry_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetIpAddress", _m_GetIpAddress_xlua_st_);
            
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(KEngine.KTool));
			
			
			Utils.EndClassRegister(typeof(KEngine.KTool), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					KEngine.KTool __cl_gen_ret = new KEngine.KTool();
					translator.Push(L, __cl_gen_ret);
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to KEngine.KTool constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsWifi_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    
                        bool __cl_gen_ret = KEngine.KTool.IsWifi(  );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetNearestPower2_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    int num = LuaAPI.xlua_tointeger(L, 1);
                    
                        int __cl_gen_ret = KEngine.KTool.GetNearestPower2( num );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CheckPow2_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    int num = LuaAPI.xlua_tointeger(L, 1);
                    
                        bool __cl_gen_ret = KEngine.KTool.CheckPow2( num );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ResetLocalTransform_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Transform t = (UnityEngine.Transform)translator.GetObject(L, 1, typeof(UnityEngine.Transform));
                    
                    KEngine.KTool.ResetLocalTransform( t );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetGCD_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    int a = LuaAPI.xlua_tointeger(L, 1);
                    int b = LuaAPI.xlua_tointeger(L, 2);
                    
                        int __cl_gen_ret = KEngine.KTool.GetGCD( a, b );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FindType_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    string qualifiedTypeName = LuaAPI.lua_tostring(L, 1);
                    
                        System.Type __cl_gen_ret = KEngine.KTool.FindType( qualifiedTypeName );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DestroyGameObjectChildren_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.GameObject go = (UnityEngine.GameObject)translator.GetObject(L, 1, typeof(UnityEngine.GameObject));
                    
                    KEngine.KTool.DestroyGameObjectChildren( go );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetWaveRandomNumberInt_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    string waveNumberStr = LuaAPI.lua_tostring(L, 1);
                    
                        int __cl_gen_ret = KEngine.KTool.GetWaveRandomNumberInt( waveNumberStr );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetWaveRandomNumber_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    string waveNumberStr = LuaAPI.lua_tostring(L, 1);
                    
                        float __cl_gen_ret = KEngine.KTool.GetWaveRandomNumber( waveNumberStr );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ParseMinMaxNumber_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    string str = LuaAPI.lua_tostring(L, 1);
                    
                        KEngine.KTool.FromToNumber __cl_gen_ret = KEngine.KTool.ParseMinMaxNumber( str );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsBetweenWave_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    string waveNumberStr = LuaAPI.lua_tostring(L, 1);
                    int testNumber = LuaAPI.xlua_tointeger(L, 2);
                    
                        bool __cl_gen_ret = KEngine.KTool.IsBetweenWave( waveNumberStr, testNumber );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsContains_xlua_st_(RealStatePtr L)
        {
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    string numberStr = LuaAPI.lua_tostring(L, 1);
                    string testValue = LuaAPI.lua_tostring(L, 2);
                    char sp = (char)LuaAPI.xlua_tointeger(L, 3);
                    
                        bool __cl_gen_ret = KEngine.KTool.IsContains( numberStr, testValue, sp );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string numberStr = LuaAPI.lua_tostring(L, 1);
                    string testValue = LuaAPI.lua_tostring(L, 2);
                    
                        bool __cl_gen_ret = KEngine.KTool.IsContains( numberStr, testValue );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to KEngine.KTool.IsContains!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FindShader_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    string shaderName = LuaAPI.lua_tostring(L, 1);
                    
                        UnityEngine.Shader __cl_gen_ret = KEngine.KTool.FindShader( shaderName );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_StructToBytes_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    object structObject = translator.GetObject(L, 1, typeof(object));
                    
                        byte[] __cl_gen_ret = KEngine.KTool.StructToBytes( structObject );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MakeDword_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    ushort high = (ushort)LuaAPI.xlua_tointeger(L, 1);
                    ushort low = (ushort)LuaAPI.xlua_tointeger(L, 2);
                    
                        uint __cl_gen_ret = KEngine.KTool.MakeDword( high, low );
                        LuaAPI.xlua_pushuint(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoWord_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    uint low = LuaAPI.xlua_touint(L, 1);
                    
                        ushort __cl_gen_ret = KEngine.KTool.LoWord( low );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HiWord_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    uint high = LuaAPI.xlua_touint(L, 1);
                    
                        ushort __cl_gen_ret = KEngine.KTool.HiWord( high );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FormatToAssetUrl_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    string filePath = LuaAPI.lua_tostring(L, 1);
                    
                        string __cl_gen_ret = KEngine.KTool.FormatToAssetUrl( filePath );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MakeLong_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    uint high = LuaAPI.xlua_touint(L, 1);
                    uint low = LuaAPI.xlua_touint(L, 2);
                    
                        ulong __cl_gen_ret = KEngine.KTool.MakeLong( high, low );
                        LuaAPI.lua_pushuint64(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HiInt_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    ulong l = LuaAPI.lua_touint64(L, 1);
                    
                        uint __cl_gen_ret = KEngine.KTool.HiInt( l );
                        LuaAPI.xlua_pushuint(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LowInt_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    ulong l = LuaAPI.lua_touint64(L, 1);
                    
                        uint __cl_gen_ret = KEngine.KTool.LowInt( l );
                        LuaAPI.xlua_pushuint(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HumanizeTimeString_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    int seconds = LuaAPI.xlua_tointeger(L, 1);
                    
                        string __cl_gen_ret = KEngine.KTool.HumanizeTimeString( seconds );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetUtcDay_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    
                        int __cl_gen_ret = KEngine.KTool.GetUtcDay(  );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetDeltaMinutes_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    System.DateTime origin;translator.Get(L, 1, out origin);
                    
                        int __cl_gen_ret = KEngine.KTool.GetDeltaMinutes( origin );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetDeltaHours_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    System.DateTime origin;translator.Get(L, 1, out origin);
                    
                        int __cl_gen_ret = KEngine.KTool.GetDeltaHours( origin );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetDeltaDay_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    System.DateTime origin;translator.Get(L, 1, out origin);
                    
                        int __cl_gen_ret = KEngine.KTool.GetDeltaDay( origin );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetDateTimeByUtcMilliseconds_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1) || LuaAPI.lua_isint64(L, 1))&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    long utcTime = LuaAPI.lua_toint64(L, 1);
                    int zone = LuaAPI.xlua_tointeger(L, 2);
                    
                        System.DateTime __cl_gen_ret = KEngine.KTool.GetDateTimeByUtcMilliseconds( utcTime, zone );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 1&& (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1) || LuaAPI.lua_isint64(L, 1))) 
                {
                    long utcTime = LuaAPI.lua_toint64(L, 1);
                    
                        System.DateTime __cl_gen_ret = KEngine.KTool.GetDateTimeByUtcMilliseconds( utcTime );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to KEngine.KTool.GetDateTimeByUtcMilliseconds!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetDateTimeByUtcSeconds_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    double unixTimeStamp = LuaAPI.lua_tonumber(L, 1);
                    int zone = LuaAPI.xlua_tointeger(L, 2);
                    
                        System.DateTime __cl_gen_ret = KEngine.KTool.GetDateTimeByUtcSeconds( unixTimeStamp, zone );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    double unixTimeStamp = LuaAPI.lua_tonumber(L, 1);
                    
                        System.DateTime __cl_gen_ret = KEngine.KTool.GetDateTimeByUtcSeconds( unixTimeStamp );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to KEngine.KTool.GetDateTimeByUtcSeconds!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetUtcMilliseconds_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 0) 
                {
                    
                        double __cl_gen_ret = KEngine.KTool.GetUtcMilliseconds(  );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 1&& translator.Assignable<System.DateTime>(L, 1)) 
                {
                    System.DateTime date;translator.Get(L, 1, out date);
                    
                        double __cl_gen_ret = KEngine.KTool.GetUtcMilliseconds( date );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to KEngine.KTool.GetUtcMilliseconds!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetUtcSeconds_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 0) 
                {
                    
                        double __cl_gen_ret = KEngine.KTool.GetUtcSeconds(  );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 1&& translator.Assignable<System.DateTime>(L, 1)) 
                {
                    System.DateTime date;translator.Get(L, 1, out date);
                    
                        double __cl_gen_ret = KEngine.KTool.GetUtcSeconds( date );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to KEngine.KTool.GetUtcSeconds!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HumanizeNumber_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    int number = LuaAPI.xlua_tointeger(L, 1);
                    
                        string __cl_gen_ret = KEngine.KTool.HumanizeNumber( number );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Match_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    string find = LuaAPI.lua_tostring(L, 1);
                    string pattern = LuaAPI.lua_tostring(L, 2);
                    
                        string[] __cl_gen_ret = KEngine.KTool.Match( find, pattern );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Format_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    string source = LuaAPI.lua_tostring(L, 1);
                    object[] args = translator.GetParams<object>(L, 2);
                    
                        string __cl_gen_ret = KEngine.KTool.Format( source, args );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FormatArgs_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    string source = LuaAPI.lua_tostring(L, 1);
                    object[] args = (object[])translator.GetObject(L, 2, typeof(object[]));
                    
                        string __cl_gen_ret = KEngine.KTool.FormatArgs( source, args );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetLayer_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.GameObject go = (UnityEngine.GameObject)translator.GetObject(L, 1, typeof(UnityEngine.GameObject));
                    int layer = LuaAPI.xlua_tointeger(L, 2);
                    
                    KEngine.KTool.SetLayer( go, layer );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DFSFindObject_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Transform parent = (UnityEngine.Transform)translator.GetObject(L, 1, typeof(UnityEngine.Transform));
                    string name = LuaAPI.lua_tostring(L, 2);
                    
                        UnityEngine.GameObject __cl_gen_ret = KEngine.KTool.DFSFindObject( parent, name );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetGameObject_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Transform>(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    string name = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.Transform findTrans = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    bool isLog = LuaAPI.lua_toboolean(L, 3);
                    
                        UnityEngine.GameObject __cl_gen_ret = KEngine.KTool.GetGameObject( name, findTrans, isLog );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Transform>(L, 2)) 
                {
                    string name = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.Transform findTrans = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    
                        UnityEngine.GameObject __cl_gen_ret = KEngine.KTool.GetGameObject( name, findTrans );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to KEngine.KTool.GetGameObject!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetChild_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.GameObject>(L, 1)&& translator.Assignable<UnityEngine.GameObject>(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.GameObject child = (UnityEngine.GameObject)translator.GetObject(L, 1, typeof(UnityEngine.GameObject));
                    UnityEngine.GameObject parent = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
                    bool selfRotation = LuaAPI.lua_toboolean(L, 3);
                    bool selfScale = LuaAPI.lua_toboolean(L, 4);
                    
                    KEngine.KTool.SetChild( child, parent, selfRotation, selfScale );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.GameObject>(L, 1)&& translator.Assignable<UnityEngine.GameObject>(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.GameObject child = (UnityEngine.GameObject)translator.GetObject(L, 1, typeof(UnityEngine.GameObject));
                    UnityEngine.GameObject parent = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
                    bool selfRotation = LuaAPI.lua_toboolean(L, 3);
                    
                    KEngine.KTool.SetChild( child, parent, selfRotation );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.GameObject>(L, 1)&& translator.Assignable<UnityEngine.GameObject>(L, 2)) 
                {
                    UnityEngine.GameObject child = (UnityEngine.GameObject)translator.GetObject(L, 1, typeof(UnityEngine.GameObject));
                    UnityEngine.GameObject parent = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
                    
                    KEngine.KTool.SetChild( child, parent );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Transform>(L, 1)&& translator.Assignable<UnityEngine.Transform>(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Transform child = (UnityEngine.Transform)translator.GetObject(L, 1, typeof(UnityEngine.Transform));
                    UnityEngine.Transform parent = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    bool selfRotation = LuaAPI.lua_toboolean(L, 3);
                    bool selfScale = LuaAPI.lua_toboolean(L, 4);
                    
                    KEngine.KTool.SetChild( child, parent, selfRotation, selfScale );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Transform>(L, 1)&& translator.Assignable<UnityEngine.Transform>(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Transform child = (UnityEngine.Transform)translator.GetObject(L, 1, typeof(UnityEngine.Transform));
                    UnityEngine.Transform parent = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    bool selfRotation = LuaAPI.lua_toboolean(L, 3);
                    
                    KEngine.KTool.SetChild( child, parent, selfRotation );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Transform>(L, 1)&& translator.Assignable<UnityEngine.Transform>(L, 2)) 
                {
                    UnityEngine.Transform child = (UnityEngine.Transform)translator.GetObject(L, 1, typeof(UnityEngine.Transform));
                    UnityEngine.Transform parent = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    
                    KEngine.KTool.SetChild( child, parent );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to KEngine.KTool.SetChild!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ResetTransform_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Transform>(L, 1)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Transform transform = (UnityEngine.Transform)translator.GetObject(L, 1, typeof(UnityEngine.Transform));
                    bool selfRotation = LuaAPI.lua_toboolean(L, 2);
                    bool selfScale = LuaAPI.lua_toboolean(L, 3);
                    
                    KEngine.KTool.ResetTransform( transform, selfRotation, selfScale );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Transform>(L, 1)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    UnityEngine.Transform transform = (UnityEngine.Transform)translator.GetObject(L, 1, typeof(UnityEngine.Transform));
                    bool selfRotation = LuaAPI.lua_toboolean(L, 2);
                    
                    KEngine.KTool.ResetTransform( transform, selfRotation );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 1&& translator.Assignable<UnityEngine.Transform>(L, 1)) 
                {
                    UnityEngine.Transform transform = (UnityEngine.Transform)translator.GetObject(L, 1, typeof(UnityEngine.Transform));
                    
                    KEngine.KTool.ResetTransform( transform );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to KEngine.KTool.ResetTransform!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetRootPathName_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Transform transform = (UnityEngine.Transform)translator.GetObject(L, 1, typeof(UnityEngine.Transform));
                    
                        string __cl_gen_ret = KEngine.KTool.GetRootPathName( transform );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MD5_Stream_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    System.IO.Stream stream = (System.IO.Stream)translator.GetObject(L, 1, typeof(System.IO.Stream));
                    
                        string __cl_gen_ret = KEngine.KTool.MD5_Stream( stream );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MD5_File_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    string filePath = LuaAPI.lua_tostring(L, 1);
                    
                        string __cl_gen_ret = KEngine.KTool.MD5_File( filePath );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MD5_bytes_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    string str = LuaAPI.lua_tostring(L, 1);
                    
                        byte[] __cl_gen_ret = KEngine.KTool.MD5_bytes( str );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MD5_16bit_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    string str = LuaAPI.lua_tostring(L, 1);
                    
                        string __cl_gen_ret = KEngine.KTool.MD5_16bit( str );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IntLerp_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    int from = LuaAPI.xlua_tointeger(L, 1);
                    int to = LuaAPI.xlua_tointeger(L, 2);
                    
                        int __cl_gen_ret = KEngine.KTool.IntLerp( from, to );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ScaleParticleSystem_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.GameObject gameObj = (UnityEngine.GameObject)translator.GetObject(L, 1, typeof(UnityEngine.GameObject));
                    float scale = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    KEngine.KTool.ScaleParticleSystem( gameObj, scale );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetParticleSystemRenderQueue_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Transform>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    UnityEngine.Transform parent = (UnityEngine.Transform)translator.GetObject(L, 1, typeof(UnityEngine.Transform));
                    int renderQueue = LuaAPI.xlua_tointeger(L, 2);
                    
                    KEngine.KTool.SetParticleSystemRenderQueue( parent, renderQueue );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 1&& translator.Assignable<UnityEngine.Transform>(L, 1)) 
                {
                    UnityEngine.Transform parent = (UnityEngine.Transform)translator.GetObject(L, 1, typeof(UnityEngine.Transform));
                    
                    KEngine.KTool.SetParticleSystemRenderQueue( parent );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to KEngine.KTool.SetParticleSystemRenderQueue!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CopyTransformToTarget_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Transform sourceTrans = (UnityEngine.Transform)translator.GetObject(L, 1, typeof(UnityEngine.Transform));
                    UnityEngine.Transform targetTrans = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    
                    KEngine.KTool.CopyTransformToTarget( sourceTrans, targetTrans );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HasWriteAccessToFolder_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    string folderPath = LuaAPI.lua_tostring(L, 1);
                    
                        bool __cl_gen_ret = KEngine.KTool.HasWriteAccessToFolder( folderPath );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetStaticRecursively_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.GameObject obj = (UnityEngine.GameObject)translator.GetObject(L, 1, typeof(UnityEngine.GameObject));
                    
                    KEngine.KTool.SetStaticRecursively( obj );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetNormalizedAngle_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    float _anyAngle = (float)LuaAPI.lua_tonumber(L, 1);
                    
                        float __cl_gen_ret = KEngine.KTool.GetNormalizedAngle( _anyAngle );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AdjustCollidersCenterZ_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.GameObject>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    UnityEngine.GameObject gameObj = (UnityEngine.GameObject)translator.GetObject(L, 1, typeof(UnityEngine.GameObject));
                    float z = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    KEngine.KTool.AdjustCollidersCenterZ( gameObj, z );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 1&& translator.Assignable<UnityEngine.GameObject>(L, 1)) 
                {
                    UnityEngine.GameObject gameObj = (UnityEngine.GameObject)translator.GetObject(L, 1, typeof(UnityEngine.GameObject));
                    
                    KEngine.KTool.AdjustCollidersCenterZ( gameObj );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to KEngine.KTool.AdjustCollidersCenterZ!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToTitleCase_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    string word = LuaAPI.lua_tostring(L, 1);
                    
                        string __cl_gen_ret = KEngine.KTool.ToTitleCase( word );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToSentenceCase_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    string str = LuaAPI.lua_tostring(L, 1);
                    
                        string __cl_gen_ret = KEngine.KTool.ToSentenceCase( str );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Probability_xlua_st_(RealStatePtr L)
        {
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    float chancePercent = (float)LuaAPI.lua_tonumber(L, 1);
                    
                        bool __cl_gen_ret = KEngine.KTool.Probability( chancePercent );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    byte chancePercent = (byte)LuaAPI.lua_tonumber(L, 1);
                    
                        bool __cl_gen_ret = KEngine.KTool.Probability( chancePercent );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to KEngine.KTool.Probability!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetSmartNpcPoints_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Vector3 startDirection;translator.Get(L, 1, out startDirection);
                    int nNum = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Vector3 pAnchorPos;translator.Get(L, 3, out pAnchorPos);
                    float fAngle = (float)LuaAPI.lua_tonumber(L, 4);
                    float nRadius = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        UnityEngine.Vector3[] __cl_gen_ret = KEngine.KTool.GetSmartNpcPoints( startDirection, nNum, pAnchorPos, fAngle, nRadius );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetParallelPoints_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Vector3 startPos;translator.Get(L, 1, out startPos);
                    UnityEngine.Vector3 startDirection;translator.Get(L, 2, out startDirection);
                    int nNum = LuaAPI.xlua_tointeger(L, 3);
                    float meterInterval = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        UnityEngine.Vector3[] __cl_gen_ret = KEngine.KTool.GetParallelPoints( startPos, startDirection, nNum, meterInterval );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LineIntersectionPoint_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Vector2 intersectPoint;
                    UnityEngine.Vector2 ps1;translator.Get(L, 1, out ps1);
                    UnityEngine.Vector2 pe1;translator.Get(L, 2, out pe1);
                    UnityEngine.Vector2 ps2;translator.Get(L, 3, out ps2);
                    UnityEngine.Vector2 pe2;translator.Get(L, 4, out pe2);
                    
                        bool __cl_gen_ret = KEngine.KTool.LineIntersectionPoint( out intersectPoint, ps1, pe1, ps2, pe2 );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    translator.PushUnityEngineVector2(L, intersectPoint);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsNumber_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    string str = LuaAPI.lua_tostring(L, 1);
                    
                        bool __cl_gen_ret = KEngine.KTool.IsNumber( str );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetRelativePositionOfEllipse_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    float 长半轴即目标距离 = (float)LuaAPI.lua_tonumber(L, 1);
                    float 短半轴 = (float)LuaAPI.lua_tonumber(L, 2);
                    float angle = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        UnityEngine.Vector2 __cl_gen_ret = KEngine.KTool.GetRelativePositionOfEllipse( 长半轴即目标距离, 短半轴, angle );
                        translator.PushUnityEngineVector2(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Angle_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Vector2 from;translator.Get(L, 1, out from);
                    UnityEngine.Vector2 to;translator.Get(L, 2, out to);
                    
                        float __cl_gen_ret = KEngine.KTool.Angle( from, to );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_NumberFormatTo3_xlua_st_(RealStatePtr L)
        {
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1) || LuaAPI.lua_isint64(L, 1))&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    long num = LuaAPI.lua_toint64(L, 1);
                    string sp = LuaAPI.lua_tostring(L, 2);
                    
                        string __cl_gen_ret = KEngine.KTool.NumberFormatTo3( num, sp );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 1&& (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1) || LuaAPI.lua_isint64(L, 1))) 
                {
                    long num = LuaAPI.lua_toint64(L, 1);
                    
                        string __cl_gen_ret = KEngine.KTool.NumberFormatTo3( num );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to KEngine.KTool.NumberFormatTo3!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetIpAddressFromIpHostEntry_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    System.Net.IPHostEntry ipHostEntry = (System.Net.IPHostEntry)translator.GetObject(L, 1, typeof(System.Net.IPHostEntry));
                    
                        System.Net.IPAddress __cl_gen_ret = KEngine.KTool.GetIpAddressFromIpHostEntry( ipHostEntry );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetIpAddress_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Action<System.Net.IPAddress>>(L, 2)) 
                {
                    string host = LuaAPI.lua_tostring(L, 1);
                    System.Action<System.Net.IPAddress> callback = translator.GetDelegate<System.Action<System.Net.IPAddress>>(L, 2);
                    
                    KEngine.KTool.GetIpAddress( host, callback );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string host = LuaAPI.lua_tostring(L, 1);
                    
                    KEngine.KTool.GetIpAddress( host );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to KEngine.KTool.GetIpAddress!");
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
