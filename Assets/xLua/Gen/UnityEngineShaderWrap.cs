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
    public class UnityEngineShaderWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.Shader), L, translator, 0, 0, 3, 1);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "isSupported", _g_get_isSupported);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "maximumLOD", _g_get_maximumLOD);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "renderQueue", _g_get_renderQueue);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "maximumLOD", _s_set_maximumLOD);
            
			Utils.EndObjectRegister(typeof(UnityEngine.Shader), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.Shader), L, __CreateInstance, 14, 1, 1);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Find", _m_Find_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "EnableKeyword", _m_EnableKeyword_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DisableKeyword", _m_DisableKeyword_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "IsKeywordEnabled", _m_IsKeywordEnabled_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetGlobalColor", _m_SetGlobalColor_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetGlobalVector", _m_SetGlobalVector_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetGlobalFloat", _m_SetGlobalFloat_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetGlobalInt", _m_SetGlobalInt_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetGlobalTexture", _m_SetGlobalTexture_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetGlobalMatrix", _m_SetGlobalMatrix_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetGlobalBuffer", _m_SetGlobalBuffer_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "PropertyToID", _m_PropertyToID_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "WarmupAllShaders", _m_WarmupAllShaders_xlua_st_);
            
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.Shader));
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "globalMaximumLOD", _g_get_globalMaximumLOD);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "globalMaximumLOD", _s_set_globalMaximumLOD);
            
			Utils.EndClassRegister(typeof(UnityEngine.Shader), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityEngine.Shader __cl_gen_ret = new UnityEngine.Shader();
					translator.Push(L, __cl_gen_ret);
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Shader constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Find_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    string name = LuaAPI.lua_tostring(L, 1);
                    
                        UnityEngine.Shader __cl_gen_ret = UnityEngine.Shader.Find( name );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EnableKeyword_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    string keyword = LuaAPI.lua_tostring(L, 1);
                    
                    UnityEngine.Shader.EnableKeyword( keyword );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DisableKeyword_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    string keyword = LuaAPI.lua_tostring(L, 1);
                    
                    UnityEngine.Shader.DisableKeyword( keyword );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsKeywordEnabled_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    string keyword = LuaAPI.lua_tostring(L, 1);
                    
                        bool __cl_gen_ret = UnityEngine.Shader.IsKeywordEnabled( keyword );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetGlobalColor_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.Color>(L, 2)) 
                {
                    int nameID = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.Color color;translator.Get(L, 2, out color);
                    
                    UnityEngine.Shader.SetGlobalColor( nameID, color );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Color>(L, 2)) 
                {
                    string propertyName = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.Color color;translator.Get(L, 2, out color);
                    
                    UnityEngine.Shader.SetGlobalColor( propertyName, color );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Shader.SetGlobalColor!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetGlobalVector_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.Vector4>(L, 2)) 
                {
                    int nameID = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.Vector4 vec;translator.Get(L, 2, out vec);
                    
                    UnityEngine.Shader.SetGlobalVector( nameID, vec );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Vector4>(L, 2)) 
                {
                    string propertyName = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.Vector4 vec;translator.Get(L, 2, out vec);
                    
                    UnityEngine.Shader.SetGlobalVector( propertyName, vec );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Shader.SetGlobalVector!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetGlobalFloat_xlua_st_(RealStatePtr L)
        {
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int nameID = LuaAPI.xlua_tointeger(L, 1);
                    float value = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    UnityEngine.Shader.SetGlobalFloat( nameID, value );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    string propertyName = LuaAPI.lua_tostring(L, 1);
                    float value = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    UnityEngine.Shader.SetGlobalFloat( propertyName, value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Shader.SetGlobalFloat!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetGlobalInt_xlua_st_(RealStatePtr L)
        {
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int nameID = LuaAPI.xlua_tointeger(L, 1);
                    int value = LuaAPI.xlua_tointeger(L, 2);
                    
                    UnityEngine.Shader.SetGlobalInt( nameID, value );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    string propertyName = LuaAPI.lua_tostring(L, 1);
                    int value = LuaAPI.xlua_tointeger(L, 2);
                    
                    UnityEngine.Shader.SetGlobalInt( propertyName, value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Shader.SetGlobalInt!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetGlobalTexture_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.Texture>(L, 2)) 
                {
                    int nameID = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.Texture tex = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    
                    UnityEngine.Shader.SetGlobalTexture( nameID, tex );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Texture>(L, 2)) 
                {
                    string propertyName = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.Texture tex = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    
                    UnityEngine.Shader.SetGlobalTexture( propertyName, tex );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Shader.SetGlobalTexture!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetGlobalMatrix_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.Matrix4x4>(L, 2)) 
                {
                    int nameID = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.Matrix4x4 mat;translator.Get(L, 2, out mat);
                    
                    UnityEngine.Shader.SetGlobalMatrix( nameID, mat );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Matrix4x4>(L, 2)) 
                {
                    string propertyName = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.Matrix4x4 mat;translator.Get(L, 2, out mat);
                    
                    UnityEngine.Shader.SetGlobalMatrix( propertyName, mat );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Shader.SetGlobalMatrix!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetGlobalBuffer_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    string propertyName = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.ComputeBuffer buffer = (UnityEngine.ComputeBuffer)translator.GetObject(L, 2, typeof(UnityEngine.ComputeBuffer));
                    
                    UnityEngine.Shader.SetGlobalBuffer( propertyName, buffer );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PropertyToID_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    string name = LuaAPI.lua_tostring(L, 1);
                    
                        int __cl_gen_ret = UnityEngine.Shader.PropertyToID( name );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WarmupAllShaders_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    
                    UnityEngine.Shader.WarmupAllShaders(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isSupported(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Shader __cl_gen_to_be_invoked = (UnityEngine.Shader)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.isSupported);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maximumLOD(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Shader __cl_gen_to_be_invoked = (UnityEngine.Shader)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.maximumLOD);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_globalMaximumLOD(RealStatePtr L)
        {
            
            try {
			    LuaAPI.xlua_pushinteger(L, UnityEngine.Shader.globalMaximumLOD);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_renderQueue(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Shader __cl_gen_to_be_invoked = (UnityEngine.Shader)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.renderQueue);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_maximumLOD(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Shader __cl_gen_to_be_invoked = (UnityEngine.Shader)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.maximumLOD = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_globalMaximumLOD(RealStatePtr L)
        {
            
            try {
			    UnityEngine.Shader.globalMaximumLOD = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
