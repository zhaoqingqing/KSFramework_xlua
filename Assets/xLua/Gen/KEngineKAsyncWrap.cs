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
    public class KEngineKAsyncWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(KEngine.KAsync), L, translator, 0, 10, 1, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WaitFinish", _m_WaitFinish);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Then", _m_Then);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Until", _m_Until);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "When", _m_When);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Thread", _m_Thread);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "_Thread", _m__Thread);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Coroutine", _m_Coroutine);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WaitForFrames", _m_WaitForFrames);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WaitForSeconds", _m_WaitForSeconds);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WaitForEndOfFrame", _m_WaitForEndOfFrame);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsFinished", _g_get_IsFinished);
            
			
			Utils.EndObjectRegister(typeof(KEngine.KAsync), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(KEngine.KAsync), L, __CreateInstance, 3, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "AddMainThreadCall", _m_AddMainThreadCall_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Start", _m_Start_xlua_st_);
            
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(KEngine.KAsync));
			
			
			Utils.EndClassRegister(typeof(KEngine.KAsync), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "KEngine.KAsync does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WaitFinish(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            KEngine.KAsync __cl_gen_to_be_invoked = (KEngine.KAsync)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                        UnityEngine.Coroutine __cl_gen_ret = __cl_gen_to_be_invoked.WaitFinish(  );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddMainThreadCall_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    System.Action call = translator.GetDelegate<System.Action>(L, 1);
                    
                    KEngine.KAsync.AddMainThreadCall( call );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Start_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 0) 
                {
                    
                        KEngine.KAsync __cl_gen_ret = KEngine.KAsync.Start(  );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 1&& translator.Assignable<System.Action>(L, 1)) 
                {
                    System.Action callback = translator.GetDelegate<System.Action>(L, 1);
                    
                        KEngine.KAsync __cl_gen_ret = KEngine.KAsync.Start( callback );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 1&& translator.Assignable<KEngine.KAsync.AsyncThenDelegateEasy>(L, 1)) 
                {
                    KEngine.KAsync.AsyncThenDelegateEasy callback = translator.GetDelegate<KEngine.KAsync.AsyncThenDelegateEasy>(L, 1);
                    
                        KEngine.KAsync __cl_gen_ret = KEngine.KAsync.Start( callback );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to KEngine.KAsync.Start!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Then(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            KEngine.KAsync __cl_gen_to_be_invoked = (KEngine.KAsync)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& translator.Assignable<System.Action>(L, 2)) 
                {
                    System.Action callback = translator.GetDelegate<System.Action>(L, 2);
                    
                        KEngine.KAsync __cl_gen_ret = __cl_gen_to_be_invoked.Then( callback );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<KEngine.KAsync.AsyncThenDelegate>(L, 2)) 
                {
                    KEngine.KAsync.AsyncThenDelegate thenFunc = translator.GetDelegate<KEngine.KAsync.AsyncThenDelegate>(L, 2);
                    
                        KEngine.KAsync __cl_gen_ret = __cl_gen_to_be_invoked.Then( thenFunc );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<KEngine.KAsync.AsyncThenDelegateEasy>(L, 2)) 
                {
                    KEngine.KAsync.AsyncThenDelegateEasy thenFunc = translator.GetDelegate<KEngine.KAsync.AsyncThenDelegateEasy>(L, 2);
                    
                        KEngine.KAsync __cl_gen_ret = __cl_gen_to_be_invoked.Then( thenFunc );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to KEngine.KAsync.Then!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Until(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            KEngine.KAsync __cl_gen_to_be_invoked = (KEngine.KAsync)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 3&& translator.Assignable<System.Func<bool>>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.Func<bool> retBool = translator.GetDelegate<System.Func<bool>>(L, 2);
                    float timeout = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        KEngine.KAsync __cl_gen_ret = __cl_gen_to_be_invoked.Until( retBool, timeout );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<System.Func<bool>>(L, 2)) 
                {
                    System.Func<bool> retBool = translator.GetDelegate<System.Func<bool>>(L, 2);
                    
                        KEngine.KAsync __cl_gen_ret = __cl_gen_to_be_invoked.Until( retBool );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to KEngine.KAsync.Until!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_When(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            KEngine.KAsync __cl_gen_to_be_invoked = (KEngine.KAsync)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 3&& translator.Assignable<System.Func<bool>>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.Func<bool> retBool = translator.GetDelegate<System.Func<bool>>(L, 2);
                    float timeout = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        KEngine.KAsync __cl_gen_ret = __cl_gen_to_be_invoked.When( retBool, timeout );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<System.Func<bool>>(L, 2)) 
                {
                    System.Func<bool> retBool = translator.GetDelegate<System.Func<bool>>(L, 2);
                    
                        KEngine.KAsync __cl_gen_ret = __cl_gen_to_be_invoked.When( retBool );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to KEngine.KAsync.When!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Thread(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            KEngine.KAsync __cl_gen_to_be_invoked = (KEngine.KAsync)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& translator.Assignable<KEngine.KAsync.AsyncThreadDelegate>(L, 2)) 
                {
                    KEngine.KAsync.AsyncThreadDelegate threadCalAction = translator.GetDelegate<KEngine.KAsync.AsyncThreadDelegate>(L, 2);
                    
                        KEngine.KAsync __cl_gen_ret = __cl_gen_to_be_invoked.Thread( threadCalAction );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<System.Action>(L, 2)) 
                {
                    System.Action threadCalAction = translator.GetDelegate<System.Action>(L, 2);
                    
                        KEngine.KAsync __cl_gen_ret = __cl_gen_to_be_invoked.Thread( threadCalAction );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<KEngine.KAsync.AsyncThreadDelegateFull>(L, 2)&& translator.Assignable<object>(L, 3)) 
                {
                    KEngine.KAsync.AsyncThreadDelegateFull threadCalAction = translator.GetDelegate<KEngine.KAsync.AsyncThreadDelegateFull>(L, 2);
                    object param = translator.GetObject(L, 3, typeof(object));
                    
                        KEngine.KAsync __cl_gen_ret = __cl_gen_to_be_invoked.Thread( threadCalAction, param );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to KEngine.KAsync.Thread!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Thread(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            KEngine.KAsync __cl_gen_to_be_invoked = (KEngine.KAsync)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 3&& translator.Assignable<KEngine.KAsync.AsyncThreadDelegateFull>(L, 2)&& translator.Assignable<object>(L, 3)) 
                {
                    KEngine.KAsync.AsyncThreadDelegateFull threadCalAction = translator.GetDelegate<KEngine.KAsync.AsyncThreadDelegateFull>(L, 2);
                    object param = translator.GetObject(L, 3, typeof(object));
                    
                        System.Collections.IEnumerator __cl_gen_ret = __cl_gen_to_be_invoked._Thread( threadCalAction, param );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<KEngine.KAsync.AsyncThreadDelegateFull>(L, 2)) 
                {
                    KEngine.KAsync.AsyncThreadDelegateFull threadCalAction = translator.GetDelegate<KEngine.KAsync.AsyncThreadDelegateFull>(L, 2);
                    
                        System.Collections.IEnumerator __cl_gen_ret = __cl_gen_to_be_invoked._Thread( threadCalAction );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to KEngine.KAsync._Thread!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Coroutine(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            KEngine.KAsync __cl_gen_to_be_invoked = (KEngine.KAsync)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& translator.Assignable<System.Collections.IEnumerator>(L, 2)) 
                {
                    System.Collections.IEnumerator enumtor = (System.Collections.IEnumerator)translator.GetObject(L, 2, typeof(System.Collections.IEnumerator));
                    
                        KEngine.KAsync __cl_gen_ret = __cl_gen_to_be_invoked.Coroutine( enumtor );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Coroutine>(L, 2)) 
                {
                    UnityEngine.Coroutine co = (UnityEngine.Coroutine)translator.GetObject(L, 2, typeof(UnityEngine.Coroutine));
                    
                        KEngine.KAsync __cl_gen_ret = __cl_gen_to_be_invoked.Coroutine( co );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to KEngine.KAsync.Coroutine!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WaitForFrames(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            KEngine.KAsync __cl_gen_to_be_invoked = (KEngine.KAsync)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    int frameCount = LuaAPI.xlua_tointeger(L, 2);
                    
                        KEngine.KAsync __cl_gen_ret = __cl_gen_to_be_invoked.WaitForFrames( frameCount );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WaitForSeconds(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            KEngine.KAsync __cl_gen_to_be_invoked = (KEngine.KAsync)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    float time = (float)LuaAPI.lua_tonumber(L, 2);
                    
                        KEngine.KAsync __cl_gen_ret = __cl_gen_to_be_invoked.WaitForSeconds( time );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WaitForEndOfFrame(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            KEngine.KAsync __cl_gen_to_be_invoked = (KEngine.KAsync)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                        KEngine.KAsync __cl_gen_ret = __cl_gen_to_be_invoked.WaitForEndOfFrame(  );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsFinished(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                KEngine.KAsync __cl_gen_to_be_invoked = (KEngine.KAsync)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.IsFinished);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
