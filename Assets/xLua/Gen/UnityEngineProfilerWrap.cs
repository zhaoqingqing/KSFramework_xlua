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
    public class UnityEngineProfilerWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.Profiler), L, translator, 0, 0, 0, 0);
			
			
			
			
			
			Utils.EndObjectRegister(typeof(UnityEngine.Profiler), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.Profiler), L, __CreateInstance, 10, 6, 4);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "AddFramesFromFile", _m_AddFramesFromFile_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "BeginSample", _m_BeginSample_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "EndSample", _m_EndSample_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetRuntimeMemorySize", _m_GetRuntimeMemorySize_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetMonoHeapSize", _m_GetMonoHeapSize_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetMonoUsedSize", _m_GetMonoUsedSize_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetTotalAllocatedMemory", _m_GetTotalAllocatedMemory_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetTotalUnusedReservedMemory", _m_GetTotalUnusedReservedMemory_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetTotalReservedMemory", _m_GetTotalReservedMemory_xlua_st_);
            
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.Profiler));
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "supported", _g_get_supported);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "logFile", _g_get_logFile);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "enableBinaryLog", _g_get_enableBinaryLog);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "enabled", _g_get_enabled);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "maxNumberOfSamplesPerFrame", _g_get_maxNumberOfSamplesPerFrame);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "usedHeapSize", _g_get_usedHeapSize);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "logFile", _s_set_logFile);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "enableBinaryLog", _s_set_enableBinaryLog);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "enabled", _s_set_enabled);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "maxNumberOfSamplesPerFrame", _s_set_maxNumberOfSamplesPerFrame);
            
			Utils.EndClassRegister(typeof(UnityEngine.Profiler), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityEngine.Profiler __cl_gen_ret = new UnityEngine.Profiler();
					translator.Push(L, __cl_gen_ret);
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Profiler constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddFramesFromFile_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    string file = LuaAPI.lua_tostring(L, 1);
                    
                    UnityEngine.Profiler.AddFramesFromFile( file );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_BeginSample_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string name = LuaAPI.lua_tostring(L, 1);
                    
                    UnityEngine.Profiler.BeginSample( name );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Object>(L, 2)) 
                {
                    string name = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.Object targetObject = (UnityEngine.Object)translator.GetObject(L, 2, typeof(UnityEngine.Object));
                    
                    UnityEngine.Profiler.BeginSample( name, targetObject );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Profiler.BeginSample!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EndSample_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    
                    UnityEngine.Profiler.EndSample(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetRuntimeMemorySize_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Object o = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    
                        int __cl_gen_ret = UnityEngine.Profiler.GetRuntimeMemorySize( o );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetMonoHeapSize_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    
                        uint __cl_gen_ret = UnityEngine.Profiler.GetMonoHeapSize(  );
                        LuaAPI.xlua_pushuint(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetMonoUsedSize_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    
                        uint __cl_gen_ret = UnityEngine.Profiler.GetMonoUsedSize(  );
                        LuaAPI.xlua_pushuint(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetTotalAllocatedMemory_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    
                        uint __cl_gen_ret = UnityEngine.Profiler.GetTotalAllocatedMemory(  );
                        LuaAPI.xlua_pushuint(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetTotalUnusedReservedMemory_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    
                        uint __cl_gen_ret = UnityEngine.Profiler.GetTotalUnusedReservedMemory(  );
                        LuaAPI.xlua_pushuint(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetTotalReservedMemory_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    
                        uint __cl_gen_ret = UnityEngine.Profiler.GetTotalReservedMemory(  );
                        LuaAPI.xlua_pushuint(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_supported(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushboolean(L, UnityEngine.Profiler.supported);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_logFile(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushstring(L, UnityEngine.Profiler.logFile);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_enableBinaryLog(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushboolean(L, UnityEngine.Profiler.enableBinaryLog);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_enabled(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushboolean(L, UnityEngine.Profiler.enabled);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maxNumberOfSamplesPerFrame(RealStatePtr L)
        {
            
            try {
			    LuaAPI.xlua_pushinteger(L, UnityEngine.Profiler.maxNumberOfSamplesPerFrame);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_usedHeapSize(RealStatePtr L)
        {
            
            try {
			    LuaAPI.xlua_pushuint(L, UnityEngine.Profiler.usedHeapSize);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_logFile(RealStatePtr L)
        {
            
            try {
			    UnityEngine.Profiler.logFile = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_enableBinaryLog(RealStatePtr L)
        {
            
            try {
			    UnityEngine.Profiler.enableBinaryLog = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_enabled(RealStatePtr L)
        {
            
            try {
			    UnityEngine.Profiler.enabled = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_maxNumberOfSamplesPerFrame(RealStatePtr L)
        {
            
            try {
			    UnityEngine.Profiler.maxNumberOfSamplesPerFrame = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
