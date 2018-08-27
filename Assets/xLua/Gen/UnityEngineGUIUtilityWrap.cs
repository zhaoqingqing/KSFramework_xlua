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
    public class UnityEngineGUIUtilityWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.GUIUtility), L, translator, 0, 0, 0, 0);
			
			
			
			
			
			Utils.EndObjectRegister(typeof(UnityEngine.GUIUtility), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.GUIUtility), L, __CreateInstance, 10, 4, 3);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "GetControlID", _m_GetControlID_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetStateObject", _m_GetStateObject_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "QueryStateObject", _m_QueryStateObject_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ExitGUI", _m_ExitGUI_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GUIToScreenPoint", _m_GUIToScreenPoint_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ScreenToGUIPoint", _m_ScreenToGUIPoint_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ScreenToGUIRect", _m_ScreenToGUIRect_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "RotateAroundPivot", _m_RotateAroundPivot_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ScaleAroundPivot", _m_ScaleAroundPivot_xlua_st_);
            
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.GUIUtility));
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "hotControl", _g_get_hotControl);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "keyboardControl", _g_get_keyboardControl);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "systemCopyBuffer", _g_get_systemCopyBuffer);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "hasModalWindow", _g_get_hasModalWindow);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "hotControl", _s_set_hotControl);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "keyboardControl", _s_set_keyboardControl);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "systemCopyBuffer", _s_set_systemCopyBuffer);
            
			Utils.EndClassRegister(typeof(UnityEngine.GUIUtility), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityEngine.GUIUtility __cl_gen_ret = new UnityEngine.GUIUtility();
					translator.Push(L, __cl_gen_ret);
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUIUtility constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetControlID_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1&& translator.Assignable<UnityEngine.FocusType>(L, 1)) 
                {
                    UnityEngine.FocusType focus;translator.Get(L, 1, out focus);
                    
                        int __cl_gen_ret = UnityEngine.GUIUtility.GetControlID( focus );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.FocusType>(L, 2)) 
                {
                    int hint = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.FocusType focus;translator.Get(L, 2, out focus);
                    
                        int __cl_gen_ret = UnityEngine.GUIUtility.GetControlID( hint, focus );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.GUIContent>(L, 1)&& translator.Assignable<UnityEngine.FocusType>(L, 2)) 
                {
                    UnityEngine.GUIContent contents = (UnityEngine.GUIContent)translator.GetObject(L, 1, typeof(UnityEngine.GUIContent));
                    UnityEngine.FocusType focus;translator.Get(L, 2, out focus);
                    
                        int __cl_gen_ret = UnityEngine.GUIUtility.GetControlID( contents, focus );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.FocusType>(L, 1)&& translator.Assignable<UnityEngine.Rect>(L, 2)) 
                {
                    UnityEngine.FocusType focus;translator.Get(L, 1, out focus);
                    UnityEngine.Rect position;translator.Get(L, 2, out position);
                    
                        int __cl_gen_ret = UnityEngine.GUIUtility.GetControlID( focus, position );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.FocusType>(L, 2)&& translator.Assignable<UnityEngine.Rect>(L, 3)) 
                {
                    int hint = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.FocusType focus;translator.Get(L, 2, out focus);
                    UnityEngine.Rect position;translator.Get(L, 3, out position);
                    
                        int __cl_gen_ret = UnityEngine.GUIUtility.GetControlID( hint, focus, position );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.GUIContent>(L, 1)&& translator.Assignable<UnityEngine.FocusType>(L, 2)&& translator.Assignable<UnityEngine.Rect>(L, 3)) 
                {
                    UnityEngine.GUIContent contents = (UnityEngine.GUIContent)translator.GetObject(L, 1, typeof(UnityEngine.GUIContent));
                    UnityEngine.FocusType focus;translator.Get(L, 2, out focus);
                    UnityEngine.Rect position;translator.Get(L, 3, out position);
                    
                        int __cl_gen_ret = UnityEngine.GUIUtility.GetControlID( contents, focus, position );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUIUtility.GetControlID!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetStateObject_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    System.Type t = (System.Type)translator.GetObject(L, 1, typeof(System.Type));
                    int controlID = LuaAPI.xlua_tointeger(L, 2);
                    
                        object __cl_gen_ret = UnityEngine.GUIUtility.GetStateObject( t, controlID );
                        translator.PushAny(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_QueryStateObject_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    System.Type t = (System.Type)translator.GetObject(L, 1, typeof(System.Type));
                    int controlID = LuaAPI.xlua_tointeger(L, 2);
                    
                        object __cl_gen_ret = UnityEngine.GUIUtility.QueryStateObject( t, controlID );
                        translator.PushAny(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ExitGUI_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    
                    UnityEngine.GUIUtility.ExitGUI(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GUIToScreenPoint_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Vector2 guiPoint;translator.Get(L, 1, out guiPoint);
                    
                        UnityEngine.Vector2 __cl_gen_ret = UnityEngine.GUIUtility.GUIToScreenPoint( guiPoint );
                        translator.PushUnityEngineVector2(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ScreenToGUIPoint_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Vector2 screenPoint;translator.Get(L, 1, out screenPoint);
                    
                        UnityEngine.Vector2 __cl_gen_ret = UnityEngine.GUIUtility.ScreenToGUIPoint( screenPoint );
                        translator.PushUnityEngineVector2(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ScreenToGUIRect_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Rect screenRect;translator.Get(L, 1, out screenRect);
                    
                        UnityEngine.Rect __cl_gen_ret = UnityEngine.GUIUtility.ScreenToGUIRect( screenRect );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RotateAroundPivot_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    float angle = (float)LuaAPI.lua_tonumber(L, 1);
                    UnityEngine.Vector2 pivotPoint;translator.Get(L, 2, out pivotPoint);
                    
                    UnityEngine.GUIUtility.RotateAroundPivot( angle, pivotPoint );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ScaleAroundPivot_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Vector2 scale;translator.Get(L, 1, out scale);
                    UnityEngine.Vector2 pivotPoint;translator.Get(L, 2, out pivotPoint);
                    
                    UnityEngine.GUIUtility.ScaleAroundPivot( scale, pivotPoint );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hotControl(RealStatePtr L)
        {
            
            try {
			    LuaAPI.xlua_pushinteger(L, UnityEngine.GUIUtility.hotControl);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_keyboardControl(RealStatePtr L)
        {
            
            try {
			    LuaAPI.xlua_pushinteger(L, UnityEngine.GUIUtility.keyboardControl);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_systemCopyBuffer(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushstring(L, UnityEngine.GUIUtility.systemCopyBuffer);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hasModalWindow(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushboolean(L, UnityEngine.GUIUtility.hasModalWindow);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_hotControl(RealStatePtr L)
        {
            
            try {
			    UnityEngine.GUIUtility.hotControl = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_keyboardControl(RealStatePtr L)
        {
            
            try {
			    UnityEngine.GUIUtility.keyboardControl = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_systemCopyBuffer(RealStatePtr L)
        {
            
            try {
			    UnityEngine.GUIUtility.systemCopyBuffer = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
