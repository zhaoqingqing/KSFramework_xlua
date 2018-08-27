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
    public class KSFrameworkCookieWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(KSFramework.Cookie), L, translator, 0, 0, 0, 0);
			
			
			
			
			
			Utils.EndObjectRegister(typeof(KSFramework.Cookie), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(KSFramework.Cookie), L, __CreateInstance, 6, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Define", _m_Define_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Set", _m_Set_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Get", _m_Get_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "AddSetListener", _m_AddSetListener_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "RemoveSetListner", _m_RemoveSetListner_xlua_st_);
            
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(KSFramework.Cookie));
			
			
			Utils.EndClassRegister(typeof(KSFramework.Cookie), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					KSFramework.Cookie __cl_gen_ret = new KSFramework.Cookie();
					translator.Push(L, __cl_gen_ret);
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to KSFramework.Cookie constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Define_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    string key = LuaAPI.lua_tostring(L, 1);
                    KSFramework.Cookie.CookieGetter getter = translator.GetDelegate<KSFramework.Cookie.CookieGetter>(L, 2);
                    KSFramework.Cookie.CookieSetter setter = translator.GetDelegate<KSFramework.Cookie.CookieSetter>(L, 3);
                    
                    KSFramework.Cookie.Define( key, getter, setter );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Set_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    string key = LuaAPI.lua_tostring(L, 1);
                    object value = translator.GetObject(L, 2, typeof(object));
                    
                    KSFramework.Cookie.Set( key, value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Get_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string key = LuaAPI.lua_tostring(L, 1);
                    
                        object __cl_gen_ret = KSFramework.Cookie.Get( key );
                        translator.PushAny(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<KSFramework.Cookie.IfNullGetter>(L, 2)) 
                {
                    string key = LuaAPI.lua_tostring(L, 1);
                    KSFramework.Cookie.IfNullGetter ifNullSetDefault = translator.GetDelegate<KSFramework.Cookie.IfNullGetter>(L, 2);
                    
                        object __cl_gen_ret = KSFramework.Cookie.Get( key, ifNullSetDefault );
                        translator.PushAny(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to KSFramework.Cookie.Get!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddSetListener_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    string key = LuaAPI.lua_tostring(L, 1);
                    KSFramework.Cookie.CookieSetListener listener = translator.GetDelegate<KSFramework.Cookie.CookieSetListener>(L, 2);
                    
                    KSFramework.Cookie.AddSetListener( key, listener );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RemoveSetListner_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    string key = LuaAPI.lua_tostring(L, 1);
                    KSFramework.Cookie.CookieSetListener listener = translator.GetDelegate<KSFramework.Cookie.CookieSetListener>(L, 2);
                    
                    KSFramework.Cookie.RemoveSetListner( key, listener );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
