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
    public class KEngineAssetBundleLoaderWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(KEngine.AssetBundleLoader), L, translator, 0, 2, 1, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Release", _m_Release);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushLoadedAsset", _m_PushLoadedAsset);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "Bundle", _g_get_Bundle);
            
			
			Utils.EndObjectRegister(typeof(KEngine.AssetBundleLoader), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(KEngine.AssetBundleLoader), L, __CreateInstance, 2, 2, 2);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Load", _m_Load_xlua_st_);
            
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(KEngine.AssetBundleLoader));
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "NewAssetBundleLoaderEvent", _g_get_NewAssetBundleLoaderEvent);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "AssetBundlerLoaderErrorEvent", _g_get_AssetBundlerLoaderErrorEvent);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "NewAssetBundleLoaderEvent", _s_set_NewAssetBundleLoaderEvent);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "AssetBundlerLoaderErrorEvent", _s_set_AssetBundlerLoaderErrorEvent);
            
			Utils.EndClassRegister(typeof(KEngine.AssetBundleLoader), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					KEngine.AssetBundleLoader __cl_gen_ret = new KEngine.AssetBundleLoader();
					translator.Push(L, __cl_gen_ret);
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to KEngine.AssetBundleLoader constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Load_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<KEngine.AssetBundleLoader.CAssetBundleLoaderDelegate>(L, 2)&& translator.Assignable<KEngine.LoaderMode>(L, 3)) 
                {
                    string url = LuaAPI.lua_tostring(L, 1);
                    KEngine.AssetBundleLoader.CAssetBundleLoaderDelegate callback = translator.GetDelegate<KEngine.AssetBundleLoader.CAssetBundleLoaderDelegate>(L, 2);
                    KEngine.LoaderMode loaderMode;translator.Get(L, 3, out loaderMode);
                    
                        KEngine.AssetBundleLoader __cl_gen_ret = KEngine.AssetBundleLoader.Load( url, callback, loaderMode );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<KEngine.AssetBundleLoader.CAssetBundleLoaderDelegate>(L, 2)) 
                {
                    string url = LuaAPI.lua_tostring(L, 1);
                    KEngine.AssetBundleLoader.CAssetBundleLoaderDelegate callback = translator.GetDelegate<KEngine.AssetBundleLoader.CAssetBundleLoaderDelegate>(L, 2);
                    
                        KEngine.AssetBundleLoader __cl_gen_ret = KEngine.AssetBundleLoader.Load( url, callback );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string url = LuaAPI.lua_tostring(L, 1);
                    
                        KEngine.AssetBundleLoader __cl_gen_ret = KEngine.AssetBundleLoader.Load( url );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to KEngine.AssetBundleLoader.Load!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Release(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            KEngine.AssetBundleLoader __cl_gen_to_be_invoked = (KEngine.AssetBundleLoader)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.Release(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushLoadedAsset(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            KEngine.AssetBundleLoader __cl_gen_to_be_invoked = (KEngine.AssetBundleLoader)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Object getAsset = (UnityEngine.Object)translator.GetObject(L, 2, typeof(UnityEngine.Object));
                    
                    __cl_gen_to_be_invoked.PushLoadedAsset( getAsset );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Bundle(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                KEngine.AssetBundleLoader __cl_gen_to_be_invoked = (KEngine.AssetBundleLoader)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.Bundle);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_NewAssetBundleLoaderEvent(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, KEngine.AssetBundleLoader.NewAssetBundleLoaderEvent);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AssetBundlerLoaderErrorEvent(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, KEngine.AssetBundleLoader.AssetBundlerLoaderErrorEvent);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_NewAssetBundleLoaderEvent(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    KEngine.AssetBundleLoader.NewAssetBundleLoaderEvent = translator.GetDelegate<System.Action<string>>(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_AssetBundlerLoaderErrorEvent(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    KEngine.AssetBundleLoader.AssetBundlerLoaderErrorEvent = translator.GetDelegate<System.Action<KEngine.AssetBundleLoader>>(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
