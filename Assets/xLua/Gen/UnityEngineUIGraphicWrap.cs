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
    public class UnityEngineUIGraphicWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.UI.Graphic), L, translator, 0, 19, 10, 3);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetAllDirty", _m_SetAllDirty);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetLayoutDirty", _m_SetLayoutDirty);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetVerticesDirty", _m_SetVerticesDirty);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetMaterialDirty", _m_SetMaterialDirty);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Rebuild", _m_Rebuild);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LayoutComplete", _m_LayoutComplete);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GraphicUpdateComplete", _m_GraphicUpdateComplete);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetNativeSize", _m_SetNativeSize);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Raycast", _m_Raycast);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PixelAdjustPoint", _m_PixelAdjustPoint);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetPixelAdjustedRect", _m_GetPixelAdjustedRect);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CrossFadeColor", _m_CrossFadeColor);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CrossFadeAlpha", _m_CrossFadeAlpha);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RegisterDirtyLayoutCallback", _m_RegisterDirtyLayoutCallback);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UnregisterDirtyLayoutCallback", _m_UnregisterDirtyLayoutCallback);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RegisterDirtyVerticesCallback", _m_RegisterDirtyVerticesCallback);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UnregisterDirtyVerticesCallback", _m_UnregisterDirtyVerticesCallback);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RegisterDirtyMaterialCallback", _m_RegisterDirtyMaterialCallback);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UnregisterDirtyMaterialCallback", _m_UnregisterDirtyMaterialCallback);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "color", _g_get_color);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "raycastTarget", _g_get_raycastTarget);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "depth", _g_get_depth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rectTransform", _g_get_rectTransform);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "canvas", _g_get_canvas);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "canvasRenderer", _g_get_canvasRenderer);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "defaultMaterial", _g_get_defaultMaterial);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "material", _g_get_material);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "materialForRendering", _g_get_materialForRendering);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "mainTexture", _g_get_mainTexture);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "color", _s_set_color);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "raycastTarget", _s_set_raycastTarget);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "material", _s_set_material);
            
			Utils.EndObjectRegister(typeof(UnityEngine.UI.Graphic), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.UI.Graphic), L, __CreateInstance, 1, 1, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.UI.Graphic));
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "defaultGraphicMaterial", _g_get_defaultGraphicMaterial);
            
			
			Utils.EndClassRegister(typeof(UnityEngine.UI.Graphic), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "UnityEngine.UI.Graphic does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetAllDirty(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.UI.Graphic __cl_gen_to_be_invoked = (UnityEngine.UI.Graphic)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.SetAllDirty(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetLayoutDirty(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.UI.Graphic __cl_gen_to_be_invoked = (UnityEngine.UI.Graphic)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.SetLayoutDirty(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetVerticesDirty(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.UI.Graphic __cl_gen_to_be_invoked = (UnityEngine.UI.Graphic)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.SetVerticesDirty(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetMaterialDirty(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.UI.Graphic __cl_gen_to_be_invoked = (UnityEngine.UI.Graphic)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.SetMaterialDirty(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Rebuild(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.UI.Graphic __cl_gen_to_be_invoked = (UnityEngine.UI.Graphic)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.UI.CanvasUpdate update;translator.Get(L, 2, out update);
                    
                    __cl_gen_to_be_invoked.Rebuild( update );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LayoutComplete(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.UI.Graphic __cl_gen_to_be_invoked = (UnityEngine.UI.Graphic)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.LayoutComplete(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GraphicUpdateComplete(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.UI.Graphic __cl_gen_to_be_invoked = (UnityEngine.UI.Graphic)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.GraphicUpdateComplete(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetNativeSize(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.UI.Graphic __cl_gen_to_be_invoked = (UnityEngine.UI.Graphic)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.SetNativeSize(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Raycast(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.UI.Graphic __cl_gen_to_be_invoked = (UnityEngine.UI.Graphic)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Vector2 sp;translator.Get(L, 2, out sp);
                    UnityEngine.Camera eventCamera = (UnityEngine.Camera)translator.GetObject(L, 3, typeof(UnityEngine.Camera));
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.Raycast( sp, eventCamera );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PixelAdjustPoint(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.UI.Graphic __cl_gen_to_be_invoked = (UnityEngine.UI.Graphic)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Vector2 point;translator.Get(L, 2, out point);
                    
                        UnityEngine.Vector2 __cl_gen_ret = __cl_gen_to_be_invoked.PixelAdjustPoint( point );
                        translator.PushUnityEngineVector2(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetPixelAdjustedRect(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.UI.Graphic __cl_gen_to_be_invoked = (UnityEngine.UI.Graphic)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                        UnityEngine.Rect __cl_gen_ret = __cl_gen_to_be_invoked.GetPixelAdjustedRect(  );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CrossFadeColor(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.UI.Graphic __cl_gen_to_be_invoked = (UnityEngine.UI.Graphic)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Color targetColor;translator.Get(L, 2, out targetColor);
                    float duration = (float)LuaAPI.lua_tonumber(L, 3);
                    bool ignoreTimeScale = LuaAPI.lua_toboolean(L, 4);
                    bool useAlpha = LuaAPI.lua_toboolean(L, 5);
                    
                    __cl_gen_to_be_invoked.CrossFadeColor( targetColor, duration, ignoreTimeScale, useAlpha );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CrossFadeAlpha(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.UI.Graphic __cl_gen_to_be_invoked = (UnityEngine.UI.Graphic)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    float alpha = (float)LuaAPI.lua_tonumber(L, 2);
                    float duration = (float)LuaAPI.lua_tonumber(L, 3);
                    bool ignoreTimeScale = LuaAPI.lua_toboolean(L, 4);
                    
                    __cl_gen_to_be_invoked.CrossFadeAlpha( alpha, duration, ignoreTimeScale );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RegisterDirtyLayoutCallback(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.UI.Graphic __cl_gen_to_be_invoked = (UnityEngine.UI.Graphic)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Events.UnityAction action = translator.GetDelegate<UnityEngine.Events.UnityAction>(L, 2);
                    
                    __cl_gen_to_be_invoked.RegisterDirtyLayoutCallback( action );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UnregisterDirtyLayoutCallback(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.UI.Graphic __cl_gen_to_be_invoked = (UnityEngine.UI.Graphic)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Events.UnityAction action = translator.GetDelegate<UnityEngine.Events.UnityAction>(L, 2);
                    
                    __cl_gen_to_be_invoked.UnregisterDirtyLayoutCallback( action );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RegisterDirtyVerticesCallback(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.UI.Graphic __cl_gen_to_be_invoked = (UnityEngine.UI.Graphic)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Events.UnityAction action = translator.GetDelegate<UnityEngine.Events.UnityAction>(L, 2);
                    
                    __cl_gen_to_be_invoked.RegisterDirtyVerticesCallback( action );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UnregisterDirtyVerticesCallback(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.UI.Graphic __cl_gen_to_be_invoked = (UnityEngine.UI.Graphic)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Events.UnityAction action = translator.GetDelegate<UnityEngine.Events.UnityAction>(L, 2);
                    
                    __cl_gen_to_be_invoked.UnregisterDirtyVerticesCallback( action );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RegisterDirtyMaterialCallback(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.UI.Graphic __cl_gen_to_be_invoked = (UnityEngine.UI.Graphic)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Events.UnityAction action = translator.GetDelegate<UnityEngine.Events.UnityAction>(L, 2);
                    
                    __cl_gen_to_be_invoked.RegisterDirtyMaterialCallback( action );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UnregisterDirtyMaterialCallback(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.UI.Graphic __cl_gen_to_be_invoked = (UnityEngine.UI.Graphic)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Events.UnityAction action = translator.GetDelegate<UnityEngine.Events.UnityAction>(L, 2);
                    
                    __cl_gen_to_be_invoked.UnregisterDirtyMaterialCallback( action );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_defaultGraphicMaterial(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, UnityEngine.UI.Graphic.defaultGraphicMaterial);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_color(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.UI.Graphic __cl_gen_to_be_invoked = (UnityEngine.UI.Graphic)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineColor(L, __cl_gen_to_be_invoked.color);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_raycastTarget(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.UI.Graphic __cl_gen_to_be_invoked = (UnityEngine.UI.Graphic)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.raycastTarget);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_depth(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.UI.Graphic __cl_gen_to_be_invoked = (UnityEngine.UI.Graphic)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.depth);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_rectTransform(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.UI.Graphic __cl_gen_to_be_invoked = (UnityEngine.UI.Graphic)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.rectTransform);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_canvas(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.UI.Graphic __cl_gen_to_be_invoked = (UnityEngine.UI.Graphic)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.canvas);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_canvasRenderer(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.UI.Graphic __cl_gen_to_be_invoked = (UnityEngine.UI.Graphic)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.canvasRenderer);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_defaultMaterial(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.UI.Graphic __cl_gen_to_be_invoked = (UnityEngine.UI.Graphic)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.defaultMaterial);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_material(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.UI.Graphic __cl_gen_to_be_invoked = (UnityEngine.UI.Graphic)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.material);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_materialForRendering(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.UI.Graphic __cl_gen_to_be_invoked = (UnityEngine.UI.Graphic)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.materialForRendering);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_mainTexture(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.UI.Graphic __cl_gen_to_be_invoked = (UnityEngine.UI.Graphic)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.mainTexture);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_color(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.UI.Graphic __cl_gen_to_be_invoked = (UnityEngine.UI.Graphic)translator.FastGetCSObj(L, 1);
                UnityEngine.Color __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.color = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_raycastTarget(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.UI.Graphic __cl_gen_to_be_invoked = (UnityEngine.UI.Graphic)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.raycastTarget = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_material(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.UI.Graphic __cl_gen_to_be_invoked = (UnityEngine.UI.Graphic)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.material = (UnityEngine.Material)translator.GetObject(L, 2, typeof(UnityEngine.Material));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
