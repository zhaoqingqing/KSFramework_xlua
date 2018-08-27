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
    public class KBehaviourWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(KBehaviour), L, translator, 0, 3, 3, 1);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Delete", _m_Delete);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DeleteSelf", _m_DeleteSelf);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DestroyEvent", _e_DestroyEvent);
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "CachedTransform", _g_get_CachedTransform);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "CachedGameObject", _g_get_CachedGameObject);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "TimeScale", _g_get_TimeScale);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "TimeScale", _s_set_TimeScale);
            
			Utils.EndObjectRegister(typeof(KBehaviour), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(KBehaviour), L, __CreateInstance, 2, 2, 1);
			
			Utils.RegisterFunc(L, Utils.CLS_IDX, "StaticDestroyEvent", _e_StaticDestroyEvent);
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(KBehaviour));
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "IsApplicationQuited", _g_get_IsApplicationQuited);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "ApplicationQuitEvent", _g_get_ApplicationQuitEvent);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "ApplicationQuitEvent", _s_set_ApplicationQuitEvent);
            
			Utils.EndClassRegister(typeof(KBehaviour), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "KBehaviour does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Delete(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            KBehaviour __cl_gen_to_be_invoked = (KBehaviour)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1) 
                {
                    
                    __cl_gen_to_be_invoked.Delete(  );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    float time = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    __cl_gen_to_be_invoked.Delete( time );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to KBehaviour.Delete!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DeleteSelf(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            KBehaviour __cl_gen_to_be_invoked = (KBehaviour)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.DeleteSelf(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_CachedTransform(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                KBehaviour __cl_gen_to_be_invoked = (KBehaviour)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.CachedTransform);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_CachedGameObject(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                KBehaviour __cl_gen_to_be_invoked = (KBehaviour)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.CachedGameObject);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsApplicationQuited(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushboolean(L, KBehaviour.IsApplicationQuited);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_TimeScale(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                KBehaviour __cl_gen_to_be_invoked = (KBehaviour)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.TimeScale);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ApplicationQuitEvent(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, KBehaviour.ApplicationQuitEvent);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_TimeScale(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                KBehaviour __cl_gen_to_be_invoked = (KBehaviour)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.TimeScale = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ApplicationQuitEvent(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    KBehaviour.ApplicationQuitEvent = translator.GetDelegate<System.Action>(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_DestroyEvent(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			int __gen_param_count = LuaAPI.lua_gettop(L);
			KBehaviour __cl_gen_to_be_invoked = (KBehaviour)translator.FastGetCSObj(L, 1);
            try {
                System.Action<KBehaviour> __gen_delegate = translator.GetDelegate<System.Action<KBehaviour>>(L, 3);
                if (__gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need System.Action<KBehaviour>!");
                }
				
				if (__gen_param_count == 3)
				{
					System.IntPtr strlen;

					System.IntPtr str = LuaAPI.lua_tolstring(L, 2, out strlen);

					if (str != System.IntPtr.Zero && strlen.ToInt32() == 1)
					{
						byte op = System.Runtime.InteropServices.Marshal.ReadByte(str);
					
						
						if (op == (byte)'+') {
							__cl_gen_to_be_invoked.DestroyEvent += __gen_delegate;
							return 0;
						} 
						
						
						if (op == (byte)'-') {
							__cl_gen_to_be_invoked.DestroyEvent -= __gen_delegate;
							return 0;
						} 
						
					}
				}
			} catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to KBehaviour.DestroyEvent!");
            return 0;
        }
        
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_StaticDestroyEvent(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			int __gen_param_count = LuaAPI.lua_gettop(L);
            try {
                System.Action<KBehaviour> __gen_delegate = translator.GetDelegate<System.Action<KBehaviour>>(L, 2);
                if (__gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need System.Action<KBehaviour>!");
                }
                
				
				if (__gen_param_count == 2 && LuaAPI.lua_tostring(L, 1) == "+") {
					KBehaviour.StaticDestroyEvent += __gen_delegate;
					return 0;
				} 
				
				
				if (__gen_param_count == 2 && LuaAPI.lua_tostring(L, 1) == "-") {
					KBehaviour.StaticDestroyEvent -= __gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to KBehaviour.StaticDestroyEvent!");
        }
        
    }
}
