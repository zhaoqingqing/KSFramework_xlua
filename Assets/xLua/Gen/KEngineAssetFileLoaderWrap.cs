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
    public class KEngineAssetFileLoaderWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(KEngine.AssetFileLoader), L, translator, 0, 0, 2, 0);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "Asset", _g_get_Asset);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Progress", _g_get_Progress);
            
			
			Utils.EndObjectRegister(typeof(KEngine.AssetFileLoader), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(KEngine.AssetFileLoader), L, __CreateInstance, 3, 1, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Load", _m_Load_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "RefreshMaterialsShaders", _m_RefreshMaterialsShaders_xlua_st_);
            
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(KEngine.AssetFileLoader));
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "IsEditorLoadAsset", _g_get_IsEditorLoadAsset);
            
			
			Utils.EndClassRegister(typeof(KEngine.AssetFileLoader), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					KEngine.AssetFileLoader __cl_gen_ret = new KEngine.AssetFileLoader();
					translator.Push(L, __cl_gen_ret);
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to KEngine.AssetFileLoader constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Load_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<KEngine.AssetFileLoader.AssetFileBridgeDelegate>(L, 2)&& translator.Assignable<KEngine.LoaderMode>(L, 3)) 
                {
                    string path = LuaAPI.lua_tostring(L, 1);
                    KEngine.AssetFileLoader.AssetFileBridgeDelegate assetFileLoadedCallback = translator.GetDelegate<KEngine.AssetFileLoader.AssetFileBridgeDelegate>(L, 2);
                    KEngine.LoaderMode loaderMode;translator.Get(L, 3, out loaderMode);
                    
                        KEngine.AssetFileLoader __cl_gen_ret = KEngine.AssetFileLoader.Load( path, assetFileLoadedCallback, loaderMode );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<KEngine.AssetFileLoader.AssetFileBridgeDelegate>(L, 2)) 
                {
                    string path = LuaAPI.lua_tostring(L, 1);
                    KEngine.AssetFileLoader.AssetFileBridgeDelegate assetFileLoadedCallback = translator.GetDelegate<KEngine.AssetFileLoader.AssetFileBridgeDelegate>(L, 2);
                    
                        KEngine.AssetFileLoader __cl_gen_ret = KEngine.AssetFileLoader.Load( path, assetFileLoadedCallback );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string path = LuaAPI.lua_tostring(L, 1);
                    
                        KEngine.AssetFileLoader __cl_gen_ret = KEngine.AssetFileLoader.Load( path );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to KEngine.AssetFileLoader.Load!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RefreshMaterialsShaders_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Renderer renderer = (UnityEngine.Renderer)translator.GetObject(L, 1, typeof(UnityEngine.Renderer));
                    
                    KEngine.AssetFileLoader.RefreshMaterialsShaders( renderer );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Asset(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                KEngine.AssetFileLoader __cl_gen_to_be_invoked = (KEngine.AssetFileLoader)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.Asset);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsEditorLoadAsset(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushboolean(L, KEngine.AssetFileLoader.IsEditorLoadAsset);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Progress(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                KEngine.AssetFileLoader __cl_gen_to_be_invoked = (KEngine.AssetFileLoader)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.Progress);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
