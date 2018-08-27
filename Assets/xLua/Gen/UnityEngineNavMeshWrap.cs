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
    public class UnityEngineNavMeshWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.NavMesh), L, translator, 0, 0, 0, 0);
			
			
			
			
			
			Utils.EndObjectRegister(typeof(UnityEngine.NavMesh), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.NavMesh), L, __CreateInstance, 10, 2, 2);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Raycast", _m_Raycast_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CalculatePath", _m_CalculatePath_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "FindClosestEdge", _m_FindClosestEdge_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SamplePosition", _m_SamplePosition_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetAreaCost", _m_SetAreaCost_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetAreaCost", _m_GetAreaCost_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetAreaFromName", _m_GetAreaFromName_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CalculateTriangulation", _m_CalculateTriangulation_xlua_st_);
            
			
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "AllAreas", UnityEngine.NavMesh.AllAreas);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.NavMesh));
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "avoidancePredictionTime", _g_get_avoidancePredictionTime);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "pathfindingIterationsPerFrame", _g_get_pathfindingIterationsPerFrame);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "avoidancePredictionTime", _s_set_avoidancePredictionTime);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "pathfindingIterationsPerFrame", _s_set_pathfindingIterationsPerFrame);
            
			Utils.EndClassRegister(typeof(UnityEngine.NavMesh), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityEngine.NavMesh __cl_gen_ret = new UnityEngine.NavMesh();
					translator.Push(L, __cl_gen_ret);
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.NavMesh constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Raycast_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Vector3 sourcePosition;translator.Get(L, 1, out sourcePosition);
                    UnityEngine.Vector3 targetPosition;translator.Get(L, 2, out targetPosition);
                    UnityEngine.NavMeshHit hit;
                    int areaMask = LuaAPI.xlua_tointeger(L, 3);
                    
                        bool __cl_gen_ret = UnityEngine.NavMesh.Raycast( sourcePosition, targetPosition, out hit, areaMask );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    translator.Push(L, hit);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CalculatePath_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Vector3 sourcePosition;translator.Get(L, 1, out sourcePosition);
                    UnityEngine.Vector3 targetPosition;translator.Get(L, 2, out targetPosition);
                    int areaMask = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.NavMeshPath path = (UnityEngine.NavMeshPath)translator.GetObject(L, 4, typeof(UnityEngine.NavMeshPath));
                    
                        bool __cl_gen_ret = UnityEngine.NavMesh.CalculatePath( sourcePosition, targetPosition, areaMask, path );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FindClosestEdge_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Vector3 sourcePosition;translator.Get(L, 1, out sourcePosition);
                    UnityEngine.NavMeshHit hit;
                    int areaMask = LuaAPI.xlua_tointeger(L, 2);
                    
                        bool __cl_gen_ret = UnityEngine.NavMesh.FindClosestEdge( sourcePosition, out hit, areaMask );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    translator.Push(L, hit);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SamplePosition_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Vector3 sourcePosition;translator.Get(L, 1, out sourcePosition);
                    UnityEngine.NavMeshHit hit;
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 2);
                    int areaMask = LuaAPI.xlua_tointeger(L, 3);
                    
                        bool __cl_gen_ret = UnityEngine.NavMesh.SamplePosition( sourcePosition, out hit, maxDistance, areaMask );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    translator.Push(L, hit);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetAreaCost_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    int areaIndex = LuaAPI.xlua_tointeger(L, 1);
                    float cost = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    UnityEngine.NavMesh.SetAreaCost( areaIndex, cost );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAreaCost_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    int areaIndex = LuaAPI.xlua_tointeger(L, 1);
                    
                        float __cl_gen_ret = UnityEngine.NavMesh.GetAreaCost( areaIndex );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAreaFromName_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    string areaName = LuaAPI.lua_tostring(L, 1);
                    
                        int __cl_gen_ret = UnityEngine.NavMesh.GetAreaFromName( areaName );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CalculateTriangulation_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    
                        UnityEngine.NavMeshTriangulation __cl_gen_ret = UnityEngine.NavMesh.CalculateTriangulation(  );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_avoidancePredictionTime(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushnumber(L, UnityEngine.NavMesh.avoidancePredictionTime);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pathfindingIterationsPerFrame(RealStatePtr L)
        {
            
            try {
			    LuaAPI.xlua_pushinteger(L, UnityEngine.NavMesh.pathfindingIterationsPerFrame);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_avoidancePredictionTime(RealStatePtr L)
        {
            
            try {
			    UnityEngine.NavMesh.avoidancePredictionTime = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_pathfindingIterationsPerFrame(RealStatePtr L)
        {
            
            try {
			    UnityEngine.NavMesh.pathfindingIterationsPerFrame = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
