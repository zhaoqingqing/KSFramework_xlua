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
    public class UnityEngineSceneManagementSceneManagerWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.SceneManagement.SceneManager), L, translator, 0, 0, 0, 0);
			
			
			
			
			
			Utils.EndObjectRegister(typeof(UnityEngine.SceneManagement.SceneManager), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.SceneManagement.SceneManager), L, __CreateInstance, 12, 2, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "GetActiveScene", _m_GetActiveScene_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetActiveScene", _m_SetActiveScene_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetSceneByPath", _m_GetSceneByPath_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetSceneByName", _m_GetSceneByName_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetSceneAt", _m_GetSceneAt_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LoadScene", _m_LoadScene_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LoadSceneAsync", _m_LoadSceneAsync_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CreateScene", _m_CreateScene_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "UnloadScene", _m_UnloadScene_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "MergeScenes", _m_MergeScenes_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "MoveGameObjectToScene", _m_MoveGameObjectToScene_xlua_st_);
            
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.SceneManagement.SceneManager));
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "sceneCount", _g_get_sceneCount);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "sceneCountInBuildSettings", _g_get_sceneCountInBuildSettings);
            
			
			Utils.EndClassRegister(typeof(UnityEngine.SceneManagement.SceneManager), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityEngine.SceneManagement.SceneManager __cl_gen_ret = new UnityEngine.SceneManagement.SceneManager();
					translator.Push(L, __cl_gen_ret);
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.SceneManagement.SceneManager constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetActiveScene_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    
                        UnityEngine.SceneManagement.Scene __cl_gen_ret = UnityEngine.SceneManagement.SceneManager.GetActiveScene(  );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetActiveScene_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.SceneManagement.Scene scene;translator.Get(L, 1, out scene);
                    
                        bool __cl_gen_ret = UnityEngine.SceneManagement.SceneManager.SetActiveScene( scene );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetSceneByPath_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    string scenePath = LuaAPI.lua_tostring(L, 1);
                    
                        UnityEngine.SceneManagement.Scene __cl_gen_ret = UnityEngine.SceneManagement.SceneManager.GetSceneByPath( scenePath );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetSceneByName_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    string name = LuaAPI.lua_tostring(L, 1);
                    
                        UnityEngine.SceneManagement.Scene __cl_gen_ret = UnityEngine.SceneManagement.SceneManager.GetSceneByName( name );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetSceneAt_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    int index = LuaAPI.xlua_tointeger(L, 1);
                    
                        UnityEngine.SceneManagement.Scene __cl_gen_ret = UnityEngine.SceneManagement.SceneManager.GetSceneAt( index );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadScene_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    int sceneBuildIndex = LuaAPI.xlua_tointeger(L, 1);
                    
                    UnityEngine.SceneManagement.SceneManager.LoadScene( sceneBuildIndex );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string sceneName = LuaAPI.lua_tostring(L, 1);
                    
                    UnityEngine.SceneManagement.SceneManager.LoadScene( sceneName );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.SceneManagement.LoadSceneMode>(L, 2)) 
                {
                    int sceneBuildIndex = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.SceneManagement.LoadSceneMode mode;translator.Get(L, 2, out mode);
                    
                    UnityEngine.SceneManagement.SceneManager.LoadScene( sceneBuildIndex, mode );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.SceneManagement.LoadSceneMode>(L, 2)) 
                {
                    string sceneName = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.SceneManagement.LoadSceneMode mode;translator.Get(L, 2, out mode);
                    
                    UnityEngine.SceneManagement.SceneManager.LoadScene( sceneName, mode );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.SceneManagement.SceneManager.LoadScene!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadSceneAsync_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    int sceneBuildIndex = LuaAPI.xlua_tointeger(L, 1);
                    
                        UnityEngine.AsyncOperation __cl_gen_ret = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync( sceneBuildIndex );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string sceneName = LuaAPI.lua_tostring(L, 1);
                    
                        UnityEngine.AsyncOperation __cl_gen_ret = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync( sceneName );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.SceneManagement.LoadSceneMode>(L, 2)) 
                {
                    int sceneBuildIndex = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.SceneManagement.LoadSceneMode mode;translator.Get(L, 2, out mode);
                    
                        UnityEngine.AsyncOperation __cl_gen_ret = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync( sceneBuildIndex, mode );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.SceneManagement.LoadSceneMode>(L, 2)) 
                {
                    string sceneName = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.SceneManagement.LoadSceneMode mode;translator.Get(L, 2, out mode);
                    
                        UnityEngine.AsyncOperation __cl_gen_ret = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync( sceneName, mode );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.SceneManagement.SceneManager.LoadSceneAsync!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateScene_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    string sceneName = LuaAPI.lua_tostring(L, 1);
                    
                        UnityEngine.SceneManagement.Scene __cl_gen_ret = UnityEngine.SceneManagement.SceneManager.CreateScene( sceneName );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UnloadScene_xlua_st_(RealStatePtr L)
        {
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    int sceneBuildIndex = LuaAPI.xlua_tointeger(L, 1);
                    
                        bool __cl_gen_ret = UnityEngine.SceneManagement.SceneManager.UnloadScene( sceneBuildIndex );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string sceneName = LuaAPI.lua_tostring(L, 1);
                    
                        bool __cl_gen_ret = UnityEngine.SceneManagement.SceneManager.UnloadScene( sceneName );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.SceneManagement.SceneManager.UnloadScene!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MergeScenes_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.SceneManagement.Scene sourceScene;translator.Get(L, 1, out sourceScene);
                    UnityEngine.SceneManagement.Scene destinationScene;translator.Get(L, 2, out destinationScene);
                    
                    UnityEngine.SceneManagement.SceneManager.MergeScenes( sourceScene, destinationScene );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MoveGameObjectToScene_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.GameObject go = (UnityEngine.GameObject)translator.GetObject(L, 1, typeof(UnityEngine.GameObject));
                    UnityEngine.SceneManagement.Scene scene;translator.Get(L, 2, out scene);
                    
                    UnityEngine.SceneManagement.SceneManager.MoveGameObjectToScene( go, scene );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_sceneCount(RealStatePtr L)
        {
            
            try {
			    LuaAPI.xlua_pushinteger(L, UnityEngine.SceneManagement.SceneManager.sceneCount);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_sceneCountInBuildSettings(RealStatePtr L)
        {
            
            try {
			    LuaAPI.xlua_pushinteger(L, UnityEngine.SceneManagement.SceneManager.sceneCountInBuildSettings);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
