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
    public class KSFrameworkLuaModuleWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(KSFramework.LuaModule), L, translator, 0, 8, 2, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ExecuteScript", _m_ExecuteScript);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CallScript", _m_CallScript);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "HasScript", _m_HasScript);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Import", _m_Import);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TryImport", _m_TryImport);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ClearAllCache", _m_ClearAllCache);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ClearCache", _m_ClearCache);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Init", _m_Init);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsInited", _g_get_IsInited);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "InitProgress", _g_get_InitProgress);
            
			
			Utils.EndObjectRegister(typeof(KSFramework.LuaModule), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(KSFramework.LuaModule), L, __CreateInstance, 1, 2, 2);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(KSFramework.LuaModule));
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Instance", _g_get_Instance);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "CacheMode", _g_get_CacheMode);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Instance", _s_set_Instance);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "CacheMode", _s_set_CacheMode);
            
			Utils.EndClassRegister(typeof(KSFramework.LuaModule), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "KSFramework.LuaModule does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ExecuteScript(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            KSFramework.LuaModule __cl_gen_to_be_invoked = (KSFramework.LuaModule)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    byte[] scriptCode = LuaAPI.lua_tobytes(L, 2);
                    
                        object __cl_gen_ret = __cl_gen_to_be_invoked.ExecuteScript( scriptCode );
                        translator.PushAny(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    byte[] scriptCode = LuaAPI.lua_tobytes(L, 2);
                    object ret;
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.ExecuteScript( scriptCode, out ret );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    translator.PushAny(L, ret);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to KSFramework.LuaModule.ExecuteScript!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CallScript(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            KSFramework.LuaModule __cl_gen_to_be_invoked = (KSFramework.LuaModule)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string path = LuaAPI.lua_tostring(L, 2);
                    
                        object __cl_gen_ret = __cl_gen_to_be_invoked.CallScript( path );
                        translator.PushAny(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HasScript(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            KSFramework.LuaModule __cl_gen_to_be_invoked = (KSFramework.LuaModule)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string scriptRelativePath = LuaAPI.lua_tostring(L, 2);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.HasScript( scriptRelativePath );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Import(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            KSFramework.LuaModule __cl_gen_to_be_invoked = (KSFramework.LuaModule)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string fileName = LuaAPI.lua_tostring(L, 2);
                    
                        object __cl_gen_ret = __cl_gen_to_be_invoked.Import( fileName );
                        translator.PushAny(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TryImport(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            KSFramework.LuaModule __cl_gen_to_be_invoked = (KSFramework.LuaModule)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string fileName = LuaAPI.lua_tostring(L, 2);
                    object result;
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.TryImport( fileName, out result );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    translator.PushAny(L, result);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ClearAllCache(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            KSFramework.LuaModule __cl_gen_to_be_invoked = (KSFramework.LuaModule)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.ClearAllCache(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ClearCache(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            KSFramework.LuaModule __cl_gen_to_be_invoked = (KSFramework.LuaModule)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string uiLuaPath = LuaAPI.lua_tostring(L, 2);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.ClearCache( uiLuaPath );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Init(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            KSFramework.LuaModule __cl_gen_to_be_invoked = (KSFramework.LuaModule)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                        System.Collections.IEnumerator __cl_gen_ret = __cl_gen_to_be_invoked.Init(  );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsInited(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                KSFramework.LuaModule __cl_gen_to_be_invoked = (KSFramework.LuaModule)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.IsInited);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_InitProgress(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                KSFramework.LuaModule __cl_gen_to_be_invoked = (KSFramework.LuaModule)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.InitProgress);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Instance(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, KSFramework.LuaModule.Instance);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_CacheMode(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushboolean(L, KSFramework.LuaModule.CacheMode);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Instance(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    KSFramework.LuaModule.Instance = (KSFramework.LuaModule)translator.GetObject(L, 1, typeof(KSFramework.LuaModule));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_CacheMode(RealStatePtr L)
        {
            
            try {
			    KSFramework.LuaModule.CacheMode = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
