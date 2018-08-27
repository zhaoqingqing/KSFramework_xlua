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
    public class KEngineUIUIModuleWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(KEngine.UI.UIModule), L, translator, 0, 12, 3, 3);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OpenWindow", _m_OpenWindow);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToggleWindow", _m_ToggleWindow);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OpenDynamicWindow", _m_OpenDynamicWindow);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CloseWindow", _m_CloseWindow);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DestroyAllWindows", _m_DestroyAllWindows);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsOpen", _m_IsOpen);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsLoad", _m_IsLoad);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LoadWindow", _m_LoadWindow);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ReloadWindow", _m_ReloadWindow);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DestroyWindow", _m_DestroyWindow);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CallUI", _m_CallUI);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CallDynamicUI", _m_CallDynamicUI);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "LoadingUICount", _g_get_LoadingUICount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "UiBridge", _g_get_UiBridge);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "UIWindows", _g_get_UIWindows);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "LoadingUICount", _s_set_LoadingUICount);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "UiBridge", _s_set_UiBridge);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "UIWindows", _s_set_UIWindows);
            
			Utils.EndObjectRegister(typeof(KEngine.UI.UIModule), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(KEngine.UI.UIModule), L, __CreateInstance, 1, 4, 3);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(KEngine.UI.UIModule));
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Instance", _g_get_Instance);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "OnInitEvent", _g_get_OnInitEvent);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "OnOpenEvent", _g_get_OnOpenEvent);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "OnCloseEvent", _g_get_OnCloseEvent);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "OnInitEvent", _s_set_OnInitEvent);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "OnOpenEvent", _s_set_OnOpenEvent);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "OnCloseEvent", _s_set_OnCloseEvent);
            
			Utils.EndClassRegister(typeof(KEngine.UI.UIModule), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					KEngine.UI.UIModule __cl_gen_ret = new KEngine.UI.UIModule();
					translator.Push(L, __cl_gen_ret);
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to KEngine.UI.UIModule constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OpenWindow(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            KEngine.UI.UIModule __cl_gen_to_be_invoked = (KEngine.UI.UIModule)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string uiTemplateName = LuaAPI.lua_tostring(L, 2);
                    object[] args = translator.GetParams<object>(L, 3);
                    
                        KEngine.UI.UILoadState __cl_gen_ret = __cl_gen_to_be_invoked.OpenWindow( uiTemplateName, args );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToggleWindow(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            KEngine.UI.UIModule __cl_gen_to_be_invoked = (KEngine.UI.UIModule)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string name = LuaAPI.lua_tostring(L, 2);
                    object[] args = translator.GetParams<object>(L, 3);
                    
                    __cl_gen_to_be_invoked.ToggleWindow( name, args );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OpenDynamicWindow(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            KEngine.UI.UIModule __cl_gen_to_be_invoked = (KEngine.UI.UIModule)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string template = LuaAPI.lua_tostring(L, 2);
                    string instanceName = LuaAPI.lua_tostring(L, 3);
                    object[] args = translator.GetParams<object>(L, 4);
                    
                        KEngine.UI.UILoadState __cl_gen_ret = __cl_gen_to_be_invoked.OpenDynamicWindow( template, instanceName, args );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CloseWindow(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            KEngine.UI.UIModule __cl_gen_to_be_invoked = (KEngine.UI.UIModule)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& translator.Assignable<System.Type>(L, 2)) 
                {
                    System.Type t = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                    __cl_gen_to_be_invoked.CloseWindow( t );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string name = LuaAPI.lua_tostring(L, 2);
                    
                    __cl_gen_to_be_invoked.CloseWindow( name );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to KEngine.UI.UIModule.CloseWindow!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DestroyAllWindows(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            KEngine.UI.UIModule __cl_gen_to_be_invoked = (KEngine.UI.UIModule)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.DestroyAllWindows(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsOpen(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            KEngine.UI.UIModule __cl_gen_to_be_invoked = (KEngine.UI.UIModule)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string name = LuaAPI.lua_tostring(L, 2);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.IsOpen( name );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsLoad(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            KEngine.UI.UIModule __cl_gen_to_be_invoked = (KEngine.UI.UIModule)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string name = LuaAPI.lua_tostring(L, 2);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.IsLoad( name );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadWindow(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            KEngine.UI.UIModule __cl_gen_to_be_invoked = (KEngine.UI.UIModule)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string windowTemplateName = LuaAPI.lua_tostring(L, 2);
                    bool openWhenFinish = LuaAPI.lua_toboolean(L, 3);
                    object[] args = translator.GetParams<object>(L, 4);
                    
                        KEngine.UI.UILoadState __cl_gen_ret = __cl_gen_to_be_invoked.LoadWindow( windowTemplateName, openWhenFinish, args );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReloadWindow(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            KEngine.UI.UIModule __cl_gen_to_be_invoked = (KEngine.UI.UIModule)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string windowTemplateName = LuaAPI.lua_tostring(L, 2);
                    KCallback callback = translator.GetDelegate<KCallback>(L, 3);
                    
                        UnityEngine.Coroutine __cl_gen_ret = __cl_gen_to_be_invoked.ReloadWindow( windowTemplateName, callback );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DestroyWindow(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            KEngine.UI.UIModule __cl_gen_to_be_invoked = (KEngine.UI.UIModule)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string uiTemplateName = LuaAPI.lua_tostring(L, 2);
                    
                    __cl_gen_to_be_invoked.DestroyWindow( uiTemplateName );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CallUI(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            KEngine.UI.UIModule __cl_gen_to_be_invoked = (KEngine.UI.UIModule)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string uiTemplateName = LuaAPI.lua_tostring(L, 2);
                    System.Action<KEngine.UI.UIController, object[]> callback = translator.GetDelegate<System.Action<KEngine.UI.UIController, object[]>>(L, 3);
                    object[] args = translator.GetParams<object>(L, 4);
                    
                    __cl_gen_to_be_invoked.CallUI( uiTemplateName, callback, args );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CallDynamicUI(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            KEngine.UI.UIModule __cl_gen_to_be_invoked = (KEngine.UI.UIModule)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string uiName = LuaAPI.lua_tostring(L, 2);
                    System.Action<KEngine.UI.UIController, object[]> callback = translator.GetDelegate<System.Action<KEngine.UI.UIController, object[]>>(L, 3);
                    object[] args = translator.GetParams<object>(L, 4);
                    
                    __cl_gen_to_be_invoked.CallDynamicUI( uiName, callback, args );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Instance(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, KEngine.UI.UIModule.Instance);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_LoadingUICount(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                KEngine.UI.UIModule __cl_gen_to_be_invoked = (KEngine.UI.UIModule)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.LoadingUICount);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_UiBridge(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                KEngine.UI.UIModule __cl_gen_to_be_invoked = (KEngine.UI.UIModule)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.UiBridge);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_UIWindows(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                KEngine.UI.UIModule __cl_gen_to_be_invoked = (KEngine.UI.UIModule)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.UIWindows);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_OnInitEvent(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, KEngine.UI.UIModule.OnInitEvent);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_OnOpenEvent(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, KEngine.UI.UIModule.OnOpenEvent);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_OnCloseEvent(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, KEngine.UI.UIModule.OnCloseEvent);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_LoadingUICount(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                KEngine.UI.UIModule __cl_gen_to_be_invoked = (KEngine.UI.UIModule)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.LoadingUICount = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_UiBridge(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                KEngine.UI.UIModule __cl_gen_to_be_invoked = (KEngine.UI.UIModule)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.UiBridge = (KEngine.UI.IUIBridge)translator.GetObject(L, 2, typeof(KEngine.UI.IUIBridge));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_UIWindows(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                KEngine.UI.UIModule __cl_gen_to_be_invoked = (KEngine.UI.UIModule)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.UIWindows = (System.Collections.Generic.Dictionary<string, KEngine.UI.UILoadState>)translator.GetObject(L, 2, typeof(System.Collections.Generic.Dictionary<string, KEngine.UI.UILoadState>));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_OnInitEvent(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    KEngine.UI.UIModule.OnInitEvent = translator.GetDelegate<System.Action<KEngine.UI.UIController>>(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_OnOpenEvent(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    KEngine.UI.UIModule.OnOpenEvent = translator.GetDelegate<System.Action<KEngine.UI.UIController>>(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_OnCloseEvent(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    KEngine.UI.UIModule.OnCloseEvent = translator.GetDelegate<System.Action<KEngine.UI.UIController>>(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
