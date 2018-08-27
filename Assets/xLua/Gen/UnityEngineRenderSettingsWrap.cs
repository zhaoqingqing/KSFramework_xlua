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
    public class UnityEngineRenderSettingsWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.RenderSettings), L, translator, 0, 0, 0, 0);
			
			
			
			
			
			Utils.EndObjectRegister(typeof(UnityEngine.RenderSettings), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.RenderSettings), L, __CreateInstance, 1, 22, 22);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.RenderSettings));
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "fog", _g_get_fog);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "fogMode", _g_get_fogMode);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "fogColor", _g_get_fogColor);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "fogDensity", _g_get_fogDensity);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "fogStartDistance", _g_get_fogStartDistance);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "fogEndDistance", _g_get_fogEndDistance);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "ambientMode", _g_get_ambientMode);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "ambientSkyColor", _g_get_ambientSkyColor);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "ambientEquatorColor", _g_get_ambientEquatorColor);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "ambientGroundColor", _g_get_ambientGroundColor);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "ambientLight", _g_get_ambientLight);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "ambientIntensity", _g_get_ambientIntensity);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "ambientProbe", _g_get_ambientProbe);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "reflectionIntensity", _g_get_reflectionIntensity);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "reflectionBounces", _g_get_reflectionBounces);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "haloStrength", _g_get_haloStrength);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "flareStrength", _g_get_flareStrength);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "flareFadeSpeed", _g_get_flareFadeSpeed);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "skybox", _g_get_skybox);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "defaultReflectionMode", _g_get_defaultReflectionMode);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "defaultReflectionResolution", _g_get_defaultReflectionResolution);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "customReflection", _g_get_customReflection);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "fog", _s_set_fog);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "fogMode", _s_set_fogMode);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "fogColor", _s_set_fogColor);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "fogDensity", _s_set_fogDensity);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "fogStartDistance", _s_set_fogStartDistance);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "fogEndDistance", _s_set_fogEndDistance);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "ambientMode", _s_set_ambientMode);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "ambientSkyColor", _s_set_ambientSkyColor);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "ambientEquatorColor", _s_set_ambientEquatorColor);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "ambientGroundColor", _s_set_ambientGroundColor);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "ambientLight", _s_set_ambientLight);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "ambientIntensity", _s_set_ambientIntensity);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "ambientProbe", _s_set_ambientProbe);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "reflectionIntensity", _s_set_reflectionIntensity);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "reflectionBounces", _s_set_reflectionBounces);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "haloStrength", _s_set_haloStrength);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "flareStrength", _s_set_flareStrength);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "flareFadeSpeed", _s_set_flareFadeSpeed);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "skybox", _s_set_skybox);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "defaultReflectionMode", _s_set_defaultReflectionMode);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "defaultReflectionResolution", _s_set_defaultReflectionResolution);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "customReflection", _s_set_customReflection);
            
			Utils.EndClassRegister(typeof(UnityEngine.RenderSettings), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityEngine.RenderSettings __cl_gen_ret = new UnityEngine.RenderSettings();
					translator.Push(L, __cl_gen_ret);
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.RenderSettings constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_fog(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushboolean(L, UnityEngine.RenderSettings.fog);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_fogMode(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.PushUnityEngineFogMode(L, UnityEngine.RenderSettings.fogMode);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_fogColor(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.PushUnityEngineColor(L, UnityEngine.RenderSettings.fogColor);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_fogDensity(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushnumber(L, UnityEngine.RenderSettings.fogDensity);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_fogStartDistance(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushnumber(L, UnityEngine.RenderSettings.fogStartDistance);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_fogEndDistance(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushnumber(L, UnityEngine.RenderSettings.fogEndDistance);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ambientMode(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, UnityEngine.RenderSettings.ambientMode);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ambientSkyColor(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.PushUnityEngineColor(L, UnityEngine.RenderSettings.ambientSkyColor);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ambientEquatorColor(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.PushUnityEngineColor(L, UnityEngine.RenderSettings.ambientEquatorColor);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ambientGroundColor(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.PushUnityEngineColor(L, UnityEngine.RenderSettings.ambientGroundColor);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ambientLight(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.PushUnityEngineColor(L, UnityEngine.RenderSettings.ambientLight);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ambientIntensity(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushnumber(L, UnityEngine.RenderSettings.ambientIntensity);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ambientProbe(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, UnityEngine.RenderSettings.ambientProbe);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_reflectionIntensity(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushnumber(L, UnityEngine.RenderSettings.reflectionIntensity);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_reflectionBounces(RealStatePtr L)
        {
            
            try {
			    LuaAPI.xlua_pushinteger(L, UnityEngine.RenderSettings.reflectionBounces);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_haloStrength(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushnumber(L, UnityEngine.RenderSettings.haloStrength);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_flareStrength(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushnumber(L, UnityEngine.RenderSettings.flareStrength);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_flareFadeSpeed(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushnumber(L, UnityEngine.RenderSettings.flareFadeSpeed);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_skybox(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, UnityEngine.RenderSettings.skybox);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_defaultReflectionMode(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, UnityEngine.RenderSettings.defaultReflectionMode);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_defaultReflectionResolution(RealStatePtr L)
        {
            
            try {
			    LuaAPI.xlua_pushinteger(L, UnityEngine.RenderSettings.defaultReflectionResolution);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_customReflection(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, UnityEngine.RenderSettings.customReflection);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_fog(RealStatePtr L)
        {
            
            try {
			    UnityEngine.RenderSettings.fog = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_fogMode(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			UnityEngine.FogMode __cl_gen_value;translator.Get(L, 1, out __cl_gen_value);
				UnityEngine.RenderSettings.fogMode = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_fogColor(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			UnityEngine.Color __cl_gen_value;translator.Get(L, 1, out __cl_gen_value);
				UnityEngine.RenderSettings.fogColor = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_fogDensity(RealStatePtr L)
        {
            
            try {
			    UnityEngine.RenderSettings.fogDensity = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_fogStartDistance(RealStatePtr L)
        {
            
            try {
			    UnityEngine.RenderSettings.fogStartDistance = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_fogEndDistance(RealStatePtr L)
        {
            
            try {
			    UnityEngine.RenderSettings.fogEndDistance = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ambientMode(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			UnityEngine.Rendering.AmbientMode __cl_gen_value;translator.Get(L, 1, out __cl_gen_value);
				UnityEngine.RenderSettings.ambientMode = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ambientSkyColor(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			UnityEngine.Color __cl_gen_value;translator.Get(L, 1, out __cl_gen_value);
				UnityEngine.RenderSettings.ambientSkyColor = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ambientEquatorColor(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			UnityEngine.Color __cl_gen_value;translator.Get(L, 1, out __cl_gen_value);
				UnityEngine.RenderSettings.ambientEquatorColor = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ambientGroundColor(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			UnityEngine.Color __cl_gen_value;translator.Get(L, 1, out __cl_gen_value);
				UnityEngine.RenderSettings.ambientGroundColor = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ambientLight(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			UnityEngine.Color __cl_gen_value;translator.Get(L, 1, out __cl_gen_value);
				UnityEngine.RenderSettings.ambientLight = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ambientIntensity(RealStatePtr L)
        {
            
            try {
			    UnityEngine.RenderSettings.ambientIntensity = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ambientProbe(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			UnityEngine.Rendering.SphericalHarmonicsL2 __cl_gen_value;translator.Get(L, 1, out __cl_gen_value);
				UnityEngine.RenderSettings.ambientProbe = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_reflectionIntensity(RealStatePtr L)
        {
            
            try {
			    UnityEngine.RenderSettings.reflectionIntensity = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_reflectionBounces(RealStatePtr L)
        {
            
            try {
			    UnityEngine.RenderSettings.reflectionBounces = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_haloStrength(RealStatePtr L)
        {
            
            try {
			    UnityEngine.RenderSettings.haloStrength = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_flareStrength(RealStatePtr L)
        {
            
            try {
			    UnityEngine.RenderSettings.flareStrength = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_flareFadeSpeed(RealStatePtr L)
        {
            
            try {
			    UnityEngine.RenderSettings.flareFadeSpeed = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_skybox(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    UnityEngine.RenderSettings.skybox = (UnityEngine.Material)translator.GetObject(L, 1, typeof(UnityEngine.Material));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_defaultReflectionMode(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			UnityEngine.Rendering.DefaultReflectionMode __cl_gen_value;translator.Get(L, 1, out __cl_gen_value);
				UnityEngine.RenderSettings.defaultReflectionMode = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_defaultReflectionResolution(RealStatePtr L)
        {
            
            try {
			    UnityEngine.RenderSettings.defaultReflectionResolution = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_customReflection(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    UnityEngine.RenderSettings.customReflection = (UnityEngine.Cubemap)translator.GetObject(L, 1, typeof(UnityEngine.Cubemap));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
