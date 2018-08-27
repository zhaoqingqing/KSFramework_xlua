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
    public class UnityEngineCameraWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.Camera), L, translator, 0, 30, 37, 30);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetTargetBuffers", _m_SetTargetBuffers);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ResetWorldToCameraMatrix", _m_ResetWorldToCameraMatrix);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ResetProjectionMatrix", _m_ResetProjectionMatrix);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ResetAspect", _m_ResetAspect);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ResetFieldOfView", _m_ResetFieldOfView);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetStereoViewMatrices", _m_SetStereoViewMatrices);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ResetStereoViewMatrices", _m_ResetStereoViewMatrices);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetStereoProjectionMatrices", _m_SetStereoProjectionMatrices);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ResetStereoProjectionMatrices", _m_ResetStereoProjectionMatrices);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WorldToScreenPoint", _m_WorldToScreenPoint);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WorldToViewportPoint", _m_WorldToViewportPoint);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ViewportToWorldPoint", _m_ViewportToWorldPoint);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ScreenToWorldPoint", _m_ScreenToWorldPoint);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ScreenToViewportPoint", _m_ScreenToViewportPoint);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ViewportToScreenPoint", _m_ViewportToScreenPoint);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ViewportPointToRay", _m_ViewportPointToRay);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ScreenPointToRay", _m_ScreenPointToRay);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Render", _m_Render);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RenderWithShader", _m_RenderWithShader);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetReplacementShader", _m_SetReplacementShader);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ResetReplacementShader", _m_ResetReplacementShader);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RenderDontRestore", _m_RenderDontRestore);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RenderToCubemap", _m_RenderToCubemap);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CopyFrom", _m_CopyFrom);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddCommandBuffer", _m_AddCommandBuffer);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RemoveCommandBuffer", _m_RemoveCommandBuffer);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RemoveCommandBuffers", _m_RemoveCommandBuffers);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RemoveAllCommandBuffers", _m_RemoveAllCommandBuffers);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetCommandBuffers", _m_GetCommandBuffers);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CalculateObliqueMatrix", _m_CalculateObliqueMatrix);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "fieldOfView", _g_get_fieldOfView);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "nearClipPlane", _g_get_nearClipPlane);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "farClipPlane", _g_get_farClipPlane);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "renderingPath", _g_get_renderingPath);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "actualRenderingPath", _g_get_actualRenderingPath);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hdr", _g_get_hdr);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "orthographicSize", _g_get_orthographicSize);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "orthographic", _g_get_orthographic);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "opaqueSortMode", _g_get_opaqueSortMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "transparencySortMode", _g_get_transparencySortMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "depth", _g_get_depth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "aspect", _g_get_aspect);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "cullingMask", _g_get_cullingMask);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "eventMask", _g_get_eventMask);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "backgroundColor", _g_get_backgroundColor);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rect", _g_get_rect);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pixelRect", _g_get_pixelRect);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "targetTexture", _g_get_targetTexture);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pixelWidth", _g_get_pixelWidth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pixelHeight", _g_get_pixelHeight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "cameraToWorldMatrix", _g_get_cameraToWorldMatrix);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "worldToCameraMatrix", _g_get_worldToCameraMatrix);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "projectionMatrix", _g_get_projectionMatrix);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "velocity", _g_get_velocity);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "clearFlags", _g_get_clearFlags);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "stereoEnabled", _g_get_stereoEnabled);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "stereoSeparation", _g_get_stereoSeparation);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "stereoConvergence", _g_get_stereoConvergence);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "cameraType", _g_get_cameraType);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "stereoMirrorMode", _g_get_stereoMirrorMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "targetDisplay", _g_get_targetDisplay);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "useOcclusionCulling", _g_get_useOcclusionCulling);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "layerCullDistances", _g_get_layerCullDistances);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "layerCullSpherical", _g_get_layerCullSpherical);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "depthTextureMode", _g_get_depthTextureMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "clearStencilAfterLightingPass", _g_get_clearStencilAfterLightingPass);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "commandBufferCount", _g_get_commandBufferCount);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "fieldOfView", _s_set_fieldOfView);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "nearClipPlane", _s_set_nearClipPlane);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "farClipPlane", _s_set_farClipPlane);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "renderingPath", _s_set_renderingPath);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "hdr", _s_set_hdr);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "orthographicSize", _s_set_orthographicSize);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "orthographic", _s_set_orthographic);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "opaqueSortMode", _s_set_opaqueSortMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "transparencySortMode", _s_set_transparencySortMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "depth", _s_set_depth);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "aspect", _s_set_aspect);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "cullingMask", _s_set_cullingMask);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "eventMask", _s_set_eventMask);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "backgroundColor", _s_set_backgroundColor);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "rect", _s_set_rect);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "pixelRect", _s_set_pixelRect);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "targetTexture", _s_set_targetTexture);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "worldToCameraMatrix", _s_set_worldToCameraMatrix);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "projectionMatrix", _s_set_projectionMatrix);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "clearFlags", _s_set_clearFlags);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "stereoSeparation", _s_set_stereoSeparation);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "stereoConvergence", _s_set_stereoConvergence);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "cameraType", _s_set_cameraType);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "stereoMirrorMode", _s_set_stereoMirrorMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "targetDisplay", _s_set_targetDisplay);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "useOcclusionCulling", _s_set_useOcclusionCulling);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "layerCullDistances", _s_set_layerCullDistances);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "layerCullSpherical", _s_set_layerCullSpherical);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "depthTextureMode", _s_set_depthTextureMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "clearStencilAfterLightingPass", _s_set_clearStencilAfterLightingPass);
            
			Utils.EndObjectRegister(typeof(UnityEngine.Camera), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.Camera), L, __CreateInstance, 3, 7, 3);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "GetAllCameras", _m_GetAllCameras_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetupCurrent", _m_SetupCurrent_xlua_st_);
            
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.Camera));
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "main", _g_get_main);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "current", _g_get_current);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "allCameras", _g_get_allCameras);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "allCamerasCount", _g_get_allCamerasCount);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "onPreCull", _g_get_onPreCull);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "onPreRender", _g_get_onPreRender);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "onPostRender", _g_get_onPostRender);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "onPreCull", _s_set_onPreCull);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "onPreRender", _s_set_onPreRender);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "onPostRender", _s_set_onPostRender);
            
			Utils.EndClassRegister(typeof(UnityEngine.Camera), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityEngine.Camera __cl_gen_ret = new UnityEngine.Camera();
					translator.Push(L, __cl_gen_ret);
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Camera constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetTargetBuffers(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.RenderBuffer>(L, 2)&& translator.Assignable<UnityEngine.RenderBuffer>(L, 3)) 
                {
                    UnityEngine.RenderBuffer colorBuffer;translator.Get(L, 2, out colorBuffer);
                    UnityEngine.RenderBuffer depthBuffer;translator.Get(L, 3, out depthBuffer);
                    
                    __cl_gen_to_be_invoked.SetTargetBuffers( colorBuffer, depthBuffer );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.RenderBuffer[]>(L, 2)&& translator.Assignable<UnityEngine.RenderBuffer>(L, 3)) 
                {
                    UnityEngine.RenderBuffer[] colorBuffer = (UnityEngine.RenderBuffer[])translator.GetObject(L, 2, typeof(UnityEngine.RenderBuffer[]));
                    UnityEngine.RenderBuffer depthBuffer;translator.Get(L, 3, out depthBuffer);
                    
                    __cl_gen_to_be_invoked.SetTargetBuffers( colorBuffer, depthBuffer );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Camera.SetTargetBuffers!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ResetWorldToCameraMatrix(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.ResetWorldToCameraMatrix(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ResetProjectionMatrix(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.ResetProjectionMatrix(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ResetAspect(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.ResetAspect(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ResetFieldOfView(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.ResetFieldOfView(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetStereoViewMatrices(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Matrix4x4 leftMatrix;translator.Get(L, 2, out leftMatrix);
                    UnityEngine.Matrix4x4 rightMatrix;translator.Get(L, 3, out rightMatrix);
                    
                    __cl_gen_to_be_invoked.SetStereoViewMatrices( leftMatrix, rightMatrix );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ResetStereoViewMatrices(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.ResetStereoViewMatrices(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetStereoProjectionMatrices(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Matrix4x4 leftMatrix;translator.Get(L, 2, out leftMatrix);
                    UnityEngine.Matrix4x4 rightMatrix;translator.Get(L, 3, out rightMatrix);
                    
                    __cl_gen_to_be_invoked.SetStereoProjectionMatrices( leftMatrix, rightMatrix );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ResetStereoProjectionMatrices(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.ResetStereoProjectionMatrices(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WorldToScreenPoint(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Vector3 position;translator.Get(L, 2, out position);
                    
                        UnityEngine.Vector3 __cl_gen_ret = __cl_gen_to_be_invoked.WorldToScreenPoint( position );
                        translator.PushUnityEngineVector3(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WorldToViewportPoint(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Vector3 position;translator.Get(L, 2, out position);
                    
                        UnityEngine.Vector3 __cl_gen_ret = __cl_gen_to_be_invoked.WorldToViewportPoint( position );
                        translator.PushUnityEngineVector3(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ViewportToWorldPoint(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Vector3 position;translator.Get(L, 2, out position);
                    
                        UnityEngine.Vector3 __cl_gen_ret = __cl_gen_to_be_invoked.ViewportToWorldPoint( position );
                        translator.PushUnityEngineVector3(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ScreenToWorldPoint(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Vector3 position;translator.Get(L, 2, out position);
                    
                        UnityEngine.Vector3 __cl_gen_ret = __cl_gen_to_be_invoked.ScreenToWorldPoint( position );
                        translator.PushUnityEngineVector3(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ScreenToViewportPoint(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Vector3 position;translator.Get(L, 2, out position);
                    
                        UnityEngine.Vector3 __cl_gen_ret = __cl_gen_to_be_invoked.ScreenToViewportPoint( position );
                        translator.PushUnityEngineVector3(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ViewportToScreenPoint(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Vector3 position;translator.Get(L, 2, out position);
                    
                        UnityEngine.Vector3 __cl_gen_ret = __cl_gen_to_be_invoked.ViewportToScreenPoint( position );
                        translator.PushUnityEngineVector3(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ViewportPointToRay(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Vector3 position;translator.Get(L, 2, out position);
                    
                        UnityEngine.Ray __cl_gen_ret = __cl_gen_to_be_invoked.ViewportPointToRay( position );
                        translator.PushUnityEngineRay(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ScreenPointToRay(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Vector3 position;translator.Get(L, 2, out position);
                    
                        UnityEngine.Ray __cl_gen_ret = __cl_gen_to_be_invoked.ScreenPointToRay( position );
                        translator.PushUnityEngineRay(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAllCameras_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Camera[] cameras = (UnityEngine.Camera[])translator.GetObject(L, 1, typeof(UnityEngine.Camera[]));
                    
                        int __cl_gen_ret = UnityEngine.Camera.GetAllCameras( cameras );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Render(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.Render(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RenderWithShader(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Shader shader = (UnityEngine.Shader)translator.GetObject(L, 2, typeof(UnityEngine.Shader));
                    string replacementTag = LuaAPI.lua_tostring(L, 3);
                    
                    __cl_gen_to_be_invoked.RenderWithShader( shader, replacementTag );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetReplacementShader(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Shader shader = (UnityEngine.Shader)translator.GetObject(L, 2, typeof(UnityEngine.Shader));
                    string replacementTag = LuaAPI.lua_tostring(L, 3);
                    
                    __cl_gen_to_be_invoked.SetReplacementShader( shader, replacementTag );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ResetReplacementShader(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.ResetReplacementShader(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RenderDontRestore(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.RenderDontRestore(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetupCurrent_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Camera cur = (UnityEngine.Camera)translator.GetObject(L, 1, typeof(UnityEngine.Camera));
                    
                    UnityEngine.Camera.SetupCurrent( cur );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RenderToCubemap(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Cubemap>(L, 2)) 
                {
                    UnityEngine.Cubemap cubemap = (UnityEngine.Cubemap)translator.GetObject(L, 2, typeof(UnityEngine.Cubemap));
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.RenderToCubemap( cubemap );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.RenderTexture>(L, 2)) 
                {
                    UnityEngine.RenderTexture cubemap = (UnityEngine.RenderTexture)translator.GetObject(L, 2, typeof(UnityEngine.RenderTexture));
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.RenderToCubemap( cubemap );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Cubemap>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Cubemap cubemap = (UnityEngine.Cubemap)translator.GetObject(L, 2, typeof(UnityEngine.Cubemap));
                    int faceMask = LuaAPI.xlua_tointeger(L, 3);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.RenderToCubemap( cubemap, faceMask );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.RenderTexture>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.RenderTexture cubemap = (UnityEngine.RenderTexture)translator.GetObject(L, 2, typeof(UnityEngine.RenderTexture));
                    int faceMask = LuaAPI.xlua_tointeger(L, 3);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.RenderToCubemap( cubemap, faceMask );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Camera.RenderToCubemap!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CopyFrom(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Camera other = (UnityEngine.Camera)translator.GetObject(L, 2, typeof(UnityEngine.Camera));
                    
                    __cl_gen_to_be_invoked.CopyFrom( other );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddCommandBuffer(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Rendering.CameraEvent evt;translator.Get(L, 2, out evt);
                    UnityEngine.Rendering.CommandBuffer buffer = (UnityEngine.Rendering.CommandBuffer)translator.GetObject(L, 3, typeof(UnityEngine.Rendering.CommandBuffer));
                    
                    __cl_gen_to_be_invoked.AddCommandBuffer( evt, buffer );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RemoveCommandBuffer(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Rendering.CameraEvent evt;translator.Get(L, 2, out evt);
                    UnityEngine.Rendering.CommandBuffer buffer = (UnityEngine.Rendering.CommandBuffer)translator.GetObject(L, 3, typeof(UnityEngine.Rendering.CommandBuffer));
                    
                    __cl_gen_to_be_invoked.RemoveCommandBuffer( evt, buffer );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RemoveCommandBuffers(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Rendering.CameraEvent evt;translator.Get(L, 2, out evt);
                    
                    __cl_gen_to_be_invoked.RemoveCommandBuffers( evt );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RemoveAllCommandBuffers(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.RemoveAllCommandBuffers(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetCommandBuffers(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Rendering.CameraEvent evt;translator.Get(L, 2, out evt);
                    
                        UnityEngine.Rendering.CommandBuffer[] __cl_gen_ret = __cl_gen_to_be_invoked.GetCommandBuffers( evt );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CalculateObliqueMatrix(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Vector4 clipPlane;translator.Get(L, 2, out clipPlane);
                    
                        UnityEngine.Matrix4x4 __cl_gen_ret = __cl_gen_to_be_invoked.CalculateObliqueMatrix( clipPlane );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_fieldOfView(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.fieldOfView);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_nearClipPlane(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.nearClipPlane);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_farClipPlane(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.farClipPlane);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_renderingPath(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.renderingPath);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_actualRenderingPath(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.actualRenderingPath);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hdr(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.hdr);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_orthographicSize(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.orthographicSize);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_orthographic(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.orthographic);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_opaqueSortMode(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.opaqueSortMode);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_transparencySortMode(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.transparencySortMode);
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
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.depth);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_aspect(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.aspect);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_cullingMask(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.cullingMask);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_eventMask(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.eventMask);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_backgroundColor(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineColor(L, __cl_gen_to_be_invoked.backgroundColor);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_rect(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.rect);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pixelRect(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.pixelRect);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_targetTexture(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.targetTexture);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pixelWidth(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.pixelWidth);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pixelHeight(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.pixelHeight);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_cameraToWorldMatrix(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.cameraToWorldMatrix);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_worldToCameraMatrix(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.worldToCameraMatrix);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_projectionMatrix(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.projectionMatrix);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_velocity(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, __cl_gen_to_be_invoked.velocity);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_clearFlags(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.clearFlags);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_stereoEnabled(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.stereoEnabled);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_stereoSeparation(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.stereoSeparation);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_stereoConvergence(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.stereoConvergence);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_cameraType(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.cameraType);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_stereoMirrorMode(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.stereoMirrorMode);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_targetDisplay(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.targetDisplay);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_main(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, UnityEngine.Camera.main);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_current(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, UnityEngine.Camera.current);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_allCameras(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, UnityEngine.Camera.allCameras);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_allCamerasCount(RealStatePtr L)
        {
            
            try {
			    LuaAPI.xlua_pushinteger(L, UnityEngine.Camera.allCamerasCount);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_useOcclusionCulling(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.useOcclusionCulling);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_layerCullDistances(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.layerCullDistances);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_layerCullSpherical(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.layerCullSpherical);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_depthTextureMode(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.depthTextureMode);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_clearStencilAfterLightingPass(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.clearStencilAfterLightingPass);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_commandBufferCount(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.commandBufferCount);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onPreCull(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, UnityEngine.Camera.onPreCull);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onPreRender(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, UnityEngine.Camera.onPreRender);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onPostRender(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, UnityEngine.Camera.onPostRender);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_fieldOfView(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.fieldOfView = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_nearClipPlane(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.nearClipPlane = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_farClipPlane(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.farClipPlane = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_renderingPath(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                UnityEngine.RenderingPath __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.renderingPath = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_hdr(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.hdr = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_orthographicSize(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.orthographicSize = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_orthographic(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.orthographic = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_opaqueSortMode(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                UnityEngine.Rendering.OpaqueSortMode __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.opaqueSortMode = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_transparencySortMode(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                UnityEngine.TransparencySortMode __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.transparencySortMode = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_depth(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.depth = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_aspect(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.aspect = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_cullingMask(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.cullingMask = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_eventMask(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.eventMask = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_backgroundColor(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                UnityEngine.Color __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.backgroundColor = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_rect(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                UnityEngine.Rect __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.rect = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_pixelRect(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                UnityEngine.Rect __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.pixelRect = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_targetTexture(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.targetTexture = (UnityEngine.RenderTexture)translator.GetObject(L, 2, typeof(UnityEngine.RenderTexture));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_worldToCameraMatrix(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                UnityEngine.Matrix4x4 __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.worldToCameraMatrix = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_projectionMatrix(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                UnityEngine.Matrix4x4 __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.projectionMatrix = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_clearFlags(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                UnityEngine.CameraClearFlags __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.clearFlags = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_stereoSeparation(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.stereoSeparation = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_stereoConvergence(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.stereoConvergence = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_cameraType(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                UnityEngine.CameraType __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.cameraType = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_stereoMirrorMode(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.stereoMirrorMode = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_targetDisplay(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.targetDisplay = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_useOcclusionCulling(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.useOcclusionCulling = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_layerCullDistances(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.layerCullDistances = (float[])translator.GetObject(L, 2, typeof(float[]));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_layerCullSpherical(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.layerCullSpherical = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_depthTextureMode(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                UnityEngine.DepthTextureMode __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.depthTextureMode = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_clearStencilAfterLightingPass(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Camera __cl_gen_to_be_invoked = (UnityEngine.Camera)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.clearStencilAfterLightingPass = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onPreCull(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    UnityEngine.Camera.onPreCull = translator.GetDelegate<UnityEngine.Camera.CameraCallback>(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onPreRender(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    UnityEngine.Camera.onPreRender = translator.GetDelegate<UnityEngine.Camera.CameraCallback>(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onPostRender(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    UnityEngine.Camera.onPostRender = translator.GetDelegate<UnityEngine.Camera.CameraCallback>(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
