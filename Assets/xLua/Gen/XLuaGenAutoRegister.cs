#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using System;
using System.Collections.Generic;
using System.Reflection;


namespace XLua.CSObjectWrap
{
    public class XLua_Gen_Initer_Register__
	{
	    static XLua_Gen_Initer_Register__()
        {
		    XLua.LuaEnv.AddIniter((luaenv, translator) => {
			    
				translator.DelayWrapLoader(typeof(KEngine.UI.UIModule), KEngineUIUIModuleWrap.__Register);
				
				translator.DelayWrapLoader(typeof(KEngineExtensions), KEngineExtensionsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(KBehaviour), KBehaviourWrap.__Register);
				
				translator.DelayWrapLoader(typeof(KEngine.Log), KEngineLogWrap.__Register);
				
				translator.DelayWrapLoader(typeof(KEngine.KTool), KEngineKToolWrap.__Register);
				
				translator.DelayWrapLoader(typeof(KEngine.KAsync), KEngineKAsyncWrap.__Register);
				
				translator.DelayWrapLoader(typeof(KEngine.CCoroutineState), KEngineCCoroutineStateWrap.__Register);
				
				translator.DelayWrapLoader(typeof(KSFramework.LuaUIController), KSFrameworkLuaUIControllerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(KEngine.AssetFileLoader), KEngineAssetFileLoaderWrap.__Register);
				
				translator.DelayWrapLoader(typeof(KEngine.StaticAssetLoader), KEngineStaticAssetLoaderWrap.__Register);
				
				translator.DelayWrapLoader(typeof(KEngine.SpriteLoader), KEngineSpriteLoaderWrap.__Register);
				
				translator.DelayWrapLoader(typeof(KEngine.InstanceAssetLoader), KEngineInstanceAssetLoaderWrap.__Register);
				
				translator.DelayWrapLoader(typeof(KEngine.AssetBundleLoader), KEngineAssetBundleLoaderWrap.__Register);
				
				translator.DelayWrapLoader(typeof(KEngine.SceneLoader), KEngineSceneLoaderWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AssetBundle), UnityEngineAssetBundleWrap.__Register);
				
				translator.DelayWrapLoader(typeof(KSFramework.Cookie), KSFrameworkCookieWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Physics), UnityEnginePhysicsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Profiler), UnityEngineProfilerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Vector2), UnityEngineVector2Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Vector3), UnityEngineVector3Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Quaternion), UnityEngineQuaternionWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Color), UnityEngineColorWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.LayerMask), UnityEngineLayerMaskWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Rect), UnityEngineRectWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.KeyCode), UnityEngineKeyCodeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Debug), UnityEngineDebugWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.RuntimePlatform), UnityEngineRuntimePlatformWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.FogMode), UnityEngineFogModeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.LightmapsMode), UnityEngineLightmapsModeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.EventSystem), UnityEngineEventSystemsEventSystemWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.RectTransformUtility), UnityEngineRectTransformUtilityWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.Graphic), UnityEngineUIGraphicWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Component), UnityEngineComponentWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AnimatorStateInfo), UnityEngineAnimatorStateInfoWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.QualitySettings), UnityEngineQualitySettingsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Object), UnityEngineObjectWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Application), UnityEngineApplicationWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.GameObject), UnityEngineGameObjectWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Transform), UnityEngineTransformWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.RectTransform), UnityEngineRectTransformWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Time), UnityEngineTimeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.WWW), UnityEngineWWWWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Rigidbody), UnityEngineRigidbodyWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.CharacterController), UnityEngineCharacterControllerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.PlayerPrefs), UnityEnginePlayerPrefsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.GUIText), UnityEngineGUITextWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Input), UnityEngineInputWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Renderer), UnityEngineRendererWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Camera), UnityEngineCameraWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Screen), UnityEngineScreenWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AnimationClip), UnityEngineAnimationClipWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AnimatorCullingMode), UnityEngineAnimatorCullingModeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.RuntimeAnimatorController), UnityEngineRuntimeAnimatorControllerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Animator), UnityEngineAnimatorWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.NavMeshAgent), UnityEngineNavMeshAgentWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.NavMeshPath), UnityEngineNavMeshPathWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.NavMesh), UnityEngineNavMeshWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.RaycastHit), UnityEngineRaycastHitWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Resources), UnityEngineResourcesWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Mesh), UnityEngineMeshWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.SkinnedMeshRenderer), UnityEngineSkinnedMeshRendererWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.RenderTexture), UnityEngineRenderTextureWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.RenderTextureFormat), UnityEngineRenderTextureFormatWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.RenderTextureReadWrite), UnityEngineRenderTextureReadWriteWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Shader), UnityEngineShaderWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Collider), UnityEngineColliderWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.SphereCollider), UnityEngineSphereColliderWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem), UnityEngineParticleSystemWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.RenderSettings), UnityEngineRenderSettingsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.MeshFilter), UnityEngineMeshFilterWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Material), UnityEngineMaterialWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.SpriteRenderer), UnityEngineSpriteRendererWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.SystemInfo), UnityEngineSystemInfoWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.SceneManagement.SceneManager), UnityEngineSceneManagementSceneManagerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.SceneManagement.Scene), UnityEngineSceneManagementSceneWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Events.UnityEventBase), UnityEngineEventsUnityEventBaseWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Mathf), UnityEngineMathfWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.StaticBatchingUtility), UnityEngineStaticBatchingUtilityWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.LightmapSettings), UnityEngineLightmapSettingsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AudioSource), UnityEngineAudioSourceWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.Text), UnityEngineUITextWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.CanvasGroup), UnityEngineCanvasGroupWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Canvas), UnityEngineCanvasWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.Button), UnityEngineUIButtonWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.Toggle), UnityEngineUIToggleWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Sprite), UnityEngineSpriteWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.Slider), UnityEngineUISliderWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.Image), UnityEngineUIImageWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.RawImage), UnityEngineUIRawImageWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.Dropdown), UnityEngineUIDropdownWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.LayoutUtility), UnityEngineUILayoutUtilityWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.LayoutElement), UnityEngineUILayoutElementWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.LayoutRebuilder), UnityEngineUILayoutRebuilderWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.VerticalLayoutGroup), UnityEngineUIVerticalLayoutGroupWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.GUIUtility), UnityEngineGUIUtilityWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.CollisionFlags), UnityEngineCollisionFlagsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.MaskableGraphic), UnityEngineUIMaskableGraphicWrap.__Register);
				
				translator.DelayWrapLoader(typeof(KSFramework.LuaModule), KSFrameworkLuaModuleWrap.__Register);
				
				
				translator.AddInterfaceBridgeCreator(typeof(System.Collections.IEnumerator), SystemCollectionsIEnumeratorBridge.__Create);
				
			});
		}
		
		
	}
	
}
namespace XLua
{
	public partial class ObjectTranslator
	{
		static XLua.CSObjectWrap.XLua_Gen_Initer_Register__ s_gen_reg_dumb_obj = new XLua.CSObjectWrap.XLua_Gen_Initer_Register__();
		static XLua.CSObjectWrap.XLua_Gen_Initer_Register__ gen_reg_dumb_obj {get{return s_gen_reg_dumb_obj;}}
	}
	
