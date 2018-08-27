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
    public class UnityEngineRectTransformUtilityWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.RectTransformUtility), L, translator, 0, 0, 0, 0);
			
			
			
			
			
			Utils.EndObjectRegister(typeof(UnityEngine.RectTransformUtility), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.RectTransformUtility), L, __CreateInstance, 11, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "RectangleContainsScreenPoint", _m_RectangleContainsScreenPoint_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "PixelAdjustPoint", _m_PixelAdjustPoint_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "PixelAdjustRect", _m_PixelAdjustRect_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ScreenPointToWorldPointInRectangle", _m_ScreenPointToWorldPointInRectangle_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ScreenPointToLocalPointInRectangle", _m_ScreenPointToLocalPointInRectangle_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ScreenPointToRay", _m_ScreenPointToRay_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "WorldToScreenPoint", _m_WorldToScreenPoint_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CalculateRelativeRectTransformBounds", _m_CalculateRelativeRectTransformBounds_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "FlipLayoutOnAxis", _m_FlipLayoutOnAxis_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "FlipLayoutAxes", _m_FlipLayoutAxes_xlua_st_);
            
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.RectTransformUtility));
			
			
			Utils.EndClassRegister(typeof(UnityEngine.RectTransformUtility), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "UnityEngine.RectTransformUtility does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RectangleContainsScreenPoint_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.RectTransform>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)) 
                {
                    UnityEngine.RectTransform rect = (UnityEngine.RectTransform)translator.GetObject(L, 1, typeof(UnityEngine.RectTransform));
                    UnityEngine.Vector2 screenPoint;translator.Get(L, 2, out screenPoint);
                    
                        bool __cl_gen_ret = UnityEngine.RectTransformUtility.RectangleContainsScreenPoint( rect, screenPoint );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.RectTransform>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Camera>(L, 3)) 
                {
                    UnityEngine.RectTransform rect = (UnityEngine.RectTransform)translator.GetObject(L, 1, typeof(UnityEngine.RectTransform));
                    UnityEngine.Vector2 screenPoint;translator.Get(L, 2, out screenPoint);
                    UnityEngine.Camera cam = (UnityEngine.Camera)translator.GetObject(L, 3, typeof(UnityEngine.Camera));
                    
                        bool __cl_gen_ret = UnityEngine.RectTransformUtility.RectangleContainsScreenPoint( rect, screenPoint, cam );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.RectTransformUtility.RectangleContainsScreenPoint!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PixelAdjustPoint_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Vector2 point;translator.Get(L, 1, out point);
                    UnityEngine.Transform elementTransform = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    UnityEngine.Canvas canvas = (UnityEngine.Canvas)translator.GetObject(L, 3, typeof(UnityEngine.Canvas));
                    
                        UnityEngine.Vector2 __cl_gen_ret = UnityEngine.RectTransformUtility.PixelAdjustPoint( point, elementTransform, canvas );
                        translator.PushUnityEngineVector2(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PixelAdjustRect_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.RectTransform rectTransform = (UnityEngine.RectTransform)translator.GetObject(L, 1, typeof(UnityEngine.RectTransform));
                    UnityEngine.Canvas canvas = (UnityEngine.Canvas)translator.GetObject(L, 2, typeof(UnityEngine.Canvas));
                    
                        UnityEngine.Rect __cl_gen_ret = UnityEngine.RectTransformUtility.PixelAdjustRect( rectTransform, canvas );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ScreenPointToWorldPointInRectangle_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.RectTransform rect = (UnityEngine.RectTransform)translator.GetObject(L, 1, typeof(UnityEngine.RectTransform));
                    UnityEngine.Vector2 screenPoint;translator.Get(L, 2, out screenPoint);
                    UnityEngine.Camera cam = (UnityEngine.Camera)translator.GetObject(L, 3, typeof(UnityEngine.Camera));
                    UnityEngine.Vector3 worldPoint;
                    
                        bool __cl_gen_ret = UnityEngine.RectTransformUtility.ScreenPointToWorldPointInRectangle( rect, screenPoint, cam, out worldPoint );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    translator.PushUnityEngineVector3(L, worldPoint);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ScreenPointToLocalPointInRectangle_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.RectTransform rect = (UnityEngine.RectTransform)translator.GetObject(L, 1, typeof(UnityEngine.RectTransform));
                    UnityEngine.Vector2 screenPoint;translator.Get(L, 2, out screenPoint);
                    UnityEngine.Camera cam = (UnityEngine.Camera)translator.GetObject(L, 3, typeof(UnityEngine.Camera));
                    UnityEngine.Vector2 localPoint;
                    
                        bool __cl_gen_ret = UnityEngine.RectTransformUtility.ScreenPointToLocalPointInRectangle( rect, screenPoint, cam, out localPoint );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    translator.PushUnityEngineVector2(L, localPoint);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ScreenPointToRay_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Camera cam = (UnityEngine.Camera)translator.GetObject(L, 1, typeof(UnityEngine.Camera));
                    UnityEngine.Vector2 screenPos;translator.Get(L, 2, out screenPos);
                    
                        UnityEngine.Ray __cl_gen_ret = UnityEngine.RectTransformUtility.ScreenPointToRay( cam, screenPos );
                        translator.PushUnityEngineRay(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WorldToScreenPoint_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Camera cam = (UnityEngine.Camera)translator.GetObject(L, 1, typeof(UnityEngine.Camera));
                    UnityEngine.Vector3 worldPoint;translator.Get(L, 2, out worldPoint);
                    
                        UnityEngine.Vector2 __cl_gen_ret = UnityEngine.RectTransformUtility.WorldToScreenPoint( cam, worldPoint );
                        translator.PushUnityEngineVector2(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CalculateRelativeRectTransformBounds_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1&& translator.Assignable<UnityEngine.Transform>(L, 1)) 
                {
                    UnityEngine.Transform trans = (UnityEngine.Transform)translator.GetObject(L, 1, typeof(UnityEngine.Transform));
                    
                        UnityEngine.Bounds __cl_gen_ret = UnityEngine.RectTransformUtility.CalculateRelativeRectTransformBounds( trans );
                        translator.PushUnityEngineBounds(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Transform>(L, 1)&& translator.Assignable<UnityEngine.Transform>(L, 2)) 
                {
                    UnityEngine.Transform root = (UnityEngine.Transform)translator.GetObject(L, 1, typeof(UnityEngine.Transform));
                    UnityEngine.Transform child = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    
                        UnityEngine.Bounds __cl_gen_ret = UnityEngine.RectTransformUtility.CalculateRelativeRectTransformBounds( root, child );
                        translator.PushUnityEngineBounds(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.RectTransformUtility.CalculateRelativeRectTransformBounds!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FlipLayoutOnAxis_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.RectTransform rect = (UnityEngine.RectTransform)translator.GetObject(L, 1, typeof(UnityEngine.RectTransform));
                    int axis = LuaAPI.xlua_tointeger(L, 2);
                    bool keepPositioning = LuaAPI.lua_toboolean(L, 3);
                    bool recursive = LuaAPI.lua_toboolean(L, 4);
                    
                    UnityEngine.RectTransformUtility.FlipLayoutOnAxis( rect, axis, keepPositioning, recursive );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FlipLayoutAxes_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.RectTransform rect = (UnityEngine.RectTransform)translator.GetObject(L, 1, typeof(UnityEngine.RectTransform));
                    bool keepPositioning = LuaAPI.lua_toboolean(L, 2);
                    bool recursive = LuaAPI.lua_toboolean(L, 3);
                    
                    UnityEngine.RectTransformUtility.FlipLayoutAxes( rect, keepPositioning, recursive );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
