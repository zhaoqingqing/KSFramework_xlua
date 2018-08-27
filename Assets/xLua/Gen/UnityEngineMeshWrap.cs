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
    public class UnityEngineMeshWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.Mesh), L, translator, 0, 25, 17, 14);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Clear", _m_Clear);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetVertices", _m_SetVertices);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetNormals", _m_SetNormals);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetTangents", _m_SetTangents);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetUVs", _m_SetUVs);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetUVs", _m_GetUVs);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetColors", _m_SetColors);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RecalculateBounds", _m_RecalculateBounds);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RecalculateNormals", _m_RecalculateNormals);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Optimize", _m_Optimize);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetTriangles", _m_GetTriangles);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetTriangles", _m_SetTriangles);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetIndices", _m_GetIndices);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetIndices", _m_SetIndices);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetTopology", _m_GetTopology);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CombineMeshes", _m_CombineMeshes);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MarkDynamic", _m_MarkDynamic);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UploadMeshData", _m_UploadMeshData);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetBlendShapeIndex", _m_GetBlendShapeIndex);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetBlendShapeName", _m_GetBlendShapeName);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetBlendShapeFrameCount", _m_GetBlendShapeFrameCount);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetBlendShapeFrameWeight", _m_GetBlendShapeFrameWeight);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetBlendShapeFrameVertices", _m_GetBlendShapeFrameVertices);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ClearBlendShapes", _m_ClearBlendShapes);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddBlendShapeFrame", _m_AddBlendShapeFrame);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "isReadable", _g_get_isReadable);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "vertices", _g_get_vertices);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "normals", _g_get_normals);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "tangents", _g_get_tangents);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "uv", _g_get_uv);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "uv2", _g_get_uv2);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "uv3", _g_get_uv3);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "uv4", _g_get_uv4);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "bounds", _g_get_bounds);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "colors", _g_get_colors);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "colors32", _g_get_colors32);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "triangles", _g_get_triangles);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "vertexCount", _g_get_vertexCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "subMeshCount", _g_get_subMeshCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "boneWeights", _g_get_boneWeights);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "bindposes", _g_get_bindposes);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "blendShapeCount", _g_get_blendShapeCount);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "vertices", _s_set_vertices);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "normals", _s_set_normals);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "tangents", _s_set_tangents);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "uv", _s_set_uv);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "uv2", _s_set_uv2);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "uv3", _s_set_uv3);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "uv4", _s_set_uv4);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "bounds", _s_set_bounds);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "colors", _s_set_colors);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "colors32", _s_set_colors32);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "triangles", _s_set_triangles);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "subMeshCount", _s_set_subMeshCount);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "boneWeights", _s_set_boneWeights);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "bindposes", _s_set_bindposes);
            
			Utils.EndObjectRegister(typeof(UnityEngine.Mesh), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.Mesh), L, __CreateInstance, 1, 0, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.Mesh));
			
			
			Utils.EndClassRegister(typeof(UnityEngine.Mesh), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityEngine.Mesh __cl_gen_ret = new UnityEngine.Mesh();
					translator.Push(L, __cl_gen_ret);
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Mesh constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Clear(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Mesh __cl_gen_to_be_invoked = (UnityEngine.Mesh)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1) 
                {
                    
                    __cl_gen_to_be_invoked.Clear(  );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    bool keepVertexLayout = LuaAPI.lua_toboolean(L, 2);
                    
                    __cl_gen_to_be_invoked.Clear( keepVertexLayout );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Mesh.Clear!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetVertices(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Mesh __cl_gen_to_be_invoked = (UnityEngine.Mesh)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    System.Collections.Generic.List<UnityEngine.Vector3> inVertices = (System.Collections.Generic.List<UnityEngine.Vector3>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Vector3>));
                    
                    __cl_gen_to_be_invoked.SetVertices( inVertices );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetNormals(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Mesh __cl_gen_to_be_invoked = (UnityEngine.Mesh)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    System.Collections.Generic.List<UnityEngine.Vector3> inNormals = (System.Collections.Generic.List<UnityEngine.Vector3>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Vector3>));
                    
                    __cl_gen_to_be_invoked.SetNormals( inNormals );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetTangents(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Mesh __cl_gen_to_be_invoked = (UnityEngine.Mesh)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    System.Collections.Generic.List<UnityEngine.Vector4> inTangents = (System.Collections.Generic.List<UnityEngine.Vector4>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Vector4>));
                    
                    __cl_gen_to_be_invoked.SetTangents( inTangents );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetUVs(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Mesh __cl_gen_to_be_invoked = (UnityEngine.Mesh)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector2>>(L, 3)) 
                {
                    int channel = LuaAPI.xlua_tointeger(L, 2);
                    System.Collections.Generic.List<UnityEngine.Vector2> uvs = (System.Collections.Generic.List<UnityEngine.Vector2>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.Vector2>));
                    
                    __cl_gen_to_be_invoked.SetUVs( channel, uvs );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector3>>(L, 3)) 
                {
                    int channel = LuaAPI.xlua_tointeger(L, 2);
                    System.Collections.Generic.List<UnityEngine.Vector3> uvs = (System.Collections.Generic.List<UnityEngine.Vector3>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.Vector3>));
                    
                    __cl_gen_to_be_invoked.SetUVs( channel, uvs );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector4>>(L, 3)) 
                {
                    int channel = LuaAPI.xlua_tointeger(L, 2);
                    System.Collections.Generic.List<UnityEngine.Vector4> uvs = (System.Collections.Generic.List<UnityEngine.Vector4>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.Vector4>));
                    
                    __cl_gen_to_be_invoked.SetUVs( channel, uvs );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Mesh.SetUVs!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetUVs(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Mesh __cl_gen_to_be_invoked = (UnityEngine.Mesh)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector2>>(L, 3)) 
                {
                    int channel = LuaAPI.xlua_tointeger(L, 2);
                    System.Collections.Generic.List<UnityEngine.Vector2> uvs = (System.Collections.Generic.List<UnityEngine.Vector2>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.Vector2>));
                    
                    __cl_gen_to_be_invoked.GetUVs( channel, uvs );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector3>>(L, 3)) 
                {
                    int channel = LuaAPI.xlua_tointeger(L, 2);
                    System.Collections.Generic.List<UnityEngine.Vector3> uvs = (System.Collections.Generic.List<UnityEngine.Vector3>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.Vector3>));
                    
                    __cl_gen_to_be_invoked.GetUVs( channel, uvs );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector4>>(L, 3)) 
                {
                    int channel = LuaAPI.xlua_tointeger(L, 2);
                    System.Collections.Generic.List<UnityEngine.Vector4> uvs = (System.Collections.Generic.List<UnityEngine.Vector4>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.Vector4>));
                    
                    __cl_gen_to_be_invoked.GetUVs( channel, uvs );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Mesh.GetUVs!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetColors(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Mesh __cl_gen_to_be_invoked = (UnityEngine.Mesh)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Color>>(L, 2)) 
                {
                    System.Collections.Generic.List<UnityEngine.Color> inColors = (System.Collections.Generic.List<UnityEngine.Color>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Color>));
                    
                    __cl_gen_to_be_invoked.SetColors( inColors );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Color32>>(L, 2)) 
                {
                    System.Collections.Generic.List<UnityEngine.Color32> inColors = (System.Collections.Generic.List<UnityEngine.Color32>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Color32>));
                    
                    __cl_gen_to_be_invoked.SetColors( inColors );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Mesh.SetColors!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RecalculateBounds(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Mesh __cl_gen_to_be_invoked = (UnityEngine.Mesh)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.RecalculateBounds(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RecalculateNormals(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Mesh __cl_gen_to_be_invoked = (UnityEngine.Mesh)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.RecalculateNormals(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Optimize(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Mesh __cl_gen_to_be_invoked = (UnityEngine.Mesh)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.Optimize(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetTriangles(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Mesh __cl_gen_to_be_invoked = (UnityEngine.Mesh)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    int submesh = LuaAPI.xlua_tointeger(L, 2);
                    
                        int[] __cl_gen_ret = __cl_gen_to_be_invoked.GetTriangles( submesh );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetTriangles(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Mesh __cl_gen_to_be_invoked = (UnityEngine.Mesh)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 3&& translator.Assignable<int[]>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    int[] triangles = (int[])translator.GetObject(L, 2, typeof(int[]));
                    int submesh = LuaAPI.xlua_tointeger(L, 3);
                    
                    __cl_gen_to_be_invoked.SetTriangles( triangles, submesh );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& translator.Assignable<System.Collections.Generic.List<int>>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.Collections.Generic.List<int> inTriangles = (System.Collections.Generic.List<int>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<int>));
                    int submesh = LuaAPI.xlua_tointeger(L, 3);
                    
                    __cl_gen_to_be_invoked.SetTriangles( inTriangles, submesh );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Mesh.SetTriangles!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetIndices(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Mesh __cl_gen_to_be_invoked = (UnityEngine.Mesh)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    int submesh = LuaAPI.xlua_tointeger(L, 2);
                    
                        int[] __cl_gen_ret = __cl_gen_to_be_invoked.GetIndices( submesh );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetIndices(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Mesh __cl_gen_to_be_invoked = (UnityEngine.Mesh)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    int[] indices = (int[])translator.GetObject(L, 2, typeof(int[]));
                    UnityEngine.MeshTopology topology;translator.Get(L, 3, out topology);
                    int submesh = LuaAPI.xlua_tointeger(L, 4);
                    
                    __cl_gen_to_be_invoked.SetIndices( indices, topology, submesh );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetTopology(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Mesh __cl_gen_to_be_invoked = (UnityEngine.Mesh)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    int submesh = LuaAPI.xlua_tointeger(L, 2);
                    
                        UnityEngine.MeshTopology __cl_gen_ret = __cl_gen_to_be_invoked.GetTopology( submesh );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CombineMeshes(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Mesh __cl_gen_to_be_invoked = (UnityEngine.Mesh)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.CombineInstance[]>(L, 2)) 
                {
                    UnityEngine.CombineInstance[] combine = (UnityEngine.CombineInstance[])translator.GetObject(L, 2, typeof(UnityEngine.CombineInstance[]));
                    
                    __cl_gen_to_be_invoked.CombineMeshes( combine );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.CombineInstance[]>(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.CombineInstance[] combine = (UnityEngine.CombineInstance[])translator.GetObject(L, 2, typeof(UnityEngine.CombineInstance[]));
                    bool mergeSubMeshes = LuaAPI.lua_toboolean(L, 3);
                    
                    __cl_gen_to_be_invoked.CombineMeshes( combine, mergeSubMeshes );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.CombineInstance[]>(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.CombineInstance[] combine = (UnityEngine.CombineInstance[])translator.GetObject(L, 2, typeof(UnityEngine.CombineInstance[]));
                    bool mergeSubMeshes = LuaAPI.lua_toboolean(L, 3);
                    bool useMatrices = LuaAPI.lua_toboolean(L, 4);
                    
                    __cl_gen_to_be_invoked.CombineMeshes( combine, mergeSubMeshes, useMatrices );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Mesh.CombineMeshes!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MarkDynamic(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Mesh __cl_gen_to_be_invoked = (UnityEngine.Mesh)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.MarkDynamic(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UploadMeshData(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Mesh __cl_gen_to_be_invoked = (UnityEngine.Mesh)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    bool markNoLogerReadable = LuaAPI.lua_toboolean(L, 2);
                    
                    __cl_gen_to_be_invoked.UploadMeshData( markNoLogerReadable );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetBlendShapeIndex(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Mesh __cl_gen_to_be_invoked = (UnityEngine.Mesh)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string blendShapeName = LuaAPI.lua_tostring(L, 2);
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.GetBlendShapeIndex( blendShapeName );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetBlendShapeName(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Mesh __cl_gen_to_be_invoked = (UnityEngine.Mesh)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    int shapeIndex = LuaAPI.xlua_tointeger(L, 2);
                    
                        string __cl_gen_ret = __cl_gen_to_be_invoked.GetBlendShapeName( shapeIndex );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetBlendShapeFrameCount(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Mesh __cl_gen_to_be_invoked = (UnityEngine.Mesh)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    int shapeIndex = LuaAPI.xlua_tointeger(L, 2);
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.GetBlendShapeFrameCount( shapeIndex );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetBlendShapeFrameWeight(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Mesh __cl_gen_to_be_invoked = (UnityEngine.Mesh)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    int shapeIndex = LuaAPI.xlua_tointeger(L, 2);
                    int frameIndex = LuaAPI.xlua_tointeger(L, 3);
                    
                        float __cl_gen_ret = __cl_gen_to_be_invoked.GetBlendShapeFrameWeight( shapeIndex, frameIndex );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetBlendShapeFrameVertices(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Mesh __cl_gen_to_be_invoked = (UnityEngine.Mesh)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    int shapeIndex = LuaAPI.xlua_tointeger(L, 2);
                    int frameIndex = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.Vector3[] deltaVertices = (UnityEngine.Vector3[])translator.GetObject(L, 4, typeof(UnityEngine.Vector3[]));
                    UnityEngine.Vector3[] deltaNormals = (UnityEngine.Vector3[])translator.GetObject(L, 5, typeof(UnityEngine.Vector3[]));
                    UnityEngine.Vector3[] deltaTangents = (UnityEngine.Vector3[])translator.GetObject(L, 6, typeof(UnityEngine.Vector3[]));
                    
                    __cl_gen_to_be_invoked.GetBlendShapeFrameVertices( shapeIndex, frameIndex, deltaVertices, deltaNormals, deltaTangents );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ClearBlendShapes(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Mesh __cl_gen_to_be_invoked = (UnityEngine.Mesh)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.ClearBlendShapes(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddBlendShapeFrame(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Mesh __cl_gen_to_be_invoked = (UnityEngine.Mesh)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string shapeName = LuaAPI.lua_tostring(L, 2);
                    float frameWeight = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector3[] deltaVertices = (UnityEngine.Vector3[])translator.GetObject(L, 4, typeof(UnityEngine.Vector3[]));
                    UnityEngine.Vector3[] deltaNormals = (UnityEngine.Vector3[])translator.GetObject(L, 5, typeof(UnityEngine.Vector3[]));
                    UnityEngine.Vector3[] deltaTangents = (UnityEngine.Vector3[])translator.GetObject(L, 6, typeof(UnityEngine.Vector3[]));
                    
                    __cl_gen_to_be_invoked.AddBlendShapeFrame( shapeName, frameWeight, deltaVertices, deltaNormals, deltaTangents );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isReadable(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Mesh __cl_gen_to_be_invoked = (UnityEngine.Mesh)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.isReadable);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_vertices(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Mesh __cl_gen_to_be_invoked = (UnityEngine.Mesh)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.vertices);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_normals(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Mesh __cl_gen_to_be_invoked = (UnityEngine.Mesh)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.normals);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_tangents(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Mesh __cl_gen_to_be_invoked = (UnityEngine.Mesh)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.tangents);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_uv(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Mesh __cl_gen_to_be_invoked = (UnityEngine.Mesh)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.uv);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_uv2(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Mesh __cl_gen_to_be_invoked = (UnityEngine.Mesh)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.uv2);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_uv3(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Mesh __cl_gen_to_be_invoked = (UnityEngine.Mesh)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.uv3);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_uv4(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Mesh __cl_gen_to_be_invoked = (UnityEngine.Mesh)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.uv4);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_bounds(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Mesh __cl_gen_to_be_invoked = (UnityEngine.Mesh)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineBounds(L, __cl_gen_to_be_invoked.bounds);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_colors(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Mesh __cl_gen_to_be_invoked = (UnityEngine.Mesh)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.colors);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_colors32(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Mesh __cl_gen_to_be_invoked = (UnityEngine.Mesh)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.colors32);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_triangles(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Mesh __cl_gen_to_be_invoked = (UnityEngine.Mesh)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.triangles);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_vertexCount(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Mesh __cl_gen_to_be_invoked = (UnityEngine.Mesh)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.vertexCount);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_subMeshCount(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Mesh __cl_gen_to_be_invoked = (UnityEngine.Mesh)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.subMeshCount);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_boneWeights(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Mesh __cl_gen_to_be_invoked = (UnityEngine.Mesh)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.boneWeights);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_bindposes(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Mesh __cl_gen_to_be_invoked = (UnityEngine.Mesh)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.bindposes);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_blendShapeCount(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Mesh __cl_gen_to_be_invoked = (UnityEngine.Mesh)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.blendShapeCount);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_vertices(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Mesh __cl_gen_to_be_invoked = (UnityEngine.Mesh)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.vertices = (UnityEngine.Vector3[])translator.GetObject(L, 2, typeof(UnityEngine.Vector3[]));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_normals(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Mesh __cl_gen_to_be_invoked = (UnityEngine.Mesh)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.normals = (UnityEngine.Vector3[])translator.GetObject(L, 2, typeof(UnityEngine.Vector3[]));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_tangents(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Mesh __cl_gen_to_be_invoked = (UnityEngine.Mesh)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.tangents = (UnityEngine.Vector4[])translator.GetObject(L, 2, typeof(UnityEngine.Vector4[]));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_uv(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Mesh __cl_gen_to_be_invoked = (UnityEngine.Mesh)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.uv = (UnityEngine.Vector2[])translator.GetObject(L, 2, typeof(UnityEngine.Vector2[]));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_uv2(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Mesh __cl_gen_to_be_invoked = (UnityEngine.Mesh)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.uv2 = (UnityEngine.Vector2[])translator.GetObject(L, 2, typeof(UnityEngine.Vector2[]));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_uv3(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Mesh __cl_gen_to_be_invoked = (UnityEngine.Mesh)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.uv3 = (UnityEngine.Vector2[])translator.GetObject(L, 2, typeof(UnityEngine.Vector2[]));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_uv4(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Mesh __cl_gen_to_be_invoked = (UnityEngine.Mesh)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.uv4 = (UnityEngine.Vector2[])translator.GetObject(L, 2, typeof(UnityEngine.Vector2[]));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_bounds(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Mesh __cl_gen_to_be_invoked = (UnityEngine.Mesh)translator.FastGetCSObj(L, 1);
                UnityEngine.Bounds __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.bounds = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_colors(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Mesh __cl_gen_to_be_invoked = (UnityEngine.Mesh)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.colors = (UnityEngine.Color[])translator.GetObject(L, 2, typeof(UnityEngine.Color[]));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_colors32(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Mesh __cl_gen_to_be_invoked = (UnityEngine.Mesh)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.colors32 = (UnityEngine.Color32[])translator.GetObject(L, 2, typeof(UnityEngine.Color32[]));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_triangles(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Mesh __cl_gen_to_be_invoked = (UnityEngine.Mesh)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.triangles = (int[])translator.GetObject(L, 2, typeof(int[]));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_subMeshCount(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Mesh __cl_gen_to_be_invoked = (UnityEngine.Mesh)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.subMeshCount = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_boneWeights(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Mesh __cl_gen_to_be_invoked = (UnityEngine.Mesh)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.boneWeights = (UnityEngine.BoneWeight[])translator.GetObject(L, 2, typeof(UnityEngine.BoneWeight[]));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_bindposes(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Mesh __cl_gen_to_be_invoked = (UnityEngine.Mesh)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.bindposes = (UnityEngine.Matrix4x4[])translator.GetObject(L, 2, typeof(UnityEngine.Matrix4x4[]));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