	public static partial class Utils
    {
	    
		delegate void __GEN_DELEGATE0( UnityEngine.RectTransform rectTrans,  float width);
		
		delegate void __GEN_DELEGATE1( UnityEngine.RectTransform rectTrans,  float height);
		
		delegate void __GEN_DELEGATE2( UnityEngine.Transform t,  float newX);
		
		delegate void __GEN_DELEGATE3( UnityEngine.Transform t,  float newY);
		
		delegate void __GEN_DELEGATE4( UnityEngine.Transform t,  float newX);
		
		delegate void __GEN_DELEGATE5( UnityEngine.Transform t,  float newY);
		
		delegate void __GEN_DELEGATE6( UnityEngine.Transform t,  float newZ);
		
		delegate void __GEN_DELEGATE7( UnityEngine.Transform t,  float newZ);
		
		delegate void __GEN_DELEGATE8( UnityEngine.Transform t,  UnityEngine.Vector3 newScale);
		
		delegate void __GEN_DELEGATE9( UnityEngine.Transform t);
		
		delegate float __GEN_DELEGATE10( UnityEngine.Transform t);
		
		delegate float __GEN_DELEGATE11( UnityEngine.Transform t);
		
		delegate float __GEN_DELEGATE12( UnityEngine.Transform t);
		
