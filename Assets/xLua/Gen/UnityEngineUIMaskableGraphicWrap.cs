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
    public class UnityEngineUIMaskableGraphicWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.UI.MaskableGraphic), L, translator, 0, 5, 2, 2);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetModifiedMaterial", _m_GetModifiedMaterial);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Cull", _m_Cull);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetClipRect", _m_SetClipRect);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RecalculateClipping", _m_RecalculateClipping);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RecalculateMasking", _m_RecalculateMasking);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "onCullStateChanged", _g_get_onCullStateChanged);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "maskable", _g_get_maskable);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "onCullStateChanged", _s_set_onCullStateChanged);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "maskable", _s_set_maskable);
            
			Utils.EndObjectRegister(typeof(UnityEngine.UI.MaskableGraphic), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.UI.MaskableGraphic), L, __CreateInstance, 1, 0, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.UI.MaskableGraphic));
			
			
			Utils.EndClassRegister(typeof(UnityEngine.UI.MaskableGraphic), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "UnityEngine.UI.MaskableGraphic does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetModifiedMaterial(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.UI.MaskableGraphic __cl_gen_to_be_invoked = (UnityEngine.UI.MaskableGraphic)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Material baseMaterial = (UnityEngine.Material)translator.GetObject(L, 2, typeof(UnityEngine.Material));
                    
                        UnityEngine.Material __cl_gen_ret = __cl_gen_to_be_invoked.GetModifiedMaterial( baseMaterial );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Cull(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.UI.MaskableGraphic __cl_gen_to_be_invoked = (UnityEngine.UI.MaskableGraphic)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Rect clipRect;translator.Get(L, 2, out clipRect);
                    bool validRect = LuaAPI.lua_toboolean(L, 3);
                    
                    __cl_gen_to_be_invoked.Cull( clipRect, validRect );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetClipRect(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.UI.MaskableGraphic __cl_gen_to_be_invoked = (UnityEngine.UI.MaskableGraphic)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Rect clipRect;translator.Get(L, 2, out clipRect);
                    bool validRect = LuaAPI.lua_toboolean(L, 3);
                    
                    __cl_gen_to_be_invoked.SetClipRect( clipRect, validRect );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RecalculateClipping(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.UI.MaskableGraphic __cl_gen_to_be_invoked = (UnityEngine.UI.MaskableGraphic)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.RecalculateClipping(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RecalculateMasking(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.UI.MaskableGraphic __cl_gen_to_be_invoked = (UnityEngine.UI.MaskableGraphic)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.RecalculateMasking(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onCullStateChanged(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.UI.MaskableGraphic __cl_gen_to_be_invoked = (UnityEngine.UI.MaskableGraphic)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onCullStateChanged);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maskable(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.UI.MaskableGraphic __cl_gen_to_be_invoked = (UnityEngine.UI.MaskableGraphic)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.maskable);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onCullStateChanged(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.UI.MaskableGraphic __cl_gen_to_be_invoked = (UnityEngine.UI.MaskableGraphic)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onCullStateChanged = (UnityEngine.UI.MaskableGraphic.CullStateChangedEvent)translator.GetObject(L, 2, typeof(UnityEngine.UI.MaskableGraphic.CullStateChangedEvent));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_maskable(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.UI.MaskableGraphic __cl_gen_to_be_invoked = (UnityEngine.UI.MaskableGraphic)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.maskable = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