		delegate float __GEN_DELEGATE13( UnityEngine.Transform t);
		
		delegate float __GEN_DELEGATE14( UnityEngine.Transform t);
		
		delegate float __GEN_DELEGATE15( UnityEngine.Transform t);
		
		delegate bool __GEN_DELEGATE16( UnityEngine.GameObject gobj);
		
		delegate bool __GEN_DELEGATE17( UnityEngine.GameObject gobj);
		
		delegate void __GEN_DELEGATE18( UnityEngine.Animation anim,  float newSpeed);
		
		delegate UnityEngine.Vector2 __GEN_DELEGATE19( UnityEngine.Vector3 vec);
		
		delegate byte __GEN_DELEGATE20( string val);
		
		delegate int __GEN_DELEGATE21( string val);
		
		delegate long __GEN_DELEGATE22( string val);
		
		delegate float __GEN_DELEGATE23( string val);
		
	    static Utils()
		{
		    extension_method_map = new Dictionary<Type, IEnumerable<MethodInfo>>()
			{
			    
				{typeof(UnityEngine.RectTransform), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE0(KEngineExtensions.SetWidth).Method,
				
				  new __GEN_DELEGATE1(KEngineExtensions.SetHeight).Method,
				
				}},
				
				{typeof(UnityEngine.Transform), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE2(KEngineExtensions.SetPositionX).Method,
				
				  new __GEN_DELEGATE3(KEngineExtensions.SetPositionY).Method,
				
				  new __GEN_DELEGATE4(KEngineExtensions.SetLocalPositionX).Method,
				
				  new __GEN_DELEGATE5(KEngineExtensions.SetLocalPositionY).Method,
				
				  new __GEN_DELEGATE6(KEngineExtensions.SetPositionZ).Method,
				
				  new __GEN_DELEGATE7(KEngineExtensions.SetLocalPositionZ).Method,
				
				  new __GEN_DELEGATE8(KEngineExtensions.SetLocalScale).Method,
				
				  new __GEN_DELEGATE9(KEngineExtensions.SetLocalScaleZero).Method,
				
				  new __GEN_DELEGATE10(KEngineExtensions.GetPositionX).Method,
				
				  new __GEN_DELEGATE11(KEngineExtensions.GetPositionY).Method,
				
				  new __GEN_DELEGATE12(KEngineExtensions.GetPositionZ).Method,
				
				  new __GEN_DELEGATE13(KEngineExtensions.GetLocalPositionX).Method,
				
				  new __GEN_DELEGATE14(KEngineExtensions.GetLocalPositionY).Method,
				
				  new __GEN_DELEGATE15(KEngineExtensions.GetLocalPositionZ).Method,
				
				}},
				
				{typeof(UnityEngine.GameObject), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE16(KEngineExtensions.HasRigidbody).Method,
				
				  new __GEN_DELEGATE17(KEngineExtensions.HasAnimation).Method,
				
				}},
				
				{typeof(UnityEngine.Animation), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE18(KEngineExtensions.SetSpeed).Method,
				
				}},
				
				{typeof(UnityEngine.Vector3), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE19(KEngineExtensions.ToVector2).Method,
				
				}},
				
				{typeof(string), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE20(KEngineExtensions.ToByte).Method,
				
				  new __GEN_DELEGATE21(KEngineExtensions.ToInt32).Method,
				
				  new __GEN_DELEGATE22(KEngineExtensions.ToInt64).Method,
				
				  new __GEN_DELEGATE23(KEngineExtensions.ToFloat).Method,
				
				}},
				
			};
		}
	}
}
