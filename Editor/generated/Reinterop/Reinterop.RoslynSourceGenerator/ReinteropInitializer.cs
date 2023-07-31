#if UNITY_EDITOR_OSX
using System;
using System.Runtime.InteropServices;

namespace Reinterop
{
    internal class ReinteropInitializer
    {
        public static void Initialize()
        {
            // This does nothing, but ensures the static constructor is
            // called exactly once.
        }

        // This function must be separate and occur before the static constructor.
        // See https://github.com/CesiumGS/cesium-unity/issues/227
        private static void AddFunctionPointers(IntPtr memory)
        {
            unsafe
            {
                Marshal.WriteIntPtr(memory, 0 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_AssetTroubleshootingDetails_Property_get_assetExistsInUserAccountDelegate));
                Marshal.WriteIntPtr(memory, 1 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_AssetTroubleshootingDetails_Property_get_loadedDelegate));
                Marshal.WriteIntPtr(memory, 2 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_AssetTroubleshootingDetails_Property_set_assetExistsInUserAccountDelegate));
                Marshal.WriteIntPtr(memory, 3 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_AssetTroubleshootingDetails_Property_set_loadedDelegate));
                Marshal.WriteIntPtr(memory, 4 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_Cesium3DTileset_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgDelegate));
                Marshal.WriteIntPtr(memory, 5 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_Cesium3DTileset_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgDelegate));
                Marshal.WriteIntPtr(memory, 6 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_Cesium3DTileset_CallRecreateTileset_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 7 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_Cesium3DTileset_Property_get_gameObjectDelegate));
                Marshal.WriteIntPtr(memory, 8 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_Cesium3DTileset_Property_get_ionAccessTokenDelegate));
                Marshal.WriteIntPtr(memory, 9 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_Cesium3DTileset_Property_get_ionAssetIDDelegate));
                Marshal.WriteIntPtr(memory, 10 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_Cesium3DTileset_Property_get_tilesetSourceDelegate));
                Marshal.WriteIntPtr(memory, 11 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_Cesium3DTileset_Property_set_ionAccessTokenDelegate));
                Marshal.WriteIntPtr(memory, 12 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_Cesium3DTileset_Property_set_ionAssetIDDelegate));
                Marshal.WriteIntPtr(memory, 13 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_Cesium3DTileset_Property_set_tilesetSourceDelegate));
                Marshal.WriteIntPtr(memory, 14 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumEditorUtility_CallAddBaseOverlayToTileset_GE91HI1OIybUlB1E__yYJCQDelegate));
                Marshal.WriteIntPtr(memory, 15 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumEditorUtility_CallCreateTileset_jsvXjE1xIXP0dz0Yem4NagDelegate));
                Marshal.WriteIntPtr(memory, 16 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumEditorUtility_CallFindFirstTileset_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 17 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumEditorUtility_CallFindFirstTilesetWithAssetID_OUsZiF60__hSy6sWtVPSwsADelegate));
                Marshal.WriteIntPtr(memory, 18 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumEditorWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 19 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumEditorWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgDelegate));
                Marshal.WriteIntPtr(memory, 20 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumEditorWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgDelegate));
                Marshal.WriteIntPtr(memory, 21 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumEditorWindow_Field_get_currentWindowDelegate));
                Marshal.WriteIntPtr(memory, 22 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumEditorWindow_Field_set_currentWindowDelegate));
                Marshal.WriteIntPtr(memory, 23 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumEditorWindow_Property_get_NativeImplementationDelegate));
                Marshal.WriteIntPtr(memory, 24 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumIonAsset_CallIsNull_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 25 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumIonAsset_Property_get_componentTypeDelegate));
                Marshal.WriteIntPtr(memory, 26 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumIonAsset_Property_get_ionAccessTokenDelegate));
                Marshal.WriteIntPtr(memory, 27 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumIonAsset_Property_get_ionAssetIDDelegate));
                Marshal.WriteIntPtr(memory, 28 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumIonAsset_Property_get_objectNameDelegate));
                Marshal.WriteIntPtr(memory, 29 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumIonAsset_Property_get_typeDelegate));
                Marshal.WriteIntPtr(memory, 30 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumIonAsset_Property_set_ionAccessTokenDelegate));
                Marshal.WriteIntPtr(memory, 31 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumIonRasterOverlay_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgDelegate));
                Marshal.WriteIntPtr(memory, 32 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumIonRasterOverlay_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgDelegate));
                Marshal.WriteIntPtr(memory, 33 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumIonRasterOverlay_CallRefresh_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 34 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumIonRasterOverlay_Property_get_gameObjectDelegate));
                Marshal.WriteIntPtr(memory, 35 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumIonRasterOverlay_Property_get_ionAccessTokenDelegate));
                Marshal.WriteIntPtr(memory, 36 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumIonRasterOverlay_Property_get_ionAssetIDDelegate));
                Marshal.WriteIntPtr(memory, 37 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumIonRasterOverlay_Property_set_ionAccessTokenDelegate));
                Marshal.WriteIntPtr(memory, 38 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumIonRasterOverlay_Property_set_ionAssetIDDelegate));
                Marshal.WriteIntPtr(memory, 39 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumIonSession_CallBroadcastAssetsUpdate_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 40 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumIonSession_CallBroadcastConnectionUpdate_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 41 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumIonSession_CallBroadcastProfileUpdate_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 42 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumIonSession_CallBroadcastTokensUpdate_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 43 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumIonSession_CallIon_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 44 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumIonSession_CallIsConnected_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 45 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumIonSession_Property_get_NativeImplementationDelegate));
                Marshal.WriteIntPtr(memory, 46 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumRasterOverlay_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgDelegate));
                Marshal.WriteIntPtr(memory, 47 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumRasterOverlay_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgDelegate));
                Marshal.WriteIntPtr(memory, 48 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumRasterOverlay_CallRefresh_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 49 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumRasterOverlay_Property_get_gameObjectDelegate));
                Marshal.WriteIntPtr(memory, 50 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumRuntimeSettings_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgDelegate));
                Marshal.WriteIntPtr(memory, 51 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumRuntimeSettings_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgDelegate));
                Marshal.WriteIntPtr(memory, 52 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumRuntimeSettings_Property_get_defaultIonAccessTokenDelegate));
                Marshal.WriteIntPtr(memory, 53 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumRuntimeSettings_Property_get_defaultIonAccessTokenIDDelegate));
                Marshal.WriteIntPtr(memory, 54 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumRuntimeSettings_Property_set_defaultIonAccessTokenDelegate));
                Marshal.WriteIntPtr(memory, 55 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumRuntimeSettings_Property_set_defaultIonAccessTokenIDDelegate));
                Marshal.WriteIntPtr(memory, 56 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_Helpers_CallToString__8pn__Nas4aiRxhf1NkpeKgDelegate));
                Marshal.WriteIntPtr(memory, 57 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_IonAssetDetails_CallFormatDate_Wg__UxSmEJUgHx3kyfccFEwDelegate));
                Marshal.WriteIntPtr(memory, 58 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_IonAssetDetails_CallFormatType_3GczHehc_XCRt9ReXGSrdQDelegate));
                Marshal.WriteIntPtr(memory, 59 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_IonAssetsTreeView_CallReload_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 60 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_IonAssetsTreeView_Construct_bk3kO2aTAFaE0GWD9sxbigDelegate));
                Marshal.WriteIntPtr(memory, 61 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_IonAssetsTreeView_Property_get_multiColumnHeaderDelegate));
                Marshal.WriteIntPtr(memory, 62 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_IonAssetsTreeView_Property_get_NativeImplementationDelegate));
                Marshal.WriteIntPtr(memory, 63 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_IonAssetsTreeView_Property_get_searchStringDelegate));
                Marshal.WriteIntPtr(memory, 64 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_IonAssetsTreeView_Property_set_multiColumnHeaderDelegate));
                Marshal.WriteIntPtr(memory, 65 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_IonAssetsTreeView_Property_set_searchStringDelegate));
                Marshal.WriteIntPtr(memory, 66 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_IonMissingAssetWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 67 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_IonMissingAssetWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgDelegate));
                Marshal.WriteIntPtr(memory, 68 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_IonMissingAssetWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgDelegate));
                Marshal.WriteIntPtr(memory, 69 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_IonMissingAssetWindow_CallShowWindow_zCuaF57FLiXZD1__wksXLdQDelegate));
                Marshal.WriteIntPtr(memory, 70 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_IonTokenTroubleshootingWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 71 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_IonTokenTroubleshootingWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgDelegate));
                Marshal.WriteIntPtr(memory, 72 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_IonTokenTroubleshootingWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgDelegate));
                Marshal.WriteIntPtr(memory, 73 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_IonTokenTroubleshootingWindow_CallUseDefaultToken_qpX7eE7SvOg4KIeidX7yngDelegate));
                Marshal.WriteIntPtr(memory, 74 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_assetDetailsDelegate));
                Marshal.WriteIntPtr(memory, 75 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_assetTokenDetailsDelegate));
                Marshal.WriteIntPtr(memory, 76 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_defaultTokenDetailsDelegate));
                Marshal.WriteIntPtr(memory, 77 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_ionAssetDelegate));
                Marshal.WriteIntPtr(memory, 78 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_IonTokenTroubleshootingWindow_Property_set_ionAssetDelegate));
                Marshal.WriteIntPtr(memory, 79 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_NativeDownloadHandler_CallDispose_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 80 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_NativeDownloadHandler_Construct_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 81 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_NativeDownloadHandler_Property_get_NativeImplementationDelegate));
                Marshal.WriteIntPtr(memory, 82 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_SelectIonTokenWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 83 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_SelectIonTokenWindow_CallGetDefaultNewTokenName_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 84 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_SelectIonTokenWindow_CallGetExistingTokenList_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 85 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_SelectIonTokenWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgDelegate));
                Marshal.WriteIntPtr(memory, 86 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_SelectIonTokenWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgDelegate));
                Marshal.WriteIntPtr(memory, 87 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_SelectIonTokenWindow_CallRefreshExistingTokenList_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 88 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_SelectIonTokenWindow_CallShowWindow_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 89 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_SelectIonTokenWindow_Field_get_currentWindowDelegate));
                Marshal.WriteIntPtr(memory, 90 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_SelectIonTokenWindow_Field_set_currentWindowDelegate));
                Marshal.WriteIntPtr(memory, 91 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_SelectIonTokenWindow_Property_get_createdTokenNameDelegate));
                Marshal.WriteIntPtr(memory, 92 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_SelectIonTokenWindow_Property_get_NativeImplementationDelegate));
                Marshal.WriteIntPtr(memory, 93 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_SelectIonTokenWindow_Property_get_selectedExistingTokenIndexDelegate));
                Marshal.WriteIntPtr(memory, 94 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_SelectIonTokenWindow_Property_get_specifiedTokenDelegate));
                Marshal.WriteIntPtr(memory, 95 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_SelectIonTokenWindow_Property_get_tokenSourceDelegate));
                Marshal.WriteIntPtr(memory, 96 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_SelectIonTokenWindow_Property_set_createdTokenNameDelegate));
                Marshal.WriteIntPtr(memory, 97 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_SelectIonTokenWindow_Property_set_selectedExistingTokenIndexDelegate));
                Marshal.WriteIntPtr(memory, 98 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_SelectIonTokenWindow_Property_set_specifiedTokenDelegate));
                Marshal.WriteIntPtr(memory, 99 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_SelectIonTokenWindow_Property_set_tokenSourceDelegate));
                Marshal.WriteIntPtr(memory, 100 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_TokenTroubleshootingDetails_Property_get_allowsAccessToAssetDelegate));
                Marshal.WriteIntPtr(memory, 101 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_TokenTroubleshootingDetails_Property_get_associatedWithUserAccountDelegate));
                Marshal.WriteIntPtr(memory, 102 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_TokenTroubleshootingDetails_Property_get_isValidDelegate));
                Marshal.WriteIntPtr(memory, 103 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_TokenTroubleshootingDetails_Property_get_loadedDelegate));
                Marshal.WriteIntPtr(memory, 104 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_TokenTroubleshootingDetails_Property_get_tokenDelegate));
                Marshal.WriteIntPtr(memory, 105 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_TokenTroubleshootingDetails_Property_set_allowsAccessToAssetDelegate));
                Marshal.WriteIntPtr(memory, 106 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_TokenTroubleshootingDetails_Property_set_associatedWithUserAccountDelegate));
                Marshal.WriteIntPtr(memory, 107 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_TokenTroubleshootingDetails_Property_set_isValidDelegate));
                Marshal.WriteIntPtr(memory, 108 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_TokenTroubleshootingDetails_Property_set_loadedDelegate));
                Marshal.WriteIntPtr(memory, 109 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_TokenTroubleshootingDetails_Property_set_tokenDelegate));
                Marshal.WriteIntPtr(memory, 110 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(Reinterop_ObjectHandleUtility_CallCopyHandle_Lk0gUmdC13dRVZ_MAT71egDelegate));
                Marshal.WriteIntPtr(memory, 111 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(Reinterop_ObjectHandleUtility_CallCreateHandle_vjOnn8y5DjvqKs3467vAJQDelegate));
                Marshal.WriteIntPtr(memory, 112 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(Reinterop_ObjectHandleUtility_CallFreeHandle_Lk0gUmdC13dRVZ_MAT71egDelegate));
                Marshal.WriteIntPtr(memory, 113 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_Action_CallInvoke_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 114 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_Action_Callop_Equality__iYzpyUo7S__gDd8L5jFzrgDelegate));
                Marshal.WriteIntPtr(memory, 115 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_Action_Callop_Equality_a0RmOPC1vpOfulhhfnafBADelegate));
                Marshal.WriteIntPtr(memory, 116 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_Action_Callop_Inequality__iYzpyUo7S__gDd8L5jFzrgDelegate));
                Marshal.WriteIntPtr(memory, 117 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_Action_Callop_Inequality_a0RmOPC1vpOfulhhfnafBADelegate));
                Marshal.WriteIntPtr(memory, 118 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_Action_CombineDelegatesDelegate));
                Marshal.WriteIntPtr(memory, 119 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_Action_CreateDelegateDelegate));
                Marshal.WriteIntPtr(memory, 120 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_Action_RemoveDelegateDelegate));
                Marshal.WriteIntPtr(memory, 121 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_ActionA2lFbwI_1jdffaYu1u_OZg_CallInvoke_GZtSECpzDV__dvLP8ujKEdADelegate));
                Marshal.WriteIntPtr(memory, 122 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Equality__iYzpyUo7S__gDd8L5jFzrgDelegate));
                Marshal.WriteIntPtr(memory, 123 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Equality_a0RmOPC1vpOfulhhfnafBADelegate));
                Marshal.WriteIntPtr(memory, 124 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Inequality__iYzpyUo7S__gDd8L5jFzrgDelegate));
                Marshal.WriteIntPtr(memory, 125 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Inequality_a0RmOPC1vpOfulhhfnafBADelegate));
                Marshal.WriteIntPtr(memory, 126 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_ActionA2lFbwI_1jdffaYu1u_OZg_CombineDelegatesDelegate));
                Marshal.WriteIntPtr(memory, 127 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_ActionA2lFbwI_1jdffaYu1u_OZg_CreateDelegateDelegate));
                Marshal.WriteIntPtr(memory, 128 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_ActionA2lFbwI_1jdffaYu1u_OZg_RemoveDelegateDelegate));
                Marshal.WriteIntPtr(memory, 129 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_Array_Property_get_LengthDelegate));
                Marshal.WriteIntPtr(memory, 130 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_Constructor_SizeDelegate));
                Marshal.WriteIntPtr(memory, 131 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_Property_get_ItemDelegate));
                Marshal.WriteIntPtr(memory, 132 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_Property_get_LengthDelegate));
                Marshal.WriteIntPtr(memory, 133 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_SetItemDelegate));
                Marshal.WriteIntPtr(memory, 134 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_Constructor_SizeDelegate));
                Marshal.WriteIntPtr(memory, 135 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_Property_get_ItemDelegate));
                Marshal.WriteIntPtr(memory, 136 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_Property_get_LengthDelegate));
                Marshal.WriteIntPtr(memory, 137 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_SetItemDelegate));
                Marshal.WriteIntPtr(memory, 138 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_Constructor_SizeDelegate));
                Marshal.WriteIntPtr(memory, 139 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_Property_get_ItemDelegate));
                Marshal.WriteIntPtr(memory, 140 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_Property_get_LengthDelegate));
                Marshal.WriteIntPtr(memory, 141 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_SetItemDelegate));
                Marshal.WriteIntPtr(memory, 142 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_Array1z79ECk55IqLfMIqXBYg_8w_Constructor_SizeDelegate));
                Marshal.WriteIntPtr(memory, 143 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_Array1z79ECk55IqLfMIqXBYg_8w_Property_get_LengthDelegate));
                Marshal.WriteIntPtr(memory, 144 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_Array1z79ECk55IqLfMIqXBYg_8w_SetItemDelegate));
                Marshal.WriteIntPtr(memory, 145 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_Collections_Generic_Dictionary5Hx6c0Eu2sl__zevLSSpjKA_CallGetEnumerator_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 146 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_Collections_Generic_Enumerator1B2M2Y8AsgTpgAmY7PhCfg_CallMoveNext_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 147 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_Collections_Generic_Enumerator1B2M2Y8AsgTpgAmY7PhCfg_Property_get_CurrentDelegate));
                Marshal.WriteIntPtr(memory, 148 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_Collections_Generic_KeyValuePair5Hx6c0Eu2sl__zevLSSpjKA_Property_get_KeyDelegate));
                Marshal.WriteIntPtr(memory, 149 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_Collections_Generic_KeyValuePair5Hx6c0Eu2sl__zevLSSpjKA_Property_get_ValueDelegate));
                Marshal.WriteIntPtr(memory, 150 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_Collections_Generic_List5eSlqDLksZG1Mz9C9wH0GQ_CallAdd_LRSjiXmrvb5pgfbcZ_Nv7wDelegate));
                Marshal.WriteIntPtr(memory, 151 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_Collections_Generic_List5eSlqDLksZG1Mz9C9wH0GQ_CallClear_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 152 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_Delegate_Callop_Equality_a0RmOPC1vpOfulhhfnafBADelegate));
                Marshal.WriteIntPtr(memory, 153 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_Delegate_Callop_Inequality_a0RmOPC1vpOfulhhfnafBADelegate));
                Marshal.WriteIntPtr(memory, 154 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_Environment_Property_get_OSVersionDelegate));
                Marshal.WriteIntPtr(memory, 155 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_MulticastDelegate_Callop_Equality__iYzpyUo7S__gDd8L5jFzrgDelegate));
                Marshal.WriteIntPtr(memory, 156 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_MulticastDelegate_Callop_Equality_a0RmOPC1vpOfulhhfnafBADelegate));
                Marshal.WriteIntPtr(memory, 157 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_MulticastDelegate_Callop_Inequality__iYzpyUo7S__gDd8L5jFzrgDelegate));
                Marshal.WriteIntPtr(memory, 158 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_MulticastDelegate_Callop_Inequality_a0RmOPC1vpOfulhhfnafBADelegate));
                Marshal.WriteIntPtr(memory, 159 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_Object_Construct_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 160 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_OperatingSystem_Property_get_VersionStringDelegate));
                Marshal.WriteIntPtr(memory, 161 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_Runtime_InteropServices_Marshal_CallFreeCoTaskMem_eF5IwSJe_WM3IuDxcegQFgDelegate));
                Marshal.WriteIntPtr(memory, 162 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_Runtime_InteropServices_Marshal_CallStringToCoTaskMemUTF8_ga80EVd9gqZ4YlhSP8iRzgDelegate));
                Marshal.WriteIntPtr(memory, 163 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_String_CallConcat_OM9SoWVFMTHXvbepMyUchwDelegate));
                Marshal.WriteIntPtr(memory, 164 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_String_CallConcat_yq7nlytzIFp8a79slfH_mwDelegate));
                Marshal.WriteIntPtr(memory, 165 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_String_CallContains_GImL1A5rlEQAx14EidO2oADelegate));
                Marshal.WriteIntPtr(memory, 166 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_String_CallEquals_46DLRq__QwpwCx8Uf20Cl7ADelegate));
                Marshal.WriteIntPtr(memory, 167 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_String_CallIsNullOrEmpty_ZOWEGUlscki07yVzH4i4wwDelegate));
                Marshal.WriteIntPtr(memory, 168 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_String_Callop_Equality_46DLRq__QwpwCx8Uf20Cl7ADelegate));
                Marshal.WriteIntPtr(memory, 169 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_String_Callop_Inequality_46DLRq__QwpwCx8Uf20Cl7ADelegate));
                Marshal.WriteIntPtr(memory, 170 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_String_Property_get_LengthDelegate));
                Marshal.WriteIntPtr(memory, 171 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_Text_Encoding_CallGetString_J_gIxYGOW0ecDuybXJZsCwDelegate));
                Marshal.WriteIntPtr(memory, 172 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_Text_Encoding_Property_get_UTF8Delegate));
                Marshal.WriteIntPtr(memory, 173 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_Threading_Tasks_Task_CallRun_uG3jiSYLEmrwe0pJoPtxoADelegate));
                Marshal.WriteIntPtr(memory, 174 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(Unity_Collections_LowLevel_Unsafe_NativeArrayUnsafeUtility_CallGetUnsafeBufferPointerWithoutChecks_QIjAavb5O6M1Tim2Rs2ohQDelegate));
                Marshal.WriteIntPtr(memory, 175 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(Unity_Collections_NativeArrayz79ECk55IqLfMIqXBYg_8w_Callop_Equality___ZFbUbDYmnqRGnwegIjKPwDelegate));
                Marshal.WriteIntPtr(memory, 176 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(Unity_Collections_NativeArrayz79ECk55IqLfMIqXBYg_8w_Callop_Inequality___ZFbUbDYmnqRGnwegIjKPwDelegate));
                Marshal.WriteIntPtr(memory, 177 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(Unity_Collections_NativeArrayz79ECk55IqLfMIqXBYg_8w_Construct_fyLz0cEPCtnsPNSt__omZwQDelegate));
                Marshal.WriteIntPtr(memory, 178 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEditor_EditorApplication_CallExecuteMenuItem__mTAWffFaNJNxtE3VLYhxwDelegate));
                Marshal.WriteIntPtr(memory, 179 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEditor_EditorPrefs_CallDeleteKey_4Oa4KGDR__vvaosUsC29xLgDelegate));
                Marshal.WriteIntPtr(memory, 180 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEditor_EditorPrefs_CallGetString_4Oa4KGDR__vvaosUsC29xLgDelegate));
                Marshal.WriteIntPtr(memory, 181 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEditor_EditorPrefs_CallHasKey_4Oa4KGDR__vvaosUsC29xLgDelegate));
                Marshal.WriteIntPtr(memory, 182 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEditor_EditorPrefs_CallSetString_eMSjpsyKrCDpoy__674QaewDelegate));
                Marshal.WriteIntPtr(memory, 183 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEditor_EditorWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 184 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEditor_EditorWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgDelegate));
                Marshal.WriteIntPtr(memory, 185 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEditor_EditorWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgDelegate));
                Marshal.WriteIntPtr(memory, 186 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEditor_IMGUI_Controls_MultiColumnHeader_CallIsSortedAscending_ZiJhFqE0LPDoV__RgQlNVpQDelegate));
                Marshal.WriteIntPtr(memory, 187 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEditor_IMGUI_Controls_MultiColumnHeader_Property_get_sortedColumnIndexDelegate));
                Marshal.WriteIntPtr(memory, 188 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEditor_IMGUI_Controls_MultiColumnHeader_Property_set_sortedColumnIndexDelegate));
                Marshal.WriteIntPtr(memory, 189 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEditor_IMGUI_Controls_TreeView_CallReload_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 190 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEditor_IMGUI_Controls_TreeView_Property_get_multiColumnHeaderDelegate));
                Marshal.WriteIntPtr(memory, 191 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEditor_IMGUI_Controls_TreeView_Property_get_searchStringDelegate));
                Marshal.WriteIntPtr(memory, 192 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEditor_IMGUI_Controls_TreeView_Property_set_multiColumnHeaderDelegate));
                Marshal.WriteIntPtr(memory, 193 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEditor_IMGUI_Controls_TreeView_Property_set_searchStringDelegate));
                Marshal.WriteIntPtr(memory, 194 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEditor_IMGUI_Controls_TreeViewItem_Construct_fAkE2H7EjTzReHiM2XHBPADelegate));
                Marshal.WriteIntPtr(memory, 195 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEditor_IMGUI_Controls_TreeViewItem_Property_get_idDelegate));
                Marshal.WriteIntPtr(memory, 196 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEditor_IMGUI_Controls_TreeViewItem_Property_set_idDelegate));
                Marshal.WriteIntPtr(memory, 197 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEditor_IMGUI_Controls_TreeViewState_Construct_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 198 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEditor_Selection_Property_get_activeGameObjectDelegate));
                Marshal.WriteIntPtr(memory, 199 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEditor_Selection_Property_set_activeGameObjectDelegate));
                Marshal.WriteIntPtr(memory, 200 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Application_CallOpenURL_i4__FgVIR5VYHO4KBzPBwNQDelegate));
                Marshal.WriteIntPtr(memory, 201 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Application_Property_get_platformDelegate));
                Marshal.WriteIntPtr(memory, 202 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Application_Property_get_productNameDelegate));
                Marshal.WriteIntPtr(memory, 203 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Application_Property_get_unityVersionDelegate));
                Marshal.WriteIntPtr(memory, 204 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Application_Property_get_versionDelegate));
                Marshal.WriteIntPtr(memory, 205 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_AsyncOperation_Calladd_completed_89b__Riirtgd1Q5mmRzPojADelegate));
                Marshal.WriteIntPtr(memory, 206 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_AsyncOperation_Callremove_completed_89b__Riirtgd1Q5mmRzPojADelegate));
                Marshal.WriteIntPtr(memory, 207 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Component_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgDelegate));
                Marshal.WriteIntPtr(memory, 208 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Component_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgDelegate));
                Marshal.WriteIntPtr(memory, 209 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Component_Property_get_gameObjectDelegate));
                Marshal.WriteIntPtr(memory, 210 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Debug_CallLog_FA05wu8x__otZNsgdHTnU9ADelegate));
                Marshal.WriteIntPtr(memory, 211 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Debug_CallLogError_FA05wu8x__otZNsgdHTnU9ADelegate));
                Marshal.WriteIntPtr(memory, 212 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Debug_CallLogWarning_FA05wu8x__otZNsgdHTnU9ADelegate));
                Marshal.WriteIntPtr(memory, 213 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_GameObject_CallAddComponent_0EgxpGTzCG1YTfWqwgLniwDelegate));
                Marshal.WriteIntPtr(memory, 214 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_GameObject_CallAddComponent_BAtcoWNWVoAVplmna6OgsQDelegate));
                Marshal.WriteIntPtr(memory, 215 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_GameObject_CallGetComponent_0EgxpGTzCG1YTfWqwgLniwDelegate));
                Marshal.WriteIntPtr(memory, 216 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_GameObject_CallGetComponent_BAtcoWNWVoAVplmna6OgsQDelegate));
                Marshal.WriteIntPtr(memory, 217 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_GameObject_CallGetComponents_BAtcoWNWVoAVplmna6OgsQDelegate));
                Marshal.WriteIntPtr(memory, 218 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_GameObject_CallGetComponents_H1UZCBm__Pf6NnqpE7xQ8NQDelegate));
                Marshal.WriteIntPtr(memory, 219 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_GameObject_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgDelegate));
                Marshal.WriteIntPtr(memory, 220 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_GameObject_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgDelegate));
                Marshal.WriteIntPtr(memory, 221 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_GameObject_Construct_wfPSjxsETIcebv8un8PGZwDelegate));
                Marshal.WriteIntPtr(memory, 222 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_GUI_CallLabel_iRU7t71QqJzkr4BTYehN9ADelegate));
                Marshal.WriteIntPtr(memory, 223 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Networking_DownloadHandler_CallDispose_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 224 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Networking_UnityWebRequest_CallGet_Y2__l4HVQ8CbSg4jpXDip9ADelegate));
                Marshal.WriteIntPtr(memory, 225 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Networking_UnityWebRequest_CallGetResponseHeader_wfPSjxsETIcebv8un8PGZwDelegate));
                Marshal.WriteIntPtr(memory, 226 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Networking_UnityWebRequest_CallGetResponseHeaders_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 227 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Networking_UnityWebRequest_CallSendWebRequest_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 228 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Networking_UnityWebRequest_CallSetRequestHeader_tEfBle3aSdR47_HxLakNjwDelegate));
                Marshal.WriteIntPtr(memory, 229 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Networking_UnityWebRequest_Construct_N5nF6s7__PflIcgtgQgj6DADelegate));
                Marshal.WriteIntPtr(memory, 230 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Networking_UnityWebRequest_Property_get_downloadHandlerDelegate));
                Marshal.WriteIntPtr(memory, 231 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Networking_UnityWebRequest_Property_get_errorDelegate));
                Marshal.WriteIntPtr(memory, 232 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Networking_UnityWebRequest_Property_get_isDoneDelegate));
                Marshal.WriteIntPtr(memory, 233 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Networking_UnityWebRequest_Property_get_methodDelegate));
                Marshal.WriteIntPtr(memory, 234 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Networking_UnityWebRequest_Property_get_responseCodeDelegate));
                Marshal.WriteIntPtr(memory, 235 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Networking_UnityWebRequest_Property_get_resultDelegate));
                Marshal.WriteIntPtr(memory, 236 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Networking_UnityWebRequest_Property_get_urlDelegate));
                Marshal.WriteIntPtr(memory, 237 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Networking_UnityWebRequest_Property_set_downloadHandlerDelegate));
                Marshal.WriteIntPtr(memory, 238 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Networking_UnityWebRequest_Property_set_methodDelegate));
                Marshal.WriteIntPtr(memory, 239 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Networking_UnityWebRequest_Property_set_urlDelegate));
                Marshal.WriteIntPtr(memory, 240 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Networking_UnityWebRequestAsyncOperation_Calladd_completed_89b__Riirtgd1Q5mmRzPojADelegate));
                Marshal.WriteIntPtr(memory, 241 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Networking_UnityWebRequestAsyncOperation_Callremove_completed_89b__Riirtgd1Q5mmRzPojADelegate));
                Marshal.WriteIntPtr(memory, 242 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Networking_UploadHandlerRaw_Construct_j9VUe_obWzqxHm0yKnVCmgDelegate));
                Marshal.WriteIntPtr(memory, 243 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Networking_UploadHandlerRaw_Construct_Wn8TTeG3Q36ufSfvO3m1sgDelegate));
                Marshal.WriteIntPtr(memory, 244 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Object_CallDestroyImmediate_c5oFMRh3nzKMIo8On83YBgDelegate));
                Marshal.WriteIntPtr(memory, 245 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Object_CallDestroyImmediate_x7aQMuJcEpatC9689ghI4ADelegate));
                Marshal.WriteIntPtr(memory, 246 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Object_CallFindObjectsOfType_0EgxpGTzCG1YTfWqwgLniwDelegate));
                Marshal.WriteIntPtr(memory, 247 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Object_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgDelegate));
                Marshal.WriteIntPtr(memory, 248 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Object_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgDelegate));
                Marshal.WriteIntPtr(memory, 249 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Rect_Construct_SWzoP__nNh7g2zNwjI5mUvQDelegate));
            }
        }

        static ReinteropInitializer()
        {
            unsafe
            {
                IntPtr memory = Marshal.AllocHGlobal(sizeof(IntPtr) * 250);
                AddFunctionPointers(memory);
                byte success = initializeReinterop(9687250882888526323UL, memory, 250);
                if (success == 0)
                    throw new NotImplementedException("The native library is out of sync with the managed one.");
            }
        }

        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static extern byte initializeReinterop(ulong validationHash, IntPtr functionPointers, int count);

        // Roslyn raises CS0252 spuriously for MulticastDelegate operator==, so disable the warning
        // See https://github.com/dotnet/roslyn/issues/17212
        //     https://github.com/dotnet/roslyn/issues/58996
        #pragma warning disable 0252

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte CesiumForUnity_AssetTroubleshootingDetails_Property_get_assetExistsInUserAccountType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_AssetTroubleshootingDetails_Property_get_assetExistsInUserAccountType CesiumForUnity_AssetTroubleshootingDetails_Property_get_assetExistsInUserAccountDelegate = new CesiumForUnity_AssetTroubleshootingDetails_Property_get_assetExistsInUserAccountType(CesiumForUnity_AssetTroubleshootingDetails_Property_get_assetExistsInUserAccount);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_AssetTroubleshootingDetails_Property_get_assetExistsInUserAccountType))]
        private static unsafe byte CesiumForUnity_AssetTroubleshootingDetails_Property_get_assetExistsInUserAccount(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.AssetTroubleshootingDetails)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).assetExistsInUserAccount;
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte CesiumForUnity_AssetTroubleshootingDetails_Property_get_loadedType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_AssetTroubleshootingDetails_Property_get_loadedType CesiumForUnity_AssetTroubleshootingDetails_Property_get_loadedDelegate = new CesiumForUnity_AssetTroubleshootingDetails_Property_get_loadedType(CesiumForUnity_AssetTroubleshootingDetails_Property_get_loaded);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_AssetTroubleshootingDetails_Property_get_loadedType))]
        private static unsafe byte CesiumForUnity_AssetTroubleshootingDetails_Property_get_loaded(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.AssetTroubleshootingDetails)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).loaded;
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_AssetTroubleshootingDetails_Property_set_assetExistsInUserAccountType(System.IntPtr thiz, byte value);
        private static unsafe readonly CesiumForUnity_AssetTroubleshootingDetails_Property_set_assetExistsInUserAccountType CesiumForUnity_AssetTroubleshootingDetails_Property_set_assetExistsInUserAccountDelegate = new CesiumForUnity_AssetTroubleshootingDetails_Property_set_assetExistsInUserAccountType(CesiumForUnity_AssetTroubleshootingDetails_Property_set_assetExistsInUserAccount);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_AssetTroubleshootingDetails_Property_set_assetExistsInUserAccountType))]
        private static unsafe void CesiumForUnity_AssetTroubleshootingDetails_Property_set_assetExistsInUserAccount(System.IntPtr thiz, byte value)
        {
            ((CesiumForUnity.AssetTroubleshootingDetails)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).assetExistsInUserAccount = value != 0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_AssetTroubleshootingDetails_Property_set_loadedType(System.IntPtr thiz, byte value);
        private static unsafe readonly CesiumForUnity_AssetTroubleshootingDetails_Property_set_loadedType CesiumForUnity_AssetTroubleshootingDetails_Property_set_loadedDelegate = new CesiumForUnity_AssetTroubleshootingDetails_Property_set_loadedType(CesiumForUnity_AssetTroubleshootingDetails_Property_set_loaded);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_AssetTroubleshootingDetails_Property_set_loadedType))]
        private static unsafe void CesiumForUnity_AssetTroubleshootingDetails_Property_set_loaded(System.IntPtr thiz, byte value)
        {
            ((CesiumForUnity.AssetTroubleshootingDetails)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).loaded = value != 0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte CesiumForUnity_Cesium3DTileset_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType(System.IntPtr x, System.IntPtr y);
        private static unsafe readonly CesiumForUnity_Cesium3DTileset_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType CesiumForUnity_Cesium3DTileset_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgDelegate = new CesiumForUnity_Cesium3DTileset_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType(CesiumForUnity_Cesium3DTileset_Callop_Equality_5bi2N6jTkaYVhpHPRxL2Wg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_Cesium3DTileset_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType))]
        private static unsafe byte CesiumForUnity_Cesium3DTileset_Callop_Equality_5bi2N6jTkaYVhpHPRxL2Wg(System.IntPtr x, System.IntPtr y)
        {
            
            var result = ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(x)!) == ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(y)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte CesiumForUnity_Cesium3DTileset_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType(System.IntPtr x, System.IntPtr y);
        private static unsafe readonly CesiumForUnity_Cesium3DTileset_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType CesiumForUnity_Cesium3DTileset_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgDelegate = new CesiumForUnity_Cesium3DTileset_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType(CesiumForUnity_Cesium3DTileset_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2Wg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_Cesium3DTileset_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType))]
        private static unsafe byte CesiumForUnity_Cesium3DTileset_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2Wg(System.IntPtr x, System.IntPtr y)
        {
            
            var result = ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(x)!) != ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(y)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_Cesium3DTileset_CallRecreateTileset_1B2M2Y8AsgTpgAmY7PhCfgType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_Cesium3DTileset_CallRecreateTileset_1B2M2Y8AsgTpgAmY7PhCfgType CesiumForUnity_Cesium3DTileset_CallRecreateTileset_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new CesiumForUnity_Cesium3DTileset_CallRecreateTileset_1B2M2Y8AsgTpgAmY7PhCfgType(CesiumForUnity_Cesium3DTileset_CallRecreateTileset_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_Cesium3DTileset_CallRecreateTileset_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe void CesiumForUnity_Cesium3DTileset_CallRecreateTileset_1B2M2Y8AsgTpgAmY7PhCfg(System.IntPtr thiz)
        {
            ((CesiumForUnity.Cesium3DTileset)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).RecreateTileset();
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_Cesium3DTileset_Property_get_gameObjectType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_Cesium3DTileset_Property_get_gameObjectType CesiumForUnity_Cesium3DTileset_Property_get_gameObjectDelegate = new CesiumForUnity_Cesium3DTileset_Property_get_gameObjectType(CesiumForUnity_Cesium3DTileset_Property_get_gameObject);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_Cesium3DTileset_Property_get_gameObjectType))]
        private static unsafe System.IntPtr CesiumForUnity_Cesium3DTileset_Property_get_gameObject(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.Cesium3DTileset)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).gameObject;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_Cesium3DTileset_Property_get_ionAccessTokenType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_Cesium3DTileset_Property_get_ionAccessTokenType CesiumForUnity_Cesium3DTileset_Property_get_ionAccessTokenDelegate = new CesiumForUnity_Cesium3DTileset_Property_get_ionAccessTokenType(CesiumForUnity_Cesium3DTileset_Property_get_ionAccessToken);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_Cesium3DTileset_Property_get_ionAccessTokenType))]
        private static unsafe System.IntPtr CesiumForUnity_Cesium3DTileset_Property_get_ionAccessToken(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.Cesium3DTileset)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).ionAccessToken;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate long CesiumForUnity_Cesium3DTileset_Property_get_ionAssetIDType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_Cesium3DTileset_Property_get_ionAssetIDType CesiumForUnity_Cesium3DTileset_Property_get_ionAssetIDDelegate = new CesiumForUnity_Cesium3DTileset_Property_get_ionAssetIDType(CesiumForUnity_Cesium3DTileset_Property_get_ionAssetID);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_Cesium3DTileset_Property_get_ionAssetIDType))]
        private static unsafe long CesiumForUnity_Cesium3DTileset_Property_get_ionAssetID(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.Cesium3DTileset)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).ionAssetID;
            
            return result;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate CesiumForUnity.CesiumDataSource CesiumForUnity_Cesium3DTileset_Property_get_tilesetSourceType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_Cesium3DTileset_Property_get_tilesetSourceType CesiumForUnity_Cesium3DTileset_Property_get_tilesetSourceDelegate = new CesiumForUnity_Cesium3DTileset_Property_get_tilesetSourceType(CesiumForUnity_Cesium3DTileset_Property_get_tilesetSource);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_Cesium3DTileset_Property_get_tilesetSourceType))]
        private static unsafe CesiumForUnity.CesiumDataSource CesiumForUnity_Cesium3DTileset_Property_get_tilesetSource(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.Cesium3DTileset)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).tilesetSource;
            
            return result;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_Cesium3DTileset_Property_set_ionAccessTokenType(System.IntPtr thiz, System.IntPtr value);
        private static unsafe readonly CesiumForUnity_Cesium3DTileset_Property_set_ionAccessTokenType CesiumForUnity_Cesium3DTileset_Property_set_ionAccessTokenDelegate = new CesiumForUnity_Cesium3DTileset_Property_set_ionAccessTokenType(CesiumForUnity_Cesium3DTileset_Property_set_ionAccessToken);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_Cesium3DTileset_Property_set_ionAccessTokenType))]
        private static unsafe void CesiumForUnity_Cesium3DTileset_Property_set_ionAccessToken(System.IntPtr thiz, System.IntPtr value)
        {
            ((CesiumForUnity.Cesium3DTileset)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).ionAccessToken = (string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(value)!;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_Cesium3DTileset_Property_set_ionAssetIDType(System.IntPtr thiz, long value);
        private static unsafe readonly CesiumForUnity_Cesium3DTileset_Property_set_ionAssetIDType CesiumForUnity_Cesium3DTileset_Property_set_ionAssetIDDelegate = new CesiumForUnity_Cesium3DTileset_Property_set_ionAssetIDType(CesiumForUnity_Cesium3DTileset_Property_set_ionAssetID);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_Cesium3DTileset_Property_set_ionAssetIDType))]
        private static unsafe void CesiumForUnity_Cesium3DTileset_Property_set_ionAssetID(System.IntPtr thiz, long value)
        {
            ((CesiumForUnity.Cesium3DTileset)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).ionAssetID = value;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_Cesium3DTileset_Property_set_tilesetSourceType(System.IntPtr thiz, CesiumForUnity.CesiumDataSource value);
        private static unsafe readonly CesiumForUnity_Cesium3DTileset_Property_set_tilesetSourceType CesiumForUnity_Cesium3DTileset_Property_set_tilesetSourceDelegate = new CesiumForUnity_Cesium3DTileset_Property_set_tilesetSourceType(CesiumForUnity_Cesium3DTileset_Property_set_tilesetSource);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_Cesium3DTileset_Property_set_tilesetSourceType))]
        private static unsafe void CesiumForUnity_Cesium3DTileset_Property_set_tilesetSource(System.IntPtr thiz, CesiumForUnity.CesiumDataSource value)
        {
            ((CesiumForUnity.Cesium3DTileset)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).tilesetSource = value;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_CesiumEditorUtility_CallAddBaseOverlayToTileset_GE91HI1OIybUlB1E__yYJCQType(System.IntPtr tileset, long assetID);
        private static unsafe readonly CesiumForUnity_CesiumEditorUtility_CallAddBaseOverlayToTileset_GE91HI1OIybUlB1E__yYJCQType CesiumForUnity_CesiumEditorUtility_CallAddBaseOverlayToTileset_GE91HI1OIybUlB1E__yYJCQDelegate = new CesiumForUnity_CesiumEditorUtility_CallAddBaseOverlayToTileset_GE91HI1OIybUlB1E__yYJCQType(CesiumForUnity_CesiumEditorUtility_CallAddBaseOverlayToTileset_GE91HI1OIybUlB1E__yYJCQ);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumEditorUtility_CallAddBaseOverlayToTileset_GE91HI1OIybUlB1E__yYJCQType))]
        private static unsafe System.IntPtr CesiumForUnity_CesiumEditorUtility_CallAddBaseOverlayToTileset_GE91HI1OIybUlB1E__yYJCQ(System.IntPtr tileset, long assetID)
        {
            
            var result = CesiumForUnity.CesiumEditorUtility.AddBaseOverlayToTileset((CesiumForUnity.Cesium3DTileset)Reinterop.ObjectHandleUtility.GetObjectFromHandle(tileset)!, assetID);
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_CesiumEditorUtility_CallCreateTileset_jsvXjE1xIXP0dz0Yem4NagType(System.IntPtr name, long assetID);
        private static unsafe readonly CesiumForUnity_CesiumEditorUtility_CallCreateTileset_jsvXjE1xIXP0dz0Yem4NagType CesiumForUnity_CesiumEditorUtility_CallCreateTileset_jsvXjE1xIXP0dz0Yem4NagDelegate = new CesiumForUnity_CesiumEditorUtility_CallCreateTileset_jsvXjE1xIXP0dz0Yem4NagType(CesiumForUnity_CesiumEditorUtility_CallCreateTileset_jsvXjE1xIXP0dz0Yem4Nag);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumEditorUtility_CallCreateTileset_jsvXjE1xIXP0dz0Yem4NagType))]
        private static unsafe System.IntPtr CesiumForUnity_CesiumEditorUtility_CallCreateTileset_jsvXjE1xIXP0dz0Yem4Nag(System.IntPtr name, long assetID)
        {
            
            var result = CesiumForUnity.CesiumEditorUtility.CreateTileset((string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(name)!, assetID);
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_CesiumEditorUtility_CallFindFirstTileset_1B2M2Y8AsgTpgAmY7PhCfgType();
        private static unsafe readonly CesiumForUnity_CesiumEditorUtility_CallFindFirstTileset_1B2M2Y8AsgTpgAmY7PhCfgType CesiumForUnity_CesiumEditorUtility_CallFindFirstTileset_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new CesiumForUnity_CesiumEditorUtility_CallFindFirstTileset_1B2M2Y8AsgTpgAmY7PhCfgType(CesiumForUnity_CesiumEditorUtility_CallFindFirstTileset_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumEditorUtility_CallFindFirstTileset_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe System.IntPtr CesiumForUnity_CesiumEditorUtility_CallFindFirstTileset_1B2M2Y8AsgTpgAmY7PhCfg()
        {
            
            var result = CesiumForUnity.CesiumEditorUtility.FindFirstTileset();
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_CesiumEditorUtility_CallFindFirstTilesetWithAssetID_OUsZiF60__hSy6sWtVPSwsAType(long assetID);
        private static unsafe readonly CesiumForUnity_CesiumEditorUtility_CallFindFirstTilesetWithAssetID_OUsZiF60__hSy6sWtVPSwsAType CesiumForUnity_CesiumEditorUtility_CallFindFirstTilesetWithAssetID_OUsZiF60__hSy6sWtVPSwsADelegate = new CesiumForUnity_CesiumEditorUtility_CallFindFirstTilesetWithAssetID_OUsZiF60__hSy6sWtVPSwsAType(CesiumForUnity_CesiumEditorUtility_CallFindFirstTilesetWithAssetID_OUsZiF60__hSy6sWtVPSwsA);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumEditorUtility_CallFindFirstTilesetWithAssetID_OUsZiF60__hSy6sWtVPSwsAType))]
        private static unsafe System.IntPtr CesiumForUnity_CesiumEditorUtility_CallFindFirstTilesetWithAssetID_OUsZiF60__hSy6sWtVPSwsA(long assetID)
        {
            
            var result = CesiumForUnity.CesiumEditorUtility.FindFirstTilesetWithAssetID(assetID);
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_CesiumEditorWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfgType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_CesiumEditorWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfgType CesiumForUnity_CesiumEditorWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new CesiumForUnity_CesiumEditorWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfgType(CesiumForUnity_CesiumEditorWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumEditorWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe void CesiumForUnity_CesiumEditorWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfg(System.IntPtr thiz)
        {
            ((CesiumForUnity.CesiumEditorWindow)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).Close();
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte CesiumForUnity_CesiumEditorWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType(System.IntPtr x, System.IntPtr y);
        private static unsafe readonly CesiumForUnity_CesiumEditorWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType CesiumForUnity_CesiumEditorWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgDelegate = new CesiumForUnity_CesiumEditorWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType(CesiumForUnity_CesiumEditorWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2Wg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumEditorWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType))]
        private static unsafe byte CesiumForUnity_CesiumEditorWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2Wg(System.IntPtr x, System.IntPtr y)
        {
            
            var result = ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(x)!) == ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(y)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte CesiumForUnity_CesiumEditorWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType(System.IntPtr x, System.IntPtr y);
        private static unsafe readonly CesiumForUnity_CesiumEditorWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType CesiumForUnity_CesiumEditorWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgDelegate = new CesiumForUnity_CesiumEditorWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType(CesiumForUnity_CesiumEditorWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2Wg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumEditorWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType))]
        private static unsafe byte CesiumForUnity_CesiumEditorWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2Wg(System.IntPtr x, System.IntPtr y)
        {
            
            var result = ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(x)!) != ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(y)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_CesiumEditorWindow_Field_get_currentWindowType();
        private static unsafe readonly CesiumForUnity_CesiumEditorWindow_Field_get_currentWindowType CesiumForUnity_CesiumEditorWindow_Field_get_currentWindowDelegate = new CesiumForUnity_CesiumEditorWindow_Field_get_currentWindowType(CesiumForUnity_CesiumEditorWindow_Field_get_currentWindow);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumEditorWindow_Field_get_currentWindowType))]
        private static unsafe System.IntPtr CesiumForUnity_CesiumEditorWindow_Field_get_currentWindow()
        {
            var result = CesiumForUnity.CesiumEditorWindow.currentWindow;
          return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_CesiumEditorWindow_Field_set_currentWindowType(System.IntPtr value);
        private static unsafe readonly CesiumForUnity_CesiumEditorWindow_Field_set_currentWindowType CesiumForUnity_CesiumEditorWindow_Field_set_currentWindowDelegate = new CesiumForUnity_CesiumEditorWindow_Field_set_currentWindowType(CesiumForUnity_CesiumEditorWindow_Field_set_currentWindow);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumEditorWindow_Field_set_currentWindowType))]
        private static unsafe void CesiumForUnity_CesiumEditorWindow_Field_set_currentWindow(System.IntPtr value)
        {
            CesiumForUnity.CesiumEditorWindow.currentWindow = (CesiumForUnity.CesiumEditorWindow)Reinterop.ObjectHandleUtility.GetObjectFromHandle(value)!;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_CesiumEditorWindow_Property_get_NativeImplementationType(IntPtr thiz);
        private static unsafe readonly CesiumForUnity_CesiumEditorWindow_Property_get_NativeImplementationType CesiumForUnity_CesiumEditorWindow_Property_get_NativeImplementationDelegate = new CesiumForUnity_CesiumEditorWindow_Property_get_NativeImplementationType(CesiumForUnity_CesiumEditorWindow_Property_get_NativeImplementation);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumEditorWindow_Property_get_NativeImplementationType))]
        private static unsafe System.IntPtr CesiumForUnity_CesiumEditorWindow_Property_get_NativeImplementation(IntPtr thiz)
        {
            return ((CesiumForUnity.CesiumEditorWindow)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).NativeImplementation.DangerousGetHandle();
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte CesiumForUnity_CesiumIonAsset_CallIsNull_1B2M2Y8AsgTpgAmY7PhCfgType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_CesiumIonAsset_CallIsNull_1B2M2Y8AsgTpgAmY7PhCfgType CesiumForUnity_CesiumIonAsset_CallIsNull_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new CesiumForUnity_CesiumIonAsset_CallIsNull_1B2M2Y8AsgTpgAmY7PhCfgType(CesiumForUnity_CesiumIonAsset_CallIsNull_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumIonAsset_CallIsNull_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe byte CesiumForUnity_CesiumIonAsset_CallIsNull_1B2M2Y8AsgTpgAmY7PhCfg(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.CesiumIonAsset)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).IsNull();
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_CesiumIonAsset_Property_get_componentTypeType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_CesiumIonAsset_Property_get_componentTypeType CesiumForUnity_CesiumIonAsset_Property_get_componentTypeDelegate = new CesiumForUnity_CesiumIonAsset_Property_get_componentTypeType(CesiumForUnity_CesiumIonAsset_Property_get_componentType);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumIonAsset_Property_get_componentTypeType))]
        private static unsafe System.IntPtr CesiumForUnity_CesiumIonAsset_Property_get_componentType(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.CesiumIonAsset)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).componentType;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_CesiumIonAsset_Property_get_ionAccessTokenType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_CesiumIonAsset_Property_get_ionAccessTokenType CesiumForUnity_CesiumIonAsset_Property_get_ionAccessTokenDelegate = new CesiumForUnity_CesiumIonAsset_Property_get_ionAccessTokenType(CesiumForUnity_CesiumIonAsset_Property_get_ionAccessToken);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumIonAsset_Property_get_ionAccessTokenType))]
        private static unsafe System.IntPtr CesiumForUnity_CesiumIonAsset_Property_get_ionAccessToken(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.CesiumIonAsset)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).ionAccessToken;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate long CesiumForUnity_CesiumIonAsset_Property_get_ionAssetIDType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_CesiumIonAsset_Property_get_ionAssetIDType CesiumForUnity_CesiumIonAsset_Property_get_ionAssetIDDelegate = new CesiumForUnity_CesiumIonAsset_Property_get_ionAssetIDType(CesiumForUnity_CesiumIonAsset_Property_get_ionAssetID);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumIonAsset_Property_get_ionAssetIDType))]
        private static unsafe long CesiumForUnity_CesiumIonAsset_Property_get_ionAssetID(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.CesiumIonAsset)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).ionAssetID;
            
            return result;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_CesiumIonAsset_Property_get_objectNameType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_CesiumIonAsset_Property_get_objectNameType CesiumForUnity_CesiumIonAsset_Property_get_objectNameDelegate = new CesiumForUnity_CesiumIonAsset_Property_get_objectNameType(CesiumForUnity_CesiumIonAsset_Property_get_objectName);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumIonAsset_Property_get_objectNameType))]
        private static unsafe System.IntPtr CesiumForUnity_CesiumIonAsset_Property_get_objectName(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.CesiumIonAsset)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).objectName;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_CesiumIonAsset_Property_get_typeType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_CesiumIonAsset_Property_get_typeType CesiumForUnity_CesiumIonAsset_Property_get_typeDelegate = new CesiumForUnity_CesiumIonAsset_Property_get_typeType(CesiumForUnity_CesiumIonAsset_Property_get_type);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumIonAsset_Property_get_typeType))]
        private static unsafe System.IntPtr CesiumForUnity_CesiumIonAsset_Property_get_type(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.CesiumIonAsset)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).type;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_CesiumIonAsset_Property_set_ionAccessTokenType(System.IntPtr thiz, System.IntPtr value);
        private static unsafe readonly CesiumForUnity_CesiumIonAsset_Property_set_ionAccessTokenType CesiumForUnity_CesiumIonAsset_Property_set_ionAccessTokenDelegate = new CesiumForUnity_CesiumIonAsset_Property_set_ionAccessTokenType(CesiumForUnity_CesiumIonAsset_Property_set_ionAccessToken);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumIonAsset_Property_set_ionAccessTokenType))]
        private static unsafe void CesiumForUnity_CesiumIonAsset_Property_set_ionAccessToken(System.IntPtr thiz, System.IntPtr value)
        {
            ((CesiumForUnity.CesiumIonAsset)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).ionAccessToken = (string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(value)!;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte CesiumForUnity_CesiumIonRasterOverlay_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType(System.IntPtr x, System.IntPtr y);
        private static unsafe readonly CesiumForUnity_CesiumIonRasterOverlay_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType CesiumForUnity_CesiumIonRasterOverlay_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgDelegate = new CesiumForUnity_CesiumIonRasterOverlay_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType(CesiumForUnity_CesiumIonRasterOverlay_Callop_Equality_5bi2N6jTkaYVhpHPRxL2Wg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumIonRasterOverlay_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType))]
        private static unsafe byte CesiumForUnity_CesiumIonRasterOverlay_Callop_Equality_5bi2N6jTkaYVhpHPRxL2Wg(System.IntPtr x, System.IntPtr y)
        {
            
            var result = ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(x)!) == ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(y)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte CesiumForUnity_CesiumIonRasterOverlay_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType(System.IntPtr x, System.IntPtr y);
        private static unsafe readonly CesiumForUnity_CesiumIonRasterOverlay_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType CesiumForUnity_CesiumIonRasterOverlay_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgDelegate = new CesiumForUnity_CesiumIonRasterOverlay_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType(CesiumForUnity_CesiumIonRasterOverlay_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2Wg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumIonRasterOverlay_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType))]
        private static unsafe byte CesiumForUnity_CesiumIonRasterOverlay_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2Wg(System.IntPtr x, System.IntPtr y)
        {
            
            var result = ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(x)!) != ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(y)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_CesiumIonRasterOverlay_CallRefresh_1B2M2Y8AsgTpgAmY7PhCfgType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_CesiumIonRasterOverlay_CallRefresh_1B2M2Y8AsgTpgAmY7PhCfgType CesiumForUnity_CesiumIonRasterOverlay_CallRefresh_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new CesiumForUnity_CesiumIonRasterOverlay_CallRefresh_1B2M2Y8AsgTpgAmY7PhCfgType(CesiumForUnity_CesiumIonRasterOverlay_CallRefresh_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumIonRasterOverlay_CallRefresh_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe void CesiumForUnity_CesiumIonRasterOverlay_CallRefresh_1B2M2Y8AsgTpgAmY7PhCfg(System.IntPtr thiz)
        {
            ((CesiumForUnity.CesiumIonRasterOverlay)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).Refresh();
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_CesiumIonRasterOverlay_Property_get_gameObjectType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_CesiumIonRasterOverlay_Property_get_gameObjectType CesiumForUnity_CesiumIonRasterOverlay_Property_get_gameObjectDelegate = new CesiumForUnity_CesiumIonRasterOverlay_Property_get_gameObjectType(CesiumForUnity_CesiumIonRasterOverlay_Property_get_gameObject);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumIonRasterOverlay_Property_get_gameObjectType))]
        private static unsafe System.IntPtr CesiumForUnity_CesiumIonRasterOverlay_Property_get_gameObject(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.CesiumIonRasterOverlay)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).gameObject;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_CesiumIonRasterOverlay_Property_get_ionAccessTokenType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_CesiumIonRasterOverlay_Property_get_ionAccessTokenType CesiumForUnity_CesiumIonRasterOverlay_Property_get_ionAccessTokenDelegate = new CesiumForUnity_CesiumIonRasterOverlay_Property_get_ionAccessTokenType(CesiumForUnity_CesiumIonRasterOverlay_Property_get_ionAccessToken);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumIonRasterOverlay_Property_get_ionAccessTokenType))]
        private static unsafe System.IntPtr CesiumForUnity_CesiumIonRasterOverlay_Property_get_ionAccessToken(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.CesiumIonRasterOverlay)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).ionAccessToken;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate long CesiumForUnity_CesiumIonRasterOverlay_Property_get_ionAssetIDType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_CesiumIonRasterOverlay_Property_get_ionAssetIDType CesiumForUnity_CesiumIonRasterOverlay_Property_get_ionAssetIDDelegate = new CesiumForUnity_CesiumIonRasterOverlay_Property_get_ionAssetIDType(CesiumForUnity_CesiumIonRasterOverlay_Property_get_ionAssetID);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumIonRasterOverlay_Property_get_ionAssetIDType))]
        private static unsafe long CesiumForUnity_CesiumIonRasterOverlay_Property_get_ionAssetID(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.CesiumIonRasterOverlay)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).ionAssetID;
            
            return result;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_CesiumIonRasterOverlay_Property_set_ionAccessTokenType(System.IntPtr thiz, System.IntPtr value);
        private static unsafe readonly CesiumForUnity_CesiumIonRasterOverlay_Property_set_ionAccessTokenType CesiumForUnity_CesiumIonRasterOverlay_Property_set_ionAccessTokenDelegate = new CesiumForUnity_CesiumIonRasterOverlay_Property_set_ionAccessTokenType(CesiumForUnity_CesiumIonRasterOverlay_Property_set_ionAccessToken);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumIonRasterOverlay_Property_set_ionAccessTokenType))]
        private static unsafe void CesiumForUnity_CesiumIonRasterOverlay_Property_set_ionAccessToken(System.IntPtr thiz, System.IntPtr value)
        {
            ((CesiumForUnity.CesiumIonRasterOverlay)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).ionAccessToken = (string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(value)!;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_CesiumIonRasterOverlay_Property_set_ionAssetIDType(System.IntPtr thiz, long value);
        private static unsafe readonly CesiumForUnity_CesiumIonRasterOverlay_Property_set_ionAssetIDType CesiumForUnity_CesiumIonRasterOverlay_Property_set_ionAssetIDDelegate = new CesiumForUnity_CesiumIonRasterOverlay_Property_set_ionAssetIDType(CesiumForUnity_CesiumIonRasterOverlay_Property_set_ionAssetID);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumIonRasterOverlay_Property_set_ionAssetIDType))]
        private static unsafe void CesiumForUnity_CesiumIonRasterOverlay_Property_set_ionAssetID(System.IntPtr thiz, long value)
        {
            ((CesiumForUnity.CesiumIonRasterOverlay)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).ionAssetID = value;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_CesiumIonSession_CallBroadcastAssetsUpdate_1B2M2Y8AsgTpgAmY7PhCfgType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_CesiumIonSession_CallBroadcastAssetsUpdate_1B2M2Y8AsgTpgAmY7PhCfgType CesiumForUnity_CesiumIonSession_CallBroadcastAssetsUpdate_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new CesiumForUnity_CesiumIonSession_CallBroadcastAssetsUpdate_1B2M2Y8AsgTpgAmY7PhCfgType(CesiumForUnity_CesiumIonSession_CallBroadcastAssetsUpdate_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumIonSession_CallBroadcastAssetsUpdate_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe void CesiumForUnity_CesiumIonSession_CallBroadcastAssetsUpdate_1B2M2Y8AsgTpgAmY7PhCfg(System.IntPtr thiz)
        {
            ((CesiumForUnity.CesiumIonSession)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).BroadcastAssetsUpdate();
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_CesiumIonSession_CallBroadcastConnectionUpdate_1B2M2Y8AsgTpgAmY7PhCfgType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_CesiumIonSession_CallBroadcastConnectionUpdate_1B2M2Y8AsgTpgAmY7PhCfgType CesiumForUnity_CesiumIonSession_CallBroadcastConnectionUpdate_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new CesiumForUnity_CesiumIonSession_CallBroadcastConnectionUpdate_1B2M2Y8AsgTpgAmY7PhCfgType(CesiumForUnity_CesiumIonSession_CallBroadcastConnectionUpdate_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumIonSession_CallBroadcastConnectionUpdate_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe void CesiumForUnity_CesiumIonSession_CallBroadcastConnectionUpdate_1B2M2Y8AsgTpgAmY7PhCfg(System.IntPtr thiz)
        {
            ((CesiumForUnity.CesiumIonSession)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).BroadcastConnectionUpdate();
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_CesiumIonSession_CallBroadcastProfileUpdate_1B2M2Y8AsgTpgAmY7PhCfgType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_CesiumIonSession_CallBroadcastProfileUpdate_1B2M2Y8AsgTpgAmY7PhCfgType CesiumForUnity_CesiumIonSession_CallBroadcastProfileUpdate_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new CesiumForUnity_CesiumIonSession_CallBroadcastProfileUpdate_1B2M2Y8AsgTpgAmY7PhCfgType(CesiumForUnity_CesiumIonSession_CallBroadcastProfileUpdate_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumIonSession_CallBroadcastProfileUpdate_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe void CesiumForUnity_CesiumIonSession_CallBroadcastProfileUpdate_1B2M2Y8AsgTpgAmY7PhCfg(System.IntPtr thiz)
        {
            ((CesiumForUnity.CesiumIonSession)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).BroadcastProfileUpdate();
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_CesiumIonSession_CallBroadcastTokensUpdate_1B2M2Y8AsgTpgAmY7PhCfgType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_CesiumIonSession_CallBroadcastTokensUpdate_1B2M2Y8AsgTpgAmY7PhCfgType CesiumForUnity_CesiumIonSession_CallBroadcastTokensUpdate_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new CesiumForUnity_CesiumIonSession_CallBroadcastTokensUpdate_1B2M2Y8AsgTpgAmY7PhCfgType(CesiumForUnity_CesiumIonSession_CallBroadcastTokensUpdate_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumIonSession_CallBroadcastTokensUpdate_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe void CesiumForUnity_CesiumIonSession_CallBroadcastTokensUpdate_1B2M2Y8AsgTpgAmY7PhCfg(System.IntPtr thiz)
        {
            ((CesiumForUnity.CesiumIonSession)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).BroadcastTokensUpdate();
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_CesiumIonSession_CallIon_1B2M2Y8AsgTpgAmY7PhCfgType();
        private static unsafe readonly CesiumForUnity_CesiumIonSession_CallIon_1B2M2Y8AsgTpgAmY7PhCfgType CesiumForUnity_CesiumIonSession_CallIon_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new CesiumForUnity_CesiumIonSession_CallIon_1B2M2Y8AsgTpgAmY7PhCfgType(CesiumForUnity_CesiumIonSession_CallIon_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumIonSession_CallIon_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe System.IntPtr CesiumForUnity_CesiumIonSession_CallIon_1B2M2Y8AsgTpgAmY7PhCfg()
        {
            
            var result = CesiumForUnity.CesiumIonSession.Ion();
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte CesiumForUnity_CesiumIonSession_CallIsConnected_1B2M2Y8AsgTpgAmY7PhCfgType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_CesiumIonSession_CallIsConnected_1B2M2Y8AsgTpgAmY7PhCfgType CesiumForUnity_CesiumIonSession_CallIsConnected_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new CesiumForUnity_CesiumIonSession_CallIsConnected_1B2M2Y8AsgTpgAmY7PhCfgType(CesiumForUnity_CesiumIonSession_CallIsConnected_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumIonSession_CallIsConnected_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe byte CesiumForUnity_CesiumIonSession_CallIsConnected_1B2M2Y8AsgTpgAmY7PhCfg(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.CesiumIonSession)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).IsConnected();
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_CesiumIonSession_Property_get_NativeImplementationType(IntPtr thiz);
        private static unsafe readonly CesiumForUnity_CesiumIonSession_Property_get_NativeImplementationType CesiumForUnity_CesiumIonSession_Property_get_NativeImplementationDelegate = new CesiumForUnity_CesiumIonSession_Property_get_NativeImplementationType(CesiumForUnity_CesiumIonSession_Property_get_NativeImplementation);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumIonSession_Property_get_NativeImplementationType))]
        private static unsafe System.IntPtr CesiumForUnity_CesiumIonSession_Property_get_NativeImplementation(IntPtr thiz)
        {
            return ((CesiumForUnity.CesiumIonSession)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).NativeImplementation.DangerousGetHandle();
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte CesiumForUnity_CesiumRasterOverlay_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType(System.IntPtr x, System.IntPtr y);
        private static unsafe readonly CesiumForUnity_CesiumRasterOverlay_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType CesiumForUnity_CesiumRasterOverlay_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgDelegate = new CesiumForUnity_CesiumRasterOverlay_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType(CesiumForUnity_CesiumRasterOverlay_Callop_Equality_5bi2N6jTkaYVhpHPRxL2Wg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumRasterOverlay_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType))]
        private static unsafe byte CesiumForUnity_CesiumRasterOverlay_Callop_Equality_5bi2N6jTkaYVhpHPRxL2Wg(System.IntPtr x, System.IntPtr y)
        {
            
            var result = ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(x)!) == ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(y)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte CesiumForUnity_CesiumRasterOverlay_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType(System.IntPtr x, System.IntPtr y);
        private static unsafe readonly CesiumForUnity_CesiumRasterOverlay_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType CesiumForUnity_CesiumRasterOverlay_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgDelegate = new CesiumForUnity_CesiumRasterOverlay_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType(CesiumForUnity_CesiumRasterOverlay_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2Wg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumRasterOverlay_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType))]
        private static unsafe byte CesiumForUnity_CesiumRasterOverlay_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2Wg(System.IntPtr x, System.IntPtr y)
        {
            
            var result = ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(x)!) != ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(y)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_CesiumRasterOverlay_CallRefresh_1B2M2Y8AsgTpgAmY7PhCfgType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_CesiumRasterOverlay_CallRefresh_1B2M2Y8AsgTpgAmY7PhCfgType CesiumForUnity_CesiumRasterOverlay_CallRefresh_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new CesiumForUnity_CesiumRasterOverlay_CallRefresh_1B2M2Y8AsgTpgAmY7PhCfgType(CesiumForUnity_CesiumRasterOverlay_CallRefresh_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumRasterOverlay_CallRefresh_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe void CesiumForUnity_CesiumRasterOverlay_CallRefresh_1B2M2Y8AsgTpgAmY7PhCfg(System.IntPtr thiz)
        {
            ((CesiumForUnity.CesiumRasterOverlay)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).Refresh();
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_CesiumRasterOverlay_Property_get_gameObjectType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_CesiumRasterOverlay_Property_get_gameObjectType CesiumForUnity_CesiumRasterOverlay_Property_get_gameObjectDelegate = new CesiumForUnity_CesiumRasterOverlay_Property_get_gameObjectType(CesiumForUnity_CesiumRasterOverlay_Property_get_gameObject);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumRasterOverlay_Property_get_gameObjectType))]
        private static unsafe System.IntPtr CesiumForUnity_CesiumRasterOverlay_Property_get_gameObject(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.CesiumRasterOverlay)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).gameObject;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte CesiumForUnity_CesiumRuntimeSettings_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType(System.IntPtr x, System.IntPtr y);
        private static unsafe readonly CesiumForUnity_CesiumRuntimeSettings_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType CesiumForUnity_CesiumRuntimeSettings_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgDelegate = new CesiumForUnity_CesiumRuntimeSettings_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType(CesiumForUnity_CesiumRuntimeSettings_Callop_Equality_5bi2N6jTkaYVhpHPRxL2Wg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumRuntimeSettings_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType))]
        private static unsafe byte CesiumForUnity_CesiumRuntimeSettings_Callop_Equality_5bi2N6jTkaYVhpHPRxL2Wg(System.IntPtr x, System.IntPtr y)
        {
            
            var result = ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(x)!) == ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(y)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte CesiumForUnity_CesiumRuntimeSettings_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType(System.IntPtr x, System.IntPtr y);
        private static unsafe readonly CesiumForUnity_CesiumRuntimeSettings_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType CesiumForUnity_CesiumRuntimeSettings_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgDelegate = new CesiumForUnity_CesiumRuntimeSettings_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType(CesiumForUnity_CesiumRuntimeSettings_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2Wg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumRuntimeSettings_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType))]
        private static unsafe byte CesiumForUnity_CesiumRuntimeSettings_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2Wg(System.IntPtr x, System.IntPtr y)
        {
            
            var result = ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(x)!) != ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(y)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_CesiumRuntimeSettings_Property_get_defaultIonAccessTokenType();
        private static unsafe readonly CesiumForUnity_CesiumRuntimeSettings_Property_get_defaultIonAccessTokenType CesiumForUnity_CesiumRuntimeSettings_Property_get_defaultIonAccessTokenDelegate = new CesiumForUnity_CesiumRuntimeSettings_Property_get_defaultIonAccessTokenType(CesiumForUnity_CesiumRuntimeSettings_Property_get_defaultIonAccessToken);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumRuntimeSettings_Property_get_defaultIonAccessTokenType))]
        private static unsafe System.IntPtr CesiumForUnity_CesiumRuntimeSettings_Property_get_defaultIonAccessToken()
        {
            
            var result = CesiumForUnity.CesiumRuntimeSettings.defaultIonAccessToken;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_CesiumRuntimeSettings_Property_get_defaultIonAccessTokenIDType();
        private static unsafe readonly CesiumForUnity_CesiumRuntimeSettings_Property_get_defaultIonAccessTokenIDType CesiumForUnity_CesiumRuntimeSettings_Property_get_defaultIonAccessTokenIDDelegate = new CesiumForUnity_CesiumRuntimeSettings_Property_get_defaultIonAccessTokenIDType(CesiumForUnity_CesiumRuntimeSettings_Property_get_defaultIonAccessTokenID);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumRuntimeSettings_Property_get_defaultIonAccessTokenIDType))]
        private static unsafe System.IntPtr CesiumForUnity_CesiumRuntimeSettings_Property_get_defaultIonAccessTokenID()
        {
            
            var result = CesiumForUnity.CesiumRuntimeSettings.defaultIonAccessTokenID;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_CesiumRuntimeSettings_Property_set_defaultIonAccessTokenType(System.IntPtr value);
        private static unsafe readonly CesiumForUnity_CesiumRuntimeSettings_Property_set_defaultIonAccessTokenType CesiumForUnity_CesiumRuntimeSettings_Property_set_defaultIonAccessTokenDelegate = new CesiumForUnity_CesiumRuntimeSettings_Property_set_defaultIonAccessTokenType(CesiumForUnity_CesiumRuntimeSettings_Property_set_defaultIonAccessToken);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumRuntimeSettings_Property_set_defaultIonAccessTokenType))]
        private static unsafe void CesiumForUnity_CesiumRuntimeSettings_Property_set_defaultIonAccessToken(System.IntPtr value)
        {
            CesiumForUnity.CesiumRuntimeSettings.defaultIonAccessToken = (string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(value)!;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_CesiumRuntimeSettings_Property_set_defaultIonAccessTokenIDType(System.IntPtr value);
        private static unsafe readonly CesiumForUnity_CesiumRuntimeSettings_Property_set_defaultIonAccessTokenIDType CesiumForUnity_CesiumRuntimeSettings_Property_set_defaultIonAccessTokenIDDelegate = new CesiumForUnity_CesiumRuntimeSettings_Property_set_defaultIonAccessTokenIDType(CesiumForUnity_CesiumRuntimeSettings_Property_set_defaultIonAccessTokenID);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumRuntimeSettings_Property_set_defaultIonAccessTokenIDType))]
        private static unsafe void CesiumForUnity_CesiumRuntimeSettings_Property_set_defaultIonAccessTokenID(System.IntPtr value)
        {
            CesiumForUnity.CesiumRuntimeSettings.defaultIonAccessTokenID = (string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(value)!;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_Helpers_CallToString__8pn__Nas4aiRxhf1NkpeKgType(UnityEngine.RuntimePlatform value);
        private static unsafe readonly CesiumForUnity_Helpers_CallToString__8pn__Nas4aiRxhf1NkpeKgType CesiumForUnity_Helpers_CallToString__8pn__Nas4aiRxhf1NkpeKgDelegate = new CesiumForUnity_Helpers_CallToString__8pn__Nas4aiRxhf1NkpeKgType(CesiumForUnity_Helpers_CallToString__8pn__Nas4aiRxhf1NkpeKg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_Helpers_CallToString__8pn__Nas4aiRxhf1NkpeKgType))]
        private static unsafe System.IntPtr CesiumForUnity_Helpers_CallToString__8pn__Nas4aiRxhf1NkpeKg(UnityEngine.RuntimePlatform value)
        {
            
            var result = CesiumForUnity.Helpers.ToString<UnityEngine.RuntimePlatform>(value);
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_IonAssetDetails_CallFormatDate_Wg__UxSmEJUgHx3kyfccFEwType(System.IntPtr assetDate);
        private static unsafe readonly CesiumForUnity_IonAssetDetails_CallFormatDate_Wg__UxSmEJUgHx3kyfccFEwType CesiumForUnity_IonAssetDetails_CallFormatDate_Wg__UxSmEJUgHx3kyfccFEwDelegate = new CesiumForUnity_IonAssetDetails_CallFormatDate_Wg__UxSmEJUgHx3kyfccFEwType(CesiumForUnity_IonAssetDetails_CallFormatDate_Wg__UxSmEJUgHx3kyfccFEw);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_IonAssetDetails_CallFormatDate_Wg__UxSmEJUgHx3kyfccFEwType))]
        private static unsafe System.IntPtr CesiumForUnity_IonAssetDetails_CallFormatDate_Wg__UxSmEJUgHx3kyfccFEw(System.IntPtr assetDate)
        {
            
            var result = CesiumForUnity.IonAssetDetails.FormatDate((string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(assetDate)!);
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_IonAssetDetails_CallFormatType_3GczHehc_XCRt9ReXGSrdQType(System.IntPtr type);
        private static unsafe readonly CesiumForUnity_IonAssetDetails_CallFormatType_3GczHehc_XCRt9ReXGSrdQType CesiumForUnity_IonAssetDetails_CallFormatType_3GczHehc_XCRt9ReXGSrdQDelegate = new CesiumForUnity_IonAssetDetails_CallFormatType_3GczHehc_XCRt9ReXGSrdQType(CesiumForUnity_IonAssetDetails_CallFormatType_3GczHehc_XCRt9ReXGSrdQ);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_IonAssetDetails_CallFormatType_3GczHehc_XCRt9ReXGSrdQType))]
        private static unsafe System.IntPtr CesiumForUnity_IonAssetDetails_CallFormatType_3GczHehc_XCRt9ReXGSrdQ(System.IntPtr type)
        {
            
            var result = CesiumForUnity.IonAssetDetails.FormatType((string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(type)!);
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_IonAssetsTreeView_CallReload_1B2M2Y8AsgTpgAmY7PhCfgType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_IonAssetsTreeView_CallReload_1B2M2Y8AsgTpgAmY7PhCfgType CesiumForUnity_IonAssetsTreeView_CallReload_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new CesiumForUnity_IonAssetsTreeView_CallReload_1B2M2Y8AsgTpgAmY7PhCfgType(CesiumForUnity_IonAssetsTreeView_CallReload_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_IonAssetsTreeView_CallReload_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe void CesiumForUnity_IonAssetsTreeView_CallReload_1B2M2Y8AsgTpgAmY7PhCfg(System.IntPtr thiz)
        {
            ((CesiumForUnity.IonAssetsTreeView)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).Reload();
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_IonAssetsTreeView_Construct_bk3kO2aTAFaE0GWD9sxbigType(System.IntPtr assetsTreeState);
        private static unsafe readonly CesiumForUnity_IonAssetsTreeView_Construct_bk3kO2aTAFaE0GWD9sxbigType CesiumForUnity_IonAssetsTreeView_Construct_bk3kO2aTAFaE0GWD9sxbigDelegate = new CesiumForUnity_IonAssetsTreeView_Construct_bk3kO2aTAFaE0GWD9sxbigType(CesiumForUnity_IonAssetsTreeView_Construct_bk3kO2aTAFaE0GWD9sxbig);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_IonAssetsTreeView_Construct_bk3kO2aTAFaE0GWD9sxbigType))]
        private static unsafe System.IntPtr CesiumForUnity_IonAssetsTreeView_Construct_bk3kO2aTAFaE0GWD9sxbig(System.IntPtr assetsTreeState)
        {
            
            var result = new CesiumForUnity.IonAssetsTreeView((UnityEditor.IMGUI.Controls.TreeViewState)Reinterop.ObjectHandleUtility.GetObjectFromHandle(assetsTreeState)!);
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_IonAssetsTreeView_Property_get_multiColumnHeaderType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_IonAssetsTreeView_Property_get_multiColumnHeaderType CesiumForUnity_IonAssetsTreeView_Property_get_multiColumnHeaderDelegate = new CesiumForUnity_IonAssetsTreeView_Property_get_multiColumnHeaderType(CesiumForUnity_IonAssetsTreeView_Property_get_multiColumnHeader);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_IonAssetsTreeView_Property_get_multiColumnHeaderType))]
        private static unsafe System.IntPtr CesiumForUnity_IonAssetsTreeView_Property_get_multiColumnHeader(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.IonAssetsTreeView)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).multiColumnHeader;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_IonAssetsTreeView_Property_get_NativeImplementationType(IntPtr thiz);
        private static unsafe readonly CesiumForUnity_IonAssetsTreeView_Property_get_NativeImplementationType CesiumForUnity_IonAssetsTreeView_Property_get_NativeImplementationDelegate = new CesiumForUnity_IonAssetsTreeView_Property_get_NativeImplementationType(CesiumForUnity_IonAssetsTreeView_Property_get_NativeImplementation);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_IonAssetsTreeView_Property_get_NativeImplementationType))]
        private static unsafe System.IntPtr CesiumForUnity_IonAssetsTreeView_Property_get_NativeImplementation(IntPtr thiz)
        {
            return ((CesiumForUnity.IonAssetsTreeView)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).NativeImplementation.DangerousGetHandle();
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_IonAssetsTreeView_Property_get_searchStringType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_IonAssetsTreeView_Property_get_searchStringType CesiumForUnity_IonAssetsTreeView_Property_get_searchStringDelegate = new CesiumForUnity_IonAssetsTreeView_Property_get_searchStringType(CesiumForUnity_IonAssetsTreeView_Property_get_searchString);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_IonAssetsTreeView_Property_get_searchStringType))]
        private static unsafe System.IntPtr CesiumForUnity_IonAssetsTreeView_Property_get_searchString(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.IonAssetsTreeView)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).searchString;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_IonAssetsTreeView_Property_set_multiColumnHeaderType(System.IntPtr thiz, System.IntPtr value);
        private static unsafe readonly CesiumForUnity_IonAssetsTreeView_Property_set_multiColumnHeaderType CesiumForUnity_IonAssetsTreeView_Property_set_multiColumnHeaderDelegate = new CesiumForUnity_IonAssetsTreeView_Property_set_multiColumnHeaderType(CesiumForUnity_IonAssetsTreeView_Property_set_multiColumnHeader);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_IonAssetsTreeView_Property_set_multiColumnHeaderType))]
        private static unsafe void CesiumForUnity_IonAssetsTreeView_Property_set_multiColumnHeader(System.IntPtr thiz, System.IntPtr value)
        {
            ((CesiumForUnity.IonAssetsTreeView)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).multiColumnHeader = (UnityEditor.IMGUI.Controls.MultiColumnHeader)Reinterop.ObjectHandleUtility.GetObjectFromHandle(value)!;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_IonAssetsTreeView_Property_set_searchStringType(System.IntPtr thiz, System.IntPtr value);
        private static unsafe readonly CesiumForUnity_IonAssetsTreeView_Property_set_searchStringType CesiumForUnity_IonAssetsTreeView_Property_set_searchStringDelegate = new CesiumForUnity_IonAssetsTreeView_Property_set_searchStringType(CesiumForUnity_IonAssetsTreeView_Property_set_searchString);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_IonAssetsTreeView_Property_set_searchStringType))]
        private static unsafe void CesiumForUnity_IonAssetsTreeView_Property_set_searchString(System.IntPtr thiz, System.IntPtr value)
        {
            ((CesiumForUnity.IonAssetsTreeView)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).searchString = (string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(value)!;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_IonMissingAssetWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfgType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_IonMissingAssetWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfgType CesiumForUnity_IonMissingAssetWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new CesiumForUnity_IonMissingAssetWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfgType(CesiumForUnity_IonMissingAssetWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_IonMissingAssetWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe void CesiumForUnity_IonMissingAssetWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfg(System.IntPtr thiz)
        {
            ((CesiumForUnity.IonMissingAssetWindow)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).Close();
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte CesiumForUnity_IonMissingAssetWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType(System.IntPtr x, System.IntPtr y);
        private static unsafe readonly CesiumForUnity_IonMissingAssetWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType CesiumForUnity_IonMissingAssetWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgDelegate = new CesiumForUnity_IonMissingAssetWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType(CesiumForUnity_IonMissingAssetWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2Wg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_IonMissingAssetWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType))]
        private static unsafe byte CesiumForUnity_IonMissingAssetWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2Wg(System.IntPtr x, System.IntPtr y)
        {
            
            var result = ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(x)!) == ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(y)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte CesiumForUnity_IonMissingAssetWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType(System.IntPtr x, System.IntPtr y);
        private static unsafe readonly CesiumForUnity_IonMissingAssetWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType CesiumForUnity_IonMissingAssetWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgDelegate = new CesiumForUnity_IonMissingAssetWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType(CesiumForUnity_IonMissingAssetWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2Wg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_IonMissingAssetWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType))]
        private static unsafe byte CesiumForUnity_IonMissingAssetWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2Wg(System.IntPtr x, System.IntPtr y)
        {
            
            var result = ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(x)!) != ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(y)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_IonMissingAssetWindow_CallShowWindow_zCuaF57FLiXZD1__wksXLdQType(System.IntPtr assetName, long assetID);
        private static unsafe readonly CesiumForUnity_IonMissingAssetWindow_CallShowWindow_zCuaF57FLiXZD1__wksXLdQType CesiumForUnity_IonMissingAssetWindow_CallShowWindow_zCuaF57FLiXZD1__wksXLdQDelegate = new CesiumForUnity_IonMissingAssetWindow_CallShowWindow_zCuaF57FLiXZD1__wksXLdQType(CesiumForUnity_IonMissingAssetWindow_CallShowWindow_zCuaF57FLiXZD1__wksXLdQ);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_IonMissingAssetWindow_CallShowWindow_zCuaF57FLiXZD1__wksXLdQType))]
        private static unsafe void CesiumForUnity_IonMissingAssetWindow_CallShowWindow_zCuaF57FLiXZD1__wksXLdQ(System.IntPtr assetName, long assetID)
        {
            CesiumForUnity.IonMissingAssetWindow.ShowWindow((string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(assetName)!, assetID);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_IonTokenTroubleshootingWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfgType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_IonTokenTroubleshootingWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfgType CesiumForUnity_IonTokenTroubleshootingWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new CesiumForUnity_IonTokenTroubleshootingWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfgType(CesiumForUnity_IonTokenTroubleshootingWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_IonTokenTroubleshootingWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe void CesiumForUnity_IonTokenTroubleshootingWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfg(System.IntPtr thiz)
        {
            ((CesiumForUnity.IonTokenTroubleshootingWindow)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).Close();
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte CesiumForUnity_IonTokenTroubleshootingWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType(System.IntPtr x, System.IntPtr y);
        private static unsafe readonly CesiumForUnity_IonTokenTroubleshootingWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType CesiumForUnity_IonTokenTroubleshootingWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgDelegate = new CesiumForUnity_IonTokenTroubleshootingWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType(CesiumForUnity_IonTokenTroubleshootingWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2Wg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_IonTokenTroubleshootingWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType))]
        private static unsafe byte CesiumForUnity_IonTokenTroubleshootingWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2Wg(System.IntPtr x, System.IntPtr y)
        {
            
            var result = ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(x)!) == ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(y)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte CesiumForUnity_IonTokenTroubleshootingWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType(System.IntPtr x, System.IntPtr y);
        private static unsafe readonly CesiumForUnity_IonTokenTroubleshootingWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType CesiumForUnity_IonTokenTroubleshootingWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgDelegate = new CesiumForUnity_IonTokenTroubleshootingWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType(CesiumForUnity_IonTokenTroubleshootingWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2Wg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_IonTokenTroubleshootingWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType))]
        private static unsafe byte CesiumForUnity_IonTokenTroubleshootingWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2Wg(System.IntPtr x, System.IntPtr y)
        {
            
            var result = ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(x)!) != ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(y)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_IonTokenTroubleshootingWindow_CallUseDefaultToken_qpX7eE7SvOg4KIeidX7yngType(System.IntPtr asset);
        private static unsafe readonly CesiumForUnity_IonTokenTroubleshootingWindow_CallUseDefaultToken_qpX7eE7SvOg4KIeidX7yngType CesiumForUnity_IonTokenTroubleshootingWindow_CallUseDefaultToken_qpX7eE7SvOg4KIeidX7yngDelegate = new CesiumForUnity_IonTokenTroubleshootingWindow_CallUseDefaultToken_qpX7eE7SvOg4KIeidX7yngType(CesiumForUnity_IonTokenTroubleshootingWindow_CallUseDefaultToken_qpX7eE7SvOg4KIeidX7yng);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_IonTokenTroubleshootingWindow_CallUseDefaultToken_qpX7eE7SvOg4KIeidX7yngType))]
        private static unsafe void CesiumForUnity_IonTokenTroubleshootingWindow_CallUseDefaultToken_qpX7eE7SvOg4KIeidX7yng(System.IntPtr asset)
        {
            CesiumForUnity.IonTokenTroubleshootingWindow.UseDefaultToken((CesiumForUnity.CesiumIonAsset)Reinterop.ObjectHandleUtility.GetObjectFromHandle(asset)!);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_assetDetailsType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_assetDetailsType CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_assetDetailsDelegate = new CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_assetDetailsType(CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_assetDetails);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_assetDetailsType))]
        private static unsafe System.IntPtr CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_assetDetails(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.IonTokenTroubleshootingWindow)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).assetDetails;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_assetTokenDetailsType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_assetTokenDetailsType CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_assetTokenDetailsDelegate = new CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_assetTokenDetailsType(CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_assetTokenDetails);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_assetTokenDetailsType))]
        private static unsafe System.IntPtr CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_assetTokenDetails(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.IonTokenTroubleshootingWindow)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).assetTokenDetails;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_defaultTokenDetailsType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_defaultTokenDetailsType CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_defaultTokenDetailsDelegate = new CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_defaultTokenDetailsType(CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_defaultTokenDetails);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_defaultTokenDetailsType))]
        private static unsafe System.IntPtr CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_defaultTokenDetails(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.IonTokenTroubleshootingWindow)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).defaultTokenDetails;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_ionAssetType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_ionAssetType CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_ionAssetDelegate = new CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_ionAssetType(CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_ionAsset);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_ionAssetType))]
        private static unsafe System.IntPtr CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_ionAsset(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.IonTokenTroubleshootingWindow)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).ionAsset;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_IonTokenTroubleshootingWindow_Property_set_ionAssetType(System.IntPtr thiz, System.IntPtr value);
        private static unsafe readonly CesiumForUnity_IonTokenTroubleshootingWindow_Property_set_ionAssetType CesiumForUnity_IonTokenTroubleshootingWindow_Property_set_ionAssetDelegate = new CesiumForUnity_IonTokenTroubleshootingWindow_Property_set_ionAssetType(CesiumForUnity_IonTokenTroubleshootingWindow_Property_set_ionAsset);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_IonTokenTroubleshootingWindow_Property_set_ionAssetType))]
        private static unsafe void CesiumForUnity_IonTokenTroubleshootingWindow_Property_set_ionAsset(System.IntPtr thiz, System.IntPtr value)
        {
            ((CesiumForUnity.IonTokenTroubleshootingWindow)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).ionAsset = (CesiumForUnity.CesiumIonAsset)Reinterop.ObjectHandleUtility.GetObjectFromHandle(value)!;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_NativeDownloadHandler_CallDispose_1B2M2Y8AsgTpgAmY7PhCfgType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_NativeDownloadHandler_CallDispose_1B2M2Y8AsgTpgAmY7PhCfgType CesiumForUnity_NativeDownloadHandler_CallDispose_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new CesiumForUnity_NativeDownloadHandler_CallDispose_1B2M2Y8AsgTpgAmY7PhCfgType(CesiumForUnity_NativeDownloadHandler_CallDispose_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_NativeDownloadHandler_CallDispose_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe void CesiumForUnity_NativeDownloadHandler_CallDispose_1B2M2Y8AsgTpgAmY7PhCfg(System.IntPtr thiz)
        {
            ((CesiumForUnity.NativeDownloadHandler)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).Dispose();
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_NativeDownloadHandler_Construct_1B2M2Y8AsgTpgAmY7PhCfgType();
        private static unsafe readonly CesiumForUnity_NativeDownloadHandler_Construct_1B2M2Y8AsgTpgAmY7PhCfgType CesiumForUnity_NativeDownloadHandler_Construct_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new CesiumForUnity_NativeDownloadHandler_Construct_1B2M2Y8AsgTpgAmY7PhCfgType(CesiumForUnity_NativeDownloadHandler_Construct_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_NativeDownloadHandler_Construct_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe System.IntPtr CesiumForUnity_NativeDownloadHandler_Construct_1B2M2Y8AsgTpgAmY7PhCfg()
        {
            
            var result = new CesiumForUnity.NativeDownloadHandler();
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_NativeDownloadHandler_Property_get_NativeImplementationType(IntPtr thiz);
        private static unsafe readonly CesiumForUnity_NativeDownloadHandler_Property_get_NativeImplementationType CesiumForUnity_NativeDownloadHandler_Property_get_NativeImplementationDelegate = new CesiumForUnity_NativeDownloadHandler_Property_get_NativeImplementationType(CesiumForUnity_NativeDownloadHandler_Property_get_NativeImplementation);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_NativeDownloadHandler_Property_get_NativeImplementationType))]
        private static unsafe System.IntPtr CesiumForUnity_NativeDownloadHandler_Property_get_NativeImplementation(IntPtr thiz)
        {
            return ((CesiumForUnity.NativeDownloadHandler)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).NativeImplementation.DangerousGetHandle();
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_SelectIonTokenWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfgType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_SelectIonTokenWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfgType CesiumForUnity_SelectIonTokenWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new CesiumForUnity_SelectIonTokenWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfgType(CesiumForUnity_SelectIonTokenWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_SelectIonTokenWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe void CesiumForUnity_SelectIonTokenWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfg(System.IntPtr thiz)
        {
            ((CesiumForUnity.SelectIonTokenWindow)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).Close();
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_SelectIonTokenWindow_CallGetDefaultNewTokenName_1B2M2Y8AsgTpgAmY7PhCfgType();
        private static unsafe readonly CesiumForUnity_SelectIonTokenWindow_CallGetDefaultNewTokenName_1B2M2Y8AsgTpgAmY7PhCfgType CesiumForUnity_SelectIonTokenWindow_CallGetDefaultNewTokenName_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new CesiumForUnity_SelectIonTokenWindow_CallGetDefaultNewTokenName_1B2M2Y8AsgTpgAmY7PhCfgType(CesiumForUnity_SelectIonTokenWindow_CallGetDefaultNewTokenName_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_SelectIonTokenWindow_CallGetDefaultNewTokenName_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe System.IntPtr CesiumForUnity_SelectIonTokenWindow_CallGetDefaultNewTokenName_1B2M2Y8AsgTpgAmY7PhCfg()
        {
            
            var result = CesiumForUnity.SelectIonTokenWindow.GetDefaultNewTokenName();
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_SelectIonTokenWindow_CallGetExistingTokenList_1B2M2Y8AsgTpgAmY7PhCfgType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_SelectIonTokenWindow_CallGetExistingTokenList_1B2M2Y8AsgTpgAmY7PhCfgType CesiumForUnity_SelectIonTokenWindow_CallGetExistingTokenList_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new CesiumForUnity_SelectIonTokenWindow_CallGetExistingTokenList_1B2M2Y8AsgTpgAmY7PhCfgType(CesiumForUnity_SelectIonTokenWindow_CallGetExistingTokenList_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_SelectIonTokenWindow_CallGetExistingTokenList_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe System.IntPtr CesiumForUnity_SelectIonTokenWindow_CallGetExistingTokenList_1B2M2Y8AsgTpgAmY7PhCfg(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.SelectIonTokenWindow)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).GetExistingTokenList();
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte CesiumForUnity_SelectIonTokenWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType(System.IntPtr x, System.IntPtr y);
        private static unsafe readonly CesiumForUnity_SelectIonTokenWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType CesiumForUnity_SelectIonTokenWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgDelegate = new CesiumForUnity_SelectIonTokenWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType(CesiumForUnity_SelectIonTokenWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2Wg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_SelectIonTokenWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType))]
        private static unsafe byte CesiumForUnity_SelectIonTokenWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2Wg(System.IntPtr x, System.IntPtr y)
        {
            
            var result = ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(x)!) == ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(y)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte CesiumForUnity_SelectIonTokenWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType(System.IntPtr x, System.IntPtr y);
        private static unsafe readonly CesiumForUnity_SelectIonTokenWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType CesiumForUnity_SelectIonTokenWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgDelegate = new CesiumForUnity_SelectIonTokenWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType(CesiumForUnity_SelectIonTokenWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2Wg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_SelectIonTokenWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType))]
        private static unsafe byte CesiumForUnity_SelectIonTokenWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2Wg(System.IntPtr x, System.IntPtr y)
        {
            
            var result = ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(x)!) != ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(y)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_SelectIonTokenWindow_CallRefreshExistingTokenList_1B2M2Y8AsgTpgAmY7PhCfgType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_SelectIonTokenWindow_CallRefreshExistingTokenList_1B2M2Y8AsgTpgAmY7PhCfgType CesiumForUnity_SelectIonTokenWindow_CallRefreshExistingTokenList_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new CesiumForUnity_SelectIonTokenWindow_CallRefreshExistingTokenList_1B2M2Y8AsgTpgAmY7PhCfgType(CesiumForUnity_SelectIonTokenWindow_CallRefreshExistingTokenList_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_SelectIonTokenWindow_CallRefreshExistingTokenList_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe void CesiumForUnity_SelectIonTokenWindow_CallRefreshExistingTokenList_1B2M2Y8AsgTpgAmY7PhCfg(System.IntPtr thiz)
        {
            ((CesiumForUnity.SelectIonTokenWindow)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).RefreshExistingTokenList();
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_SelectIonTokenWindow_CallShowWindow_1B2M2Y8AsgTpgAmY7PhCfgType();
        private static unsafe readonly CesiumForUnity_SelectIonTokenWindow_CallShowWindow_1B2M2Y8AsgTpgAmY7PhCfgType CesiumForUnity_SelectIonTokenWindow_CallShowWindow_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new CesiumForUnity_SelectIonTokenWindow_CallShowWindow_1B2M2Y8AsgTpgAmY7PhCfgType(CesiumForUnity_SelectIonTokenWindow_CallShowWindow_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_SelectIonTokenWindow_CallShowWindow_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe void CesiumForUnity_SelectIonTokenWindow_CallShowWindow_1B2M2Y8AsgTpgAmY7PhCfg()
        {
            CesiumForUnity.SelectIonTokenWindow.ShowWindow();
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_SelectIonTokenWindow_Field_get_currentWindowType();
        private static unsafe readonly CesiumForUnity_SelectIonTokenWindow_Field_get_currentWindowType CesiumForUnity_SelectIonTokenWindow_Field_get_currentWindowDelegate = new CesiumForUnity_SelectIonTokenWindow_Field_get_currentWindowType(CesiumForUnity_SelectIonTokenWindow_Field_get_currentWindow);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_SelectIonTokenWindow_Field_get_currentWindowType))]
        private static unsafe System.IntPtr CesiumForUnity_SelectIonTokenWindow_Field_get_currentWindow()
        {
            var result = CesiumForUnity.SelectIonTokenWindow.currentWindow;
          return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_SelectIonTokenWindow_Field_set_currentWindowType(System.IntPtr value);
        private static unsafe readonly CesiumForUnity_SelectIonTokenWindow_Field_set_currentWindowType CesiumForUnity_SelectIonTokenWindow_Field_set_currentWindowDelegate = new CesiumForUnity_SelectIonTokenWindow_Field_set_currentWindowType(CesiumForUnity_SelectIonTokenWindow_Field_set_currentWindow);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_SelectIonTokenWindow_Field_set_currentWindowType))]
        private static unsafe void CesiumForUnity_SelectIonTokenWindow_Field_set_currentWindow(System.IntPtr value)
        {
            CesiumForUnity.SelectIonTokenWindow.currentWindow = (CesiumForUnity.SelectIonTokenWindow)Reinterop.ObjectHandleUtility.GetObjectFromHandle(value)!;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_SelectIonTokenWindow_Property_get_createdTokenNameType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_SelectIonTokenWindow_Property_get_createdTokenNameType CesiumForUnity_SelectIonTokenWindow_Property_get_createdTokenNameDelegate = new CesiumForUnity_SelectIonTokenWindow_Property_get_createdTokenNameType(CesiumForUnity_SelectIonTokenWindow_Property_get_createdTokenName);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_SelectIonTokenWindow_Property_get_createdTokenNameType))]
        private static unsafe System.IntPtr CesiumForUnity_SelectIonTokenWindow_Property_get_createdTokenName(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.SelectIonTokenWindow)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).createdTokenName;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_SelectIonTokenWindow_Property_get_NativeImplementationType(IntPtr thiz);
        private static unsafe readonly CesiumForUnity_SelectIonTokenWindow_Property_get_NativeImplementationType CesiumForUnity_SelectIonTokenWindow_Property_get_NativeImplementationDelegate = new CesiumForUnity_SelectIonTokenWindow_Property_get_NativeImplementationType(CesiumForUnity_SelectIonTokenWindow_Property_get_NativeImplementation);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_SelectIonTokenWindow_Property_get_NativeImplementationType))]
        private static unsafe System.IntPtr CesiumForUnity_SelectIonTokenWindow_Property_get_NativeImplementation(IntPtr thiz)
        {
            return ((CesiumForUnity.SelectIonTokenWindow)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).NativeImplementation.DangerousGetHandle();
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate int CesiumForUnity_SelectIonTokenWindow_Property_get_selectedExistingTokenIndexType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_SelectIonTokenWindow_Property_get_selectedExistingTokenIndexType CesiumForUnity_SelectIonTokenWindow_Property_get_selectedExistingTokenIndexDelegate = new CesiumForUnity_SelectIonTokenWindow_Property_get_selectedExistingTokenIndexType(CesiumForUnity_SelectIonTokenWindow_Property_get_selectedExistingTokenIndex);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_SelectIonTokenWindow_Property_get_selectedExistingTokenIndexType))]
        private static unsafe int CesiumForUnity_SelectIonTokenWindow_Property_get_selectedExistingTokenIndex(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.SelectIonTokenWindow)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).selectedExistingTokenIndex;
            
            return result;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_SelectIonTokenWindow_Property_get_specifiedTokenType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_SelectIonTokenWindow_Property_get_specifiedTokenType CesiumForUnity_SelectIonTokenWindow_Property_get_specifiedTokenDelegate = new CesiumForUnity_SelectIonTokenWindow_Property_get_specifiedTokenType(CesiumForUnity_SelectIonTokenWindow_Property_get_specifiedToken);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_SelectIonTokenWindow_Property_get_specifiedTokenType))]
        private static unsafe System.IntPtr CesiumForUnity_SelectIonTokenWindow_Property_get_specifiedToken(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.SelectIonTokenWindow)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).specifiedToken;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate CesiumForUnity.IonTokenSource CesiumForUnity_SelectIonTokenWindow_Property_get_tokenSourceType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_SelectIonTokenWindow_Property_get_tokenSourceType CesiumForUnity_SelectIonTokenWindow_Property_get_tokenSourceDelegate = new CesiumForUnity_SelectIonTokenWindow_Property_get_tokenSourceType(CesiumForUnity_SelectIonTokenWindow_Property_get_tokenSource);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_SelectIonTokenWindow_Property_get_tokenSourceType))]
        private static unsafe CesiumForUnity.IonTokenSource CesiumForUnity_SelectIonTokenWindow_Property_get_tokenSource(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.SelectIonTokenWindow)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).tokenSource;
            
            return result;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_SelectIonTokenWindow_Property_set_createdTokenNameType(System.IntPtr thiz, System.IntPtr value);
        private static unsafe readonly CesiumForUnity_SelectIonTokenWindow_Property_set_createdTokenNameType CesiumForUnity_SelectIonTokenWindow_Property_set_createdTokenNameDelegate = new CesiumForUnity_SelectIonTokenWindow_Property_set_createdTokenNameType(CesiumForUnity_SelectIonTokenWindow_Property_set_createdTokenName);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_SelectIonTokenWindow_Property_set_createdTokenNameType))]
        private static unsafe void CesiumForUnity_SelectIonTokenWindow_Property_set_createdTokenName(System.IntPtr thiz, System.IntPtr value)
        {
            ((CesiumForUnity.SelectIonTokenWindow)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).createdTokenName = (string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(value)!;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_SelectIonTokenWindow_Property_set_selectedExistingTokenIndexType(System.IntPtr thiz, int value);
        private static unsafe readonly CesiumForUnity_SelectIonTokenWindow_Property_set_selectedExistingTokenIndexType CesiumForUnity_SelectIonTokenWindow_Property_set_selectedExistingTokenIndexDelegate = new CesiumForUnity_SelectIonTokenWindow_Property_set_selectedExistingTokenIndexType(CesiumForUnity_SelectIonTokenWindow_Property_set_selectedExistingTokenIndex);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_SelectIonTokenWindow_Property_set_selectedExistingTokenIndexType))]
        private static unsafe void CesiumForUnity_SelectIonTokenWindow_Property_set_selectedExistingTokenIndex(System.IntPtr thiz, int value)
        {
            ((CesiumForUnity.SelectIonTokenWindow)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).selectedExistingTokenIndex = value;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_SelectIonTokenWindow_Property_set_specifiedTokenType(System.IntPtr thiz, System.IntPtr value);
        private static unsafe readonly CesiumForUnity_SelectIonTokenWindow_Property_set_specifiedTokenType CesiumForUnity_SelectIonTokenWindow_Property_set_specifiedTokenDelegate = new CesiumForUnity_SelectIonTokenWindow_Property_set_specifiedTokenType(CesiumForUnity_SelectIonTokenWindow_Property_set_specifiedToken);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_SelectIonTokenWindow_Property_set_specifiedTokenType))]
        private static unsafe void CesiumForUnity_SelectIonTokenWindow_Property_set_specifiedToken(System.IntPtr thiz, System.IntPtr value)
        {
            ((CesiumForUnity.SelectIonTokenWindow)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).specifiedToken = (string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(value)!;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_SelectIonTokenWindow_Property_set_tokenSourceType(System.IntPtr thiz, CesiumForUnity.IonTokenSource value);
        private static unsafe readonly CesiumForUnity_SelectIonTokenWindow_Property_set_tokenSourceType CesiumForUnity_SelectIonTokenWindow_Property_set_tokenSourceDelegate = new CesiumForUnity_SelectIonTokenWindow_Property_set_tokenSourceType(CesiumForUnity_SelectIonTokenWindow_Property_set_tokenSource);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_SelectIonTokenWindow_Property_set_tokenSourceType))]
        private static unsafe void CesiumForUnity_SelectIonTokenWindow_Property_set_tokenSource(System.IntPtr thiz, CesiumForUnity.IonTokenSource value)
        {
            ((CesiumForUnity.SelectIonTokenWindow)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).tokenSource = value;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte CesiumForUnity_TokenTroubleshootingDetails_Property_get_allowsAccessToAssetType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_TokenTroubleshootingDetails_Property_get_allowsAccessToAssetType CesiumForUnity_TokenTroubleshootingDetails_Property_get_allowsAccessToAssetDelegate = new CesiumForUnity_TokenTroubleshootingDetails_Property_get_allowsAccessToAssetType(CesiumForUnity_TokenTroubleshootingDetails_Property_get_allowsAccessToAsset);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_TokenTroubleshootingDetails_Property_get_allowsAccessToAssetType))]
        private static unsafe byte CesiumForUnity_TokenTroubleshootingDetails_Property_get_allowsAccessToAsset(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.TokenTroubleshootingDetails)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).allowsAccessToAsset;
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte CesiumForUnity_TokenTroubleshootingDetails_Property_get_associatedWithUserAccountType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_TokenTroubleshootingDetails_Property_get_associatedWithUserAccountType CesiumForUnity_TokenTroubleshootingDetails_Property_get_associatedWithUserAccountDelegate = new CesiumForUnity_TokenTroubleshootingDetails_Property_get_associatedWithUserAccountType(CesiumForUnity_TokenTroubleshootingDetails_Property_get_associatedWithUserAccount);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_TokenTroubleshootingDetails_Property_get_associatedWithUserAccountType))]
        private static unsafe byte CesiumForUnity_TokenTroubleshootingDetails_Property_get_associatedWithUserAccount(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.TokenTroubleshootingDetails)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).associatedWithUserAccount;
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte CesiumForUnity_TokenTroubleshootingDetails_Property_get_isValidType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_TokenTroubleshootingDetails_Property_get_isValidType CesiumForUnity_TokenTroubleshootingDetails_Property_get_isValidDelegate = new CesiumForUnity_TokenTroubleshootingDetails_Property_get_isValidType(CesiumForUnity_TokenTroubleshootingDetails_Property_get_isValid);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_TokenTroubleshootingDetails_Property_get_isValidType))]
        private static unsafe byte CesiumForUnity_TokenTroubleshootingDetails_Property_get_isValid(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.TokenTroubleshootingDetails)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).isValid;
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte CesiumForUnity_TokenTroubleshootingDetails_Property_get_loadedType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_TokenTroubleshootingDetails_Property_get_loadedType CesiumForUnity_TokenTroubleshootingDetails_Property_get_loadedDelegate = new CesiumForUnity_TokenTroubleshootingDetails_Property_get_loadedType(CesiumForUnity_TokenTroubleshootingDetails_Property_get_loaded);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_TokenTroubleshootingDetails_Property_get_loadedType))]
        private static unsafe byte CesiumForUnity_TokenTroubleshootingDetails_Property_get_loaded(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.TokenTroubleshootingDetails)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).loaded;
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_TokenTroubleshootingDetails_Property_get_tokenType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_TokenTroubleshootingDetails_Property_get_tokenType CesiumForUnity_TokenTroubleshootingDetails_Property_get_tokenDelegate = new CesiumForUnity_TokenTroubleshootingDetails_Property_get_tokenType(CesiumForUnity_TokenTroubleshootingDetails_Property_get_token);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_TokenTroubleshootingDetails_Property_get_tokenType))]
        private static unsafe System.IntPtr CesiumForUnity_TokenTroubleshootingDetails_Property_get_token(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.TokenTroubleshootingDetails)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).token;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_TokenTroubleshootingDetails_Property_set_allowsAccessToAssetType(System.IntPtr thiz, byte value);
        private static unsafe readonly CesiumForUnity_TokenTroubleshootingDetails_Property_set_allowsAccessToAssetType CesiumForUnity_TokenTroubleshootingDetails_Property_set_allowsAccessToAssetDelegate = new CesiumForUnity_TokenTroubleshootingDetails_Property_set_allowsAccessToAssetType(CesiumForUnity_TokenTroubleshootingDetails_Property_set_allowsAccessToAsset);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_TokenTroubleshootingDetails_Property_set_allowsAccessToAssetType))]
        private static unsafe void CesiumForUnity_TokenTroubleshootingDetails_Property_set_allowsAccessToAsset(System.IntPtr thiz, byte value)
        {
            ((CesiumForUnity.TokenTroubleshootingDetails)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).allowsAccessToAsset = value != 0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_TokenTroubleshootingDetails_Property_set_associatedWithUserAccountType(System.IntPtr thiz, byte value);
        private static unsafe readonly CesiumForUnity_TokenTroubleshootingDetails_Property_set_associatedWithUserAccountType CesiumForUnity_TokenTroubleshootingDetails_Property_set_associatedWithUserAccountDelegate = new CesiumForUnity_TokenTroubleshootingDetails_Property_set_associatedWithUserAccountType(CesiumForUnity_TokenTroubleshootingDetails_Property_set_associatedWithUserAccount);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_TokenTroubleshootingDetails_Property_set_associatedWithUserAccountType))]
        private static unsafe void CesiumForUnity_TokenTroubleshootingDetails_Property_set_associatedWithUserAccount(System.IntPtr thiz, byte value)
        {
            ((CesiumForUnity.TokenTroubleshootingDetails)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).associatedWithUserAccount = value != 0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_TokenTroubleshootingDetails_Property_set_isValidType(System.IntPtr thiz, byte value);
        private static unsafe readonly CesiumForUnity_TokenTroubleshootingDetails_Property_set_isValidType CesiumForUnity_TokenTroubleshootingDetails_Property_set_isValidDelegate = new CesiumForUnity_TokenTroubleshootingDetails_Property_set_isValidType(CesiumForUnity_TokenTroubleshootingDetails_Property_set_isValid);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_TokenTroubleshootingDetails_Property_set_isValidType))]
        private static unsafe void CesiumForUnity_TokenTroubleshootingDetails_Property_set_isValid(System.IntPtr thiz, byte value)
        {
            ((CesiumForUnity.TokenTroubleshootingDetails)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).isValid = value != 0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_TokenTroubleshootingDetails_Property_set_loadedType(System.IntPtr thiz, byte value);
        private static unsafe readonly CesiumForUnity_TokenTroubleshootingDetails_Property_set_loadedType CesiumForUnity_TokenTroubleshootingDetails_Property_set_loadedDelegate = new CesiumForUnity_TokenTroubleshootingDetails_Property_set_loadedType(CesiumForUnity_TokenTroubleshootingDetails_Property_set_loaded);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_TokenTroubleshootingDetails_Property_set_loadedType))]
        private static unsafe void CesiumForUnity_TokenTroubleshootingDetails_Property_set_loaded(System.IntPtr thiz, byte value)
        {
            ((CesiumForUnity.TokenTroubleshootingDetails)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).loaded = value != 0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_TokenTroubleshootingDetails_Property_set_tokenType(System.IntPtr thiz, System.IntPtr value);
        private static unsafe readonly CesiumForUnity_TokenTroubleshootingDetails_Property_set_tokenType CesiumForUnity_TokenTroubleshootingDetails_Property_set_tokenDelegate = new CesiumForUnity_TokenTroubleshootingDetails_Property_set_tokenType(CesiumForUnity_TokenTroubleshootingDetails_Property_set_token);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_TokenTroubleshootingDetails_Property_set_tokenType))]
        private static unsafe void CesiumForUnity_TokenTroubleshootingDetails_Property_set_token(System.IntPtr thiz, System.IntPtr value)
        {
            ((CesiumForUnity.TokenTroubleshootingDetails)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).token = (string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(value)!;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr Reinterop_ObjectHandleUtility_CallCopyHandle_Lk0gUmdC13dRVZ_MAT71egType(System.IntPtr handle);
        private static unsafe readonly Reinterop_ObjectHandleUtility_CallCopyHandle_Lk0gUmdC13dRVZ_MAT71egType Reinterop_ObjectHandleUtility_CallCopyHandle_Lk0gUmdC13dRVZ_MAT71egDelegate = new Reinterop_ObjectHandleUtility_CallCopyHandle_Lk0gUmdC13dRVZ_MAT71egType(Reinterop_ObjectHandleUtility_CallCopyHandle_Lk0gUmdC13dRVZ_MAT71eg);
        [AOT.MonoPInvokeCallback(typeof(Reinterop_ObjectHandleUtility_CallCopyHandle_Lk0gUmdC13dRVZ_MAT71egType))]
        private static unsafe System.IntPtr Reinterop_ObjectHandleUtility_CallCopyHandle_Lk0gUmdC13dRVZ_MAT71eg(System.IntPtr handle)
        {
            
            var result = Reinterop.ObjectHandleUtility.CopyHandle(handle);
            
            return result;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr Reinterop_ObjectHandleUtility_CallCreateHandle_vjOnn8y5DjvqKs3467vAJQType(System.IntPtr o);
        private static unsafe readonly Reinterop_ObjectHandleUtility_CallCreateHandle_vjOnn8y5DjvqKs3467vAJQType Reinterop_ObjectHandleUtility_CallCreateHandle_vjOnn8y5DjvqKs3467vAJQDelegate = new Reinterop_ObjectHandleUtility_CallCreateHandle_vjOnn8y5DjvqKs3467vAJQType(Reinterop_ObjectHandleUtility_CallCreateHandle_vjOnn8y5DjvqKs3467vAJQ);
        [AOT.MonoPInvokeCallback(typeof(Reinterop_ObjectHandleUtility_CallCreateHandle_vjOnn8y5DjvqKs3467vAJQType))]
        private static unsafe System.IntPtr Reinterop_ObjectHandleUtility_CallCreateHandle_vjOnn8y5DjvqKs3467vAJQ(System.IntPtr o)
        {
            
            var result = Reinterop.ObjectHandleUtility.CreateHandle((object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(o)!);
            
            return result;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void Reinterop_ObjectHandleUtility_CallFreeHandle_Lk0gUmdC13dRVZ_MAT71egType(System.IntPtr handle);
        private static unsafe readonly Reinterop_ObjectHandleUtility_CallFreeHandle_Lk0gUmdC13dRVZ_MAT71egType Reinterop_ObjectHandleUtility_CallFreeHandle_Lk0gUmdC13dRVZ_MAT71egDelegate = new Reinterop_ObjectHandleUtility_CallFreeHandle_Lk0gUmdC13dRVZ_MAT71egType(Reinterop_ObjectHandleUtility_CallFreeHandle_Lk0gUmdC13dRVZ_MAT71eg);
        [AOT.MonoPInvokeCallback(typeof(Reinterop_ObjectHandleUtility_CallFreeHandle_Lk0gUmdC13dRVZ_MAT71egType))]
        private static unsafe void Reinterop_ObjectHandleUtility_CallFreeHandle_Lk0gUmdC13dRVZ_MAT71eg(System.IntPtr handle)
        {
            Reinterop.ObjectHandleUtility.FreeHandle(handle);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void System_Action_CallInvoke_1B2M2Y8AsgTpgAmY7PhCfgType(System.IntPtr thiz);
        private static unsafe readonly System_Action_CallInvoke_1B2M2Y8AsgTpgAmY7PhCfgType System_Action_CallInvoke_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new System_Action_CallInvoke_1B2M2Y8AsgTpgAmY7PhCfgType(System_Action_CallInvoke_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(System_Action_CallInvoke_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe void System_Action_CallInvoke_1B2M2Y8AsgTpgAmY7PhCfg(System.IntPtr thiz)
        {
            ((System.Action)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).Invoke();
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte System_Action_Callop_Equality__iYzpyUo7S__gDd8L5jFzrgType(System.IntPtr d1, System.IntPtr d2);
        private static unsafe readonly System_Action_Callop_Equality__iYzpyUo7S__gDd8L5jFzrgType System_Action_Callop_Equality__iYzpyUo7S__gDd8L5jFzrgDelegate = new System_Action_Callop_Equality__iYzpyUo7S__gDd8L5jFzrgType(System_Action_Callop_Equality__iYzpyUo7S__gDd8L5jFzrg);
        [AOT.MonoPInvokeCallback(typeof(System_Action_Callop_Equality__iYzpyUo7S__gDd8L5jFzrgType))]
        private static unsafe byte System_Action_Callop_Equality__iYzpyUo7S__gDd8L5jFzrg(System.IntPtr d1, System.IntPtr d2)
        {
            
            var result = ((System.MulticastDelegate)Reinterop.ObjectHandleUtility.GetObjectFromHandle(d1)!) == ((System.MulticastDelegate)Reinterop.ObjectHandleUtility.GetObjectFromHandle(d2)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte System_Action_Callop_Equality_a0RmOPC1vpOfulhhfnafBAType(System.IntPtr d1, System.IntPtr d2);
        private static unsafe readonly System_Action_Callop_Equality_a0RmOPC1vpOfulhhfnafBAType System_Action_Callop_Equality_a0RmOPC1vpOfulhhfnafBADelegate = new System_Action_Callop_Equality_a0RmOPC1vpOfulhhfnafBAType(System_Action_Callop_Equality_a0RmOPC1vpOfulhhfnafBA);
        [AOT.MonoPInvokeCallback(typeof(System_Action_Callop_Equality_a0RmOPC1vpOfulhhfnafBAType))]
        private static unsafe byte System_Action_Callop_Equality_a0RmOPC1vpOfulhhfnafBA(System.IntPtr d1, System.IntPtr d2)
        {
            
            var result = ((System.Delegate)Reinterop.ObjectHandleUtility.GetObjectFromHandle(d1)!) == ((System.Delegate)Reinterop.ObjectHandleUtility.GetObjectFromHandle(d2)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte System_Action_Callop_Inequality__iYzpyUo7S__gDd8L5jFzrgType(System.IntPtr d1, System.IntPtr d2);
        private static unsafe readonly System_Action_Callop_Inequality__iYzpyUo7S__gDd8L5jFzrgType System_Action_Callop_Inequality__iYzpyUo7S__gDd8L5jFzrgDelegate = new System_Action_Callop_Inequality__iYzpyUo7S__gDd8L5jFzrgType(System_Action_Callop_Inequality__iYzpyUo7S__gDd8L5jFzrg);
        [AOT.MonoPInvokeCallback(typeof(System_Action_Callop_Inequality__iYzpyUo7S__gDd8L5jFzrgType))]
        private static unsafe byte System_Action_Callop_Inequality__iYzpyUo7S__gDd8L5jFzrg(System.IntPtr d1, System.IntPtr d2)
        {
            
            var result = ((System.MulticastDelegate)Reinterop.ObjectHandleUtility.GetObjectFromHandle(d1)!) != ((System.MulticastDelegate)Reinterop.ObjectHandleUtility.GetObjectFromHandle(d2)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte System_Action_Callop_Inequality_a0RmOPC1vpOfulhhfnafBAType(System.IntPtr d1, System.IntPtr d2);
        private static unsafe readonly System_Action_Callop_Inequality_a0RmOPC1vpOfulhhfnafBAType System_Action_Callop_Inequality_a0RmOPC1vpOfulhhfnafBADelegate = new System_Action_Callop_Inequality_a0RmOPC1vpOfulhhfnafBAType(System_Action_Callop_Inequality_a0RmOPC1vpOfulhhfnafBA);
        [AOT.MonoPInvokeCallback(typeof(System_Action_Callop_Inequality_a0RmOPC1vpOfulhhfnafBAType))]
        private static unsafe byte System_Action_Callop_Inequality_a0RmOPC1vpOfulhhfnafBA(System.IntPtr d1, System.IntPtr d2)
        {
            
            var result = ((System.Delegate)Reinterop.ObjectHandleUtility.GetObjectFromHandle(d1)!) != ((System.Delegate)Reinterop.ObjectHandleUtility.GetObjectFromHandle(d2)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr System_Action_CombineDelegatesType(System.IntPtr thiz, System.IntPtr rhs);
        private static unsafe readonly System_Action_CombineDelegatesType System_Action_CombineDelegatesDelegate = new System_Action_CombineDelegatesType(System_Action_CombineDelegates);
        [AOT.MonoPInvokeCallback(typeof(System_Action_CombineDelegatesType))]
        private static unsafe System.IntPtr System_Action_CombineDelegates(System.IntPtr thiz, System.IntPtr rhs)
        {
            System.Action left = (System.Action)ObjectHandleUtility.GetObjectFromHandle(thiz)!;
            System.Action right = (System.Action)ObjectHandleUtility.GetObjectFromHandle(rhs)!;
            return ObjectHandleUtility.CreateHandle(left + right);
        }
        private class ActionNativeFunction : System.IDisposable
        {
            private IntPtr _callbackFunction;
        
            public ActionNativeFunction(IntPtr callbackFunction)
            {
                _callbackFunction = callbackFunction;
            }
        
            ~ActionNativeFunction()
            {
                Dispose(false);
            }
        
            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }
        
            private void Dispose(bool disposing)
            {
                if (_callbackFunction != IntPtr.Zero)
                {
                    System_Action_DisposeCallback(_callbackFunction);
                    _callbackFunction = IntPtr.Zero;
                }
            }
        
            public void Invoke()
            {
                if (_callbackFunction == null)
                    throw new System.ObjectDisposedException("Action");
        
                System_Action_InvokeCallback(_callbackFunction);
                return;;
            }
        
            [System.Runtime.InteropServices.DllImport("CesiumForUnityNative-Editor", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
            private static extern void System_Action_DisposeCallback(IntPtr callbackFunction);
            [System.Runtime.InteropServices.DllImport("CesiumForUnityNative-Editor", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
            private static extern void System_Action_InvokeCallback(IntPtr callbackFunction);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate IntPtr System_Action_CreateDelegateType(IntPtr callbackFunction);
        private static unsafe readonly System_Action_CreateDelegateType System_Action_CreateDelegateDelegate = new System_Action_CreateDelegateType(System_Action_CreateDelegate);
        [AOT.MonoPInvokeCallback(typeof(System_Action_CreateDelegateType))]
        private static unsafe IntPtr System_Action_CreateDelegate(IntPtr callbackFunction)
        {
            var receiver = new ActionNativeFunction(callbackFunction);
            return Reinterop.ObjectHandleUtility.CreateHandle(new System.Action(receiver.Invoke));
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr System_Action_RemoveDelegateType(System.IntPtr thiz, System.IntPtr rhs);
        private static unsafe readonly System_Action_RemoveDelegateType System_Action_RemoveDelegateDelegate = new System_Action_RemoveDelegateType(System_Action_RemoveDelegate);
        [AOT.MonoPInvokeCallback(typeof(System_Action_RemoveDelegateType))]
        private static unsafe System.IntPtr System_Action_RemoveDelegate(System.IntPtr thiz, System.IntPtr rhs)
        {
            System.Action left = (System.Action)ObjectHandleUtility.GetObjectFromHandle(thiz)!;
            System.Action right = (System.Action)ObjectHandleUtility.GetObjectFromHandle(rhs)!;
            return ObjectHandleUtility.CreateHandle(left - right);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void System_ActionA2lFbwI_1jdffaYu1u_OZg_CallInvoke_GZtSECpzDV__dvLP8ujKEdAType(System.IntPtr thiz, System.IntPtr obj);
        private static unsafe readonly System_ActionA2lFbwI_1jdffaYu1u_OZg_CallInvoke_GZtSECpzDV__dvLP8ujKEdAType System_ActionA2lFbwI_1jdffaYu1u_OZg_CallInvoke_GZtSECpzDV__dvLP8ujKEdADelegate = new System_ActionA2lFbwI_1jdffaYu1u_OZg_CallInvoke_GZtSECpzDV__dvLP8ujKEdAType(System_ActionA2lFbwI_1jdffaYu1u_OZg_CallInvoke_GZtSECpzDV__dvLP8ujKEdA);
        [AOT.MonoPInvokeCallback(typeof(System_ActionA2lFbwI_1jdffaYu1u_OZg_CallInvoke_GZtSECpzDV__dvLP8ujKEdAType))]
        private static unsafe void System_ActionA2lFbwI_1jdffaYu1u_OZg_CallInvoke_GZtSECpzDV__dvLP8ujKEdA(System.IntPtr thiz, System.IntPtr obj)
        {
            ((System.Action<UnityEngine.AsyncOperation>)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).Invoke((UnityEngine.AsyncOperation)Reinterop.ObjectHandleUtility.GetObjectFromHandle(obj)!);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Equality__iYzpyUo7S__gDd8L5jFzrgType(System.IntPtr d1, System.IntPtr d2);
        private static unsafe readonly System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Equality__iYzpyUo7S__gDd8L5jFzrgType System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Equality__iYzpyUo7S__gDd8L5jFzrgDelegate = new System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Equality__iYzpyUo7S__gDd8L5jFzrgType(System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Equality__iYzpyUo7S__gDd8L5jFzrg);
        [AOT.MonoPInvokeCallback(typeof(System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Equality__iYzpyUo7S__gDd8L5jFzrgType))]
        private static unsafe byte System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Equality__iYzpyUo7S__gDd8L5jFzrg(System.IntPtr d1, System.IntPtr d2)
        {
            
            var result = ((System.MulticastDelegate)Reinterop.ObjectHandleUtility.GetObjectFromHandle(d1)!) == ((System.MulticastDelegate)Reinterop.ObjectHandleUtility.GetObjectFromHandle(d2)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Equality_a0RmOPC1vpOfulhhfnafBAType(System.IntPtr d1, System.IntPtr d2);
        private static unsafe readonly System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Equality_a0RmOPC1vpOfulhhfnafBAType System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Equality_a0RmOPC1vpOfulhhfnafBADelegate = new System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Equality_a0RmOPC1vpOfulhhfnafBAType(System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Equality_a0RmOPC1vpOfulhhfnafBA);
        [AOT.MonoPInvokeCallback(typeof(System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Equality_a0RmOPC1vpOfulhhfnafBAType))]
        private static unsafe byte System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Equality_a0RmOPC1vpOfulhhfnafBA(System.IntPtr d1, System.IntPtr d2)
        {
            
            var result = ((System.Delegate)Reinterop.ObjectHandleUtility.GetObjectFromHandle(d1)!) == ((System.Delegate)Reinterop.ObjectHandleUtility.GetObjectFromHandle(d2)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Inequality__iYzpyUo7S__gDd8L5jFzrgType(System.IntPtr d1, System.IntPtr d2);
        private static unsafe readonly System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Inequality__iYzpyUo7S__gDd8L5jFzrgType System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Inequality__iYzpyUo7S__gDd8L5jFzrgDelegate = new System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Inequality__iYzpyUo7S__gDd8L5jFzrgType(System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Inequality__iYzpyUo7S__gDd8L5jFzrg);
        [AOT.MonoPInvokeCallback(typeof(System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Inequality__iYzpyUo7S__gDd8L5jFzrgType))]
        private static unsafe byte System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Inequality__iYzpyUo7S__gDd8L5jFzrg(System.IntPtr d1, System.IntPtr d2)
        {
            
            var result = ((System.MulticastDelegate)Reinterop.ObjectHandleUtility.GetObjectFromHandle(d1)!) != ((System.MulticastDelegate)Reinterop.ObjectHandleUtility.GetObjectFromHandle(d2)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Inequality_a0RmOPC1vpOfulhhfnafBAType(System.IntPtr d1, System.IntPtr d2);
        private static unsafe readonly System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Inequality_a0RmOPC1vpOfulhhfnafBAType System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Inequality_a0RmOPC1vpOfulhhfnafBADelegate = new System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Inequality_a0RmOPC1vpOfulhhfnafBAType(System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Inequality_a0RmOPC1vpOfulhhfnafBA);
        [AOT.MonoPInvokeCallback(typeof(System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Inequality_a0RmOPC1vpOfulhhfnafBAType))]
        private static unsafe byte System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Inequality_a0RmOPC1vpOfulhhfnafBA(System.IntPtr d1, System.IntPtr d2)
        {
            
            var result = ((System.Delegate)Reinterop.ObjectHandleUtility.GetObjectFromHandle(d1)!) != ((System.Delegate)Reinterop.ObjectHandleUtility.GetObjectFromHandle(d2)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr System_ActionA2lFbwI_1jdffaYu1u_OZg_CombineDelegatesType(System.IntPtr thiz, System.IntPtr rhs);
        private static unsafe readonly System_ActionA2lFbwI_1jdffaYu1u_OZg_CombineDelegatesType System_ActionA2lFbwI_1jdffaYu1u_OZg_CombineDelegatesDelegate = new System_ActionA2lFbwI_1jdffaYu1u_OZg_CombineDelegatesType(System_ActionA2lFbwI_1jdffaYu1u_OZg_CombineDelegates);
        [AOT.MonoPInvokeCallback(typeof(System_ActionA2lFbwI_1jdffaYu1u_OZg_CombineDelegatesType))]
        private static unsafe System.IntPtr System_ActionA2lFbwI_1jdffaYu1u_OZg_CombineDelegates(System.IntPtr thiz, System.IntPtr rhs)
        {
            System.Action<UnityEngine.AsyncOperation> left = (System.Action<UnityEngine.AsyncOperation>)ObjectHandleUtility.GetObjectFromHandle(thiz)!;
            System.Action<UnityEngine.AsyncOperation> right = (System.Action<UnityEngine.AsyncOperation>)ObjectHandleUtility.GetObjectFromHandle(rhs)!;
            return ObjectHandleUtility.CreateHandle(left + right);
        }
        private class ActionA2lFbwI_1jdffaYu1u_OZgNativeFunction : System.IDisposable
        {
            private IntPtr _callbackFunction;
        
            public ActionA2lFbwI_1jdffaYu1u_OZgNativeFunction(IntPtr callbackFunction)
            {
                _callbackFunction = callbackFunction;
            }
        
            ~ActionA2lFbwI_1jdffaYu1u_OZgNativeFunction()
            {
                Dispose(false);
            }
        
            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }
        
            private void Dispose(bool disposing)
            {
                if (_callbackFunction != IntPtr.Zero)
                {
                    System_ActionA2lFbwI_1jdffaYu1u_OZg_DisposeCallback(_callbackFunction);
                    _callbackFunction = IntPtr.Zero;
                }
            }
        
            public void Invoke(UnityEngine.AsyncOperation obj)
            {
                if (_callbackFunction == null)
                    throw new System.ObjectDisposedException("Action");
        
                System_ActionA2lFbwI_1jdffaYu1u_OZg_InvokeCallback(_callbackFunction, Reinterop.ObjectHandleUtility.CreateHandle(obj));
                return;;
            }
        
            [System.Runtime.InteropServices.DllImport("CesiumForUnityNative-Editor", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
            private static extern void System_ActionA2lFbwI_1jdffaYu1u_OZg_DisposeCallback(IntPtr callbackFunction);
            [System.Runtime.InteropServices.DllImport("CesiumForUnityNative-Editor", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
            private static extern void System_ActionA2lFbwI_1jdffaYu1u_OZg_InvokeCallback(IntPtr callbackFunction, System.IntPtr obj);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate IntPtr System_ActionA2lFbwI_1jdffaYu1u_OZg_CreateDelegateType(IntPtr callbackFunction);
        private static unsafe readonly System_ActionA2lFbwI_1jdffaYu1u_OZg_CreateDelegateType System_ActionA2lFbwI_1jdffaYu1u_OZg_CreateDelegateDelegate = new System_ActionA2lFbwI_1jdffaYu1u_OZg_CreateDelegateType(System_ActionA2lFbwI_1jdffaYu1u_OZg_CreateDelegate);
        [AOT.MonoPInvokeCallback(typeof(System_ActionA2lFbwI_1jdffaYu1u_OZg_CreateDelegateType))]
        private static unsafe IntPtr System_ActionA2lFbwI_1jdffaYu1u_OZg_CreateDelegate(IntPtr callbackFunction)
        {
            var receiver = new ActionA2lFbwI_1jdffaYu1u_OZgNativeFunction(callbackFunction);
            return Reinterop.ObjectHandleUtility.CreateHandle(new System.Action<UnityEngine.AsyncOperation>(receiver.Invoke));
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr System_ActionA2lFbwI_1jdffaYu1u_OZg_RemoveDelegateType(System.IntPtr thiz, System.IntPtr rhs);
        private static unsafe readonly System_ActionA2lFbwI_1jdffaYu1u_OZg_RemoveDelegateType System_ActionA2lFbwI_1jdffaYu1u_OZg_RemoveDelegateDelegate = new System_ActionA2lFbwI_1jdffaYu1u_OZg_RemoveDelegateType(System_ActionA2lFbwI_1jdffaYu1u_OZg_RemoveDelegate);
        [AOT.MonoPInvokeCallback(typeof(System_ActionA2lFbwI_1jdffaYu1u_OZg_RemoveDelegateType))]
        private static unsafe System.IntPtr System_ActionA2lFbwI_1jdffaYu1u_OZg_RemoveDelegate(System.IntPtr thiz, System.IntPtr rhs)
        {
            System.Action<UnityEngine.AsyncOperation> left = (System.Action<UnityEngine.AsyncOperation>)ObjectHandleUtility.GetObjectFromHandle(thiz)!;
            System.Action<UnityEngine.AsyncOperation> right = (System.Action<UnityEngine.AsyncOperation>)ObjectHandleUtility.GetObjectFromHandle(rhs)!;
            return ObjectHandleUtility.CreateHandle(left - right);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate int System_Array_Property_get_LengthType(System.IntPtr thiz);
        private static unsafe readonly System_Array_Property_get_LengthType System_Array_Property_get_LengthDelegate = new System_Array_Property_get_LengthType(System_Array_Property_get_Length);
        [AOT.MonoPInvokeCallback(typeof(System_Array_Property_get_LengthType))]
        private static unsafe int System_Array_Property_get_Length(System.IntPtr thiz)
        {
            
            var result = ((System.Array)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).Length;
            
            return result;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate IntPtr CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_Constructor_SizeType(System.Int32 size);
        private static unsafe readonly CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_Constructor_SizeType CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_Constructor_SizeDelegate = new CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_Constructor_SizeType(CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_Constructor_Size);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_Constructor_SizeType))]
        private static unsafe IntPtr CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_Constructor_Size(System.Int32 size)
        {
            var result = new CesiumForUnity.Cesium3DTileset[size];
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_Property_get_ItemType(System.IntPtr thiz, int index);
        private static unsafe readonly CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_Property_get_ItemType CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_Property_get_ItemDelegate = new CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_Property_get_ItemType(CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_Property_get_Item);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_Property_get_ItemType))]
        private static unsafe System.IntPtr CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_Property_get_Item(System.IntPtr thiz, int index)
        {
            
            var result = ((CesiumForUnity.Cesium3DTileset[])Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!)[index];
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate int CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_Property_get_LengthType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_Property_get_LengthType CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_Property_get_LengthDelegate = new CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_Property_get_LengthType(CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_Property_get_Length);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_Property_get_LengthType))]
        private static unsafe int CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_Property_get_Length(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.Cesium3DTileset[])Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).Length;
            
            return result;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_SetItemType(System.IntPtr thiz, System.Int32 index, System.IntPtr value);
        private static unsafe readonly CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_SetItemType CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_SetItemDelegate = new CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_SetItemType(CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_SetItem);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_SetItemType))]
        private static unsafe void CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_SetItem(System.IntPtr thiz, System.Int32 index, System.IntPtr value)
        {
            ((CesiumForUnity.Cesium3DTileset[])Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!)[index] = (CesiumForUnity.Cesium3DTileset)Reinterop.ObjectHandleUtility.GetObjectFromHandle(value)!;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate IntPtr CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_Constructor_SizeType(System.Int32 size);
        private static unsafe readonly CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_Constructor_SizeType CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_Constructor_SizeDelegate = new CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_Constructor_SizeType(CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_Constructor_Size);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_Constructor_SizeType))]
        private static unsafe IntPtr CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_Constructor_Size(System.Int32 size)
        {
            var result = new CesiumForUnity.CesiumIonRasterOverlay[size];
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_Property_get_ItemType(System.IntPtr thiz, int index);
        private static unsafe readonly CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_Property_get_ItemType CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_Property_get_ItemDelegate = new CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_Property_get_ItemType(CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_Property_get_Item);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_Property_get_ItemType))]
        private static unsafe System.IntPtr CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_Property_get_Item(System.IntPtr thiz, int index)
        {
            
            var result = ((CesiumForUnity.CesiumIonRasterOverlay[])Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!)[index];
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate int CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_Property_get_LengthType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_Property_get_LengthType CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_Property_get_LengthDelegate = new CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_Property_get_LengthType(CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_Property_get_Length);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_Property_get_LengthType))]
        private static unsafe int CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_Property_get_Length(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.CesiumIonRasterOverlay[])Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).Length;
            
            return result;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_SetItemType(System.IntPtr thiz, System.Int32 index, System.IntPtr value);
        private static unsafe readonly CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_SetItemType CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_SetItemDelegate = new CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_SetItemType(CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_SetItem);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_SetItemType))]
        private static unsafe void CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_SetItem(System.IntPtr thiz, System.Int32 index, System.IntPtr value)
        {
            ((CesiumForUnity.CesiumIonRasterOverlay[])Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!)[index] = (CesiumForUnity.CesiumIonRasterOverlay)Reinterop.ObjectHandleUtility.GetObjectFromHandle(value)!;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate IntPtr CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_Constructor_SizeType(System.Int32 size);
        private static unsafe readonly CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_Constructor_SizeType CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_Constructor_SizeDelegate = new CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_Constructor_SizeType(CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_Constructor_Size);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_Constructor_SizeType))]
        private static unsafe IntPtr CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_Constructor_Size(System.Int32 size)
        {
            var result = new CesiumForUnity.CesiumRasterOverlay[size];
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_Property_get_ItemType(System.IntPtr thiz, int index);
        private static unsafe readonly CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_Property_get_ItemType CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_Property_get_ItemDelegate = new CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_Property_get_ItemType(CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_Property_get_Item);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_Property_get_ItemType))]
        private static unsafe System.IntPtr CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_Property_get_Item(System.IntPtr thiz, int index)
        {
            
            var result = ((CesiumForUnity.CesiumRasterOverlay[])Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!)[index];
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate int CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_Property_get_LengthType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_Property_get_LengthType CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_Property_get_LengthDelegate = new CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_Property_get_LengthType(CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_Property_get_Length);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_Property_get_LengthType))]
        private static unsafe int CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_Property_get_Length(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.CesiumRasterOverlay[])Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).Length;
            
            return result;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_SetItemType(System.IntPtr thiz, System.Int32 index, System.IntPtr value);
        private static unsafe readonly CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_SetItemType CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_SetItemDelegate = new CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_SetItemType(CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_SetItem);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_SetItemType))]
        private static unsafe void CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_SetItem(System.IntPtr thiz, System.Int32 index, System.IntPtr value)
        {
            ((CesiumForUnity.CesiumRasterOverlay[])Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!)[index] = (CesiumForUnity.CesiumRasterOverlay)Reinterop.ObjectHandleUtility.GetObjectFromHandle(value)!;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate IntPtr System_Array1z79ECk55IqLfMIqXBYg_8w_Constructor_SizeType(System.Int32 size);
        private static unsafe readonly System_Array1z79ECk55IqLfMIqXBYg_8w_Constructor_SizeType System_Array1z79ECk55IqLfMIqXBYg_8w_Constructor_SizeDelegate = new System_Array1z79ECk55IqLfMIqXBYg_8w_Constructor_SizeType(System_Array1z79ECk55IqLfMIqXBYg_8w_Constructor_Size);
        [AOT.MonoPInvokeCallback(typeof(System_Array1z79ECk55IqLfMIqXBYg_8w_Constructor_SizeType))]
        private static unsafe IntPtr System_Array1z79ECk55IqLfMIqXBYg_8w_Constructor_Size(System.Int32 size)
        {
            var result = new byte[size];
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate int System_Array1z79ECk55IqLfMIqXBYg_8w_Property_get_LengthType(System.IntPtr thiz);
        private static unsafe readonly System_Array1z79ECk55IqLfMIqXBYg_8w_Property_get_LengthType System_Array1z79ECk55IqLfMIqXBYg_8w_Property_get_LengthDelegate = new System_Array1z79ECk55IqLfMIqXBYg_8w_Property_get_LengthType(System_Array1z79ECk55IqLfMIqXBYg_8w_Property_get_Length);
        [AOT.MonoPInvokeCallback(typeof(System_Array1z79ECk55IqLfMIqXBYg_8w_Property_get_LengthType))]
        private static unsafe int System_Array1z79ECk55IqLfMIqXBYg_8w_Property_get_Length(System.IntPtr thiz)
        {
            
            var result = ((byte[])Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).Length;
            
            return result;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void System_Array1z79ECk55IqLfMIqXBYg_8w_SetItemType(System.IntPtr thiz, System.Int32 index, byte value);
        private static unsafe readonly System_Array1z79ECk55IqLfMIqXBYg_8w_SetItemType System_Array1z79ECk55IqLfMIqXBYg_8w_SetItemDelegate = new System_Array1z79ECk55IqLfMIqXBYg_8w_SetItemType(System_Array1z79ECk55IqLfMIqXBYg_8w_SetItem);
        [AOT.MonoPInvokeCallback(typeof(System_Array1z79ECk55IqLfMIqXBYg_8w_SetItemType))]
        private static unsafe void System_Array1z79ECk55IqLfMIqXBYg_8w_SetItem(System.IntPtr thiz, System.Int32 index, byte value)
        {
            ((byte[])Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!)[index] = value;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr System_Collections_Generic_Dictionary5Hx6c0Eu2sl__zevLSSpjKA_CallGetEnumerator_1B2M2Y8AsgTpgAmY7PhCfgType(System.IntPtr thiz);
        private static unsafe readonly System_Collections_Generic_Dictionary5Hx6c0Eu2sl__zevLSSpjKA_CallGetEnumerator_1B2M2Y8AsgTpgAmY7PhCfgType System_Collections_Generic_Dictionary5Hx6c0Eu2sl__zevLSSpjKA_CallGetEnumerator_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new System_Collections_Generic_Dictionary5Hx6c0Eu2sl__zevLSSpjKA_CallGetEnumerator_1B2M2Y8AsgTpgAmY7PhCfgType(System_Collections_Generic_Dictionary5Hx6c0Eu2sl__zevLSSpjKA_CallGetEnumerator_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(System_Collections_Generic_Dictionary5Hx6c0Eu2sl__zevLSSpjKA_CallGetEnumerator_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe System.IntPtr System_Collections_Generic_Dictionary5Hx6c0Eu2sl__zevLSSpjKA_CallGetEnumerator_1B2M2Y8AsgTpgAmY7PhCfg(System.IntPtr thiz)
        {
            
            var result = ((System.Collections.Generic.Dictionary<string, string>)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).GetEnumerator();
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte System_Collections_Generic_Enumerator1B2M2Y8AsgTpgAmY7PhCfg_CallMoveNext_1B2M2Y8AsgTpgAmY7PhCfgType(System.IntPtr thiz);
        private static unsafe readonly System_Collections_Generic_Enumerator1B2M2Y8AsgTpgAmY7PhCfg_CallMoveNext_1B2M2Y8AsgTpgAmY7PhCfgType System_Collections_Generic_Enumerator1B2M2Y8AsgTpgAmY7PhCfg_CallMoveNext_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new System_Collections_Generic_Enumerator1B2M2Y8AsgTpgAmY7PhCfg_CallMoveNext_1B2M2Y8AsgTpgAmY7PhCfgType(System_Collections_Generic_Enumerator1B2M2Y8AsgTpgAmY7PhCfg_CallMoveNext_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(System_Collections_Generic_Enumerator1B2M2Y8AsgTpgAmY7PhCfg_CallMoveNext_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe byte System_Collections_Generic_Enumerator1B2M2Y8AsgTpgAmY7PhCfg_CallMoveNext_1B2M2Y8AsgTpgAmY7PhCfg(System.IntPtr thiz)
        {
            var thizUnboxed = (System.Collections.Generic.Dictionary<string, string>.Enumerator)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!;
            var result = thizUnboxed.MoveNext();
            Reinterop.ObjectHandleUtility.ResetHandleObject(thiz, thizUnboxed);
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr System_Collections_Generic_Enumerator1B2M2Y8AsgTpgAmY7PhCfg_Property_get_CurrentType(System.IntPtr thiz);
        private static unsafe readonly System_Collections_Generic_Enumerator1B2M2Y8AsgTpgAmY7PhCfg_Property_get_CurrentType System_Collections_Generic_Enumerator1B2M2Y8AsgTpgAmY7PhCfg_Property_get_CurrentDelegate = new System_Collections_Generic_Enumerator1B2M2Y8AsgTpgAmY7PhCfg_Property_get_CurrentType(System_Collections_Generic_Enumerator1B2M2Y8AsgTpgAmY7PhCfg_Property_get_Current);
        [AOT.MonoPInvokeCallback(typeof(System_Collections_Generic_Enumerator1B2M2Y8AsgTpgAmY7PhCfg_Property_get_CurrentType))]
        private static unsafe System.IntPtr System_Collections_Generic_Enumerator1B2M2Y8AsgTpgAmY7PhCfg_Property_get_Current(System.IntPtr thiz)
        {
            var thizUnboxed = (System.Collections.Generic.Dictionary<string, string>.Enumerator)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!;
            var result = thizUnboxed.Current;
            Reinterop.ObjectHandleUtility.ResetHandleObject(thiz, thizUnboxed);
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr System_Collections_Generic_KeyValuePair5Hx6c0Eu2sl__zevLSSpjKA_Property_get_KeyType(System.IntPtr thiz);
        private static unsafe readonly System_Collections_Generic_KeyValuePair5Hx6c0Eu2sl__zevLSSpjKA_Property_get_KeyType System_Collections_Generic_KeyValuePair5Hx6c0Eu2sl__zevLSSpjKA_Property_get_KeyDelegate = new System_Collections_Generic_KeyValuePair5Hx6c0Eu2sl__zevLSSpjKA_Property_get_KeyType(System_Collections_Generic_KeyValuePair5Hx6c0Eu2sl__zevLSSpjKA_Property_get_Key);
        [AOT.MonoPInvokeCallback(typeof(System_Collections_Generic_KeyValuePair5Hx6c0Eu2sl__zevLSSpjKA_Property_get_KeyType))]
        private static unsafe System.IntPtr System_Collections_Generic_KeyValuePair5Hx6c0Eu2sl__zevLSSpjKA_Property_get_Key(System.IntPtr thiz)
        {
            var thizUnboxed = (System.Collections.Generic.KeyValuePair<string, string>)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!;
            var result = thizUnboxed.Key;
            Reinterop.ObjectHandleUtility.ResetHandleObject(thiz, thizUnboxed);
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr System_Collections_Generic_KeyValuePair5Hx6c0Eu2sl__zevLSSpjKA_Property_get_ValueType(System.IntPtr thiz);
        private static unsafe readonly System_Collections_Generic_KeyValuePair5Hx6c0Eu2sl__zevLSSpjKA_Property_get_ValueType System_Collections_Generic_KeyValuePair5Hx6c0Eu2sl__zevLSSpjKA_Property_get_ValueDelegate = new System_Collections_Generic_KeyValuePair5Hx6c0Eu2sl__zevLSSpjKA_Property_get_ValueType(System_Collections_Generic_KeyValuePair5Hx6c0Eu2sl__zevLSSpjKA_Property_get_Value);
        [AOT.MonoPInvokeCallback(typeof(System_Collections_Generic_KeyValuePair5Hx6c0Eu2sl__zevLSSpjKA_Property_get_ValueType))]
        private static unsafe System.IntPtr System_Collections_Generic_KeyValuePair5Hx6c0Eu2sl__zevLSSpjKA_Property_get_Value(System.IntPtr thiz)
        {
            var thizUnboxed = (System.Collections.Generic.KeyValuePair<string, string>)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!;
            var result = thizUnboxed.Value;
            Reinterop.ObjectHandleUtility.ResetHandleObject(thiz, thizUnboxed);
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void System_Collections_Generic_List5eSlqDLksZG1Mz9C9wH0GQ_CallAdd_LRSjiXmrvb5pgfbcZ_Nv7wType(System.IntPtr thiz, System.IntPtr item);
        private static unsafe readonly System_Collections_Generic_List5eSlqDLksZG1Mz9C9wH0GQ_CallAdd_LRSjiXmrvb5pgfbcZ_Nv7wType System_Collections_Generic_List5eSlqDLksZG1Mz9C9wH0GQ_CallAdd_LRSjiXmrvb5pgfbcZ_Nv7wDelegate = new System_Collections_Generic_List5eSlqDLksZG1Mz9C9wH0GQ_CallAdd_LRSjiXmrvb5pgfbcZ_Nv7wType(System_Collections_Generic_List5eSlqDLksZG1Mz9C9wH0GQ_CallAdd_LRSjiXmrvb5pgfbcZ_Nv7w);
        [AOT.MonoPInvokeCallback(typeof(System_Collections_Generic_List5eSlqDLksZG1Mz9C9wH0GQ_CallAdd_LRSjiXmrvb5pgfbcZ_Nv7wType))]
        private static unsafe void System_Collections_Generic_List5eSlqDLksZG1Mz9C9wH0GQ_CallAdd_LRSjiXmrvb5pgfbcZ_Nv7w(System.IntPtr thiz, System.IntPtr item)
        {
            ((System.Collections.Generic.List<string>)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).Add((string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(item)!);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void System_Collections_Generic_List5eSlqDLksZG1Mz9C9wH0GQ_CallClear_1B2M2Y8AsgTpgAmY7PhCfgType(System.IntPtr thiz);
        private static unsafe readonly System_Collections_Generic_List5eSlqDLksZG1Mz9C9wH0GQ_CallClear_1B2M2Y8AsgTpgAmY7PhCfgType System_Collections_Generic_List5eSlqDLksZG1Mz9C9wH0GQ_CallClear_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new System_Collections_Generic_List5eSlqDLksZG1Mz9C9wH0GQ_CallClear_1B2M2Y8AsgTpgAmY7PhCfgType(System_Collections_Generic_List5eSlqDLksZG1Mz9C9wH0GQ_CallClear_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(System_Collections_Generic_List5eSlqDLksZG1Mz9C9wH0GQ_CallClear_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe void System_Collections_Generic_List5eSlqDLksZG1Mz9C9wH0GQ_CallClear_1B2M2Y8AsgTpgAmY7PhCfg(System.IntPtr thiz)
        {
            ((System.Collections.Generic.List<string>)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).Clear();
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte System_Delegate_Callop_Equality_a0RmOPC1vpOfulhhfnafBAType(System.IntPtr d1, System.IntPtr d2);
        private static unsafe readonly System_Delegate_Callop_Equality_a0RmOPC1vpOfulhhfnafBAType System_Delegate_Callop_Equality_a0RmOPC1vpOfulhhfnafBADelegate = new System_Delegate_Callop_Equality_a0RmOPC1vpOfulhhfnafBAType(System_Delegate_Callop_Equality_a0RmOPC1vpOfulhhfnafBA);
        [AOT.MonoPInvokeCallback(typeof(System_Delegate_Callop_Equality_a0RmOPC1vpOfulhhfnafBAType))]
        private static unsafe byte System_Delegate_Callop_Equality_a0RmOPC1vpOfulhhfnafBA(System.IntPtr d1, System.IntPtr d2)
        {
            
            var result = ((System.Delegate)Reinterop.ObjectHandleUtility.GetObjectFromHandle(d1)!) == ((System.Delegate)Reinterop.ObjectHandleUtility.GetObjectFromHandle(d2)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte System_Delegate_Callop_Inequality_a0RmOPC1vpOfulhhfnafBAType(System.IntPtr d1, System.IntPtr d2);
        private static unsafe readonly System_Delegate_Callop_Inequality_a0RmOPC1vpOfulhhfnafBAType System_Delegate_Callop_Inequality_a0RmOPC1vpOfulhhfnafBADelegate = new System_Delegate_Callop_Inequality_a0RmOPC1vpOfulhhfnafBAType(System_Delegate_Callop_Inequality_a0RmOPC1vpOfulhhfnafBA);
        [AOT.MonoPInvokeCallback(typeof(System_Delegate_Callop_Inequality_a0RmOPC1vpOfulhhfnafBAType))]
        private static unsafe byte System_Delegate_Callop_Inequality_a0RmOPC1vpOfulhhfnafBA(System.IntPtr d1, System.IntPtr d2)
        {
            
            var result = ((System.Delegate)Reinterop.ObjectHandleUtility.GetObjectFromHandle(d1)!) != ((System.Delegate)Reinterop.ObjectHandleUtility.GetObjectFromHandle(d2)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr System_Environment_Property_get_OSVersionType();
        private static unsafe readonly System_Environment_Property_get_OSVersionType System_Environment_Property_get_OSVersionDelegate = new System_Environment_Property_get_OSVersionType(System_Environment_Property_get_OSVersion);
        [AOT.MonoPInvokeCallback(typeof(System_Environment_Property_get_OSVersionType))]
        private static unsafe System.IntPtr System_Environment_Property_get_OSVersion()
        {
            
            var result = System.Environment.OSVersion;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte System_MulticastDelegate_Callop_Equality__iYzpyUo7S__gDd8L5jFzrgType(System.IntPtr d1, System.IntPtr d2);
        private static unsafe readonly System_MulticastDelegate_Callop_Equality__iYzpyUo7S__gDd8L5jFzrgType System_MulticastDelegate_Callop_Equality__iYzpyUo7S__gDd8L5jFzrgDelegate = new System_MulticastDelegate_Callop_Equality__iYzpyUo7S__gDd8L5jFzrgType(System_MulticastDelegate_Callop_Equality__iYzpyUo7S__gDd8L5jFzrg);
        [AOT.MonoPInvokeCallback(typeof(System_MulticastDelegate_Callop_Equality__iYzpyUo7S__gDd8L5jFzrgType))]
        private static unsafe byte System_MulticastDelegate_Callop_Equality__iYzpyUo7S__gDd8L5jFzrg(System.IntPtr d1, System.IntPtr d2)
        {
            
            var result = ((System.MulticastDelegate)Reinterop.ObjectHandleUtility.GetObjectFromHandle(d1)!) == ((System.MulticastDelegate)Reinterop.ObjectHandleUtility.GetObjectFromHandle(d2)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte System_MulticastDelegate_Callop_Equality_a0RmOPC1vpOfulhhfnafBAType(System.IntPtr d1, System.IntPtr d2);
        private static unsafe readonly System_MulticastDelegate_Callop_Equality_a0RmOPC1vpOfulhhfnafBAType System_MulticastDelegate_Callop_Equality_a0RmOPC1vpOfulhhfnafBADelegate = new System_MulticastDelegate_Callop_Equality_a0RmOPC1vpOfulhhfnafBAType(System_MulticastDelegate_Callop_Equality_a0RmOPC1vpOfulhhfnafBA);
        [AOT.MonoPInvokeCallback(typeof(System_MulticastDelegate_Callop_Equality_a0RmOPC1vpOfulhhfnafBAType))]
        private static unsafe byte System_MulticastDelegate_Callop_Equality_a0RmOPC1vpOfulhhfnafBA(System.IntPtr d1, System.IntPtr d2)
        {
            
            var result = ((System.Delegate)Reinterop.ObjectHandleUtility.GetObjectFromHandle(d1)!) == ((System.Delegate)Reinterop.ObjectHandleUtility.GetObjectFromHandle(d2)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte System_MulticastDelegate_Callop_Inequality__iYzpyUo7S__gDd8L5jFzrgType(System.IntPtr d1, System.IntPtr d2);
        private static unsafe readonly System_MulticastDelegate_Callop_Inequality__iYzpyUo7S__gDd8L5jFzrgType System_MulticastDelegate_Callop_Inequality__iYzpyUo7S__gDd8L5jFzrgDelegate = new System_MulticastDelegate_Callop_Inequality__iYzpyUo7S__gDd8L5jFzrgType(System_MulticastDelegate_Callop_Inequality__iYzpyUo7S__gDd8L5jFzrg);
        [AOT.MonoPInvokeCallback(typeof(System_MulticastDelegate_Callop_Inequality__iYzpyUo7S__gDd8L5jFzrgType))]
        private static unsafe byte System_MulticastDelegate_Callop_Inequality__iYzpyUo7S__gDd8L5jFzrg(System.IntPtr d1, System.IntPtr d2)
        {
            
            var result = ((System.MulticastDelegate)Reinterop.ObjectHandleUtility.GetObjectFromHandle(d1)!) != ((System.MulticastDelegate)Reinterop.ObjectHandleUtility.GetObjectFromHandle(d2)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte System_MulticastDelegate_Callop_Inequality_a0RmOPC1vpOfulhhfnafBAType(System.IntPtr d1, System.IntPtr d2);
        private static unsafe readonly System_MulticastDelegate_Callop_Inequality_a0RmOPC1vpOfulhhfnafBAType System_MulticastDelegate_Callop_Inequality_a0RmOPC1vpOfulhhfnafBADelegate = new System_MulticastDelegate_Callop_Inequality_a0RmOPC1vpOfulhhfnafBAType(System_MulticastDelegate_Callop_Inequality_a0RmOPC1vpOfulhhfnafBA);
        [AOT.MonoPInvokeCallback(typeof(System_MulticastDelegate_Callop_Inequality_a0RmOPC1vpOfulhhfnafBAType))]
        private static unsafe byte System_MulticastDelegate_Callop_Inequality_a0RmOPC1vpOfulhhfnafBA(System.IntPtr d1, System.IntPtr d2)
        {
            
            var result = ((System.Delegate)Reinterop.ObjectHandleUtility.GetObjectFromHandle(d1)!) != ((System.Delegate)Reinterop.ObjectHandleUtility.GetObjectFromHandle(d2)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr System_Object_Construct_1B2M2Y8AsgTpgAmY7PhCfgType();
        private static unsafe readonly System_Object_Construct_1B2M2Y8AsgTpgAmY7PhCfgType System_Object_Construct_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new System_Object_Construct_1B2M2Y8AsgTpgAmY7PhCfgType(System_Object_Construct_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(System_Object_Construct_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe System.IntPtr System_Object_Construct_1B2M2Y8AsgTpgAmY7PhCfg()
        {
            
            var result = new object();
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr System_OperatingSystem_Property_get_VersionStringType(System.IntPtr thiz);
        private static unsafe readonly System_OperatingSystem_Property_get_VersionStringType System_OperatingSystem_Property_get_VersionStringDelegate = new System_OperatingSystem_Property_get_VersionStringType(System_OperatingSystem_Property_get_VersionString);
        [AOT.MonoPInvokeCallback(typeof(System_OperatingSystem_Property_get_VersionStringType))]
        private static unsafe System.IntPtr System_OperatingSystem_Property_get_VersionString(System.IntPtr thiz)
        {
            
            var result = ((System.OperatingSystem)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).VersionString;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void System_Runtime_InteropServices_Marshal_CallFreeCoTaskMem_eF5IwSJe_WM3IuDxcegQFgType(System.IntPtr ptr);
        private static unsafe readonly System_Runtime_InteropServices_Marshal_CallFreeCoTaskMem_eF5IwSJe_WM3IuDxcegQFgType System_Runtime_InteropServices_Marshal_CallFreeCoTaskMem_eF5IwSJe_WM3IuDxcegQFgDelegate = new System_Runtime_InteropServices_Marshal_CallFreeCoTaskMem_eF5IwSJe_WM3IuDxcegQFgType(System_Runtime_InteropServices_Marshal_CallFreeCoTaskMem_eF5IwSJe_WM3IuDxcegQFg);
        [AOT.MonoPInvokeCallback(typeof(System_Runtime_InteropServices_Marshal_CallFreeCoTaskMem_eF5IwSJe_WM3IuDxcegQFgType))]
        private static unsafe void System_Runtime_InteropServices_Marshal_CallFreeCoTaskMem_eF5IwSJe_WM3IuDxcegQFg(System.IntPtr ptr)
        {
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(ptr);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr System_Runtime_InteropServices_Marshal_CallStringToCoTaskMemUTF8_ga80EVd9gqZ4YlhSP8iRzgType(System.IntPtr s);
        private static unsafe readonly System_Runtime_InteropServices_Marshal_CallStringToCoTaskMemUTF8_ga80EVd9gqZ4YlhSP8iRzgType System_Runtime_InteropServices_Marshal_CallStringToCoTaskMemUTF8_ga80EVd9gqZ4YlhSP8iRzgDelegate = new System_Runtime_InteropServices_Marshal_CallStringToCoTaskMemUTF8_ga80EVd9gqZ4YlhSP8iRzgType(System_Runtime_InteropServices_Marshal_CallStringToCoTaskMemUTF8_ga80EVd9gqZ4YlhSP8iRzg);
        [AOT.MonoPInvokeCallback(typeof(System_Runtime_InteropServices_Marshal_CallStringToCoTaskMemUTF8_ga80EVd9gqZ4YlhSP8iRzgType))]
        private static unsafe System.IntPtr System_Runtime_InteropServices_Marshal_CallStringToCoTaskMemUTF8_ga80EVd9gqZ4YlhSP8iRzg(System.IntPtr s)
        {
            
            var result = System.Runtime.InteropServices.Marshal.StringToCoTaskMemUTF8((string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(s)!);
            
            return result;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr System_String_CallConcat_OM9SoWVFMTHXvbepMyUchwType(System.IntPtr str0, System.IntPtr str1);
        private static unsafe readonly System_String_CallConcat_OM9SoWVFMTHXvbepMyUchwType System_String_CallConcat_OM9SoWVFMTHXvbepMyUchwDelegate = new System_String_CallConcat_OM9SoWVFMTHXvbepMyUchwType(System_String_CallConcat_OM9SoWVFMTHXvbepMyUchw);
        [AOT.MonoPInvokeCallback(typeof(System_String_CallConcat_OM9SoWVFMTHXvbepMyUchwType))]
        private static unsafe System.IntPtr System_String_CallConcat_OM9SoWVFMTHXvbepMyUchw(System.IntPtr str0, System.IntPtr str1)
        {
            
            var result = string.Concat((string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(str0)!, (string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(str1)!);
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr System_String_CallConcat_yq7nlytzIFp8a79slfH_mwType(System.IntPtr arg0, System.IntPtr arg1);
        private static unsafe readonly System_String_CallConcat_yq7nlytzIFp8a79slfH_mwType System_String_CallConcat_yq7nlytzIFp8a79slfH_mwDelegate = new System_String_CallConcat_yq7nlytzIFp8a79slfH_mwType(System_String_CallConcat_yq7nlytzIFp8a79slfH_mw);
        [AOT.MonoPInvokeCallback(typeof(System_String_CallConcat_yq7nlytzIFp8a79slfH_mwType))]
        private static unsafe System.IntPtr System_String_CallConcat_yq7nlytzIFp8a79slfH_mw(System.IntPtr arg0, System.IntPtr arg1)
        {
            
            var result = string.Concat((object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(arg0)!, (object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(arg1)!);
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte System_String_CallContains_GImL1A5rlEQAx14EidO2oAType(System.IntPtr thiz, System.IntPtr value, System.StringComparison comparisonType);
        private static unsafe readonly System_String_CallContains_GImL1A5rlEQAx14EidO2oAType System_String_CallContains_GImL1A5rlEQAx14EidO2oADelegate = new System_String_CallContains_GImL1A5rlEQAx14EidO2oAType(System_String_CallContains_GImL1A5rlEQAx14EidO2oA);
        [AOT.MonoPInvokeCallback(typeof(System_String_CallContains_GImL1A5rlEQAx14EidO2oAType))]
        private static unsafe byte System_String_CallContains_GImL1A5rlEQAx14EidO2oA(System.IntPtr thiz, System.IntPtr value, System.StringComparison comparisonType)
        {
            
            var result = ((string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).Contains((string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(value)!, comparisonType);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte System_String_CallEquals_46DLRq__QwpwCx8Uf20Cl7AType(System.IntPtr a, System.IntPtr b);
        private static unsafe readonly System_String_CallEquals_46DLRq__QwpwCx8Uf20Cl7AType System_String_CallEquals_46DLRq__QwpwCx8Uf20Cl7ADelegate = new System_String_CallEquals_46DLRq__QwpwCx8Uf20Cl7AType(System_String_CallEquals_46DLRq__QwpwCx8Uf20Cl7A);
        [AOT.MonoPInvokeCallback(typeof(System_String_CallEquals_46DLRq__QwpwCx8Uf20Cl7AType))]
        private static unsafe byte System_String_CallEquals_46DLRq__QwpwCx8Uf20Cl7A(System.IntPtr a, System.IntPtr b)
        {
            
            var result = string.Equals((string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(a)!, (string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(b)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte System_String_CallIsNullOrEmpty_ZOWEGUlscki07yVzH4i4wwType(System.IntPtr value);
        private static unsafe readonly System_String_CallIsNullOrEmpty_ZOWEGUlscki07yVzH4i4wwType System_String_CallIsNullOrEmpty_ZOWEGUlscki07yVzH4i4wwDelegate = new System_String_CallIsNullOrEmpty_ZOWEGUlscki07yVzH4i4wwType(System_String_CallIsNullOrEmpty_ZOWEGUlscki07yVzH4i4ww);
        [AOT.MonoPInvokeCallback(typeof(System_String_CallIsNullOrEmpty_ZOWEGUlscki07yVzH4i4wwType))]
        private static unsafe byte System_String_CallIsNullOrEmpty_ZOWEGUlscki07yVzH4i4ww(System.IntPtr value)
        {
            
            var result = string.IsNullOrEmpty((string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(value)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte System_String_Callop_Equality_46DLRq__QwpwCx8Uf20Cl7AType(System.IntPtr a, System.IntPtr b);
        private static unsafe readonly System_String_Callop_Equality_46DLRq__QwpwCx8Uf20Cl7AType System_String_Callop_Equality_46DLRq__QwpwCx8Uf20Cl7ADelegate = new System_String_Callop_Equality_46DLRq__QwpwCx8Uf20Cl7AType(System_String_Callop_Equality_46DLRq__QwpwCx8Uf20Cl7A);
        [AOT.MonoPInvokeCallback(typeof(System_String_Callop_Equality_46DLRq__QwpwCx8Uf20Cl7AType))]
        private static unsafe byte System_String_Callop_Equality_46DLRq__QwpwCx8Uf20Cl7A(System.IntPtr a, System.IntPtr b)
        {
            
            var result = ((string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(a)!) == ((string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(b)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte System_String_Callop_Inequality_46DLRq__QwpwCx8Uf20Cl7AType(System.IntPtr a, System.IntPtr b);
        private static unsafe readonly System_String_Callop_Inequality_46DLRq__QwpwCx8Uf20Cl7AType System_String_Callop_Inequality_46DLRq__QwpwCx8Uf20Cl7ADelegate = new System_String_Callop_Inequality_46DLRq__QwpwCx8Uf20Cl7AType(System_String_Callop_Inequality_46DLRq__QwpwCx8Uf20Cl7A);
        [AOT.MonoPInvokeCallback(typeof(System_String_Callop_Inequality_46DLRq__QwpwCx8Uf20Cl7AType))]
        private static unsafe byte System_String_Callop_Inequality_46DLRq__QwpwCx8Uf20Cl7A(System.IntPtr a, System.IntPtr b)
        {
            
            var result = ((string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(a)!) != ((string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(b)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate int System_String_Property_get_LengthType(System.IntPtr thiz);
        private static unsafe readonly System_String_Property_get_LengthType System_String_Property_get_LengthDelegate = new System_String_Property_get_LengthType(System_String_Property_get_Length);
        [AOT.MonoPInvokeCallback(typeof(System_String_Property_get_LengthType))]
        private static unsafe int System_String_Property_get_Length(System.IntPtr thiz)
        {
            
            var result = ((string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).Length;
            
            return result;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr System_Text_Encoding_CallGetString_J_gIxYGOW0ecDuybXJZsCwType(System.IntPtr thiz, byte* bytes, int byteCount);
        private static unsafe readonly System_Text_Encoding_CallGetString_J_gIxYGOW0ecDuybXJZsCwType System_Text_Encoding_CallGetString_J_gIxYGOW0ecDuybXJZsCwDelegate = new System_Text_Encoding_CallGetString_J_gIxYGOW0ecDuybXJZsCwType(System_Text_Encoding_CallGetString_J_gIxYGOW0ecDuybXJZsCw);
        [AOT.MonoPInvokeCallback(typeof(System_Text_Encoding_CallGetString_J_gIxYGOW0ecDuybXJZsCwType))]
        private static unsafe System.IntPtr System_Text_Encoding_CallGetString_J_gIxYGOW0ecDuybXJZsCw(System.IntPtr thiz, byte* bytes, int byteCount)
        {
            
            var result = ((System.Text.Encoding)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).GetString(bytes, byteCount);
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr System_Text_Encoding_Property_get_UTF8Type();
        private static unsafe readonly System_Text_Encoding_Property_get_UTF8Type System_Text_Encoding_Property_get_UTF8Delegate = new System_Text_Encoding_Property_get_UTF8Type(System_Text_Encoding_Property_get_UTF8);
        [AOT.MonoPInvokeCallback(typeof(System_Text_Encoding_Property_get_UTF8Type))]
        private static unsafe System.IntPtr System_Text_Encoding_Property_get_UTF8()
        {
            
            var result = System.Text.Encoding.UTF8;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr System_Threading_Tasks_Task_CallRun_uG3jiSYLEmrwe0pJoPtxoAType(System.IntPtr action);
        private static unsafe readonly System_Threading_Tasks_Task_CallRun_uG3jiSYLEmrwe0pJoPtxoAType System_Threading_Tasks_Task_CallRun_uG3jiSYLEmrwe0pJoPtxoADelegate = new System_Threading_Tasks_Task_CallRun_uG3jiSYLEmrwe0pJoPtxoAType(System_Threading_Tasks_Task_CallRun_uG3jiSYLEmrwe0pJoPtxoA);
        [AOT.MonoPInvokeCallback(typeof(System_Threading_Tasks_Task_CallRun_uG3jiSYLEmrwe0pJoPtxoAType))]
        private static unsafe System.IntPtr System_Threading_Tasks_Task_CallRun_uG3jiSYLEmrwe0pJoPtxoA(System.IntPtr action)
        {
            
            var result = System.Threading.Tasks.Task.Run((System.Action)Reinterop.ObjectHandleUtility.GetObjectFromHandle(action)!);
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void* Unity_Collections_LowLevel_Unsafe_NativeArrayUnsafeUtility_CallGetUnsafeBufferPointerWithoutChecks_QIjAavb5O6M1Tim2Rs2ohQType(System.IntPtr nativeArray);
        private static unsafe readonly Unity_Collections_LowLevel_Unsafe_NativeArrayUnsafeUtility_CallGetUnsafeBufferPointerWithoutChecks_QIjAavb5O6M1Tim2Rs2ohQType Unity_Collections_LowLevel_Unsafe_NativeArrayUnsafeUtility_CallGetUnsafeBufferPointerWithoutChecks_QIjAavb5O6M1Tim2Rs2ohQDelegate = new Unity_Collections_LowLevel_Unsafe_NativeArrayUnsafeUtility_CallGetUnsafeBufferPointerWithoutChecks_QIjAavb5O6M1Tim2Rs2ohQType(Unity_Collections_LowLevel_Unsafe_NativeArrayUnsafeUtility_CallGetUnsafeBufferPointerWithoutChecks_QIjAavb5O6M1Tim2Rs2ohQ);
        [AOT.MonoPInvokeCallback(typeof(Unity_Collections_LowLevel_Unsafe_NativeArrayUnsafeUtility_CallGetUnsafeBufferPointerWithoutChecks_QIjAavb5O6M1Tim2Rs2ohQType))]
        private static unsafe void* Unity_Collections_LowLevel_Unsafe_NativeArrayUnsafeUtility_CallGetUnsafeBufferPointerWithoutChecks_QIjAavb5O6M1Tim2Rs2ohQ(System.IntPtr nativeArray)
        {
            
            var result = Unity.Collections.LowLevel.Unsafe.NativeArrayUnsafeUtility.GetUnsafeBufferPointerWithoutChecks<byte>((Unity.Collections.NativeArray<byte>)Reinterop.ObjectHandleUtility.GetObjectFromHandle(nativeArray)!);
            
            return result;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte Unity_Collections_NativeArrayz79ECk55IqLfMIqXBYg_8w_Callop_Equality___ZFbUbDYmnqRGnwegIjKPwType(System.IntPtr left, System.IntPtr right);
        private static unsafe readonly Unity_Collections_NativeArrayz79ECk55IqLfMIqXBYg_8w_Callop_Equality___ZFbUbDYmnqRGnwegIjKPwType Unity_Collections_NativeArrayz79ECk55IqLfMIqXBYg_8w_Callop_Equality___ZFbUbDYmnqRGnwegIjKPwDelegate = new Unity_Collections_NativeArrayz79ECk55IqLfMIqXBYg_8w_Callop_Equality___ZFbUbDYmnqRGnwegIjKPwType(Unity_Collections_NativeArrayz79ECk55IqLfMIqXBYg_8w_Callop_Equality___ZFbUbDYmnqRGnwegIjKPw);
        [AOT.MonoPInvokeCallback(typeof(Unity_Collections_NativeArrayz79ECk55IqLfMIqXBYg_8w_Callop_Equality___ZFbUbDYmnqRGnwegIjKPwType))]
        private static unsafe byte Unity_Collections_NativeArrayz79ECk55IqLfMIqXBYg_8w_Callop_Equality___ZFbUbDYmnqRGnwegIjKPw(System.IntPtr left, System.IntPtr right)
        {
            
            var result = ((Unity.Collections.NativeArray<byte>)Reinterop.ObjectHandleUtility.GetObjectFromHandle(left)!) == ((Unity.Collections.NativeArray<byte>)Reinterop.ObjectHandleUtility.GetObjectFromHandle(right)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte Unity_Collections_NativeArrayz79ECk55IqLfMIqXBYg_8w_Callop_Inequality___ZFbUbDYmnqRGnwegIjKPwType(System.IntPtr left, System.IntPtr right);
        private static unsafe readonly Unity_Collections_NativeArrayz79ECk55IqLfMIqXBYg_8w_Callop_Inequality___ZFbUbDYmnqRGnwegIjKPwType Unity_Collections_NativeArrayz79ECk55IqLfMIqXBYg_8w_Callop_Inequality___ZFbUbDYmnqRGnwegIjKPwDelegate = new Unity_Collections_NativeArrayz79ECk55IqLfMIqXBYg_8w_Callop_Inequality___ZFbUbDYmnqRGnwegIjKPwType(Unity_Collections_NativeArrayz79ECk55IqLfMIqXBYg_8w_Callop_Inequality___ZFbUbDYmnqRGnwegIjKPw);
        [AOT.MonoPInvokeCallback(typeof(Unity_Collections_NativeArrayz79ECk55IqLfMIqXBYg_8w_Callop_Inequality___ZFbUbDYmnqRGnwegIjKPwType))]
        private static unsafe byte Unity_Collections_NativeArrayz79ECk55IqLfMIqXBYg_8w_Callop_Inequality___ZFbUbDYmnqRGnwegIjKPw(System.IntPtr left, System.IntPtr right)
        {
            
            var result = ((Unity.Collections.NativeArray<byte>)Reinterop.ObjectHandleUtility.GetObjectFromHandle(left)!) != ((Unity.Collections.NativeArray<byte>)Reinterop.ObjectHandleUtility.GetObjectFromHandle(right)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr Unity_Collections_NativeArrayz79ECk55IqLfMIqXBYg_8w_Construct_fyLz0cEPCtnsPNSt__omZwQType(int length, Unity.Collections.Allocator allocator, Unity.Collections.NativeArrayOptions options);
        private static unsafe readonly Unity_Collections_NativeArrayz79ECk55IqLfMIqXBYg_8w_Construct_fyLz0cEPCtnsPNSt__omZwQType Unity_Collections_NativeArrayz79ECk55IqLfMIqXBYg_8w_Construct_fyLz0cEPCtnsPNSt__omZwQDelegate = new Unity_Collections_NativeArrayz79ECk55IqLfMIqXBYg_8w_Construct_fyLz0cEPCtnsPNSt__omZwQType(Unity_Collections_NativeArrayz79ECk55IqLfMIqXBYg_8w_Construct_fyLz0cEPCtnsPNSt__omZwQ);
        [AOT.MonoPInvokeCallback(typeof(Unity_Collections_NativeArrayz79ECk55IqLfMIqXBYg_8w_Construct_fyLz0cEPCtnsPNSt__omZwQType))]
        private static unsafe System.IntPtr Unity_Collections_NativeArrayz79ECk55IqLfMIqXBYg_8w_Construct_fyLz0cEPCtnsPNSt__omZwQ(int length, Unity.Collections.Allocator allocator, Unity.Collections.NativeArrayOptions options)
        {
            
            var result = new Unity.Collections.NativeArray<byte>(length, allocator, options);
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte UnityEditor_EditorApplication_CallExecuteMenuItem__mTAWffFaNJNxtE3VLYhxwType(System.IntPtr menuItemPath);
        private static unsafe readonly UnityEditor_EditorApplication_CallExecuteMenuItem__mTAWffFaNJNxtE3VLYhxwType UnityEditor_EditorApplication_CallExecuteMenuItem__mTAWffFaNJNxtE3VLYhxwDelegate = new UnityEditor_EditorApplication_CallExecuteMenuItem__mTAWffFaNJNxtE3VLYhxwType(UnityEditor_EditorApplication_CallExecuteMenuItem__mTAWffFaNJNxtE3VLYhxw);
        [AOT.MonoPInvokeCallback(typeof(UnityEditor_EditorApplication_CallExecuteMenuItem__mTAWffFaNJNxtE3VLYhxwType))]
        private static unsafe byte UnityEditor_EditorApplication_CallExecuteMenuItem__mTAWffFaNJNxtE3VLYhxw(System.IntPtr menuItemPath)
        {
            
            var result = UnityEditor.EditorApplication.ExecuteMenuItem((string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(menuItemPath)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void UnityEditor_EditorPrefs_CallDeleteKey_4Oa4KGDR__vvaosUsC29xLgType(System.IntPtr key);
        private static unsafe readonly UnityEditor_EditorPrefs_CallDeleteKey_4Oa4KGDR__vvaosUsC29xLgType UnityEditor_EditorPrefs_CallDeleteKey_4Oa4KGDR__vvaosUsC29xLgDelegate = new UnityEditor_EditorPrefs_CallDeleteKey_4Oa4KGDR__vvaosUsC29xLgType(UnityEditor_EditorPrefs_CallDeleteKey_4Oa4KGDR__vvaosUsC29xLg);
        [AOT.MonoPInvokeCallback(typeof(UnityEditor_EditorPrefs_CallDeleteKey_4Oa4KGDR__vvaosUsC29xLgType))]
        private static unsafe void UnityEditor_EditorPrefs_CallDeleteKey_4Oa4KGDR__vvaosUsC29xLg(System.IntPtr key)
        {
            UnityEditor.EditorPrefs.DeleteKey((string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(key)!);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr UnityEditor_EditorPrefs_CallGetString_4Oa4KGDR__vvaosUsC29xLgType(System.IntPtr key);
        private static unsafe readonly UnityEditor_EditorPrefs_CallGetString_4Oa4KGDR__vvaosUsC29xLgType UnityEditor_EditorPrefs_CallGetString_4Oa4KGDR__vvaosUsC29xLgDelegate = new UnityEditor_EditorPrefs_CallGetString_4Oa4KGDR__vvaosUsC29xLgType(UnityEditor_EditorPrefs_CallGetString_4Oa4KGDR__vvaosUsC29xLg);
        [AOT.MonoPInvokeCallback(typeof(UnityEditor_EditorPrefs_CallGetString_4Oa4KGDR__vvaosUsC29xLgType))]
        private static unsafe System.IntPtr UnityEditor_EditorPrefs_CallGetString_4Oa4KGDR__vvaosUsC29xLg(System.IntPtr key)
        {
            
            var result = UnityEditor.EditorPrefs.GetString((string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(key)!);
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte UnityEditor_EditorPrefs_CallHasKey_4Oa4KGDR__vvaosUsC29xLgType(System.IntPtr key);
        private static unsafe readonly UnityEditor_EditorPrefs_CallHasKey_4Oa4KGDR__vvaosUsC29xLgType UnityEditor_EditorPrefs_CallHasKey_4Oa4KGDR__vvaosUsC29xLgDelegate = new UnityEditor_EditorPrefs_CallHasKey_4Oa4KGDR__vvaosUsC29xLgType(UnityEditor_EditorPrefs_CallHasKey_4Oa4KGDR__vvaosUsC29xLg);
        [AOT.MonoPInvokeCallback(typeof(UnityEditor_EditorPrefs_CallHasKey_4Oa4KGDR__vvaosUsC29xLgType))]
        private static unsafe byte UnityEditor_EditorPrefs_CallHasKey_4Oa4KGDR__vvaosUsC29xLg(System.IntPtr key)
        {
            
            var result = UnityEditor.EditorPrefs.HasKey((string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(key)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void UnityEditor_EditorPrefs_CallSetString_eMSjpsyKrCDpoy__674QaewType(System.IntPtr key, System.IntPtr value);
        private static unsafe readonly UnityEditor_EditorPrefs_CallSetString_eMSjpsyKrCDpoy__674QaewType UnityEditor_EditorPrefs_CallSetString_eMSjpsyKrCDpoy__674QaewDelegate = new UnityEditor_EditorPrefs_CallSetString_eMSjpsyKrCDpoy__674QaewType(UnityEditor_EditorPrefs_CallSetString_eMSjpsyKrCDpoy__674Qaew);
        [AOT.MonoPInvokeCallback(typeof(UnityEditor_EditorPrefs_CallSetString_eMSjpsyKrCDpoy__674QaewType))]
        private static unsafe void UnityEditor_EditorPrefs_CallSetString_eMSjpsyKrCDpoy__674Qaew(System.IntPtr key, System.IntPtr value)
        {
            UnityEditor.EditorPrefs.SetString((string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(key)!, (string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(value)!);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void UnityEditor_EditorWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfgType(System.IntPtr thiz);
        private static unsafe readonly UnityEditor_EditorWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfgType UnityEditor_EditorWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new UnityEditor_EditorWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfgType(UnityEditor_EditorWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(UnityEditor_EditorWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe void UnityEditor_EditorWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfg(System.IntPtr thiz)
        {
            ((UnityEditor.EditorWindow)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).Close();
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte UnityEditor_EditorWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType(System.IntPtr x, System.IntPtr y);
        private static unsafe readonly UnityEditor_EditorWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType UnityEditor_EditorWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgDelegate = new UnityEditor_EditorWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType(UnityEditor_EditorWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2Wg);
        [AOT.MonoPInvokeCallback(typeof(UnityEditor_EditorWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType))]
        private static unsafe byte UnityEditor_EditorWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2Wg(System.IntPtr x, System.IntPtr y)
        {
            
            var result = ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(x)!) == ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(y)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte UnityEditor_EditorWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType(System.IntPtr x, System.IntPtr y);
        private static unsafe readonly UnityEditor_EditorWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType UnityEditor_EditorWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgDelegate = new UnityEditor_EditorWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType(UnityEditor_EditorWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2Wg);
        [AOT.MonoPInvokeCallback(typeof(UnityEditor_EditorWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType))]
        private static unsafe byte UnityEditor_EditorWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2Wg(System.IntPtr x, System.IntPtr y)
        {
            
            var result = ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(x)!) != ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(y)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte UnityEditor_IMGUI_Controls_MultiColumnHeader_CallIsSortedAscending_ZiJhFqE0LPDoV__RgQlNVpQType(System.IntPtr thiz, int columnIndex);
        private static unsafe readonly UnityEditor_IMGUI_Controls_MultiColumnHeader_CallIsSortedAscending_ZiJhFqE0LPDoV__RgQlNVpQType UnityEditor_IMGUI_Controls_MultiColumnHeader_CallIsSortedAscending_ZiJhFqE0LPDoV__RgQlNVpQDelegate = new UnityEditor_IMGUI_Controls_MultiColumnHeader_CallIsSortedAscending_ZiJhFqE0LPDoV__RgQlNVpQType(UnityEditor_IMGUI_Controls_MultiColumnHeader_CallIsSortedAscending_ZiJhFqE0LPDoV__RgQlNVpQ);
        [AOT.MonoPInvokeCallback(typeof(UnityEditor_IMGUI_Controls_MultiColumnHeader_CallIsSortedAscending_ZiJhFqE0LPDoV__RgQlNVpQType))]
        private static unsafe byte UnityEditor_IMGUI_Controls_MultiColumnHeader_CallIsSortedAscending_ZiJhFqE0LPDoV__RgQlNVpQ(System.IntPtr thiz, int columnIndex)
        {
            
            var result = ((UnityEditor.IMGUI.Controls.MultiColumnHeader)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).IsSortedAscending(columnIndex);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate int UnityEditor_IMGUI_Controls_MultiColumnHeader_Property_get_sortedColumnIndexType(System.IntPtr thiz);
        private static unsafe readonly UnityEditor_IMGUI_Controls_MultiColumnHeader_Property_get_sortedColumnIndexType UnityEditor_IMGUI_Controls_MultiColumnHeader_Property_get_sortedColumnIndexDelegate = new UnityEditor_IMGUI_Controls_MultiColumnHeader_Property_get_sortedColumnIndexType(UnityEditor_IMGUI_Controls_MultiColumnHeader_Property_get_sortedColumnIndex);
        [AOT.MonoPInvokeCallback(typeof(UnityEditor_IMGUI_Controls_MultiColumnHeader_Property_get_sortedColumnIndexType))]
        private static unsafe int UnityEditor_IMGUI_Controls_MultiColumnHeader_Property_get_sortedColumnIndex(System.IntPtr thiz)
        {
            
            var result = ((UnityEditor.IMGUI.Controls.MultiColumnHeader)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).sortedColumnIndex;
            
            return result;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void UnityEditor_IMGUI_Controls_MultiColumnHeader_Property_set_sortedColumnIndexType(System.IntPtr thiz, int value);
        private static unsafe readonly UnityEditor_IMGUI_Controls_MultiColumnHeader_Property_set_sortedColumnIndexType UnityEditor_IMGUI_Controls_MultiColumnHeader_Property_set_sortedColumnIndexDelegate = new UnityEditor_IMGUI_Controls_MultiColumnHeader_Property_set_sortedColumnIndexType(UnityEditor_IMGUI_Controls_MultiColumnHeader_Property_set_sortedColumnIndex);
        [AOT.MonoPInvokeCallback(typeof(UnityEditor_IMGUI_Controls_MultiColumnHeader_Property_set_sortedColumnIndexType))]
        private static unsafe void UnityEditor_IMGUI_Controls_MultiColumnHeader_Property_set_sortedColumnIndex(System.IntPtr thiz, int value)
        {
            ((UnityEditor.IMGUI.Controls.MultiColumnHeader)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).sortedColumnIndex = value;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void UnityEditor_IMGUI_Controls_TreeView_CallReload_1B2M2Y8AsgTpgAmY7PhCfgType(System.IntPtr thiz);
        private static unsafe readonly UnityEditor_IMGUI_Controls_TreeView_CallReload_1B2M2Y8AsgTpgAmY7PhCfgType UnityEditor_IMGUI_Controls_TreeView_CallReload_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new UnityEditor_IMGUI_Controls_TreeView_CallReload_1B2M2Y8AsgTpgAmY7PhCfgType(UnityEditor_IMGUI_Controls_TreeView_CallReload_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(UnityEditor_IMGUI_Controls_TreeView_CallReload_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe void UnityEditor_IMGUI_Controls_TreeView_CallReload_1B2M2Y8AsgTpgAmY7PhCfg(System.IntPtr thiz)
        {
            ((UnityEditor.IMGUI.Controls.TreeView)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).Reload();
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr UnityEditor_IMGUI_Controls_TreeView_Property_get_multiColumnHeaderType(System.IntPtr thiz);
        private static unsafe readonly UnityEditor_IMGUI_Controls_TreeView_Property_get_multiColumnHeaderType UnityEditor_IMGUI_Controls_TreeView_Property_get_multiColumnHeaderDelegate = new UnityEditor_IMGUI_Controls_TreeView_Property_get_multiColumnHeaderType(UnityEditor_IMGUI_Controls_TreeView_Property_get_multiColumnHeader);
        [AOT.MonoPInvokeCallback(typeof(UnityEditor_IMGUI_Controls_TreeView_Property_get_multiColumnHeaderType))]
        private static unsafe System.IntPtr UnityEditor_IMGUI_Controls_TreeView_Property_get_multiColumnHeader(System.IntPtr thiz)
        {
            
            var result = ((UnityEditor.IMGUI.Controls.TreeView)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).multiColumnHeader;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr UnityEditor_IMGUI_Controls_TreeView_Property_get_searchStringType(System.IntPtr thiz);
        private static unsafe readonly UnityEditor_IMGUI_Controls_TreeView_Property_get_searchStringType UnityEditor_IMGUI_Controls_TreeView_Property_get_searchStringDelegate = new UnityEditor_IMGUI_Controls_TreeView_Property_get_searchStringType(UnityEditor_IMGUI_Controls_TreeView_Property_get_searchString);
        [AOT.MonoPInvokeCallback(typeof(UnityEditor_IMGUI_Controls_TreeView_Property_get_searchStringType))]
        private static unsafe System.IntPtr UnityEditor_IMGUI_Controls_TreeView_Property_get_searchString(System.IntPtr thiz)
        {
            
            var result = ((UnityEditor.IMGUI.Controls.TreeView)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).searchString;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void UnityEditor_IMGUI_Controls_TreeView_Property_set_multiColumnHeaderType(System.IntPtr thiz, System.IntPtr value);
        private static unsafe readonly UnityEditor_IMGUI_Controls_TreeView_Property_set_multiColumnHeaderType UnityEditor_IMGUI_Controls_TreeView_Property_set_multiColumnHeaderDelegate = new UnityEditor_IMGUI_Controls_TreeView_Property_set_multiColumnHeaderType(UnityEditor_IMGUI_Controls_TreeView_Property_set_multiColumnHeader);
        [AOT.MonoPInvokeCallback(typeof(UnityEditor_IMGUI_Controls_TreeView_Property_set_multiColumnHeaderType))]
        private static unsafe void UnityEditor_IMGUI_Controls_TreeView_Property_set_multiColumnHeader(System.IntPtr thiz, System.IntPtr value)
        {
            ((UnityEditor.IMGUI.Controls.TreeView)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).multiColumnHeader = (UnityEditor.IMGUI.Controls.MultiColumnHeader)Reinterop.ObjectHandleUtility.GetObjectFromHandle(value)!;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void UnityEditor_IMGUI_Controls_TreeView_Property_set_searchStringType(System.IntPtr thiz, System.IntPtr value);
        private static unsafe readonly UnityEditor_IMGUI_Controls_TreeView_Property_set_searchStringType UnityEditor_IMGUI_Controls_TreeView_Property_set_searchStringDelegate = new UnityEditor_IMGUI_Controls_TreeView_Property_set_searchStringType(UnityEditor_IMGUI_Controls_TreeView_Property_set_searchString);
        [AOT.MonoPInvokeCallback(typeof(UnityEditor_IMGUI_Controls_TreeView_Property_set_searchStringType))]
        private static unsafe void UnityEditor_IMGUI_Controls_TreeView_Property_set_searchString(System.IntPtr thiz, System.IntPtr value)
        {
            ((UnityEditor.IMGUI.Controls.TreeView)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).searchString = (string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(value)!;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr UnityEditor_IMGUI_Controls_TreeViewItem_Construct_fAkE2H7EjTzReHiM2XHBPAType(int id, int depth, System.IntPtr displayName);
        private static unsafe readonly UnityEditor_IMGUI_Controls_TreeViewItem_Construct_fAkE2H7EjTzReHiM2XHBPAType UnityEditor_IMGUI_Controls_TreeViewItem_Construct_fAkE2H7EjTzReHiM2XHBPADelegate = new UnityEditor_IMGUI_Controls_TreeViewItem_Construct_fAkE2H7EjTzReHiM2XHBPAType(UnityEditor_IMGUI_Controls_TreeViewItem_Construct_fAkE2H7EjTzReHiM2XHBPA);
        [AOT.MonoPInvokeCallback(typeof(UnityEditor_IMGUI_Controls_TreeViewItem_Construct_fAkE2H7EjTzReHiM2XHBPAType))]
        private static unsafe System.IntPtr UnityEditor_IMGUI_Controls_TreeViewItem_Construct_fAkE2H7EjTzReHiM2XHBPA(int id, int depth, System.IntPtr displayName)
        {
            
            var result = new UnityEditor.IMGUI.Controls.TreeViewItem(id, depth, (string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(displayName)!);
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate int UnityEditor_IMGUI_Controls_TreeViewItem_Property_get_idType(System.IntPtr thiz);
        private static unsafe readonly UnityEditor_IMGUI_Controls_TreeViewItem_Property_get_idType UnityEditor_IMGUI_Controls_TreeViewItem_Property_get_idDelegate = new UnityEditor_IMGUI_Controls_TreeViewItem_Property_get_idType(UnityEditor_IMGUI_Controls_TreeViewItem_Property_get_id);
        [AOT.MonoPInvokeCallback(typeof(UnityEditor_IMGUI_Controls_TreeViewItem_Property_get_idType))]
        private static unsafe int UnityEditor_IMGUI_Controls_TreeViewItem_Property_get_id(System.IntPtr thiz)
        {
            
            var result = ((UnityEditor.IMGUI.Controls.TreeViewItem)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).id;
            
            return result;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void UnityEditor_IMGUI_Controls_TreeViewItem_Property_set_idType(System.IntPtr thiz, int value);
        private static unsafe readonly UnityEditor_IMGUI_Controls_TreeViewItem_Property_set_idType UnityEditor_IMGUI_Controls_TreeViewItem_Property_set_idDelegate = new UnityEditor_IMGUI_Controls_TreeViewItem_Property_set_idType(UnityEditor_IMGUI_Controls_TreeViewItem_Property_set_id);
        [AOT.MonoPInvokeCallback(typeof(UnityEditor_IMGUI_Controls_TreeViewItem_Property_set_idType))]
        private static unsafe void UnityEditor_IMGUI_Controls_TreeViewItem_Property_set_id(System.IntPtr thiz, int value)
        {
            ((UnityEditor.IMGUI.Controls.TreeViewItem)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).id = value;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr UnityEditor_IMGUI_Controls_TreeViewState_Construct_1B2M2Y8AsgTpgAmY7PhCfgType();
        private static unsafe readonly UnityEditor_IMGUI_Controls_TreeViewState_Construct_1B2M2Y8AsgTpgAmY7PhCfgType UnityEditor_IMGUI_Controls_TreeViewState_Construct_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new UnityEditor_IMGUI_Controls_TreeViewState_Construct_1B2M2Y8AsgTpgAmY7PhCfgType(UnityEditor_IMGUI_Controls_TreeViewState_Construct_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(UnityEditor_IMGUI_Controls_TreeViewState_Construct_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe System.IntPtr UnityEditor_IMGUI_Controls_TreeViewState_Construct_1B2M2Y8AsgTpgAmY7PhCfg()
        {
            
            var result = new UnityEditor.IMGUI.Controls.TreeViewState();
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr UnityEditor_Selection_Property_get_activeGameObjectType();
        private static unsafe readonly UnityEditor_Selection_Property_get_activeGameObjectType UnityEditor_Selection_Property_get_activeGameObjectDelegate = new UnityEditor_Selection_Property_get_activeGameObjectType(UnityEditor_Selection_Property_get_activeGameObject);
        [AOT.MonoPInvokeCallback(typeof(UnityEditor_Selection_Property_get_activeGameObjectType))]
        private static unsafe System.IntPtr UnityEditor_Selection_Property_get_activeGameObject()
        {
            
            var result = UnityEditor.Selection.activeGameObject;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void UnityEditor_Selection_Property_set_activeGameObjectType(System.IntPtr value);
        private static unsafe readonly UnityEditor_Selection_Property_set_activeGameObjectType UnityEditor_Selection_Property_set_activeGameObjectDelegate = new UnityEditor_Selection_Property_set_activeGameObjectType(UnityEditor_Selection_Property_set_activeGameObject);
        [AOT.MonoPInvokeCallback(typeof(UnityEditor_Selection_Property_set_activeGameObjectType))]
        private static unsafe void UnityEditor_Selection_Property_set_activeGameObject(System.IntPtr value)
        {
            UnityEditor.Selection.activeGameObject = (UnityEngine.GameObject)Reinterop.ObjectHandleUtility.GetObjectFromHandle(value)!;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void UnityEngine_Application_CallOpenURL_i4__FgVIR5VYHO4KBzPBwNQType(System.IntPtr url);
        private static unsafe readonly UnityEngine_Application_CallOpenURL_i4__FgVIR5VYHO4KBzPBwNQType UnityEngine_Application_CallOpenURL_i4__FgVIR5VYHO4KBzPBwNQDelegate = new UnityEngine_Application_CallOpenURL_i4__FgVIR5VYHO4KBzPBwNQType(UnityEngine_Application_CallOpenURL_i4__FgVIR5VYHO4KBzPBwNQ);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Application_CallOpenURL_i4__FgVIR5VYHO4KBzPBwNQType))]
        private static unsafe void UnityEngine_Application_CallOpenURL_i4__FgVIR5VYHO4KBzPBwNQ(System.IntPtr url)
        {
            UnityEngine.Application.OpenURL((string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(url)!);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate UnityEngine.RuntimePlatform UnityEngine_Application_Property_get_platformType();
        private static unsafe readonly UnityEngine_Application_Property_get_platformType UnityEngine_Application_Property_get_platformDelegate = new UnityEngine_Application_Property_get_platformType(UnityEngine_Application_Property_get_platform);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Application_Property_get_platformType))]
        private static unsafe UnityEngine.RuntimePlatform UnityEngine_Application_Property_get_platform()
        {
            
            var result = UnityEngine.Application.platform;
            
            return result;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr UnityEngine_Application_Property_get_productNameType();
        private static unsafe readonly UnityEngine_Application_Property_get_productNameType UnityEngine_Application_Property_get_productNameDelegate = new UnityEngine_Application_Property_get_productNameType(UnityEngine_Application_Property_get_productName);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Application_Property_get_productNameType))]
        private static unsafe System.IntPtr UnityEngine_Application_Property_get_productName()
        {
            
            var result = UnityEngine.Application.productName;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr UnityEngine_Application_Property_get_unityVersionType();
        private static unsafe readonly UnityEngine_Application_Property_get_unityVersionType UnityEngine_Application_Property_get_unityVersionDelegate = new UnityEngine_Application_Property_get_unityVersionType(UnityEngine_Application_Property_get_unityVersion);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Application_Property_get_unityVersionType))]
        private static unsafe System.IntPtr UnityEngine_Application_Property_get_unityVersion()
        {
            
            var result = UnityEngine.Application.unityVersion;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr UnityEngine_Application_Property_get_versionType();
        private static unsafe readonly UnityEngine_Application_Property_get_versionType UnityEngine_Application_Property_get_versionDelegate = new UnityEngine_Application_Property_get_versionType(UnityEngine_Application_Property_get_version);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Application_Property_get_versionType))]
        private static unsafe System.IntPtr UnityEngine_Application_Property_get_version()
        {
            
            var result = UnityEngine.Application.version;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void UnityEngine_AsyncOperation_Calladd_completed_89b__Riirtgd1Q5mmRzPojAType(System.IntPtr thiz, System.IntPtr value);
        private static unsafe readonly UnityEngine_AsyncOperation_Calladd_completed_89b__Riirtgd1Q5mmRzPojAType UnityEngine_AsyncOperation_Calladd_completed_89b__Riirtgd1Q5mmRzPojADelegate = new UnityEngine_AsyncOperation_Calladd_completed_89b__Riirtgd1Q5mmRzPojAType(UnityEngine_AsyncOperation_Calladd_completed_89b__Riirtgd1Q5mmRzPojA);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_AsyncOperation_Calladd_completed_89b__Riirtgd1Q5mmRzPojAType))]
        private static unsafe void UnityEngine_AsyncOperation_Calladd_completed_89b__Riirtgd1Q5mmRzPojA(System.IntPtr thiz, System.IntPtr value)
        {
            ((UnityEngine.AsyncOperation)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).completed += (System.Action<UnityEngine.AsyncOperation>)Reinterop.ObjectHandleUtility.GetObjectFromHandle(value)!;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void UnityEngine_AsyncOperation_Callremove_completed_89b__Riirtgd1Q5mmRzPojAType(System.IntPtr thiz, System.IntPtr value);
        private static unsafe readonly UnityEngine_AsyncOperation_Callremove_completed_89b__Riirtgd1Q5mmRzPojAType UnityEngine_AsyncOperation_Callremove_completed_89b__Riirtgd1Q5mmRzPojADelegate = new UnityEngine_AsyncOperation_Callremove_completed_89b__Riirtgd1Q5mmRzPojAType(UnityEngine_AsyncOperation_Callremove_completed_89b__Riirtgd1Q5mmRzPojA);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_AsyncOperation_Callremove_completed_89b__Riirtgd1Q5mmRzPojAType))]
        private static unsafe void UnityEngine_AsyncOperation_Callremove_completed_89b__Riirtgd1Q5mmRzPojA(System.IntPtr thiz, System.IntPtr value)
        {
            ((UnityEngine.AsyncOperation)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).completed -= (System.Action<UnityEngine.AsyncOperation>)Reinterop.ObjectHandleUtility.GetObjectFromHandle(value)!;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte UnityEngine_Component_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType(System.IntPtr x, System.IntPtr y);
        private static unsafe readonly UnityEngine_Component_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType UnityEngine_Component_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgDelegate = new UnityEngine_Component_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType(UnityEngine_Component_Callop_Equality_5bi2N6jTkaYVhpHPRxL2Wg);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Component_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType))]
        private static unsafe byte UnityEngine_Component_Callop_Equality_5bi2N6jTkaYVhpHPRxL2Wg(System.IntPtr x, System.IntPtr y)
        {
            
            var result = ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(x)!) == ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(y)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte UnityEngine_Component_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType(System.IntPtr x, System.IntPtr y);
        private static unsafe readonly UnityEngine_Component_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType UnityEngine_Component_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgDelegate = new UnityEngine_Component_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType(UnityEngine_Component_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2Wg);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Component_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType))]
        private static unsafe byte UnityEngine_Component_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2Wg(System.IntPtr x, System.IntPtr y)
        {
            
            var result = ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(x)!) != ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(y)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr UnityEngine_Component_Property_get_gameObjectType(System.IntPtr thiz);
        private static unsafe readonly UnityEngine_Component_Property_get_gameObjectType UnityEngine_Component_Property_get_gameObjectDelegate = new UnityEngine_Component_Property_get_gameObjectType(UnityEngine_Component_Property_get_gameObject);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Component_Property_get_gameObjectType))]
        private static unsafe System.IntPtr UnityEngine_Component_Property_get_gameObject(System.IntPtr thiz)
        {
            
            var result = ((UnityEngine.Component)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).gameObject;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void UnityEngine_Debug_CallLog_FA05wu8x__otZNsgdHTnU9AType(System.IntPtr message);
        private static unsafe readonly UnityEngine_Debug_CallLog_FA05wu8x__otZNsgdHTnU9AType UnityEngine_Debug_CallLog_FA05wu8x__otZNsgdHTnU9ADelegate = new UnityEngine_Debug_CallLog_FA05wu8x__otZNsgdHTnU9AType(UnityEngine_Debug_CallLog_FA05wu8x__otZNsgdHTnU9A);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Debug_CallLog_FA05wu8x__otZNsgdHTnU9AType))]
        private static unsafe void UnityEngine_Debug_CallLog_FA05wu8x__otZNsgdHTnU9A(System.IntPtr message)
        {
            UnityEngine.Debug.Log((object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(message)!);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void UnityEngine_Debug_CallLogError_FA05wu8x__otZNsgdHTnU9AType(System.IntPtr message);
        private static unsafe readonly UnityEngine_Debug_CallLogError_FA05wu8x__otZNsgdHTnU9AType UnityEngine_Debug_CallLogError_FA05wu8x__otZNsgdHTnU9ADelegate = new UnityEngine_Debug_CallLogError_FA05wu8x__otZNsgdHTnU9AType(UnityEngine_Debug_CallLogError_FA05wu8x__otZNsgdHTnU9A);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Debug_CallLogError_FA05wu8x__otZNsgdHTnU9AType))]
        private static unsafe void UnityEngine_Debug_CallLogError_FA05wu8x__otZNsgdHTnU9A(System.IntPtr message)
        {
            UnityEngine.Debug.LogError((object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(message)!);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void UnityEngine_Debug_CallLogWarning_FA05wu8x__otZNsgdHTnU9AType(System.IntPtr message);
        private static unsafe readonly UnityEngine_Debug_CallLogWarning_FA05wu8x__otZNsgdHTnU9AType UnityEngine_Debug_CallLogWarning_FA05wu8x__otZNsgdHTnU9ADelegate = new UnityEngine_Debug_CallLogWarning_FA05wu8x__otZNsgdHTnU9AType(UnityEngine_Debug_CallLogWarning_FA05wu8x__otZNsgdHTnU9A);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Debug_CallLogWarning_FA05wu8x__otZNsgdHTnU9AType))]
        private static unsafe void UnityEngine_Debug_CallLogWarning_FA05wu8x__otZNsgdHTnU9A(System.IntPtr message)
        {
            UnityEngine.Debug.LogWarning((object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(message)!);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr UnityEngine_GameObject_CallAddComponent_0EgxpGTzCG1YTfWqwgLniwType(System.IntPtr thiz);
        private static unsafe readonly UnityEngine_GameObject_CallAddComponent_0EgxpGTzCG1YTfWqwgLniwType UnityEngine_GameObject_CallAddComponent_0EgxpGTzCG1YTfWqwgLniwDelegate = new UnityEngine_GameObject_CallAddComponent_0EgxpGTzCG1YTfWqwgLniwType(UnityEngine_GameObject_CallAddComponent_0EgxpGTzCG1YTfWqwgLniw);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_GameObject_CallAddComponent_0EgxpGTzCG1YTfWqwgLniwType))]
        private static unsafe System.IntPtr UnityEngine_GameObject_CallAddComponent_0EgxpGTzCG1YTfWqwgLniw(System.IntPtr thiz)
        {
            
            var result = ((UnityEngine.GameObject)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).AddComponent<CesiumForUnity.Cesium3DTileset>();
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr UnityEngine_GameObject_CallAddComponent_BAtcoWNWVoAVplmna6OgsQType(System.IntPtr thiz);
        private static unsafe readonly UnityEngine_GameObject_CallAddComponent_BAtcoWNWVoAVplmna6OgsQType UnityEngine_GameObject_CallAddComponent_BAtcoWNWVoAVplmna6OgsQDelegate = new UnityEngine_GameObject_CallAddComponent_BAtcoWNWVoAVplmna6OgsQType(UnityEngine_GameObject_CallAddComponent_BAtcoWNWVoAVplmna6OgsQ);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_GameObject_CallAddComponent_BAtcoWNWVoAVplmna6OgsQType))]
        private static unsafe System.IntPtr UnityEngine_GameObject_CallAddComponent_BAtcoWNWVoAVplmna6OgsQ(System.IntPtr thiz)
        {
            
            var result = ((UnityEngine.GameObject)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).AddComponent<CesiumForUnity.CesiumIonRasterOverlay>();
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr UnityEngine_GameObject_CallGetComponent_0EgxpGTzCG1YTfWqwgLniwType(System.IntPtr thiz);
        private static unsafe readonly UnityEngine_GameObject_CallGetComponent_0EgxpGTzCG1YTfWqwgLniwType UnityEngine_GameObject_CallGetComponent_0EgxpGTzCG1YTfWqwgLniwDelegate = new UnityEngine_GameObject_CallGetComponent_0EgxpGTzCG1YTfWqwgLniwType(UnityEngine_GameObject_CallGetComponent_0EgxpGTzCG1YTfWqwgLniw);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_GameObject_CallGetComponent_0EgxpGTzCG1YTfWqwgLniwType))]
        private static unsafe System.IntPtr UnityEngine_GameObject_CallGetComponent_0EgxpGTzCG1YTfWqwgLniw(System.IntPtr thiz)
        {
            
            var result = ((UnityEngine.GameObject)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).GetComponent<CesiumForUnity.Cesium3DTileset>();
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr UnityEngine_GameObject_CallGetComponent_BAtcoWNWVoAVplmna6OgsQType(System.IntPtr thiz);
        private static unsafe readonly UnityEngine_GameObject_CallGetComponent_BAtcoWNWVoAVplmna6OgsQType UnityEngine_GameObject_CallGetComponent_BAtcoWNWVoAVplmna6OgsQDelegate = new UnityEngine_GameObject_CallGetComponent_BAtcoWNWVoAVplmna6OgsQType(UnityEngine_GameObject_CallGetComponent_BAtcoWNWVoAVplmna6OgsQ);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_GameObject_CallGetComponent_BAtcoWNWVoAVplmna6OgsQType))]
        private static unsafe System.IntPtr UnityEngine_GameObject_CallGetComponent_BAtcoWNWVoAVplmna6OgsQ(System.IntPtr thiz)
        {
            
            var result = ((UnityEngine.GameObject)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).GetComponent<CesiumForUnity.CesiumIonRasterOverlay>();
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr UnityEngine_GameObject_CallGetComponents_BAtcoWNWVoAVplmna6OgsQType(System.IntPtr thiz);
        private static unsafe readonly UnityEngine_GameObject_CallGetComponents_BAtcoWNWVoAVplmna6OgsQType UnityEngine_GameObject_CallGetComponents_BAtcoWNWVoAVplmna6OgsQDelegate = new UnityEngine_GameObject_CallGetComponents_BAtcoWNWVoAVplmna6OgsQType(UnityEngine_GameObject_CallGetComponents_BAtcoWNWVoAVplmna6OgsQ);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_GameObject_CallGetComponents_BAtcoWNWVoAVplmna6OgsQType))]
        private static unsafe System.IntPtr UnityEngine_GameObject_CallGetComponents_BAtcoWNWVoAVplmna6OgsQ(System.IntPtr thiz)
        {
            
            var result = ((UnityEngine.GameObject)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).GetComponents<CesiumForUnity.CesiumIonRasterOverlay>();
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr UnityEngine_GameObject_CallGetComponents_H1UZCBm__Pf6NnqpE7xQ8NQType(System.IntPtr thiz);
        private static unsafe readonly UnityEngine_GameObject_CallGetComponents_H1UZCBm__Pf6NnqpE7xQ8NQType UnityEngine_GameObject_CallGetComponents_H1UZCBm__Pf6NnqpE7xQ8NQDelegate = new UnityEngine_GameObject_CallGetComponents_H1UZCBm__Pf6NnqpE7xQ8NQType(UnityEngine_GameObject_CallGetComponents_H1UZCBm__Pf6NnqpE7xQ8NQ);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_GameObject_CallGetComponents_H1UZCBm__Pf6NnqpE7xQ8NQType))]
        private static unsafe System.IntPtr UnityEngine_GameObject_CallGetComponents_H1UZCBm__Pf6NnqpE7xQ8NQ(System.IntPtr thiz)
        {
            
            var result = ((UnityEngine.GameObject)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).GetComponents<CesiumForUnity.CesiumRasterOverlay>();
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte UnityEngine_GameObject_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType(System.IntPtr x, System.IntPtr y);
        private static unsafe readonly UnityEngine_GameObject_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType UnityEngine_GameObject_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgDelegate = new UnityEngine_GameObject_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType(UnityEngine_GameObject_Callop_Equality_5bi2N6jTkaYVhpHPRxL2Wg);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_GameObject_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType))]
        private static unsafe byte UnityEngine_GameObject_Callop_Equality_5bi2N6jTkaYVhpHPRxL2Wg(System.IntPtr x, System.IntPtr y)
        {
            
            var result = ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(x)!) == ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(y)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte UnityEngine_GameObject_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType(System.IntPtr x, System.IntPtr y);
        private static unsafe readonly UnityEngine_GameObject_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType UnityEngine_GameObject_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgDelegate = new UnityEngine_GameObject_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType(UnityEngine_GameObject_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2Wg);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_GameObject_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType))]
        private static unsafe byte UnityEngine_GameObject_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2Wg(System.IntPtr x, System.IntPtr y)
        {
            
            var result = ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(x)!) != ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(y)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr UnityEngine_GameObject_Construct_wfPSjxsETIcebv8un8PGZwType(System.IntPtr name);
        private static unsafe readonly UnityEngine_GameObject_Construct_wfPSjxsETIcebv8un8PGZwType UnityEngine_GameObject_Construct_wfPSjxsETIcebv8un8PGZwDelegate = new UnityEngine_GameObject_Construct_wfPSjxsETIcebv8un8PGZwType(UnityEngine_GameObject_Construct_wfPSjxsETIcebv8un8PGZw);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_GameObject_Construct_wfPSjxsETIcebv8un8PGZwType))]
        private static unsafe System.IntPtr UnityEngine_GameObject_Construct_wfPSjxsETIcebv8un8PGZw(System.IntPtr name)
        {
            
            var result = new UnityEngine.GameObject((string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(name)!);
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void UnityEngine_GUI_CallLabel_iRU7t71QqJzkr4BTYehN9AType(UnityEngine.Rect* position, System.IntPtr text);
        private static unsafe readonly UnityEngine_GUI_CallLabel_iRU7t71QqJzkr4BTYehN9AType UnityEngine_GUI_CallLabel_iRU7t71QqJzkr4BTYehN9ADelegate = new UnityEngine_GUI_CallLabel_iRU7t71QqJzkr4BTYehN9AType(UnityEngine_GUI_CallLabel_iRU7t71QqJzkr4BTYehN9A);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_GUI_CallLabel_iRU7t71QqJzkr4BTYehN9AType))]
        private static unsafe void UnityEngine_GUI_CallLabel_iRU7t71QqJzkr4BTYehN9A(UnityEngine.Rect* position, System.IntPtr text)
        {
            UnityEngine.GUI.Label(*position, (string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(text)!);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void UnityEngine_Networking_DownloadHandler_CallDispose_1B2M2Y8AsgTpgAmY7PhCfgType(System.IntPtr thiz);
        private static unsafe readonly UnityEngine_Networking_DownloadHandler_CallDispose_1B2M2Y8AsgTpgAmY7PhCfgType UnityEngine_Networking_DownloadHandler_CallDispose_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new UnityEngine_Networking_DownloadHandler_CallDispose_1B2M2Y8AsgTpgAmY7PhCfgType(UnityEngine_Networking_DownloadHandler_CallDispose_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Networking_DownloadHandler_CallDispose_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe void UnityEngine_Networking_DownloadHandler_CallDispose_1B2M2Y8AsgTpgAmY7PhCfg(System.IntPtr thiz)
        {
            ((UnityEngine.Networking.DownloadHandler)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).Dispose();
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr UnityEngine_Networking_UnityWebRequest_CallGet_Y2__l4HVQ8CbSg4jpXDip9AType(System.IntPtr uri);
        private static unsafe readonly UnityEngine_Networking_UnityWebRequest_CallGet_Y2__l4HVQ8CbSg4jpXDip9AType UnityEngine_Networking_UnityWebRequest_CallGet_Y2__l4HVQ8CbSg4jpXDip9ADelegate = new UnityEngine_Networking_UnityWebRequest_CallGet_Y2__l4HVQ8CbSg4jpXDip9AType(UnityEngine_Networking_UnityWebRequest_CallGet_Y2__l4HVQ8CbSg4jpXDip9A);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Networking_UnityWebRequest_CallGet_Y2__l4HVQ8CbSg4jpXDip9AType))]
        private static unsafe System.IntPtr UnityEngine_Networking_UnityWebRequest_CallGet_Y2__l4HVQ8CbSg4jpXDip9A(System.IntPtr uri)
        {
            
            var result = UnityEngine.Networking.UnityWebRequest.Get((string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(uri)!);
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr UnityEngine_Networking_UnityWebRequest_CallGetResponseHeader_wfPSjxsETIcebv8un8PGZwType(System.IntPtr thiz, System.IntPtr name);
        private static unsafe readonly UnityEngine_Networking_UnityWebRequest_CallGetResponseHeader_wfPSjxsETIcebv8un8PGZwType UnityEngine_Networking_UnityWebRequest_CallGetResponseHeader_wfPSjxsETIcebv8un8PGZwDelegate = new UnityEngine_Networking_UnityWebRequest_CallGetResponseHeader_wfPSjxsETIcebv8un8PGZwType(UnityEngine_Networking_UnityWebRequest_CallGetResponseHeader_wfPSjxsETIcebv8un8PGZw);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Networking_UnityWebRequest_CallGetResponseHeader_wfPSjxsETIcebv8un8PGZwType))]
        private static unsafe System.IntPtr UnityEngine_Networking_UnityWebRequest_CallGetResponseHeader_wfPSjxsETIcebv8un8PGZw(System.IntPtr thiz, System.IntPtr name)
        {
            
            var result = ((UnityEngine.Networking.UnityWebRequest)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).GetResponseHeader((string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(name)!);
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr UnityEngine_Networking_UnityWebRequest_CallGetResponseHeaders_1B2M2Y8AsgTpgAmY7PhCfgType(System.IntPtr thiz);
        private static unsafe readonly UnityEngine_Networking_UnityWebRequest_CallGetResponseHeaders_1B2M2Y8AsgTpgAmY7PhCfgType UnityEngine_Networking_UnityWebRequest_CallGetResponseHeaders_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new UnityEngine_Networking_UnityWebRequest_CallGetResponseHeaders_1B2M2Y8AsgTpgAmY7PhCfgType(UnityEngine_Networking_UnityWebRequest_CallGetResponseHeaders_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Networking_UnityWebRequest_CallGetResponseHeaders_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe System.IntPtr UnityEngine_Networking_UnityWebRequest_CallGetResponseHeaders_1B2M2Y8AsgTpgAmY7PhCfg(System.IntPtr thiz)
        {
            
            var result = ((UnityEngine.Networking.UnityWebRequest)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).GetResponseHeaders();
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr UnityEngine_Networking_UnityWebRequest_CallSendWebRequest_1B2M2Y8AsgTpgAmY7PhCfgType(System.IntPtr thiz);
        private static unsafe readonly UnityEngine_Networking_UnityWebRequest_CallSendWebRequest_1B2M2Y8AsgTpgAmY7PhCfgType UnityEngine_Networking_UnityWebRequest_CallSendWebRequest_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new UnityEngine_Networking_UnityWebRequest_CallSendWebRequest_1B2M2Y8AsgTpgAmY7PhCfgType(UnityEngine_Networking_UnityWebRequest_CallSendWebRequest_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Networking_UnityWebRequest_CallSendWebRequest_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe System.IntPtr UnityEngine_Networking_UnityWebRequest_CallSendWebRequest_1B2M2Y8AsgTpgAmY7PhCfg(System.IntPtr thiz)
        {
            
            var result = ((UnityEngine.Networking.UnityWebRequest)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).SendWebRequest();
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void UnityEngine_Networking_UnityWebRequest_CallSetRequestHeader_tEfBle3aSdR47_HxLakNjwType(System.IntPtr thiz, System.IntPtr name, System.IntPtr value);
        private static unsafe readonly UnityEngine_Networking_UnityWebRequest_CallSetRequestHeader_tEfBle3aSdR47_HxLakNjwType UnityEngine_Networking_UnityWebRequest_CallSetRequestHeader_tEfBle3aSdR47_HxLakNjwDelegate = new UnityEngine_Networking_UnityWebRequest_CallSetRequestHeader_tEfBle3aSdR47_HxLakNjwType(UnityEngine_Networking_UnityWebRequest_CallSetRequestHeader_tEfBle3aSdR47_HxLakNjw);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Networking_UnityWebRequest_CallSetRequestHeader_tEfBle3aSdR47_HxLakNjwType))]
        private static unsafe void UnityEngine_Networking_UnityWebRequest_CallSetRequestHeader_tEfBle3aSdR47_HxLakNjw(System.IntPtr thiz, System.IntPtr name, System.IntPtr value)
        {
            ((UnityEngine.Networking.UnityWebRequest)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).SetRequestHeader((string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(name)!, (string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(value)!);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr UnityEngine_Networking_UnityWebRequest_Construct_N5nF6s7__PflIcgtgQgj6DAType(System.IntPtr url, System.IntPtr method, System.IntPtr downloadHandler, System.IntPtr uploadHandler);
        private static unsafe readonly UnityEngine_Networking_UnityWebRequest_Construct_N5nF6s7__PflIcgtgQgj6DAType UnityEngine_Networking_UnityWebRequest_Construct_N5nF6s7__PflIcgtgQgj6DADelegate = new UnityEngine_Networking_UnityWebRequest_Construct_N5nF6s7__PflIcgtgQgj6DAType(UnityEngine_Networking_UnityWebRequest_Construct_N5nF6s7__PflIcgtgQgj6DA);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Networking_UnityWebRequest_Construct_N5nF6s7__PflIcgtgQgj6DAType))]
        private static unsafe System.IntPtr UnityEngine_Networking_UnityWebRequest_Construct_N5nF6s7__PflIcgtgQgj6DA(System.IntPtr url, System.IntPtr method, System.IntPtr downloadHandler, System.IntPtr uploadHandler)
        {
            
            var result = new UnityEngine.Networking.UnityWebRequest((string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(url)!, (string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(method)!, (UnityEngine.Networking.DownloadHandler)Reinterop.ObjectHandleUtility.GetObjectFromHandle(downloadHandler)!, (UnityEngine.Networking.UploadHandler)Reinterop.ObjectHandleUtility.GetObjectFromHandle(uploadHandler)!);
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr UnityEngine_Networking_UnityWebRequest_Property_get_downloadHandlerType(System.IntPtr thiz);
        private static unsafe readonly UnityEngine_Networking_UnityWebRequest_Property_get_downloadHandlerType UnityEngine_Networking_UnityWebRequest_Property_get_downloadHandlerDelegate = new UnityEngine_Networking_UnityWebRequest_Property_get_downloadHandlerType(UnityEngine_Networking_UnityWebRequest_Property_get_downloadHandler);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Networking_UnityWebRequest_Property_get_downloadHandlerType))]
        private static unsafe System.IntPtr UnityEngine_Networking_UnityWebRequest_Property_get_downloadHandler(System.IntPtr thiz)
        {
            
            var result = ((UnityEngine.Networking.UnityWebRequest)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).downloadHandler;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr UnityEngine_Networking_UnityWebRequest_Property_get_errorType(System.IntPtr thiz);
        private static unsafe readonly UnityEngine_Networking_UnityWebRequest_Property_get_errorType UnityEngine_Networking_UnityWebRequest_Property_get_errorDelegate = new UnityEngine_Networking_UnityWebRequest_Property_get_errorType(UnityEngine_Networking_UnityWebRequest_Property_get_error);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Networking_UnityWebRequest_Property_get_errorType))]
        private static unsafe System.IntPtr UnityEngine_Networking_UnityWebRequest_Property_get_error(System.IntPtr thiz)
        {
            
            var result = ((UnityEngine.Networking.UnityWebRequest)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).error;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte UnityEngine_Networking_UnityWebRequest_Property_get_isDoneType(System.IntPtr thiz);
        private static unsafe readonly UnityEngine_Networking_UnityWebRequest_Property_get_isDoneType UnityEngine_Networking_UnityWebRequest_Property_get_isDoneDelegate = new UnityEngine_Networking_UnityWebRequest_Property_get_isDoneType(UnityEngine_Networking_UnityWebRequest_Property_get_isDone);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Networking_UnityWebRequest_Property_get_isDoneType))]
        private static unsafe byte UnityEngine_Networking_UnityWebRequest_Property_get_isDone(System.IntPtr thiz)
        {
            
            var result = ((UnityEngine.Networking.UnityWebRequest)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).isDone;
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr UnityEngine_Networking_UnityWebRequest_Property_get_methodType(System.IntPtr thiz);
        private static unsafe readonly UnityEngine_Networking_UnityWebRequest_Property_get_methodType UnityEngine_Networking_UnityWebRequest_Property_get_methodDelegate = new UnityEngine_Networking_UnityWebRequest_Property_get_methodType(UnityEngine_Networking_UnityWebRequest_Property_get_method);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Networking_UnityWebRequest_Property_get_methodType))]
        private static unsafe System.IntPtr UnityEngine_Networking_UnityWebRequest_Property_get_method(System.IntPtr thiz)
        {
            
            var result = ((UnityEngine.Networking.UnityWebRequest)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).method;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate long UnityEngine_Networking_UnityWebRequest_Property_get_responseCodeType(System.IntPtr thiz);
        private static unsafe readonly UnityEngine_Networking_UnityWebRequest_Property_get_responseCodeType UnityEngine_Networking_UnityWebRequest_Property_get_responseCodeDelegate = new UnityEngine_Networking_UnityWebRequest_Property_get_responseCodeType(UnityEngine_Networking_UnityWebRequest_Property_get_responseCode);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Networking_UnityWebRequest_Property_get_responseCodeType))]
        private static unsafe long UnityEngine_Networking_UnityWebRequest_Property_get_responseCode(System.IntPtr thiz)
        {
            
            var result = ((UnityEngine.Networking.UnityWebRequest)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).responseCode;
            
            return result;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate UnityEngine.Networking.UnityWebRequest.Result UnityEngine_Networking_UnityWebRequest_Property_get_resultType(System.IntPtr thiz);
        private static unsafe readonly UnityEngine_Networking_UnityWebRequest_Property_get_resultType UnityEngine_Networking_UnityWebRequest_Property_get_resultDelegate = new UnityEngine_Networking_UnityWebRequest_Property_get_resultType(UnityEngine_Networking_UnityWebRequest_Property_get_result);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Networking_UnityWebRequest_Property_get_resultType))]
        private static unsafe UnityEngine.Networking.UnityWebRequest.Result UnityEngine_Networking_UnityWebRequest_Property_get_result(System.IntPtr thiz)
        {
            
            var result = ((UnityEngine.Networking.UnityWebRequest)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).result;
            
            return result;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr UnityEngine_Networking_UnityWebRequest_Property_get_urlType(System.IntPtr thiz);
        private static unsafe readonly UnityEngine_Networking_UnityWebRequest_Property_get_urlType UnityEngine_Networking_UnityWebRequest_Property_get_urlDelegate = new UnityEngine_Networking_UnityWebRequest_Property_get_urlType(UnityEngine_Networking_UnityWebRequest_Property_get_url);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Networking_UnityWebRequest_Property_get_urlType))]
        private static unsafe System.IntPtr UnityEngine_Networking_UnityWebRequest_Property_get_url(System.IntPtr thiz)
        {
            
            var result = ((UnityEngine.Networking.UnityWebRequest)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).url;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void UnityEngine_Networking_UnityWebRequest_Property_set_downloadHandlerType(System.IntPtr thiz, System.IntPtr value);
        private static unsafe readonly UnityEngine_Networking_UnityWebRequest_Property_set_downloadHandlerType UnityEngine_Networking_UnityWebRequest_Property_set_downloadHandlerDelegate = new UnityEngine_Networking_UnityWebRequest_Property_set_downloadHandlerType(UnityEngine_Networking_UnityWebRequest_Property_set_downloadHandler);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Networking_UnityWebRequest_Property_set_downloadHandlerType))]
        private static unsafe void UnityEngine_Networking_UnityWebRequest_Property_set_downloadHandler(System.IntPtr thiz, System.IntPtr value)
        {
            ((UnityEngine.Networking.UnityWebRequest)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).downloadHandler = (UnityEngine.Networking.DownloadHandler)Reinterop.ObjectHandleUtility.GetObjectFromHandle(value)!;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void UnityEngine_Networking_UnityWebRequest_Property_set_methodType(System.IntPtr thiz, System.IntPtr value);
        private static unsafe readonly UnityEngine_Networking_UnityWebRequest_Property_set_methodType UnityEngine_Networking_UnityWebRequest_Property_set_methodDelegate = new UnityEngine_Networking_UnityWebRequest_Property_set_methodType(UnityEngine_Networking_UnityWebRequest_Property_set_method);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Networking_UnityWebRequest_Property_set_methodType))]
        private static unsafe void UnityEngine_Networking_UnityWebRequest_Property_set_method(System.IntPtr thiz, System.IntPtr value)
        {
            ((UnityEngine.Networking.UnityWebRequest)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).method = (string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(value)!;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void UnityEngine_Networking_UnityWebRequest_Property_set_urlType(System.IntPtr thiz, System.IntPtr value);
        private static unsafe readonly UnityEngine_Networking_UnityWebRequest_Property_set_urlType UnityEngine_Networking_UnityWebRequest_Property_set_urlDelegate = new UnityEngine_Networking_UnityWebRequest_Property_set_urlType(UnityEngine_Networking_UnityWebRequest_Property_set_url);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Networking_UnityWebRequest_Property_set_urlType))]
        private static unsafe void UnityEngine_Networking_UnityWebRequest_Property_set_url(System.IntPtr thiz, System.IntPtr value)
        {
            ((UnityEngine.Networking.UnityWebRequest)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).url = (string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(value)!;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void UnityEngine_Networking_UnityWebRequestAsyncOperation_Calladd_completed_89b__Riirtgd1Q5mmRzPojAType(System.IntPtr thiz, System.IntPtr value);
        private static unsafe readonly UnityEngine_Networking_UnityWebRequestAsyncOperation_Calladd_completed_89b__Riirtgd1Q5mmRzPojAType UnityEngine_Networking_UnityWebRequestAsyncOperation_Calladd_completed_89b__Riirtgd1Q5mmRzPojADelegate = new UnityEngine_Networking_UnityWebRequestAsyncOperation_Calladd_completed_89b__Riirtgd1Q5mmRzPojAType(UnityEngine_Networking_UnityWebRequestAsyncOperation_Calladd_completed_89b__Riirtgd1Q5mmRzPojA);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Networking_UnityWebRequestAsyncOperation_Calladd_completed_89b__Riirtgd1Q5mmRzPojAType))]
        private static unsafe void UnityEngine_Networking_UnityWebRequestAsyncOperation_Calladd_completed_89b__Riirtgd1Q5mmRzPojA(System.IntPtr thiz, System.IntPtr value)
        {
            ((UnityEngine.Networking.UnityWebRequestAsyncOperation)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).completed += (System.Action<UnityEngine.AsyncOperation>)Reinterop.ObjectHandleUtility.GetObjectFromHandle(value)!;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void UnityEngine_Networking_UnityWebRequestAsyncOperation_Callremove_completed_89b__Riirtgd1Q5mmRzPojAType(System.IntPtr thiz, System.IntPtr value);
        private static unsafe readonly UnityEngine_Networking_UnityWebRequestAsyncOperation_Callremove_completed_89b__Riirtgd1Q5mmRzPojAType UnityEngine_Networking_UnityWebRequestAsyncOperation_Callremove_completed_89b__Riirtgd1Q5mmRzPojADelegate = new UnityEngine_Networking_UnityWebRequestAsyncOperation_Callremove_completed_89b__Riirtgd1Q5mmRzPojAType(UnityEngine_Networking_UnityWebRequestAsyncOperation_Callremove_completed_89b__Riirtgd1Q5mmRzPojA);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Networking_UnityWebRequestAsyncOperation_Callremove_completed_89b__Riirtgd1Q5mmRzPojAType))]
        private static unsafe void UnityEngine_Networking_UnityWebRequestAsyncOperation_Callremove_completed_89b__Riirtgd1Q5mmRzPojA(System.IntPtr thiz, System.IntPtr value)
        {
            ((UnityEngine.Networking.UnityWebRequestAsyncOperation)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).completed -= (System.Action<UnityEngine.AsyncOperation>)Reinterop.ObjectHandleUtility.GetObjectFromHandle(value)!;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr UnityEngine_Networking_UploadHandlerRaw_Construct_j9VUe_obWzqxHm0yKnVCmgType(System.IntPtr data, byte transferOwnership);
        private static unsafe readonly UnityEngine_Networking_UploadHandlerRaw_Construct_j9VUe_obWzqxHm0yKnVCmgType UnityEngine_Networking_UploadHandlerRaw_Construct_j9VUe_obWzqxHm0yKnVCmgDelegate = new UnityEngine_Networking_UploadHandlerRaw_Construct_j9VUe_obWzqxHm0yKnVCmgType(UnityEngine_Networking_UploadHandlerRaw_Construct_j9VUe_obWzqxHm0yKnVCmg);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Networking_UploadHandlerRaw_Construct_j9VUe_obWzqxHm0yKnVCmgType))]
        private static unsafe System.IntPtr UnityEngine_Networking_UploadHandlerRaw_Construct_j9VUe_obWzqxHm0yKnVCmg(System.IntPtr data, byte transferOwnership)
        {
            
            var result = new UnityEngine.Networking.UploadHandlerRaw((Unity.Collections.NativeArray<byte>)Reinterop.ObjectHandleUtility.GetObjectFromHandle(data)!, transferOwnership != 0);
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr UnityEngine_Networking_UploadHandlerRaw_Construct_Wn8TTeG3Q36ufSfvO3m1sgType(System.IntPtr data);
        private static unsafe readonly UnityEngine_Networking_UploadHandlerRaw_Construct_Wn8TTeG3Q36ufSfvO3m1sgType UnityEngine_Networking_UploadHandlerRaw_Construct_Wn8TTeG3Q36ufSfvO3m1sgDelegate = new UnityEngine_Networking_UploadHandlerRaw_Construct_Wn8TTeG3Q36ufSfvO3m1sgType(UnityEngine_Networking_UploadHandlerRaw_Construct_Wn8TTeG3Q36ufSfvO3m1sg);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Networking_UploadHandlerRaw_Construct_Wn8TTeG3Q36ufSfvO3m1sgType))]
        private static unsafe System.IntPtr UnityEngine_Networking_UploadHandlerRaw_Construct_Wn8TTeG3Q36ufSfvO3m1sg(System.IntPtr data)
        {
            
            var result = new UnityEngine.Networking.UploadHandlerRaw((byte[])Reinterop.ObjectHandleUtility.GetObjectFromHandle(data)!);
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void UnityEngine_Object_CallDestroyImmediate_c5oFMRh3nzKMIo8On83YBgType(System.IntPtr obj, byte allowDestroyingAssets);
        private static unsafe readonly UnityEngine_Object_CallDestroyImmediate_c5oFMRh3nzKMIo8On83YBgType UnityEngine_Object_CallDestroyImmediate_c5oFMRh3nzKMIo8On83YBgDelegate = new UnityEngine_Object_CallDestroyImmediate_c5oFMRh3nzKMIo8On83YBgType(UnityEngine_Object_CallDestroyImmediate_c5oFMRh3nzKMIo8On83YBg);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Object_CallDestroyImmediate_c5oFMRh3nzKMIo8On83YBgType))]
        private static unsafe void UnityEngine_Object_CallDestroyImmediate_c5oFMRh3nzKMIo8On83YBg(System.IntPtr obj, byte allowDestroyingAssets)
        {
            UnityEngine.Object.DestroyImmediate((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(obj)!, allowDestroyingAssets != 0);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void UnityEngine_Object_CallDestroyImmediate_x7aQMuJcEpatC9689ghI4AType(System.IntPtr obj);
        private static unsafe readonly UnityEngine_Object_CallDestroyImmediate_x7aQMuJcEpatC9689ghI4AType UnityEngine_Object_CallDestroyImmediate_x7aQMuJcEpatC9689ghI4ADelegate = new UnityEngine_Object_CallDestroyImmediate_x7aQMuJcEpatC9689ghI4AType(UnityEngine_Object_CallDestroyImmediate_x7aQMuJcEpatC9689ghI4A);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Object_CallDestroyImmediate_x7aQMuJcEpatC9689ghI4AType))]
        private static unsafe void UnityEngine_Object_CallDestroyImmediate_x7aQMuJcEpatC9689ghI4A(System.IntPtr obj)
        {
            UnityEngine.Object.DestroyImmediate((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(obj)!);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr UnityEngine_Object_CallFindObjectsOfType_0EgxpGTzCG1YTfWqwgLniwType();
        private static unsafe readonly UnityEngine_Object_CallFindObjectsOfType_0EgxpGTzCG1YTfWqwgLniwType UnityEngine_Object_CallFindObjectsOfType_0EgxpGTzCG1YTfWqwgLniwDelegate = new UnityEngine_Object_CallFindObjectsOfType_0EgxpGTzCG1YTfWqwgLniwType(UnityEngine_Object_CallFindObjectsOfType_0EgxpGTzCG1YTfWqwgLniw);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Object_CallFindObjectsOfType_0EgxpGTzCG1YTfWqwgLniwType))]
        private static unsafe System.IntPtr UnityEngine_Object_CallFindObjectsOfType_0EgxpGTzCG1YTfWqwgLniw()
        {
            
            var result = UnityEngine.Object.FindObjectsOfType<CesiumForUnity.Cesium3DTileset>();
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte UnityEngine_Object_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType(System.IntPtr x, System.IntPtr y);
        private static unsafe readonly UnityEngine_Object_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType UnityEngine_Object_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgDelegate = new UnityEngine_Object_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType(UnityEngine_Object_Callop_Equality_5bi2N6jTkaYVhpHPRxL2Wg);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Object_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType))]
        private static unsafe byte UnityEngine_Object_Callop_Equality_5bi2N6jTkaYVhpHPRxL2Wg(System.IntPtr x, System.IntPtr y)
        {
            
            var result = ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(x)!) == ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(y)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte UnityEngine_Object_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType(System.IntPtr x, System.IntPtr y);
        private static unsafe readonly UnityEngine_Object_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType UnityEngine_Object_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgDelegate = new UnityEngine_Object_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType(UnityEngine_Object_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2Wg);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Object_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType))]
        private static unsafe byte UnityEngine_Object_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2Wg(System.IntPtr x, System.IntPtr y)
        {
            
            var result = ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(x)!) != ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(y)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void UnityEngine_Rect_Construct_SWzoP__nNh7g2zNwjI5mUvQType(float x, float y, float width, float height, UnityEngine.Rect* pReturnValue);
        private static unsafe readonly UnityEngine_Rect_Construct_SWzoP__nNh7g2zNwjI5mUvQType UnityEngine_Rect_Construct_SWzoP__nNh7g2zNwjI5mUvQDelegate = new UnityEngine_Rect_Construct_SWzoP__nNh7g2zNwjI5mUvQType(UnityEngine_Rect_Construct_SWzoP__nNh7g2zNwjI5mUvQ);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Rect_Construct_SWzoP__nNh7g2zNwjI5mUvQType))]
        private static unsafe void UnityEngine_Rect_Construct_SWzoP__nNh7g2zNwjI5mUvQ(float x, float y, float width, float height, UnityEngine.Rect* pReturnValue)
        {
            
            var result = new UnityEngine.Rect(x, y, width, height);
            
            *pReturnValue = result;
        }

        #pragma warning restore 0252
    }
}
#endif
#if UNITY_EDITOR_WIN
using System;
using System.Runtime.InteropServices;

namespace Reinterop
{
    internal class ReinteropInitializer
    {
        public static void Initialize()
        {
            // This does nothing, but ensures the static constructor is
            // called exactly once.
        }

        // This function must be separate and occur before the static constructor.
        // See https://github.com/CesiumGS/cesium-unity/issues/227
        private static void AddFunctionPointers(IntPtr memory)
        {
            unsafe
            {
                Marshal.WriteIntPtr(memory, 0 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_AssetTroubleshootingDetails_Property_get_assetExistsInUserAccountDelegate));
                Marshal.WriteIntPtr(memory, 1 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_AssetTroubleshootingDetails_Property_get_loadedDelegate));
                Marshal.WriteIntPtr(memory, 2 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_AssetTroubleshootingDetails_Property_set_assetExistsInUserAccountDelegate));
                Marshal.WriteIntPtr(memory, 3 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_AssetTroubleshootingDetails_Property_set_loadedDelegate));
                Marshal.WriteIntPtr(memory, 4 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_Cesium3DTileset_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgDelegate));
                Marshal.WriteIntPtr(memory, 5 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_Cesium3DTileset_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgDelegate));
                Marshal.WriteIntPtr(memory, 6 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_Cesium3DTileset_CallRecreateTileset_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 7 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_Cesium3DTileset_Property_get_gameObjectDelegate));
                Marshal.WriteIntPtr(memory, 8 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_Cesium3DTileset_Property_get_ionAccessTokenDelegate));
                Marshal.WriteIntPtr(memory, 9 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_Cesium3DTileset_Property_get_ionAssetIDDelegate));
                Marshal.WriteIntPtr(memory, 10 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_Cesium3DTileset_Property_get_tilesetSourceDelegate));
                Marshal.WriteIntPtr(memory, 11 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_Cesium3DTileset_Property_set_ionAccessTokenDelegate));
                Marshal.WriteIntPtr(memory, 12 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_Cesium3DTileset_Property_set_ionAssetIDDelegate));
                Marshal.WriteIntPtr(memory, 13 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_Cesium3DTileset_Property_set_tilesetSourceDelegate));
                Marshal.WriteIntPtr(memory, 14 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumEditorUtility_CallAddBaseOverlayToTileset_GE91HI1OIybUlB1E__yYJCQDelegate));
                Marshal.WriteIntPtr(memory, 15 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumEditorUtility_CallCreateTileset_jsvXjE1xIXP0dz0Yem4NagDelegate));
                Marshal.WriteIntPtr(memory, 16 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumEditorUtility_CallFindFirstTileset_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 17 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumEditorUtility_CallFindFirstTilesetWithAssetID_OUsZiF60__hSy6sWtVPSwsADelegate));
                Marshal.WriteIntPtr(memory, 18 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumEditorWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 19 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumEditorWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgDelegate));
                Marshal.WriteIntPtr(memory, 20 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumEditorWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgDelegate));
                Marshal.WriteIntPtr(memory, 21 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumEditorWindow_Field_get_currentWindowDelegate));
                Marshal.WriteIntPtr(memory, 22 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumEditorWindow_Field_set_currentWindowDelegate));
                Marshal.WriteIntPtr(memory, 23 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumEditorWindow_Property_get_NativeImplementationDelegate));
                Marshal.WriteIntPtr(memory, 24 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumIonAsset_CallIsNull_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 25 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumIonAsset_Property_get_componentTypeDelegate));
                Marshal.WriteIntPtr(memory, 26 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumIonAsset_Property_get_ionAccessTokenDelegate));
                Marshal.WriteIntPtr(memory, 27 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumIonAsset_Property_get_ionAssetIDDelegate));
                Marshal.WriteIntPtr(memory, 28 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumIonAsset_Property_get_objectNameDelegate));
                Marshal.WriteIntPtr(memory, 29 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumIonAsset_Property_get_typeDelegate));
                Marshal.WriteIntPtr(memory, 30 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumIonAsset_Property_set_ionAccessTokenDelegate));
                Marshal.WriteIntPtr(memory, 31 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumIonRasterOverlay_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgDelegate));
                Marshal.WriteIntPtr(memory, 32 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumIonRasterOverlay_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgDelegate));
                Marshal.WriteIntPtr(memory, 33 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumIonRasterOverlay_CallRefresh_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 34 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumIonRasterOverlay_Property_get_gameObjectDelegate));
                Marshal.WriteIntPtr(memory, 35 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumIonRasterOverlay_Property_get_ionAccessTokenDelegate));
                Marshal.WriteIntPtr(memory, 36 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumIonRasterOverlay_Property_get_ionAssetIDDelegate));
                Marshal.WriteIntPtr(memory, 37 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumIonRasterOverlay_Property_set_ionAccessTokenDelegate));
                Marshal.WriteIntPtr(memory, 38 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumIonRasterOverlay_Property_set_ionAssetIDDelegate));
                Marshal.WriteIntPtr(memory, 39 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumIonSession_CallBroadcastAssetsUpdate_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 40 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumIonSession_CallBroadcastConnectionUpdate_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 41 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumIonSession_CallBroadcastProfileUpdate_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 42 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumIonSession_CallBroadcastTokensUpdate_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 43 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumIonSession_CallIon_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 44 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumIonSession_CallIsConnected_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 45 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumIonSession_Property_get_NativeImplementationDelegate));
                Marshal.WriteIntPtr(memory, 46 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumRasterOverlay_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgDelegate));
                Marshal.WriteIntPtr(memory, 47 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumRasterOverlay_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgDelegate));
                Marshal.WriteIntPtr(memory, 48 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumRasterOverlay_CallRefresh_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 49 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumRasterOverlay_Property_get_gameObjectDelegate));
                Marshal.WriteIntPtr(memory, 50 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumRuntimeSettings_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgDelegate));
                Marshal.WriteIntPtr(memory, 51 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumRuntimeSettings_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgDelegate));
                Marshal.WriteIntPtr(memory, 52 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumRuntimeSettings_Property_get_defaultIonAccessTokenDelegate));
                Marshal.WriteIntPtr(memory, 53 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumRuntimeSettings_Property_get_defaultIonAccessTokenIDDelegate));
                Marshal.WriteIntPtr(memory, 54 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumRuntimeSettings_Property_set_defaultIonAccessTokenDelegate));
                Marshal.WriteIntPtr(memory, 55 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_CesiumRuntimeSettings_Property_set_defaultIonAccessTokenIDDelegate));
                Marshal.WriteIntPtr(memory, 56 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_Helpers_CallToString__8pn__Nas4aiRxhf1NkpeKgDelegate));
                Marshal.WriteIntPtr(memory, 57 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_IonAssetDetails_CallFormatDate_Wg__UxSmEJUgHx3kyfccFEwDelegate));
                Marshal.WriteIntPtr(memory, 58 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_IonAssetDetails_CallFormatType_3GczHehc_XCRt9ReXGSrdQDelegate));
                Marshal.WriteIntPtr(memory, 59 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_IonAssetsTreeView_CallReload_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 60 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_IonAssetsTreeView_Construct_bk3kO2aTAFaE0GWD9sxbigDelegate));
                Marshal.WriteIntPtr(memory, 61 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_IonAssetsTreeView_Property_get_multiColumnHeaderDelegate));
                Marshal.WriteIntPtr(memory, 62 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_IonAssetsTreeView_Property_get_NativeImplementationDelegate));
                Marshal.WriteIntPtr(memory, 63 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_IonAssetsTreeView_Property_get_searchStringDelegate));
                Marshal.WriteIntPtr(memory, 64 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_IonAssetsTreeView_Property_set_multiColumnHeaderDelegate));
                Marshal.WriteIntPtr(memory, 65 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_IonAssetsTreeView_Property_set_searchStringDelegate));
                Marshal.WriteIntPtr(memory, 66 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_IonMissingAssetWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 67 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_IonMissingAssetWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgDelegate));
                Marshal.WriteIntPtr(memory, 68 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_IonMissingAssetWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgDelegate));
                Marshal.WriteIntPtr(memory, 69 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_IonMissingAssetWindow_CallShowWindow_zCuaF57FLiXZD1__wksXLdQDelegate));
                Marshal.WriteIntPtr(memory, 70 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_IonTokenTroubleshootingWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 71 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_IonTokenTroubleshootingWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgDelegate));
                Marshal.WriteIntPtr(memory, 72 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_IonTokenTroubleshootingWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgDelegate));
                Marshal.WriteIntPtr(memory, 73 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_IonTokenTroubleshootingWindow_CallUseDefaultToken_qpX7eE7SvOg4KIeidX7yngDelegate));
                Marshal.WriteIntPtr(memory, 74 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_assetDetailsDelegate));
                Marshal.WriteIntPtr(memory, 75 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_assetTokenDetailsDelegate));
                Marshal.WriteIntPtr(memory, 76 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_defaultTokenDetailsDelegate));
                Marshal.WriteIntPtr(memory, 77 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_ionAssetDelegate));
                Marshal.WriteIntPtr(memory, 78 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_IonTokenTroubleshootingWindow_Property_set_ionAssetDelegate));
                Marshal.WriteIntPtr(memory, 79 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_NativeDownloadHandler_CallDispose_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 80 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_NativeDownloadHandler_Construct_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 81 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_NativeDownloadHandler_Property_get_NativeImplementationDelegate));
                Marshal.WriteIntPtr(memory, 82 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_SelectIonTokenWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 83 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_SelectIonTokenWindow_CallGetDefaultNewTokenName_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 84 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_SelectIonTokenWindow_CallGetExistingTokenList_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 85 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_SelectIonTokenWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgDelegate));
                Marshal.WriteIntPtr(memory, 86 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_SelectIonTokenWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgDelegate));
                Marshal.WriteIntPtr(memory, 87 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_SelectIonTokenWindow_CallRefreshExistingTokenList_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 88 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_SelectIonTokenWindow_CallShowWindow_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 89 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_SelectIonTokenWindow_Field_get_currentWindowDelegate));
                Marshal.WriteIntPtr(memory, 90 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_SelectIonTokenWindow_Field_set_currentWindowDelegate));
                Marshal.WriteIntPtr(memory, 91 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_SelectIonTokenWindow_Property_get_createdTokenNameDelegate));
                Marshal.WriteIntPtr(memory, 92 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_SelectIonTokenWindow_Property_get_NativeImplementationDelegate));
                Marshal.WriteIntPtr(memory, 93 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_SelectIonTokenWindow_Property_get_selectedExistingTokenIndexDelegate));
                Marshal.WriteIntPtr(memory, 94 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_SelectIonTokenWindow_Property_get_specifiedTokenDelegate));
                Marshal.WriteIntPtr(memory, 95 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_SelectIonTokenWindow_Property_get_tokenSourceDelegate));
                Marshal.WriteIntPtr(memory, 96 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_SelectIonTokenWindow_Property_set_createdTokenNameDelegate));
                Marshal.WriteIntPtr(memory, 97 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_SelectIonTokenWindow_Property_set_selectedExistingTokenIndexDelegate));
                Marshal.WriteIntPtr(memory, 98 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_SelectIonTokenWindow_Property_set_specifiedTokenDelegate));
                Marshal.WriteIntPtr(memory, 99 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_SelectIonTokenWindow_Property_set_tokenSourceDelegate));
                Marshal.WriteIntPtr(memory, 100 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_TokenTroubleshootingDetails_Property_get_allowsAccessToAssetDelegate));
                Marshal.WriteIntPtr(memory, 101 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_TokenTroubleshootingDetails_Property_get_associatedWithUserAccountDelegate));
                Marshal.WriteIntPtr(memory, 102 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_TokenTroubleshootingDetails_Property_get_isValidDelegate));
                Marshal.WriteIntPtr(memory, 103 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_TokenTroubleshootingDetails_Property_get_loadedDelegate));
                Marshal.WriteIntPtr(memory, 104 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_TokenTroubleshootingDetails_Property_get_tokenDelegate));
                Marshal.WriteIntPtr(memory, 105 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_TokenTroubleshootingDetails_Property_set_allowsAccessToAssetDelegate));
                Marshal.WriteIntPtr(memory, 106 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_TokenTroubleshootingDetails_Property_set_associatedWithUserAccountDelegate));
                Marshal.WriteIntPtr(memory, 107 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_TokenTroubleshootingDetails_Property_set_isValidDelegate));
                Marshal.WriteIntPtr(memory, 108 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_TokenTroubleshootingDetails_Property_set_loadedDelegate));
                Marshal.WriteIntPtr(memory, 109 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_TokenTroubleshootingDetails_Property_set_tokenDelegate));
                Marshal.WriteIntPtr(memory, 110 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(Reinterop_ObjectHandleUtility_CallCopyHandle_Lk0gUmdC13dRVZ_MAT71egDelegate));
                Marshal.WriteIntPtr(memory, 111 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(Reinterop_ObjectHandleUtility_CallCreateHandle_vjOnn8y5DjvqKs3467vAJQDelegate));
                Marshal.WriteIntPtr(memory, 112 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(Reinterop_ObjectHandleUtility_CallFreeHandle_Lk0gUmdC13dRVZ_MAT71egDelegate));
                Marshal.WriteIntPtr(memory, 113 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_Action_CallInvoke_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 114 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_Action_Callop_Equality__iYzpyUo7S__gDd8L5jFzrgDelegate));
                Marshal.WriteIntPtr(memory, 115 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_Action_Callop_Equality_a0RmOPC1vpOfulhhfnafBADelegate));
                Marshal.WriteIntPtr(memory, 116 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_Action_Callop_Inequality__iYzpyUo7S__gDd8L5jFzrgDelegate));
                Marshal.WriteIntPtr(memory, 117 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_Action_Callop_Inequality_a0RmOPC1vpOfulhhfnafBADelegate));
                Marshal.WriteIntPtr(memory, 118 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_Action_CombineDelegatesDelegate));
                Marshal.WriteIntPtr(memory, 119 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_Action_CreateDelegateDelegate));
                Marshal.WriteIntPtr(memory, 120 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_Action_RemoveDelegateDelegate));
                Marshal.WriteIntPtr(memory, 121 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_ActionA2lFbwI_1jdffaYu1u_OZg_CallInvoke_GZtSECpzDV__dvLP8ujKEdADelegate));
                Marshal.WriteIntPtr(memory, 122 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Equality__iYzpyUo7S__gDd8L5jFzrgDelegate));
                Marshal.WriteIntPtr(memory, 123 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Equality_a0RmOPC1vpOfulhhfnafBADelegate));
                Marshal.WriteIntPtr(memory, 124 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Inequality__iYzpyUo7S__gDd8L5jFzrgDelegate));
                Marshal.WriteIntPtr(memory, 125 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Inequality_a0RmOPC1vpOfulhhfnafBADelegate));
                Marshal.WriteIntPtr(memory, 126 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_ActionA2lFbwI_1jdffaYu1u_OZg_CombineDelegatesDelegate));
                Marshal.WriteIntPtr(memory, 127 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_ActionA2lFbwI_1jdffaYu1u_OZg_CreateDelegateDelegate));
                Marshal.WriteIntPtr(memory, 128 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_ActionA2lFbwI_1jdffaYu1u_OZg_RemoveDelegateDelegate));
                Marshal.WriteIntPtr(memory, 129 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_Array_Property_get_LengthDelegate));
                Marshal.WriteIntPtr(memory, 130 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_Constructor_SizeDelegate));
                Marshal.WriteIntPtr(memory, 131 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_Property_get_ItemDelegate));
                Marshal.WriteIntPtr(memory, 132 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_Property_get_LengthDelegate));
                Marshal.WriteIntPtr(memory, 133 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_SetItemDelegate));
                Marshal.WriteIntPtr(memory, 134 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_Constructor_SizeDelegate));
                Marshal.WriteIntPtr(memory, 135 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_Property_get_ItemDelegate));
                Marshal.WriteIntPtr(memory, 136 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_Property_get_LengthDelegate));
                Marshal.WriteIntPtr(memory, 137 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_SetItemDelegate));
                Marshal.WriteIntPtr(memory, 138 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_Constructor_SizeDelegate));
                Marshal.WriteIntPtr(memory, 139 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_Property_get_ItemDelegate));
                Marshal.WriteIntPtr(memory, 140 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_Property_get_LengthDelegate));
                Marshal.WriteIntPtr(memory, 141 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_SetItemDelegate));
                Marshal.WriteIntPtr(memory, 142 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_Array1z79ECk55IqLfMIqXBYg_8w_Constructor_SizeDelegate));
                Marshal.WriteIntPtr(memory, 143 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_Array1z79ECk55IqLfMIqXBYg_8w_Property_get_LengthDelegate));
                Marshal.WriteIntPtr(memory, 144 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_Array1z79ECk55IqLfMIqXBYg_8w_SetItemDelegate));
                Marshal.WriteIntPtr(memory, 145 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_Collections_Generic_Dictionary5Hx6c0Eu2sl__zevLSSpjKA_CallGetEnumerator_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 146 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_Collections_Generic_Enumerator1B2M2Y8AsgTpgAmY7PhCfg_CallMoveNext_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 147 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_Collections_Generic_Enumerator1B2M2Y8AsgTpgAmY7PhCfg_Property_get_CurrentDelegate));
                Marshal.WriteIntPtr(memory, 148 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_Collections_Generic_KeyValuePair5Hx6c0Eu2sl__zevLSSpjKA_Property_get_KeyDelegate));
                Marshal.WriteIntPtr(memory, 149 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_Collections_Generic_KeyValuePair5Hx6c0Eu2sl__zevLSSpjKA_Property_get_ValueDelegate));
                Marshal.WriteIntPtr(memory, 150 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_Collections_Generic_List5eSlqDLksZG1Mz9C9wH0GQ_CallAdd_LRSjiXmrvb5pgfbcZ_Nv7wDelegate));
                Marshal.WriteIntPtr(memory, 151 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_Collections_Generic_List5eSlqDLksZG1Mz9C9wH0GQ_CallClear_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 152 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_Delegate_Callop_Equality_a0RmOPC1vpOfulhhfnafBADelegate));
                Marshal.WriteIntPtr(memory, 153 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_Delegate_Callop_Inequality_a0RmOPC1vpOfulhhfnafBADelegate));
                Marshal.WriteIntPtr(memory, 154 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_Environment_Property_get_OSVersionDelegate));
                Marshal.WriteIntPtr(memory, 155 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_MulticastDelegate_Callop_Equality__iYzpyUo7S__gDd8L5jFzrgDelegate));
                Marshal.WriteIntPtr(memory, 156 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_MulticastDelegate_Callop_Equality_a0RmOPC1vpOfulhhfnafBADelegate));
                Marshal.WriteIntPtr(memory, 157 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_MulticastDelegate_Callop_Inequality__iYzpyUo7S__gDd8L5jFzrgDelegate));
                Marshal.WriteIntPtr(memory, 158 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_MulticastDelegate_Callop_Inequality_a0RmOPC1vpOfulhhfnafBADelegate));
                Marshal.WriteIntPtr(memory, 159 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_Object_Construct_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 160 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_OperatingSystem_Property_get_VersionStringDelegate));
                Marshal.WriteIntPtr(memory, 161 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_Runtime_InteropServices_Marshal_CallFreeCoTaskMem_eF5IwSJe_WM3IuDxcegQFgDelegate));
                Marshal.WriteIntPtr(memory, 162 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_Runtime_InteropServices_Marshal_CallStringToCoTaskMemUTF8_ga80EVd9gqZ4YlhSP8iRzgDelegate));
                Marshal.WriteIntPtr(memory, 163 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_String_CallConcat_OM9SoWVFMTHXvbepMyUchwDelegate));
                Marshal.WriteIntPtr(memory, 164 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_String_CallConcat_yq7nlytzIFp8a79slfH_mwDelegate));
                Marshal.WriteIntPtr(memory, 165 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_String_CallContains_GImL1A5rlEQAx14EidO2oADelegate));
                Marshal.WriteIntPtr(memory, 166 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_String_CallEquals_46DLRq__QwpwCx8Uf20Cl7ADelegate));
                Marshal.WriteIntPtr(memory, 167 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_String_CallIsNullOrEmpty_ZOWEGUlscki07yVzH4i4wwDelegate));
                Marshal.WriteIntPtr(memory, 168 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_String_Callop_Equality_46DLRq__QwpwCx8Uf20Cl7ADelegate));
                Marshal.WriteIntPtr(memory, 169 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_String_Callop_Inequality_46DLRq__QwpwCx8Uf20Cl7ADelegate));
                Marshal.WriteIntPtr(memory, 170 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_String_Property_get_LengthDelegate));
                Marshal.WriteIntPtr(memory, 171 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_Text_Encoding_CallGetString_J_gIxYGOW0ecDuybXJZsCwDelegate));
                Marshal.WriteIntPtr(memory, 172 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_Text_Encoding_Property_get_UTF8Delegate));
                Marshal.WriteIntPtr(memory, 173 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(System_Threading_Tasks_Task_CallRun_uG3jiSYLEmrwe0pJoPtxoADelegate));
                Marshal.WriteIntPtr(memory, 174 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(Unity_Collections_LowLevel_Unsafe_NativeArrayUnsafeUtility_CallGetUnsafeBufferPointerWithoutChecks_QIjAavb5O6M1Tim2Rs2ohQDelegate));
                Marshal.WriteIntPtr(memory, 175 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(Unity_Collections_NativeArrayz79ECk55IqLfMIqXBYg_8w_Callop_Equality___ZFbUbDYmnqRGnwegIjKPwDelegate));
                Marshal.WriteIntPtr(memory, 176 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(Unity_Collections_NativeArrayz79ECk55IqLfMIqXBYg_8w_Callop_Inequality___ZFbUbDYmnqRGnwegIjKPwDelegate));
                Marshal.WriteIntPtr(memory, 177 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(Unity_Collections_NativeArrayz79ECk55IqLfMIqXBYg_8w_Construct_fyLz0cEPCtnsPNSt__omZwQDelegate));
                Marshal.WriteIntPtr(memory, 178 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEditor_EditorApplication_CallExecuteMenuItem__mTAWffFaNJNxtE3VLYhxwDelegate));
                Marshal.WriteIntPtr(memory, 179 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEditor_EditorPrefs_CallDeleteKey_4Oa4KGDR__vvaosUsC29xLgDelegate));
                Marshal.WriteIntPtr(memory, 180 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEditor_EditorPrefs_CallGetString_4Oa4KGDR__vvaosUsC29xLgDelegate));
                Marshal.WriteIntPtr(memory, 181 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEditor_EditorPrefs_CallHasKey_4Oa4KGDR__vvaosUsC29xLgDelegate));
                Marshal.WriteIntPtr(memory, 182 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEditor_EditorPrefs_CallSetString_eMSjpsyKrCDpoy__674QaewDelegate));
                Marshal.WriteIntPtr(memory, 183 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEditor_EditorWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 184 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEditor_EditorWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgDelegate));
                Marshal.WriteIntPtr(memory, 185 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEditor_EditorWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgDelegate));
                Marshal.WriteIntPtr(memory, 186 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEditor_IMGUI_Controls_MultiColumnHeader_CallIsSortedAscending_ZiJhFqE0LPDoV__RgQlNVpQDelegate));
                Marshal.WriteIntPtr(memory, 187 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEditor_IMGUI_Controls_MultiColumnHeader_Property_get_sortedColumnIndexDelegate));
                Marshal.WriteIntPtr(memory, 188 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEditor_IMGUI_Controls_MultiColumnHeader_Property_set_sortedColumnIndexDelegate));
                Marshal.WriteIntPtr(memory, 189 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEditor_IMGUI_Controls_TreeView_CallReload_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 190 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEditor_IMGUI_Controls_TreeView_Property_get_multiColumnHeaderDelegate));
                Marshal.WriteIntPtr(memory, 191 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEditor_IMGUI_Controls_TreeView_Property_get_searchStringDelegate));
                Marshal.WriteIntPtr(memory, 192 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEditor_IMGUI_Controls_TreeView_Property_set_multiColumnHeaderDelegate));
                Marshal.WriteIntPtr(memory, 193 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEditor_IMGUI_Controls_TreeView_Property_set_searchStringDelegate));
                Marshal.WriteIntPtr(memory, 194 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEditor_IMGUI_Controls_TreeViewItem_Construct_fAkE2H7EjTzReHiM2XHBPADelegate));
                Marshal.WriteIntPtr(memory, 195 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEditor_IMGUI_Controls_TreeViewItem_Property_get_idDelegate));
                Marshal.WriteIntPtr(memory, 196 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEditor_IMGUI_Controls_TreeViewItem_Property_set_idDelegate));
                Marshal.WriteIntPtr(memory, 197 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEditor_IMGUI_Controls_TreeViewState_Construct_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 198 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEditor_Selection_Property_get_activeGameObjectDelegate));
                Marshal.WriteIntPtr(memory, 199 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEditor_Selection_Property_set_activeGameObjectDelegate));
                Marshal.WriteIntPtr(memory, 200 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Application_CallOpenURL_i4__FgVIR5VYHO4KBzPBwNQDelegate));
                Marshal.WriteIntPtr(memory, 201 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Application_Property_get_platformDelegate));
                Marshal.WriteIntPtr(memory, 202 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Application_Property_get_productNameDelegate));
                Marshal.WriteIntPtr(memory, 203 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Application_Property_get_unityVersionDelegate));
                Marshal.WriteIntPtr(memory, 204 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Application_Property_get_versionDelegate));
                Marshal.WriteIntPtr(memory, 205 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_AsyncOperation_Calladd_completed_89b__Riirtgd1Q5mmRzPojADelegate));
                Marshal.WriteIntPtr(memory, 206 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_AsyncOperation_Callremove_completed_89b__Riirtgd1Q5mmRzPojADelegate));
                Marshal.WriteIntPtr(memory, 207 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Component_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgDelegate));
                Marshal.WriteIntPtr(memory, 208 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Component_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgDelegate));
                Marshal.WriteIntPtr(memory, 209 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Component_Property_get_gameObjectDelegate));
                Marshal.WriteIntPtr(memory, 210 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Debug_CallLog_FA05wu8x__otZNsgdHTnU9ADelegate));
                Marshal.WriteIntPtr(memory, 211 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Debug_CallLogError_FA05wu8x__otZNsgdHTnU9ADelegate));
                Marshal.WriteIntPtr(memory, 212 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Debug_CallLogWarning_FA05wu8x__otZNsgdHTnU9ADelegate));
                Marshal.WriteIntPtr(memory, 213 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_GameObject_CallAddComponent_0EgxpGTzCG1YTfWqwgLniwDelegate));
                Marshal.WriteIntPtr(memory, 214 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_GameObject_CallAddComponent_BAtcoWNWVoAVplmna6OgsQDelegate));
                Marshal.WriteIntPtr(memory, 215 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_GameObject_CallGetComponent_0EgxpGTzCG1YTfWqwgLniwDelegate));
                Marshal.WriteIntPtr(memory, 216 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_GameObject_CallGetComponent_BAtcoWNWVoAVplmna6OgsQDelegate));
                Marshal.WriteIntPtr(memory, 217 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_GameObject_CallGetComponents_BAtcoWNWVoAVplmna6OgsQDelegate));
                Marshal.WriteIntPtr(memory, 218 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_GameObject_CallGetComponents_H1UZCBm__Pf6NnqpE7xQ8NQDelegate));
                Marshal.WriteIntPtr(memory, 219 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_GameObject_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgDelegate));
                Marshal.WriteIntPtr(memory, 220 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_GameObject_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgDelegate));
                Marshal.WriteIntPtr(memory, 221 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_GameObject_Construct_wfPSjxsETIcebv8un8PGZwDelegate));
                Marshal.WriteIntPtr(memory, 222 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_GUI_CallLabel_iRU7t71QqJzkr4BTYehN9ADelegate));
                Marshal.WriteIntPtr(memory, 223 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Networking_DownloadHandler_CallDispose_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 224 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Networking_UnityWebRequest_CallGet_Y2__l4HVQ8CbSg4jpXDip9ADelegate));
                Marshal.WriteIntPtr(memory, 225 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Networking_UnityWebRequest_CallGetResponseHeader_wfPSjxsETIcebv8un8PGZwDelegate));
                Marshal.WriteIntPtr(memory, 226 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Networking_UnityWebRequest_CallGetResponseHeaders_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 227 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Networking_UnityWebRequest_CallSendWebRequest_1B2M2Y8AsgTpgAmY7PhCfgDelegate));
                Marshal.WriteIntPtr(memory, 228 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Networking_UnityWebRequest_CallSetRequestHeader_tEfBle3aSdR47_HxLakNjwDelegate));
                Marshal.WriteIntPtr(memory, 229 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Networking_UnityWebRequest_Construct_N5nF6s7__PflIcgtgQgj6DADelegate));
                Marshal.WriteIntPtr(memory, 230 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Networking_UnityWebRequest_Property_get_downloadHandlerDelegate));
                Marshal.WriteIntPtr(memory, 231 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Networking_UnityWebRequest_Property_get_errorDelegate));
                Marshal.WriteIntPtr(memory, 232 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Networking_UnityWebRequest_Property_get_isDoneDelegate));
                Marshal.WriteIntPtr(memory, 233 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Networking_UnityWebRequest_Property_get_methodDelegate));
                Marshal.WriteIntPtr(memory, 234 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Networking_UnityWebRequest_Property_get_responseCodeDelegate));
                Marshal.WriteIntPtr(memory, 235 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Networking_UnityWebRequest_Property_get_resultDelegate));
                Marshal.WriteIntPtr(memory, 236 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Networking_UnityWebRequest_Property_get_urlDelegate));
                Marshal.WriteIntPtr(memory, 237 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Networking_UnityWebRequest_Property_set_downloadHandlerDelegate));
                Marshal.WriteIntPtr(memory, 238 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Networking_UnityWebRequest_Property_set_methodDelegate));
                Marshal.WriteIntPtr(memory, 239 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Networking_UnityWebRequest_Property_set_urlDelegate));
                Marshal.WriteIntPtr(memory, 240 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Networking_UnityWebRequestAsyncOperation_Calladd_completed_89b__Riirtgd1Q5mmRzPojADelegate));
                Marshal.WriteIntPtr(memory, 241 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Networking_UnityWebRequestAsyncOperation_Callremove_completed_89b__Riirtgd1Q5mmRzPojADelegate));
                Marshal.WriteIntPtr(memory, 242 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Networking_UploadHandlerRaw_Construct_j9VUe_obWzqxHm0yKnVCmgDelegate));
                Marshal.WriteIntPtr(memory, 243 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Networking_UploadHandlerRaw_Construct_Wn8TTeG3Q36ufSfvO3m1sgDelegate));
                Marshal.WriteIntPtr(memory, 244 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Object_CallDestroyImmediate_c5oFMRh3nzKMIo8On83YBgDelegate));
                Marshal.WriteIntPtr(memory, 245 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Object_CallDestroyImmediate_x7aQMuJcEpatC9689ghI4ADelegate));
                Marshal.WriteIntPtr(memory, 246 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Object_CallFindObjectsOfType_0EgxpGTzCG1YTfWqwgLniwDelegate));
                Marshal.WriteIntPtr(memory, 247 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Object_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgDelegate));
                Marshal.WriteIntPtr(memory, 248 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Object_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgDelegate));
                Marshal.WriteIntPtr(memory, 249 * sizeof(IntPtr), Marshal.GetFunctionPointerForDelegate(UnityEngine_Rect_Construct_SWzoP__nNh7g2zNwjI5mUvQDelegate));
            }
        }

        static ReinteropInitializer()
        {
            unsafe
            {
                IntPtr memory = Marshal.AllocHGlobal(sizeof(IntPtr) * 250);
                AddFunctionPointers(memory);
                byte success = initializeReinterop(12523656046724051223UL, memory, 250);
                if (success == 0)
                    throw new NotImplementedException("The native library is out of sync with the managed one.");
            }
        }

        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static extern byte initializeReinterop(ulong validationHash, IntPtr functionPointers, int count);

        // Roslyn raises CS0252 spuriously for MulticastDelegate operator==, so disable the warning
        // See https://github.com/dotnet/roslyn/issues/17212
        //     https://github.com/dotnet/roslyn/issues/58996
        #pragma warning disable 0252

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte CesiumForUnity_AssetTroubleshootingDetails_Property_get_assetExistsInUserAccountType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_AssetTroubleshootingDetails_Property_get_assetExistsInUserAccountType CesiumForUnity_AssetTroubleshootingDetails_Property_get_assetExistsInUserAccountDelegate = new CesiumForUnity_AssetTroubleshootingDetails_Property_get_assetExistsInUserAccountType(CesiumForUnity_AssetTroubleshootingDetails_Property_get_assetExistsInUserAccount);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_AssetTroubleshootingDetails_Property_get_assetExistsInUserAccountType))]
        private static unsafe byte CesiumForUnity_AssetTroubleshootingDetails_Property_get_assetExistsInUserAccount(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.AssetTroubleshootingDetails)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).assetExistsInUserAccount;
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte CesiumForUnity_AssetTroubleshootingDetails_Property_get_loadedType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_AssetTroubleshootingDetails_Property_get_loadedType CesiumForUnity_AssetTroubleshootingDetails_Property_get_loadedDelegate = new CesiumForUnity_AssetTroubleshootingDetails_Property_get_loadedType(CesiumForUnity_AssetTroubleshootingDetails_Property_get_loaded);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_AssetTroubleshootingDetails_Property_get_loadedType))]
        private static unsafe byte CesiumForUnity_AssetTroubleshootingDetails_Property_get_loaded(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.AssetTroubleshootingDetails)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).loaded;
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_AssetTroubleshootingDetails_Property_set_assetExistsInUserAccountType(System.IntPtr thiz, byte value);
        private static unsafe readonly CesiumForUnity_AssetTroubleshootingDetails_Property_set_assetExistsInUserAccountType CesiumForUnity_AssetTroubleshootingDetails_Property_set_assetExistsInUserAccountDelegate = new CesiumForUnity_AssetTroubleshootingDetails_Property_set_assetExistsInUserAccountType(CesiumForUnity_AssetTroubleshootingDetails_Property_set_assetExistsInUserAccount);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_AssetTroubleshootingDetails_Property_set_assetExistsInUserAccountType))]
        private static unsafe void CesiumForUnity_AssetTroubleshootingDetails_Property_set_assetExistsInUserAccount(System.IntPtr thiz, byte value)
        {
            ((CesiumForUnity.AssetTroubleshootingDetails)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).assetExistsInUserAccount = value != 0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_AssetTroubleshootingDetails_Property_set_loadedType(System.IntPtr thiz, byte value);
        private static unsafe readonly CesiumForUnity_AssetTroubleshootingDetails_Property_set_loadedType CesiumForUnity_AssetTroubleshootingDetails_Property_set_loadedDelegate = new CesiumForUnity_AssetTroubleshootingDetails_Property_set_loadedType(CesiumForUnity_AssetTroubleshootingDetails_Property_set_loaded);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_AssetTroubleshootingDetails_Property_set_loadedType))]
        private static unsafe void CesiumForUnity_AssetTroubleshootingDetails_Property_set_loaded(System.IntPtr thiz, byte value)
        {
            ((CesiumForUnity.AssetTroubleshootingDetails)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).loaded = value != 0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte CesiumForUnity_Cesium3DTileset_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType(System.IntPtr x, System.IntPtr y);
        private static unsafe readonly CesiumForUnity_Cesium3DTileset_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType CesiumForUnity_Cesium3DTileset_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgDelegate = new CesiumForUnity_Cesium3DTileset_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType(CesiumForUnity_Cesium3DTileset_Callop_Equality_5bi2N6jTkaYVhpHPRxL2Wg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_Cesium3DTileset_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType))]
        private static unsafe byte CesiumForUnity_Cesium3DTileset_Callop_Equality_5bi2N6jTkaYVhpHPRxL2Wg(System.IntPtr x, System.IntPtr y)
        {
            
            var result = ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(x)!) == ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(y)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte CesiumForUnity_Cesium3DTileset_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType(System.IntPtr x, System.IntPtr y);
        private static unsafe readonly CesiumForUnity_Cesium3DTileset_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType CesiumForUnity_Cesium3DTileset_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgDelegate = new CesiumForUnity_Cesium3DTileset_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType(CesiumForUnity_Cesium3DTileset_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2Wg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_Cesium3DTileset_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType))]
        private static unsafe byte CesiumForUnity_Cesium3DTileset_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2Wg(System.IntPtr x, System.IntPtr y)
        {
            
            var result = ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(x)!) != ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(y)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_Cesium3DTileset_CallRecreateTileset_1B2M2Y8AsgTpgAmY7PhCfgType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_Cesium3DTileset_CallRecreateTileset_1B2M2Y8AsgTpgAmY7PhCfgType CesiumForUnity_Cesium3DTileset_CallRecreateTileset_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new CesiumForUnity_Cesium3DTileset_CallRecreateTileset_1B2M2Y8AsgTpgAmY7PhCfgType(CesiumForUnity_Cesium3DTileset_CallRecreateTileset_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_Cesium3DTileset_CallRecreateTileset_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe void CesiumForUnity_Cesium3DTileset_CallRecreateTileset_1B2M2Y8AsgTpgAmY7PhCfg(System.IntPtr thiz)
        {
            ((CesiumForUnity.Cesium3DTileset)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).RecreateTileset();
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_Cesium3DTileset_Property_get_gameObjectType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_Cesium3DTileset_Property_get_gameObjectType CesiumForUnity_Cesium3DTileset_Property_get_gameObjectDelegate = new CesiumForUnity_Cesium3DTileset_Property_get_gameObjectType(CesiumForUnity_Cesium3DTileset_Property_get_gameObject);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_Cesium3DTileset_Property_get_gameObjectType))]
        private static unsafe System.IntPtr CesiumForUnity_Cesium3DTileset_Property_get_gameObject(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.Cesium3DTileset)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).gameObject;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_Cesium3DTileset_Property_get_ionAccessTokenType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_Cesium3DTileset_Property_get_ionAccessTokenType CesiumForUnity_Cesium3DTileset_Property_get_ionAccessTokenDelegate = new CesiumForUnity_Cesium3DTileset_Property_get_ionAccessTokenType(CesiumForUnity_Cesium3DTileset_Property_get_ionAccessToken);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_Cesium3DTileset_Property_get_ionAccessTokenType))]
        private static unsafe System.IntPtr CesiumForUnity_Cesium3DTileset_Property_get_ionAccessToken(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.Cesium3DTileset)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).ionAccessToken;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate long CesiumForUnity_Cesium3DTileset_Property_get_ionAssetIDType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_Cesium3DTileset_Property_get_ionAssetIDType CesiumForUnity_Cesium3DTileset_Property_get_ionAssetIDDelegate = new CesiumForUnity_Cesium3DTileset_Property_get_ionAssetIDType(CesiumForUnity_Cesium3DTileset_Property_get_ionAssetID);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_Cesium3DTileset_Property_get_ionAssetIDType))]
        private static unsafe long CesiumForUnity_Cesium3DTileset_Property_get_ionAssetID(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.Cesium3DTileset)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).ionAssetID;
            
            return result;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate CesiumForUnity.CesiumDataSource CesiumForUnity_Cesium3DTileset_Property_get_tilesetSourceType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_Cesium3DTileset_Property_get_tilesetSourceType CesiumForUnity_Cesium3DTileset_Property_get_tilesetSourceDelegate = new CesiumForUnity_Cesium3DTileset_Property_get_tilesetSourceType(CesiumForUnity_Cesium3DTileset_Property_get_tilesetSource);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_Cesium3DTileset_Property_get_tilesetSourceType))]
        private static unsafe CesiumForUnity.CesiumDataSource CesiumForUnity_Cesium3DTileset_Property_get_tilesetSource(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.Cesium3DTileset)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).tilesetSource;
            
            return result;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_Cesium3DTileset_Property_set_ionAccessTokenType(System.IntPtr thiz, System.IntPtr value);
        private static unsafe readonly CesiumForUnity_Cesium3DTileset_Property_set_ionAccessTokenType CesiumForUnity_Cesium3DTileset_Property_set_ionAccessTokenDelegate = new CesiumForUnity_Cesium3DTileset_Property_set_ionAccessTokenType(CesiumForUnity_Cesium3DTileset_Property_set_ionAccessToken);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_Cesium3DTileset_Property_set_ionAccessTokenType))]
        private static unsafe void CesiumForUnity_Cesium3DTileset_Property_set_ionAccessToken(System.IntPtr thiz, System.IntPtr value)
        {
            ((CesiumForUnity.Cesium3DTileset)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).ionAccessToken = (string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(value)!;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_Cesium3DTileset_Property_set_ionAssetIDType(System.IntPtr thiz, long value);
        private static unsafe readonly CesiumForUnity_Cesium3DTileset_Property_set_ionAssetIDType CesiumForUnity_Cesium3DTileset_Property_set_ionAssetIDDelegate = new CesiumForUnity_Cesium3DTileset_Property_set_ionAssetIDType(CesiumForUnity_Cesium3DTileset_Property_set_ionAssetID);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_Cesium3DTileset_Property_set_ionAssetIDType))]
        private static unsafe void CesiumForUnity_Cesium3DTileset_Property_set_ionAssetID(System.IntPtr thiz, long value)
        {
            ((CesiumForUnity.Cesium3DTileset)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).ionAssetID = value;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_Cesium3DTileset_Property_set_tilesetSourceType(System.IntPtr thiz, CesiumForUnity.CesiumDataSource value);
        private static unsafe readonly CesiumForUnity_Cesium3DTileset_Property_set_tilesetSourceType CesiumForUnity_Cesium3DTileset_Property_set_tilesetSourceDelegate = new CesiumForUnity_Cesium3DTileset_Property_set_tilesetSourceType(CesiumForUnity_Cesium3DTileset_Property_set_tilesetSource);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_Cesium3DTileset_Property_set_tilesetSourceType))]
        private static unsafe void CesiumForUnity_Cesium3DTileset_Property_set_tilesetSource(System.IntPtr thiz, CesiumForUnity.CesiumDataSource value)
        {
            ((CesiumForUnity.Cesium3DTileset)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).tilesetSource = value;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_CesiumEditorUtility_CallAddBaseOverlayToTileset_GE91HI1OIybUlB1E__yYJCQType(System.IntPtr tileset, long assetID);
        private static unsafe readonly CesiumForUnity_CesiumEditorUtility_CallAddBaseOverlayToTileset_GE91HI1OIybUlB1E__yYJCQType CesiumForUnity_CesiumEditorUtility_CallAddBaseOverlayToTileset_GE91HI1OIybUlB1E__yYJCQDelegate = new CesiumForUnity_CesiumEditorUtility_CallAddBaseOverlayToTileset_GE91HI1OIybUlB1E__yYJCQType(CesiumForUnity_CesiumEditorUtility_CallAddBaseOverlayToTileset_GE91HI1OIybUlB1E__yYJCQ);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumEditorUtility_CallAddBaseOverlayToTileset_GE91HI1OIybUlB1E__yYJCQType))]
        private static unsafe System.IntPtr CesiumForUnity_CesiumEditorUtility_CallAddBaseOverlayToTileset_GE91HI1OIybUlB1E__yYJCQ(System.IntPtr tileset, long assetID)
        {
            
            var result = CesiumForUnity.CesiumEditorUtility.AddBaseOverlayToTileset((CesiumForUnity.Cesium3DTileset)Reinterop.ObjectHandleUtility.GetObjectFromHandle(tileset)!, assetID);
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_CesiumEditorUtility_CallCreateTileset_jsvXjE1xIXP0dz0Yem4NagType(System.IntPtr name, long assetID);
        private static unsafe readonly CesiumForUnity_CesiumEditorUtility_CallCreateTileset_jsvXjE1xIXP0dz0Yem4NagType CesiumForUnity_CesiumEditorUtility_CallCreateTileset_jsvXjE1xIXP0dz0Yem4NagDelegate = new CesiumForUnity_CesiumEditorUtility_CallCreateTileset_jsvXjE1xIXP0dz0Yem4NagType(CesiumForUnity_CesiumEditorUtility_CallCreateTileset_jsvXjE1xIXP0dz0Yem4Nag);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumEditorUtility_CallCreateTileset_jsvXjE1xIXP0dz0Yem4NagType))]
        private static unsafe System.IntPtr CesiumForUnity_CesiumEditorUtility_CallCreateTileset_jsvXjE1xIXP0dz0Yem4Nag(System.IntPtr name, long assetID)
        {
            
            var result = CesiumForUnity.CesiumEditorUtility.CreateTileset((string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(name)!, assetID);
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_CesiumEditorUtility_CallFindFirstTileset_1B2M2Y8AsgTpgAmY7PhCfgType();
        private static unsafe readonly CesiumForUnity_CesiumEditorUtility_CallFindFirstTileset_1B2M2Y8AsgTpgAmY7PhCfgType CesiumForUnity_CesiumEditorUtility_CallFindFirstTileset_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new CesiumForUnity_CesiumEditorUtility_CallFindFirstTileset_1B2M2Y8AsgTpgAmY7PhCfgType(CesiumForUnity_CesiumEditorUtility_CallFindFirstTileset_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumEditorUtility_CallFindFirstTileset_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe System.IntPtr CesiumForUnity_CesiumEditorUtility_CallFindFirstTileset_1B2M2Y8AsgTpgAmY7PhCfg()
        {
            
            var result = CesiumForUnity.CesiumEditorUtility.FindFirstTileset();
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_CesiumEditorUtility_CallFindFirstTilesetWithAssetID_OUsZiF60__hSy6sWtVPSwsAType(long assetID);
        private static unsafe readonly CesiumForUnity_CesiumEditorUtility_CallFindFirstTilesetWithAssetID_OUsZiF60__hSy6sWtVPSwsAType CesiumForUnity_CesiumEditorUtility_CallFindFirstTilesetWithAssetID_OUsZiF60__hSy6sWtVPSwsADelegate = new CesiumForUnity_CesiumEditorUtility_CallFindFirstTilesetWithAssetID_OUsZiF60__hSy6sWtVPSwsAType(CesiumForUnity_CesiumEditorUtility_CallFindFirstTilesetWithAssetID_OUsZiF60__hSy6sWtVPSwsA);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumEditorUtility_CallFindFirstTilesetWithAssetID_OUsZiF60__hSy6sWtVPSwsAType))]
        private static unsafe System.IntPtr CesiumForUnity_CesiumEditorUtility_CallFindFirstTilesetWithAssetID_OUsZiF60__hSy6sWtVPSwsA(long assetID)
        {
            
            var result = CesiumForUnity.CesiumEditorUtility.FindFirstTilesetWithAssetID(assetID);
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_CesiumEditorWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfgType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_CesiumEditorWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfgType CesiumForUnity_CesiumEditorWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new CesiumForUnity_CesiumEditorWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfgType(CesiumForUnity_CesiumEditorWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumEditorWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe void CesiumForUnity_CesiumEditorWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfg(System.IntPtr thiz)
        {
            ((CesiumForUnity.CesiumEditorWindow)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).Close();
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte CesiumForUnity_CesiumEditorWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType(System.IntPtr x, System.IntPtr y);
        private static unsafe readonly CesiumForUnity_CesiumEditorWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType CesiumForUnity_CesiumEditorWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgDelegate = new CesiumForUnity_CesiumEditorWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType(CesiumForUnity_CesiumEditorWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2Wg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumEditorWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType))]
        private static unsafe byte CesiumForUnity_CesiumEditorWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2Wg(System.IntPtr x, System.IntPtr y)
        {
            
            var result = ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(x)!) == ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(y)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte CesiumForUnity_CesiumEditorWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType(System.IntPtr x, System.IntPtr y);
        private static unsafe readonly CesiumForUnity_CesiumEditorWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType CesiumForUnity_CesiumEditorWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgDelegate = new CesiumForUnity_CesiumEditorWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType(CesiumForUnity_CesiumEditorWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2Wg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumEditorWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType))]
        private static unsafe byte CesiumForUnity_CesiumEditorWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2Wg(System.IntPtr x, System.IntPtr y)
        {
            
            var result = ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(x)!) != ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(y)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_CesiumEditorWindow_Field_get_currentWindowType();
        private static unsafe readonly CesiumForUnity_CesiumEditorWindow_Field_get_currentWindowType CesiumForUnity_CesiumEditorWindow_Field_get_currentWindowDelegate = new CesiumForUnity_CesiumEditorWindow_Field_get_currentWindowType(CesiumForUnity_CesiumEditorWindow_Field_get_currentWindow);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumEditorWindow_Field_get_currentWindowType))]
        private static unsafe System.IntPtr CesiumForUnity_CesiumEditorWindow_Field_get_currentWindow()
        {
            var result = CesiumForUnity.CesiumEditorWindow.currentWindow;
          return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_CesiumEditorWindow_Field_set_currentWindowType(System.IntPtr value);
        private static unsafe readonly CesiumForUnity_CesiumEditorWindow_Field_set_currentWindowType CesiumForUnity_CesiumEditorWindow_Field_set_currentWindowDelegate = new CesiumForUnity_CesiumEditorWindow_Field_set_currentWindowType(CesiumForUnity_CesiumEditorWindow_Field_set_currentWindow);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumEditorWindow_Field_set_currentWindowType))]
        private static unsafe void CesiumForUnity_CesiumEditorWindow_Field_set_currentWindow(System.IntPtr value)
        {
            CesiumForUnity.CesiumEditorWindow.currentWindow = (CesiumForUnity.CesiumEditorWindow)Reinterop.ObjectHandleUtility.GetObjectFromHandle(value)!;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_CesiumEditorWindow_Property_get_NativeImplementationType(IntPtr thiz);
        private static unsafe readonly CesiumForUnity_CesiumEditorWindow_Property_get_NativeImplementationType CesiumForUnity_CesiumEditorWindow_Property_get_NativeImplementationDelegate = new CesiumForUnity_CesiumEditorWindow_Property_get_NativeImplementationType(CesiumForUnity_CesiumEditorWindow_Property_get_NativeImplementation);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumEditorWindow_Property_get_NativeImplementationType))]
        private static unsafe System.IntPtr CesiumForUnity_CesiumEditorWindow_Property_get_NativeImplementation(IntPtr thiz)
        {
            return ((CesiumForUnity.CesiumEditorWindow)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).NativeImplementation.DangerousGetHandle();
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte CesiumForUnity_CesiumIonAsset_CallIsNull_1B2M2Y8AsgTpgAmY7PhCfgType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_CesiumIonAsset_CallIsNull_1B2M2Y8AsgTpgAmY7PhCfgType CesiumForUnity_CesiumIonAsset_CallIsNull_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new CesiumForUnity_CesiumIonAsset_CallIsNull_1B2M2Y8AsgTpgAmY7PhCfgType(CesiumForUnity_CesiumIonAsset_CallIsNull_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumIonAsset_CallIsNull_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe byte CesiumForUnity_CesiumIonAsset_CallIsNull_1B2M2Y8AsgTpgAmY7PhCfg(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.CesiumIonAsset)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).IsNull();
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_CesiumIonAsset_Property_get_componentTypeType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_CesiumIonAsset_Property_get_componentTypeType CesiumForUnity_CesiumIonAsset_Property_get_componentTypeDelegate = new CesiumForUnity_CesiumIonAsset_Property_get_componentTypeType(CesiumForUnity_CesiumIonAsset_Property_get_componentType);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumIonAsset_Property_get_componentTypeType))]
        private static unsafe System.IntPtr CesiumForUnity_CesiumIonAsset_Property_get_componentType(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.CesiumIonAsset)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).componentType;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_CesiumIonAsset_Property_get_ionAccessTokenType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_CesiumIonAsset_Property_get_ionAccessTokenType CesiumForUnity_CesiumIonAsset_Property_get_ionAccessTokenDelegate = new CesiumForUnity_CesiumIonAsset_Property_get_ionAccessTokenType(CesiumForUnity_CesiumIonAsset_Property_get_ionAccessToken);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumIonAsset_Property_get_ionAccessTokenType))]
        private static unsafe System.IntPtr CesiumForUnity_CesiumIonAsset_Property_get_ionAccessToken(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.CesiumIonAsset)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).ionAccessToken;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate long CesiumForUnity_CesiumIonAsset_Property_get_ionAssetIDType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_CesiumIonAsset_Property_get_ionAssetIDType CesiumForUnity_CesiumIonAsset_Property_get_ionAssetIDDelegate = new CesiumForUnity_CesiumIonAsset_Property_get_ionAssetIDType(CesiumForUnity_CesiumIonAsset_Property_get_ionAssetID);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumIonAsset_Property_get_ionAssetIDType))]
        private static unsafe long CesiumForUnity_CesiumIonAsset_Property_get_ionAssetID(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.CesiumIonAsset)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).ionAssetID;
            
            return result;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_CesiumIonAsset_Property_get_objectNameType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_CesiumIonAsset_Property_get_objectNameType CesiumForUnity_CesiumIonAsset_Property_get_objectNameDelegate = new CesiumForUnity_CesiumIonAsset_Property_get_objectNameType(CesiumForUnity_CesiumIonAsset_Property_get_objectName);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumIonAsset_Property_get_objectNameType))]
        private static unsafe System.IntPtr CesiumForUnity_CesiumIonAsset_Property_get_objectName(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.CesiumIonAsset)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).objectName;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_CesiumIonAsset_Property_get_typeType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_CesiumIonAsset_Property_get_typeType CesiumForUnity_CesiumIonAsset_Property_get_typeDelegate = new CesiumForUnity_CesiumIonAsset_Property_get_typeType(CesiumForUnity_CesiumIonAsset_Property_get_type);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumIonAsset_Property_get_typeType))]
        private static unsafe System.IntPtr CesiumForUnity_CesiumIonAsset_Property_get_type(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.CesiumIonAsset)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).type;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_CesiumIonAsset_Property_set_ionAccessTokenType(System.IntPtr thiz, System.IntPtr value);
        private static unsafe readonly CesiumForUnity_CesiumIonAsset_Property_set_ionAccessTokenType CesiumForUnity_CesiumIonAsset_Property_set_ionAccessTokenDelegate = new CesiumForUnity_CesiumIonAsset_Property_set_ionAccessTokenType(CesiumForUnity_CesiumIonAsset_Property_set_ionAccessToken);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumIonAsset_Property_set_ionAccessTokenType))]
        private static unsafe void CesiumForUnity_CesiumIonAsset_Property_set_ionAccessToken(System.IntPtr thiz, System.IntPtr value)
        {
            ((CesiumForUnity.CesiumIonAsset)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).ionAccessToken = (string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(value)!;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte CesiumForUnity_CesiumIonRasterOverlay_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType(System.IntPtr x, System.IntPtr y);
        private static unsafe readonly CesiumForUnity_CesiumIonRasterOverlay_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType CesiumForUnity_CesiumIonRasterOverlay_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgDelegate = new CesiumForUnity_CesiumIonRasterOverlay_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType(CesiumForUnity_CesiumIonRasterOverlay_Callop_Equality_5bi2N6jTkaYVhpHPRxL2Wg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumIonRasterOverlay_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType))]
        private static unsafe byte CesiumForUnity_CesiumIonRasterOverlay_Callop_Equality_5bi2N6jTkaYVhpHPRxL2Wg(System.IntPtr x, System.IntPtr y)
        {
            
            var result = ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(x)!) == ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(y)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte CesiumForUnity_CesiumIonRasterOverlay_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType(System.IntPtr x, System.IntPtr y);
        private static unsafe readonly CesiumForUnity_CesiumIonRasterOverlay_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType CesiumForUnity_CesiumIonRasterOverlay_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgDelegate = new CesiumForUnity_CesiumIonRasterOverlay_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType(CesiumForUnity_CesiumIonRasterOverlay_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2Wg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumIonRasterOverlay_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType))]
        private static unsafe byte CesiumForUnity_CesiumIonRasterOverlay_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2Wg(System.IntPtr x, System.IntPtr y)
        {
            
            var result = ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(x)!) != ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(y)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_CesiumIonRasterOverlay_CallRefresh_1B2M2Y8AsgTpgAmY7PhCfgType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_CesiumIonRasterOverlay_CallRefresh_1B2M2Y8AsgTpgAmY7PhCfgType CesiumForUnity_CesiumIonRasterOverlay_CallRefresh_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new CesiumForUnity_CesiumIonRasterOverlay_CallRefresh_1B2M2Y8AsgTpgAmY7PhCfgType(CesiumForUnity_CesiumIonRasterOverlay_CallRefresh_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumIonRasterOverlay_CallRefresh_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe void CesiumForUnity_CesiumIonRasterOverlay_CallRefresh_1B2M2Y8AsgTpgAmY7PhCfg(System.IntPtr thiz)
        {
            ((CesiumForUnity.CesiumIonRasterOverlay)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).Refresh();
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_CesiumIonRasterOverlay_Property_get_gameObjectType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_CesiumIonRasterOverlay_Property_get_gameObjectType CesiumForUnity_CesiumIonRasterOverlay_Property_get_gameObjectDelegate = new CesiumForUnity_CesiumIonRasterOverlay_Property_get_gameObjectType(CesiumForUnity_CesiumIonRasterOverlay_Property_get_gameObject);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumIonRasterOverlay_Property_get_gameObjectType))]
        private static unsafe System.IntPtr CesiumForUnity_CesiumIonRasterOverlay_Property_get_gameObject(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.CesiumIonRasterOverlay)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).gameObject;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_CesiumIonRasterOverlay_Property_get_ionAccessTokenType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_CesiumIonRasterOverlay_Property_get_ionAccessTokenType CesiumForUnity_CesiumIonRasterOverlay_Property_get_ionAccessTokenDelegate = new CesiumForUnity_CesiumIonRasterOverlay_Property_get_ionAccessTokenType(CesiumForUnity_CesiumIonRasterOverlay_Property_get_ionAccessToken);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumIonRasterOverlay_Property_get_ionAccessTokenType))]
        private static unsafe System.IntPtr CesiumForUnity_CesiumIonRasterOverlay_Property_get_ionAccessToken(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.CesiumIonRasterOverlay)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).ionAccessToken;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate long CesiumForUnity_CesiumIonRasterOverlay_Property_get_ionAssetIDType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_CesiumIonRasterOverlay_Property_get_ionAssetIDType CesiumForUnity_CesiumIonRasterOverlay_Property_get_ionAssetIDDelegate = new CesiumForUnity_CesiumIonRasterOverlay_Property_get_ionAssetIDType(CesiumForUnity_CesiumIonRasterOverlay_Property_get_ionAssetID);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumIonRasterOverlay_Property_get_ionAssetIDType))]
        private static unsafe long CesiumForUnity_CesiumIonRasterOverlay_Property_get_ionAssetID(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.CesiumIonRasterOverlay)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).ionAssetID;
            
            return result;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_CesiumIonRasterOverlay_Property_set_ionAccessTokenType(System.IntPtr thiz, System.IntPtr value);
        private static unsafe readonly CesiumForUnity_CesiumIonRasterOverlay_Property_set_ionAccessTokenType CesiumForUnity_CesiumIonRasterOverlay_Property_set_ionAccessTokenDelegate = new CesiumForUnity_CesiumIonRasterOverlay_Property_set_ionAccessTokenType(CesiumForUnity_CesiumIonRasterOverlay_Property_set_ionAccessToken);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumIonRasterOverlay_Property_set_ionAccessTokenType))]
        private static unsafe void CesiumForUnity_CesiumIonRasterOverlay_Property_set_ionAccessToken(System.IntPtr thiz, System.IntPtr value)
        {
            ((CesiumForUnity.CesiumIonRasterOverlay)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).ionAccessToken = (string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(value)!;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_CesiumIonRasterOverlay_Property_set_ionAssetIDType(System.IntPtr thiz, long value);
        private static unsafe readonly CesiumForUnity_CesiumIonRasterOverlay_Property_set_ionAssetIDType CesiumForUnity_CesiumIonRasterOverlay_Property_set_ionAssetIDDelegate = new CesiumForUnity_CesiumIonRasterOverlay_Property_set_ionAssetIDType(CesiumForUnity_CesiumIonRasterOverlay_Property_set_ionAssetID);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumIonRasterOverlay_Property_set_ionAssetIDType))]
        private static unsafe void CesiumForUnity_CesiumIonRasterOverlay_Property_set_ionAssetID(System.IntPtr thiz, long value)
        {
            ((CesiumForUnity.CesiumIonRasterOverlay)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).ionAssetID = value;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_CesiumIonSession_CallBroadcastAssetsUpdate_1B2M2Y8AsgTpgAmY7PhCfgType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_CesiumIonSession_CallBroadcastAssetsUpdate_1B2M2Y8AsgTpgAmY7PhCfgType CesiumForUnity_CesiumIonSession_CallBroadcastAssetsUpdate_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new CesiumForUnity_CesiumIonSession_CallBroadcastAssetsUpdate_1B2M2Y8AsgTpgAmY7PhCfgType(CesiumForUnity_CesiumIonSession_CallBroadcastAssetsUpdate_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumIonSession_CallBroadcastAssetsUpdate_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe void CesiumForUnity_CesiumIonSession_CallBroadcastAssetsUpdate_1B2M2Y8AsgTpgAmY7PhCfg(System.IntPtr thiz)
        {
            ((CesiumForUnity.CesiumIonSession)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).BroadcastAssetsUpdate();
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_CesiumIonSession_CallBroadcastConnectionUpdate_1B2M2Y8AsgTpgAmY7PhCfgType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_CesiumIonSession_CallBroadcastConnectionUpdate_1B2M2Y8AsgTpgAmY7PhCfgType CesiumForUnity_CesiumIonSession_CallBroadcastConnectionUpdate_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new CesiumForUnity_CesiumIonSession_CallBroadcastConnectionUpdate_1B2M2Y8AsgTpgAmY7PhCfgType(CesiumForUnity_CesiumIonSession_CallBroadcastConnectionUpdate_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumIonSession_CallBroadcastConnectionUpdate_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe void CesiumForUnity_CesiumIonSession_CallBroadcastConnectionUpdate_1B2M2Y8AsgTpgAmY7PhCfg(System.IntPtr thiz)
        {
            ((CesiumForUnity.CesiumIonSession)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).BroadcastConnectionUpdate();
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_CesiumIonSession_CallBroadcastProfileUpdate_1B2M2Y8AsgTpgAmY7PhCfgType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_CesiumIonSession_CallBroadcastProfileUpdate_1B2M2Y8AsgTpgAmY7PhCfgType CesiumForUnity_CesiumIonSession_CallBroadcastProfileUpdate_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new CesiumForUnity_CesiumIonSession_CallBroadcastProfileUpdate_1B2M2Y8AsgTpgAmY7PhCfgType(CesiumForUnity_CesiumIonSession_CallBroadcastProfileUpdate_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumIonSession_CallBroadcastProfileUpdate_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe void CesiumForUnity_CesiumIonSession_CallBroadcastProfileUpdate_1B2M2Y8AsgTpgAmY7PhCfg(System.IntPtr thiz)
        {
            ((CesiumForUnity.CesiumIonSession)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).BroadcastProfileUpdate();
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_CesiumIonSession_CallBroadcastTokensUpdate_1B2M2Y8AsgTpgAmY7PhCfgType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_CesiumIonSession_CallBroadcastTokensUpdate_1B2M2Y8AsgTpgAmY7PhCfgType CesiumForUnity_CesiumIonSession_CallBroadcastTokensUpdate_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new CesiumForUnity_CesiumIonSession_CallBroadcastTokensUpdate_1B2M2Y8AsgTpgAmY7PhCfgType(CesiumForUnity_CesiumIonSession_CallBroadcastTokensUpdate_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumIonSession_CallBroadcastTokensUpdate_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe void CesiumForUnity_CesiumIonSession_CallBroadcastTokensUpdate_1B2M2Y8AsgTpgAmY7PhCfg(System.IntPtr thiz)
        {
            ((CesiumForUnity.CesiumIonSession)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).BroadcastTokensUpdate();
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_CesiumIonSession_CallIon_1B2M2Y8AsgTpgAmY7PhCfgType();
        private static unsafe readonly CesiumForUnity_CesiumIonSession_CallIon_1B2M2Y8AsgTpgAmY7PhCfgType CesiumForUnity_CesiumIonSession_CallIon_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new CesiumForUnity_CesiumIonSession_CallIon_1B2M2Y8AsgTpgAmY7PhCfgType(CesiumForUnity_CesiumIonSession_CallIon_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumIonSession_CallIon_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe System.IntPtr CesiumForUnity_CesiumIonSession_CallIon_1B2M2Y8AsgTpgAmY7PhCfg()
        {
            
            var result = CesiumForUnity.CesiumIonSession.Ion();
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte CesiumForUnity_CesiumIonSession_CallIsConnected_1B2M2Y8AsgTpgAmY7PhCfgType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_CesiumIonSession_CallIsConnected_1B2M2Y8AsgTpgAmY7PhCfgType CesiumForUnity_CesiumIonSession_CallIsConnected_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new CesiumForUnity_CesiumIonSession_CallIsConnected_1B2M2Y8AsgTpgAmY7PhCfgType(CesiumForUnity_CesiumIonSession_CallIsConnected_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumIonSession_CallIsConnected_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe byte CesiumForUnity_CesiumIonSession_CallIsConnected_1B2M2Y8AsgTpgAmY7PhCfg(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.CesiumIonSession)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).IsConnected();
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_CesiumIonSession_Property_get_NativeImplementationType(IntPtr thiz);
        private static unsafe readonly CesiumForUnity_CesiumIonSession_Property_get_NativeImplementationType CesiumForUnity_CesiumIonSession_Property_get_NativeImplementationDelegate = new CesiumForUnity_CesiumIonSession_Property_get_NativeImplementationType(CesiumForUnity_CesiumIonSession_Property_get_NativeImplementation);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumIonSession_Property_get_NativeImplementationType))]
        private static unsafe System.IntPtr CesiumForUnity_CesiumIonSession_Property_get_NativeImplementation(IntPtr thiz)
        {
            return ((CesiumForUnity.CesiumIonSession)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).NativeImplementation.DangerousGetHandle();
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte CesiumForUnity_CesiumRasterOverlay_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType(System.IntPtr x, System.IntPtr y);
        private static unsafe readonly CesiumForUnity_CesiumRasterOverlay_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType CesiumForUnity_CesiumRasterOverlay_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgDelegate = new CesiumForUnity_CesiumRasterOverlay_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType(CesiumForUnity_CesiumRasterOverlay_Callop_Equality_5bi2N6jTkaYVhpHPRxL2Wg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumRasterOverlay_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType))]
        private static unsafe byte CesiumForUnity_CesiumRasterOverlay_Callop_Equality_5bi2N6jTkaYVhpHPRxL2Wg(System.IntPtr x, System.IntPtr y)
        {
            
            var result = ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(x)!) == ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(y)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte CesiumForUnity_CesiumRasterOverlay_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType(System.IntPtr x, System.IntPtr y);
        private static unsafe readonly CesiumForUnity_CesiumRasterOverlay_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType CesiumForUnity_CesiumRasterOverlay_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgDelegate = new CesiumForUnity_CesiumRasterOverlay_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType(CesiumForUnity_CesiumRasterOverlay_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2Wg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumRasterOverlay_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType))]
        private static unsafe byte CesiumForUnity_CesiumRasterOverlay_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2Wg(System.IntPtr x, System.IntPtr y)
        {
            
            var result = ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(x)!) != ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(y)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_CesiumRasterOverlay_CallRefresh_1B2M2Y8AsgTpgAmY7PhCfgType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_CesiumRasterOverlay_CallRefresh_1B2M2Y8AsgTpgAmY7PhCfgType CesiumForUnity_CesiumRasterOverlay_CallRefresh_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new CesiumForUnity_CesiumRasterOverlay_CallRefresh_1B2M2Y8AsgTpgAmY7PhCfgType(CesiumForUnity_CesiumRasterOverlay_CallRefresh_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumRasterOverlay_CallRefresh_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe void CesiumForUnity_CesiumRasterOverlay_CallRefresh_1B2M2Y8AsgTpgAmY7PhCfg(System.IntPtr thiz)
        {
            ((CesiumForUnity.CesiumRasterOverlay)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).Refresh();
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_CesiumRasterOverlay_Property_get_gameObjectType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_CesiumRasterOverlay_Property_get_gameObjectType CesiumForUnity_CesiumRasterOverlay_Property_get_gameObjectDelegate = new CesiumForUnity_CesiumRasterOverlay_Property_get_gameObjectType(CesiumForUnity_CesiumRasterOverlay_Property_get_gameObject);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumRasterOverlay_Property_get_gameObjectType))]
        private static unsafe System.IntPtr CesiumForUnity_CesiumRasterOverlay_Property_get_gameObject(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.CesiumRasterOverlay)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).gameObject;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte CesiumForUnity_CesiumRuntimeSettings_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType(System.IntPtr x, System.IntPtr y);
        private static unsafe readonly CesiumForUnity_CesiumRuntimeSettings_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType CesiumForUnity_CesiumRuntimeSettings_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgDelegate = new CesiumForUnity_CesiumRuntimeSettings_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType(CesiumForUnity_CesiumRuntimeSettings_Callop_Equality_5bi2N6jTkaYVhpHPRxL2Wg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumRuntimeSettings_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType))]
        private static unsafe byte CesiumForUnity_CesiumRuntimeSettings_Callop_Equality_5bi2N6jTkaYVhpHPRxL2Wg(System.IntPtr x, System.IntPtr y)
        {
            
            var result = ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(x)!) == ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(y)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte CesiumForUnity_CesiumRuntimeSettings_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType(System.IntPtr x, System.IntPtr y);
        private static unsafe readonly CesiumForUnity_CesiumRuntimeSettings_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType CesiumForUnity_CesiumRuntimeSettings_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgDelegate = new CesiumForUnity_CesiumRuntimeSettings_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType(CesiumForUnity_CesiumRuntimeSettings_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2Wg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumRuntimeSettings_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType))]
        private static unsafe byte CesiumForUnity_CesiumRuntimeSettings_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2Wg(System.IntPtr x, System.IntPtr y)
        {
            
            var result = ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(x)!) != ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(y)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_CesiumRuntimeSettings_Property_get_defaultIonAccessTokenType();
        private static unsafe readonly CesiumForUnity_CesiumRuntimeSettings_Property_get_defaultIonAccessTokenType CesiumForUnity_CesiumRuntimeSettings_Property_get_defaultIonAccessTokenDelegate = new CesiumForUnity_CesiumRuntimeSettings_Property_get_defaultIonAccessTokenType(CesiumForUnity_CesiumRuntimeSettings_Property_get_defaultIonAccessToken);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumRuntimeSettings_Property_get_defaultIonAccessTokenType))]
        private static unsafe System.IntPtr CesiumForUnity_CesiumRuntimeSettings_Property_get_defaultIonAccessToken()
        {
            
            var result = CesiumForUnity.CesiumRuntimeSettings.defaultIonAccessToken;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_CesiumRuntimeSettings_Property_get_defaultIonAccessTokenIDType();
        private static unsafe readonly CesiumForUnity_CesiumRuntimeSettings_Property_get_defaultIonAccessTokenIDType CesiumForUnity_CesiumRuntimeSettings_Property_get_defaultIonAccessTokenIDDelegate = new CesiumForUnity_CesiumRuntimeSettings_Property_get_defaultIonAccessTokenIDType(CesiumForUnity_CesiumRuntimeSettings_Property_get_defaultIonAccessTokenID);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumRuntimeSettings_Property_get_defaultIonAccessTokenIDType))]
        private static unsafe System.IntPtr CesiumForUnity_CesiumRuntimeSettings_Property_get_defaultIonAccessTokenID()
        {
            
            var result = CesiumForUnity.CesiumRuntimeSettings.defaultIonAccessTokenID;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_CesiumRuntimeSettings_Property_set_defaultIonAccessTokenType(System.IntPtr value);
        private static unsafe readonly CesiumForUnity_CesiumRuntimeSettings_Property_set_defaultIonAccessTokenType CesiumForUnity_CesiumRuntimeSettings_Property_set_defaultIonAccessTokenDelegate = new CesiumForUnity_CesiumRuntimeSettings_Property_set_defaultIonAccessTokenType(CesiumForUnity_CesiumRuntimeSettings_Property_set_defaultIonAccessToken);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumRuntimeSettings_Property_set_defaultIonAccessTokenType))]
        private static unsafe void CesiumForUnity_CesiumRuntimeSettings_Property_set_defaultIonAccessToken(System.IntPtr value)
        {
            CesiumForUnity.CesiumRuntimeSettings.defaultIonAccessToken = (string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(value)!;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_CesiumRuntimeSettings_Property_set_defaultIonAccessTokenIDType(System.IntPtr value);
        private static unsafe readonly CesiumForUnity_CesiumRuntimeSettings_Property_set_defaultIonAccessTokenIDType CesiumForUnity_CesiumRuntimeSettings_Property_set_defaultIonAccessTokenIDDelegate = new CesiumForUnity_CesiumRuntimeSettings_Property_set_defaultIonAccessTokenIDType(CesiumForUnity_CesiumRuntimeSettings_Property_set_defaultIonAccessTokenID);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_CesiumRuntimeSettings_Property_set_defaultIonAccessTokenIDType))]
        private static unsafe void CesiumForUnity_CesiumRuntimeSettings_Property_set_defaultIonAccessTokenID(System.IntPtr value)
        {
            CesiumForUnity.CesiumRuntimeSettings.defaultIonAccessTokenID = (string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(value)!;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_Helpers_CallToString__8pn__Nas4aiRxhf1NkpeKgType(UnityEngine.RuntimePlatform value);
        private static unsafe readonly CesiumForUnity_Helpers_CallToString__8pn__Nas4aiRxhf1NkpeKgType CesiumForUnity_Helpers_CallToString__8pn__Nas4aiRxhf1NkpeKgDelegate = new CesiumForUnity_Helpers_CallToString__8pn__Nas4aiRxhf1NkpeKgType(CesiumForUnity_Helpers_CallToString__8pn__Nas4aiRxhf1NkpeKg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_Helpers_CallToString__8pn__Nas4aiRxhf1NkpeKgType))]
        private static unsafe System.IntPtr CesiumForUnity_Helpers_CallToString__8pn__Nas4aiRxhf1NkpeKg(UnityEngine.RuntimePlatform value)
        {
            
            var result = CesiumForUnity.Helpers.ToString<UnityEngine.RuntimePlatform>(value);
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_IonAssetDetails_CallFormatDate_Wg__UxSmEJUgHx3kyfccFEwType(System.IntPtr assetDate);
        private static unsafe readonly CesiumForUnity_IonAssetDetails_CallFormatDate_Wg__UxSmEJUgHx3kyfccFEwType CesiumForUnity_IonAssetDetails_CallFormatDate_Wg__UxSmEJUgHx3kyfccFEwDelegate = new CesiumForUnity_IonAssetDetails_CallFormatDate_Wg__UxSmEJUgHx3kyfccFEwType(CesiumForUnity_IonAssetDetails_CallFormatDate_Wg__UxSmEJUgHx3kyfccFEw);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_IonAssetDetails_CallFormatDate_Wg__UxSmEJUgHx3kyfccFEwType))]
        private static unsafe System.IntPtr CesiumForUnity_IonAssetDetails_CallFormatDate_Wg__UxSmEJUgHx3kyfccFEw(System.IntPtr assetDate)
        {
            
            var result = CesiumForUnity.IonAssetDetails.FormatDate((string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(assetDate)!);
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_IonAssetDetails_CallFormatType_3GczHehc_XCRt9ReXGSrdQType(System.IntPtr type);
        private static unsafe readonly CesiumForUnity_IonAssetDetails_CallFormatType_3GczHehc_XCRt9ReXGSrdQType CesiumForUnity_IonAssetDetails_CallFormatType_3GczHehc_XCRt9ReXGSrdQDelegate = new CesiumForUnity_IonAssetDetails_CallFormatType_3GczHehc_XCRt9ReXGSrdQType(CesiumForUnity_IonAssetDetails_CallFormatType_3GczHehc_XCRt9ReXGSrdQ);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_IonAssetDetails_CallFormatType_3GczHehc_XCRt9ReXGSrdQType))]
        private static unsafe System.IntPtr CesiumForUnity_IonAssetDetails_CallFormatType_3GczHehc_XCRt9ReXGSrdQ(System.IntPtr type)
        {
            
            var result = CesiumForUnity.IonAssetDetails.FormatType((string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(type)!);
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_IonAssetsTreeView_CallReload_1B2M2Y8AsgTpgAmY7PhCfgType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_IonAssetsTreeView_CallReload_1B2M2Y8AsgTpgAmY7PhCfgType CesiumForUnity_IonAssetsTreeView_CallReload_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new CesiumForUnity_IonAssetsTreeView_CallReload_1B2M2Y8AsgTpgAmY7PhCfgType(CesiumForUnity_IonAssetsTreeView_CallReload_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_IonAssetsTreeView_CallReload_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe void CesiumForUnity_IonAssetsTreeView_CallReload_1B2M2Y8AsgTpgAmY7PhCfg(System.IntPtr thiz)
        {
            ((CesiumForUnity.IonAssetsTreeView)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).Reload();
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_IonAssetsTreeView_Construct_bk3kO2aTAFaE0GWD9sxbigType(System.IntPtr assetsTreeState);
        private static unsafe readonly CesiumForUnity_IonAssetsTreeView_Construct_bk3kO2aTAFaE0GWD9sxbigType CesiumForUnity_IonAssetsTreeView_Construct_bk3kO2aTAFaE0GWD9sxbigDelegate = new CesiumForUnity_IonAssetsTreeView_Construct_bk3kO2aTAFaE0GWD9sxbigType(CesiumForUnity_IonAssetsTreeView_Construct_bk3kO2aTAFaE0GWD9sxbig);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_IonAssetsTreeView_Construct_bk3kO2aTAFaE0GWD9sxbigType))]
        private static unsafe System.IntPtr CesiumForUnity_IonAssetsTreeView_Construct_bk3kO2aTAFaE0GWD9sxbig(System.IntPtr assetsTreeState)
        {
            
            var result = new CesiumForUnity.IonAssetsTreeView((UnityEditor.IMGUI.Controls.TreeViewState)Reinterop.ObjectHandleUtility.GetObjectFromHandle(assetsTreeState)!);
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_IonAssetsTreeView_Property_get_multiColumnHeaderType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_IonAssetsTreeView_Property_get_multiColumnHeaderType CesiumForUnity_IonAssetsTreeView_Property_get_multiColumnHeaderDelegate = new CesiumForUnity_IonAssetsTreeView_Property_get_multiColumnHeaderType(CesiumForUnity_IonAssetsTreeView_Property_get_multiColumnHeader);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_IonAssetsTreeView_Property_get_multiColumnHeaderType))]
        private static unsafe System.IntPtr CesiumForUnity_IonAssetsTreeView_Property_get_multiColumnHeader(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.IonAssetsTreeView)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).multiColumnHeader;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_IonAssetsTreeView_Property_get_NativeImplementationType(IntPtr thiz);
        private static unsafe readonly CesiumForUnity_IonAssetsTreeView_Property_get_NativeImplementationType CesiumForUnity_IonAssetsTreeView_Property_get_NativeImplementationDelegate = new CesiumForUnity_IonAssetsTreeView_Property_get_NativeImplementationType(CesiumForUnity_IonAssetsTreeView_Property_get_NativeImplementation);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_IonAssetsTreeView_Property_get_NativeImplementationType))]
        private static unsafe System.IntPtr CesiumForUnity_IonAssetsTreeView_Property_get_NativeImplementation(IntPtr thiz)
        {
            return ((CesiumForUnity.IonAssetsTreeView)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).NativeImplementation.DangerousGetHandle();
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_IonAssetsTreeView_Property_get_searchStringType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_IonAssetsTreeView_Property_get_searchStringType CesiumForUnity_IonAssetsTreeView_Property_get_searchStringDelegate = new CesiumForUnity_IonAssetsTreeView_Property_get_searchStringType(CesiumForUnity_IonAssetsTreeView_Property_get_searchString);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_IonAssetsTreeView_Property_get_searchStringType))]
        private static unsafe System.IntPtr CesiumForUnity_IonAssetsTreeView_Property_get_searchString(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.IonAssetsTreeView)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).searchString;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_IonAssetsTreeView_Property_set_multiColumnHeaderType(System.IntPtr thiz, System.IntPtr value);
        private static unsafe readonly CesiumForUnity_IonAssetsTreeView_Property_set_multiColumnHeaderType CesiumForUnity_IonAssetsTreeView_Property_set_multiColumnHeaderDelegate = new CesiumForUnity_IonAssetsTreeView_Property_set_multiColumnHeaderType(CesiumForUnity_IonAssetsTreeView_Property_set_multiColumnHeader);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_IonAssetsTreeView_Property_set_multiColumnHeaderType))]
        private static unsafe void CesiumForUnity_IonAssetsTreeView_Property_set_multiColumnHeader(System.IntPtr thiz, System.IntPtr value)
        {
            ((CesiumForUnity.IonAssetsTreeView)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).multiColumnHeader = (UnityEditor.IMGUI.Controls.MultiColumnHeader)Reinterop.ObjectHandleUtility.GetObjectFromHandle(value)!;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_IonAssetsTreeView_Property_set_searchStringType(System.IntPtr thiz, System.IntPtr value);
        private static unsafe readonly CesiumForUnity_IonAssetsTreeView_Property_set_searchStringType CesiumForUnity_IonAssetsTreeView_Property_set_searchStringDelegate = new CesiumForUnity_IonAssetsTreeView_Property_set_searchStringType(CesiumForUnity_IonAssetsTreeView_Property_set_searchString);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_IonAssetsTreeView_Property_set_searchStringType))]
        private static unsafe void CesiumForUnity_IonAssetsTreeView_Property_set_searchString(System.IntPtr thiz, System.IntPtr value)
        {
            ((CesiumForUnity.IonAssetsTreeView)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).searchString = (string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(value)!;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_IonMissingAssetWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfgType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_IonMissingAssetWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfgType CesiumForUnity_IonMissingAssetWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new CesiumForUnity_IonMissingAssetWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfgType(CesiumForUnity_IonMissingAssetWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_IonMissingAssetWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe void CesiumForUnity_IonMissingAssetWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfg(System.IntPtr thiz)
        {
            ((CesiumForUnity.IonMissingAssetWindow)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).Close();
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte CesiumForUnity_IonMissingAssetWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType(System.IntPtr x, System.IntPtr y);
        private static unsafe readonly CesiumForUnity_IonMissingAssetWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType CesiumForUnity_IonMissingAssetWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgDelegate = new CesiumForUnity_IonMissingAssetWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType(CesiumForUnity_IonMissingAssetWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2Wg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_IonMissingAssetWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType))]
        private static unsafe byte CesiumForUnity_IonMissingAssetWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2Wg(System.IntPtr x, System.IntPtr y)
        {
            
            var result = ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(x)!) == ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(y)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte CesiumForUnity_IonMissingAssetWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType(System.IntPtr x, System.IntPtr y);
        private static unsafe readonly CesiumForUnity_IonMissingAssetWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType CesiumForUnity_IonMissingAssetWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgDelegate = new CesiumForUnity_IonMissingAssetWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType(CesiumForUnity_IonMissingAssetWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2Wg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_IonMissingAssetWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType))]
        private static unsafe byte CesiumForUnity_IonMissingAssetWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2Wg(System.IntPtr x, System.IntPtr y)
        {
            
            var result = ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(x)!) != ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(y)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_IonMissingAssetWindow_CallShowWindow_zCuaF57FLiXZD1__wksXLdQType(System.IntPtr assetName, long assetID);
        private static unsafe readonly CesiumForUnity_IonMissingAssetWindow_CallShowWindow_zCuaF57FLiXZD1__wksXLdQType CesiumForUnity_IonMissingAssetWindow_CallShowWindow_zCuaF57FLiXZD1__wksXLdQDelegate = new CesiumForUnity_IonMissingAssetWindow_CallShowWindow_zCuaF57FLiXZD1__wksXLdQType(CesiumForUnity_IonMissingAssetWindow_CallShowWindow_zCuaF57FLiXZD1__wksXLdQ);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_IonMissingAssetWindow_CallShowWindow_zCuaF57FLiXZD1__wksXLdQType))]
        private static unsafe void CesiumForUnity_IonMissingAssetWindow_CallShowWindow_zCuaF57FLiXZD1__wksXLdQ(System.IntPtr assetName, long assetID)
        {
            CesiumForUnity.IonMissingAssetWindow.ShowWindow((string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(assetName)!, assetID);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_IonTokenTroubleshootingWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfgType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_IonTokenTroubleshootingWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfgType CesiumForUnity_IonTokenTroubleshootingWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new CesiumForUnity_IonTokenTroubleshootingWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfgType(CesiumForUnity_IonTokenTroubleshootingWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_IonTokenTroubleshootingWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe void CesiumForUnity_IonTokenTroubleshootingWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfg(System.IntPtr thiz)
        {
            ((CesiumForUnity.IonTokenTroubleshootingWindow)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).Close();
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte CesiumForUnity_IonTokenTroubleshootingWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType(System.IntPtr x, System.IntPtr y);
        private static unsafe readonly CesiumForUnity_IonTokenTroubleshootingWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType CesiumForUnity_IonTokenTroubleshootingWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgDelegate = new CesiumForUnity_IonTokenTroubleshootingWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType(CesiumForUnity_IonTokenTroubleshootingWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2Wg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_IonTokenTroubleshootingWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType))]
        private static unsafe byte CesiumForUnity_IonTokenTroubleshootingWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2Wg(System.IntPtr x, System.IntPtr y)
        {
            
            var result = ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(x)!) == ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(y)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte CesiumForUnity_IonTokenTroubleshootingWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType(System.IntPtr x, System.IntPtr y);
        private static unsafe readonly CesiumForUnity_IonTokenTroubleshootingWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType CesiumForUnity_IonTokenTroubleshootingWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgDelegate = new CesiumForUnity_IonTokenTroubleshootingWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType(CesiumForUnity_IonTokenTroubleshootingWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2Wg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_IonTokenTroubleshootingWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType))]
        private static unsafe byte CesiumForUnity_IonTokenTroubleshootingWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2Wg(System.IntPtr x, System.IntPtr y)
        {
            
            var result = ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(x)!) != ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(y)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_IonTokenTroubleshootingWindow_CallUseDefaultToken_qpX7eE7SvOg4KIeidX7yngType(System.IntPtr asset);
        private static unsafe readonly CesiumForUnity_IonTokenTroubleshootingWindow_CallUseDefaultToken_qpX7eE7SvOg4KIeidX7yngType CesiumForUnity_IonTokenTroubleshootingWindow_CallUseDefaultToken_qpX7eE7SvOg4KIeidX7yngDelegate = new CesiumForUnity_IonTokenTroubleshootingWindow_CallUseDefaultToken_qpX7eE7SvOg4KIeidX7yngType(CesiumForUnity_IonTokenTroubleshootingWindow_CallUseDefaultToken_qpX7eE7SvOg4KIeidX7yng);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_IonTokenTroubleshootingWindow_CallUseDefaultToken_qpX7eE7SvOg4KIeidX7yngType))]
        private static unsafe void CesiumForUnity_IonTokenTroubleshootingWindow_CallUseDefaultToken_qpX7eE7SvOg4KIeidX7yng(System.IntPtr asset)
        {
            CesiumForUnity.IonTokenTroubleshootingWindow.UseDefaultToken((CesiumForUnity.CesiumIonAsset)Reinterop.ObjectHandleUtility.GetObjectFromHandle(asset)!);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_assetDetailsType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_assetDetailsType CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_assetDetailsDelegate = new CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_assetDetailsType(CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_assetDetails);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_assetDetailsType))]
        private static unsafe System.IntPtr CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_assetDetails(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.IonTokenTroubleshootingWindow)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).assetDetails;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_assetTokenDetailsType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_assetTokenDetailsType CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_assetTokenDetailsDelegate = new CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_assetTokenDetailsType(CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_assetTokenDetails);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_assetTokenDetailsType))]
        private static unsafe System.IntPtr CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_assetTokenDetails(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.IonTokenTroubleshootingWindow)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).assetTokenDetails;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_defaultTokenDetailsType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_defaultTokenDetailsType CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_defaultTokenDetailsDelegate = new CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_defaultTokenDetailsType(CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_defaultTokenDetails);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_defaultTokenDetailsType))]
        private static unsafe System.IntPtr CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_defaultTokenDetails(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.IonTokenTroubleshootingWindow)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).defaultTokenDetails;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_ionAssetType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_ionAssetType CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_ionAssetDelegate = new CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_ionAssetType(CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_ionAsset);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_ionAssetType))]
        private static unsafe System.IntPtr CesiumForUnity_IonTokenTroubleshootingWindow_Property_get_ionAsset(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.IonTokenTroubleshootingWindow)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).ionAsset;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_IonTokenTroubleshootingWindow_Property_set_ionAssetType(System.IntPtr thiz, System.IntPtr value);
        private static unsafe readonly CesiumForUnity_IonTokenTroubleshootingWindow_Property_set_ionAssetType CesiumForUnity_IonTokenTroubleshootingWindow_Property_set_ionAssetDelegate = new CesiumForUnity_IonTokenTroubleshootingWindow_Property_set_ionAssetType(CesiumForUnity_IonTokenTroubleshootingWindow_Property_set_ionAsset);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_IonTokenTroubleshootingWindow_Property_set_ionAssetType))]
        private static unsafe void CesiumForUnity_IonTokenTroubleshootingWindow_Property_set_ionAsset(System.IntPtr thiz, System.IntPtr value)
        {
            ((CesiumForUnity.IonTokenTroubleshootingWindow)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).ionAsset = (CesiumForUnity.CesiumIonAsset)Reinterop.ObjectHandleUtility.GetObjectFromHandle(value)!;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_NativeDownloadHandler_CallDispose_1B2M2Y8AsgTpgAmY7PhCfgType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_NativeDownloadHandler_CallDispose_1B2M2Y8AsgTpgAmY7PhCfgType CesiumForUnity_NativeDownloadHandler_CallDispose_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new CesiumForUnity_NativeDownloadHandler_CallDispose_1B2M2Y8AsgTpgAmY7PhCfgType(CesiumForUnity_NativeDownloadHandler_CallDispose_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_NativeDownloadHandler_CallDispose_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe void CesiumForUnity_NativeDownloadHandler_CallDispose_1B2M2Y8AsgTpgAmY7PhCfg(System.IntPtr thiz)
        {
            ((CesiumForUnity.NativeDownloadHandler)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).Dispose();
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_NativeDownloadHandler_Construct_1B2M2Y8AsgTpgAmY7PhCfgType();
        private static unsafe readonly CesiumForUnity_NativeDownloadHandler_Construct_1B2M2Y8AsgTpgAmY7PhCfgType CesiumForUnity_NativeDownloadHandler_Construct_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new CesiumForUnity_NativeDownloadHandler_Construct_1B2M2Y8AsgTpgAmY7PhCfgType(CesiumForUnity_NativeDownloadHandler_Construct_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_NativeDownloadHandler_Construct_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe System.IntPtr CesiumForUnity_NativeDownloadHandler_Construct_1B2M2Y8AsgTpgAmY7PhCfg()
        {
            
            var result = new CesiumForUnity.NativeDownloadHandler();
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_NativeDownloadHandler_Property_get_NativeImplementationType(IntPtr thiz);
        private static unsafe readonly CesiumForUnity_NativeDownloadHandler_Property_get_NativeImplementationType CesiumForUnity_NativeDownloadHandler_Property_get_NativeImplementationDelegate = new CesiumForUnity_NativeDownloadHandler_Property_get_NativeImplementationType(CesiumForUnity_NativeDownloadHandler_Property_get_NativeImplementation);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_NativeDownloadHandler_Property_get_NativeImplementationType))]
        private static unsafe System.IntPtr CesiumForUnity_NativeDownloadHandler_Property_get_NativeImplementation(IntPtr thiz)
        {
            return ((CesiumForUnity.NativeDownloadHandler)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).NativeImplementation.DangerousGetHandle();
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_SelectIonTokenWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfgType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_SelectIonTokenWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfgType CesiumForUnity_SelectIonTokenWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new CesiumForUnity_SelectIonTokenWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfgType(CesiumForUnity_SelectIonTokenWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_SelectIonTokenWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe void CesiumForUnity_SelectIonTokenWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfg(System.IntPtr thiz)
        {
            ((CesiumForUnity.SelectIonTokenWindow)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).Close();
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_SelectIonTokenWindow_CallGetDefaultNewTokenName_1B2M2Y8AsgTpgAmY7PhCfgType();
        private static unsafe readonly CesiumForUnity_SelectIonTokenWindow_CallGetDefaultNewTokenName_1B2M2Y8AsgTpgAmY7PhCfgType CesiumForUnity_SelectIonTokenWindow_CallGetDefaultNewTokenName_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new CesiumForUnity_SelectIonTokenWindow_CallGetDefaultNewTokenName_1B2M2Y8AsgTpgAmY7PhCfgType(CesiumForUnity_SelectIonTokenWindow_CallGetDefaultNewTokenName_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_SelectIonTokenWindow_CallGetDefaultNewTokenName_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe System.IntPtr CesiumForUnity_SelectIonTokenWindow_CallGetDefaultNewTokenName_1B2M2Y8AsgTpgAmY7PhCfg()
        {
            
            var result = CesiumForUnity.SelectIonTokenWindow.GetDefaultNewTokenName();
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_SelectIonTokenWindow_CallGetExistingTokenList_1B2M2Y8AsgTpgAmY7PhCfgType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_SelectIonTokenWindow_CallGetExistingTokenList_1B2M2Y8AsgTpgAmY7PhCfgType CesiumForUnity_SelectIonTokenWindow_CallGetExistingTokenList_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new CesiumForUnity_SelectIonTokenWindow_CallGetExistingTokenList_1B2M2Y8AsgTpgAmY7PhCfgType(CesiumForUnity_SelectIonTokenWindow_CallGetExistingTokenList_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_SelectIonTokenWindow_CallGetExistingTokenList_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe System.IntPtr CesiumForUnity_SelectIonTokenWindow_CallGetExistingTokenList_1B2M2Y8AsgTpgAmY7PhCfg(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.SelectIonTokenWindow)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).GetExistingTokenList();
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte CesiumForUnity_SelectIonTokenWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType(System.IntPtr x, System.IntPtr y);
        private static unsafe readonly CesiumForUnity_SelectIonTokenWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType CesiumForUnity_SelectIonTokenWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgDelegate = new CesiumForUnity_SelectIonTokenWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType(CesiumForUnity_SelectIonTokenWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2Wg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_SelectIonTokenWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType))]
        private static unsafe byte CesiumForUnity_SelectIonTokenWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2Wg(System.IntPtr x, System.IntPtr y)
        {
            
            var result = ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(x)!) == ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(y)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte CesiumForUnity_SelectIonTokenWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType(System.IntPtr x, System.IntPtr y);
        private static unsafe readonly CesiumForUnity_SelectIonTokenWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType CesiumForUnity_SelectIonTokenWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgDelegate = new CesiumForUnity_SelectIonTokenWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType(CesiumForUnity_SelectIonTokenWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2Wg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_SelectIonTokenWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType))]
        private static unsafe byte CesiumForUnity_SelectIonTokenWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2Wg(System.IntPtr x, System.IntPtr y)
        {
            
            var result = ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(x)!) != ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(y)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_SelectIonTokenWindow_CallRefreshExistingTokenList_1B2M2Y8AsgTpgAmY7PhCfgType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_SelectIonTokenWindow_CallRefreshExistingTokenList_1B2M2Y8AsgTpgAmY7PhCfgType CesiumForUnity_SelectIonTokenWindow_CallRefreshExistingTokenList_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new CesiumForUnity_SelectIonTokenWindow_CallRefreshExistingTokenList_1B2M2Y8AsgTpgAmY7PhCfgType(CesiumForUnity_SelectIonTokenWindow_CallRefreshExistingTokenList_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_SelectIonTokenWindow_CallRefreshExistingTokenList_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe void CesiumForUnity_SelectIonTokenWindow_CallRefreshExistingTokenList_1B2M2Y8AsgTpgAmY7PhCfg(System.IntPtr thiz)
        {
            ((CesiumForUnity.SelectIonTokenWindow)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).RefreshExistingTokenList();
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_SelectIonTokenWindow_CallShowWindow_1B2M2Y8AsgTpgAmY7PhCfgType();
        private static unsafe readonly CesiumForUnity_SelectIonTokenWindow_CallShowWindow_1B2M2Y8AsgTpgAmY7PhCfgType CesiumForUnity_SelectIonTokenWindow_CallShowWindow_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new CesiumForUnity_SelectIonTokenWindow_CallShowWindow_1B2M2Y8AsgTpgAmY7PhCfgType(CesiumForUnity_SelectIonTokenWindow_CallShowWindow_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_SelectIonTokenWindow_CallShowWindow_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe void CesiumForUnity_SelectIonTokenWindow_CallShowWindow_1B2M2Y8AsgTpgAmY7PhCfg()
        {
            CesiumForUnity.SelectIonTokenWindow.ShowWindow();
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_SelectIonTokenWindow_Field_get_currentWindowType();
        private static unsafe readonly CesiumForUnity_SelectIonTokenWindow_Field_get_currentWindowType CesiumForUnity_SelectIonTokenWindow_Field_get_currentWindowDelegate = new CesiumForUnity_SelectIonTokenWindow_Field_get_currentWindowType(CesiumForUnity_SelectIonTokenWindow_Field_get_currentWindow);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_SelectIonTokenWindow_Field_get_currentWindowType))]
        private static unsafe System.IntPtr CesiumForUnity_SelectIonTokenWindow_Field_get_currentWindow()
        {
            var result = CesiumForUnity.SelectIonTokenWindow.currentWindow;
          return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_SelectIonTokenWindow_Field_set_currentWindowType(System.IntPtr value);
        private static unsafe readonly CesiumForUnity_SelectIonTokenWindow_Field_set_currentWindowType CesiumForUnity_SelectIonTokenWindow_Field_set_currentWindowDelegate = new CesiumForUnity_SelectIonTokenWindow_Field_set_currentWindowType(CesiumForUnity_SelectIonTokenWindow_Field_set_currentWindow);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_SelectIonTokenWindow_Field_set_currentWindowType))]
        private static unsafe void CesiumForUnity_SelectIonTokenWindow_Field_set_currentWindow(System.IntPtr value)
        {
            CesiumForUnity.SelectIonTokenWindow.currentWindow = (CesiumForUnity.SelectIonTokenWindow)Reinterop.ObjectHandleUtility.GetObjectFromHandle(value)!;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_SelectIonTokenWindow_Property_get_createdTokenNameType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_SelectIonTokenWindow_Property_get_createdTokenNameType CesiumForUnity_SelectIonTokenWindow_Property_get_createdTokenNameDelegate = new CesiumForUnity_SelectIonTokenWindow_Property_get_createdTokenNameType(CesiumForUnity_SelectIonTokenWindow_Property_get_createdTokenName);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_SelectIonTokenWindow_Property_get_createdTokenNameType))]
        private static unsafe System.IntPtr CesiumForUnity_SelectIonTokenWindow_Property_get_createdTokenName(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.SelectIonTokenWindow)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).createdTokenName;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_SelectIonTokenWindow_Property_get_NativeImplementationType(IntPtr thiz);
        private static unsafe readonly CesiumForUnity_SelectIonTokenWindow_Property_get_NativeImplementationType CesiumForUnity_SelectIonTokenWindow_Property_get_NativeImplementationDelegate = new CesiumForUnity_SelectIonTokenWindow_Property_get_NativeImplementationType(CesiumForUnity_SelectIonTokenWindow_Property_get_NativeImplementation);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_SelectIonTokenWindow_Property_get_NativeImplementationType))]
        private static unsafe System.IntPtr CesiumForUnity_SelectIonTokenWindow_Property_get_NativeImplementation(IntPtr thiz)
        {
            return ((CesiumForUnity.SelectIonTokenWindow)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).NativeImplementation.DangerousGetHandle();
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate int CesiumForUnity_SelectIonTokenWindow_Property_get_selectedExistingTokenIndexType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_SelectIonTokenWindow_Property_get_selectedExistingTokenIndexType CesiumForUnity_SelectIonTokenWindow_Property_get_selectedExistingTokenIndexDelegate = new CesiumForUnity_SelectIonTokenWindow_Property_get_selectedExistingTokenIndexType(CesiumForUnity_SelectIonTokenWindow_Property_get_selectedExistingTokenIndex);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_SelectIonTokenWindow_Property_get_selectedExistingTokenIndexType))]
        private static unsafe int CesiumForUnity_SelectIonTokenWindow_Property_get_selectedExistingTokenIndex(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.SelectIonTokenWindow)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).selectedExistingTokenIndex;
            
            return result;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_SelectIonTokenWindow_Property_get_specifiedTokenType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_SelectIonTokenWindow_Property_get_specifiedTokenType CesiumForUnity_SelectIonTokenWindow_Property_get_specifiedTokenDelegate = new CesiumForUnity_SelectIonTokenWindow_Property_get_specifiedTokenType(CesiumForUnity_SelectIonTokenWindow_Property_get_specifiedToken);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_SelectIonTokenWindow_Property_get_specifiedTokenType))]
        private static unsafe System.IntPtr CesiumForUnity_SelectIonTokenWindow_Property_get_specifiedToken(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.SelectIonTokenWindow)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).specifiedToken;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate CesiumForUnity.IonTokenSource CesiumForUnity_SelectIonTokenWindow_Property_get_tokenSourceType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_SelectIonTokenWindow_Property_get_tokenSourceType CesiumForUnity_SelectIonTokenWindow_Property_get_tokenSourceDelegate = new CesiumForUnity_SelectIonTokenWindow_Property_get_tokenSourceType(CesiumForUnity_SelectIonTokenWindow_Property_get_tokenSource);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_SelectIonTokenWindow_Property_get_tokenSourceType))]
        private static unsafe CesiumForUnity.IonTokenSource CesiumForUnity_SelectIonTokenWindow_Property_get_tokenSource(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.SelectIonTokenWindow)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).tokenSource;
            
            return result;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_SelectIonTokenWindow_Property_set_createdTokenNameType(System.IntPtr thiz, System.IntPtr value);
        private static unsafe readonly CesiumForUnity_SelectIonTokenWindow_Property_set_createdTokenNameType CesiumForUnity_SelectIonTokenWindow_Property_set_createdTokenNameDelegate = new CesiumForUnity_SelectIonTokenWindow_Property_set_createdTokenNameType(CesiumForUnity_SelectIonTokenWindow_Property_set_createdTokenName);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_SelectIonTokenWindow_Property_set_createdTokenNameType))]
        private static unsafe void CesiumForUnity_SelectIonTokenWindow_Property_set_createdTokenName(System.IntPtr thiz, System.IntPtr value)
        {
            ((CesiumForUnity.SelectIonTokenWindow)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).createdTokenName = (string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(value)!;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_SelectIonTokenWindow_Property_set_selectedExistingTokenIndexType(System.IntPtr thiz, int value);
        private static unsafe readonly CesiumForUnity_SelectIonTokenWindow_Property_set_selectedExistingTokenIndexType CesiumForUnity_SelectIonTokenWindow_Property_set_selectedExistingTokenIndexDelegate = new CesiumForUnity_SelectIonTokenWindow_Property_set_selectedExistingTokenIndexType(CesiumForUnity_SelectIonTokenWindow_Property_set_selectedExistingTokenIndex);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_SelectIonTokenWindow_Property_set_selectedExistingTokenIndexType))]
        private static unsafe void CesiumForUnity_SelectIonTokenWindow_Property_set_selectedExistingTokenIndex(System.IntPtr thiz, int value)
        {
            ((CesiumForUnity.SelectIonTokenWindow)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).selectedExistingTokenIndex = value;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_SelectIonTokenWindow_Property_set_specifiedTokenType(System.IntPtr thiz, System.IntPtr value);
        private static unsafe readonly CesiumForUnity_SelectIonTokenWindow_Property_set_specifiedTokenType CesiumForUnity_SelectIonTokenWindow_Property_set_specifiedTokenDelegate = new CesiumForUnity_SelectIonTokenWindow_Property_set_specifiedTokenType(CesiumForUnity_SelectIonTokenWindow_Property_set_specifiedToken);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_SelectIonTokenWindow_Property_set_specifiedTokenType))]
        private static unsafe void CesiumForUnity_SelectIonTokenWindow_Property_set_specifiedToken(System.IntPtr thiz, System.IntPtr value)
        {
            ((CesiumForUnity.SelectIonTokenWindow)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).specifiedToken = (string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(value)!;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_SelectIonTokenWindow_Property_set_tokenSourceType(System.IntPtr thiz, CesiumForUnity.IonTokenSource value);
        private static unsafe readonly CesiumForUnity_SelectIonTokenWindow_Property_set_tokenSourceType CesiumForUnity_SelectIonTokenWindow_Property_set_tokenSourceDelegate = new CesiumForUnity_SelectIonTokenWindow_Property_set_tokenSourceType(CesiumForUnity_SelectIonTokenWindow_Property_set_tokenSource);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_SelectIonTokenWindow_Property_set_tokenSourceType))]
        private static unsafe void CesiumForUnity_SelectIonTokenWindow_Property_set_tokenSource(System.IntPtr thiz, CesiumForUnity.IonTokenSource value)
        {
            ((CesiumForUnity.SelectIonTokenWindow)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).tokenSource = value;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte CesiumForUnity_TokenTroubleshootingDetails_Property_get_allowsAccessToAssetType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_TokenTroubleshootingDetails_Property_get_allowsAccessToAssetType CesiumForUnity_TokenTroubleshootingDetails_Property_get_allowsAccessToAssetDelegate = new CesiumForUnity_TokenTroubleshootingDetails_Property_get_allowsAccessToAssetType(CesiumForUnity_TokenTroubleshootingDetails_Property_get_allowsAccessToAsset);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_TokenTroubleshootingDetails_Property_get_allowsAccessToAssetType))]
        private static unsafe byte CesiumForUnity_TokenTroubleshootingDetails_Property_get_allowsAccessToAsset(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.TokenTroubleshootingDetails)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).allowsAccessToAsset;
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte CesiumForUnity_TokenTroubleshootingDetails_Property_get_associatedWithUserAccountType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_TokenTroubleshootingDetails_Property_get_associatedWithUserAccountType CesiumForUnity_TokenTroubleshootingDetails_Property_get_associatedWithUserAccountDelegate = new CesiumForUnity_TokenTroubleshootingDetails_Property_get_associatedWithUserAccountType(CesiumForUnity_TokenTroubleshootingDetails_Property_get_associatedWithUserAccount);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_TokenTroubleshootingDetails_Property_get_associatedWithUserAccountType))]
        private static unsafe byte CesiumForUnity_TokenTroubleshootingDetails_Property_get_associatedWithUserAccount(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.TokenTroubleshootingDetails)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).associatedWithUserAccount;
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte CesiumForUnity_TokenTroubleshootingDetails_Property_get_isValidType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_TokenTroubleshootingDetails_Property_get_isValidType CesiumForUnity_TokenTroubleshootingDetails_Property_get_isValidDelegate = new CesiumForUnity_TokenTroubleshootingDetails_Property_get_isValidType(CesiumForUnity_TokenTroubleshootingDetails_Property_get_isValid);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_TokenTroubleshootingDetails_Property_get_isValidType))]
        private static unsafe byte CesiumForUnity_TokenTroubleshootingDetails_Property_get_isValid(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.TokenTroubleshootingDetails)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).isValid;
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte CesiumForUnity_TokenTroubleshootingDetails_Property_get_loadedType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_TokenTroubleshootingDetails_Property_get_loadedType CesiumForUnity_TokenTroubleshootingDetails_Property_get_loadedDelegate = new CesiumForUnity_TokenTroubleshootingDetails_Property_get_loadedType(CesiumForUnity_TokenTroubleshootingDetails_Property_get_loaded);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_TokenTroubleshootingDetails_Property_get_loadedType))]
        private static unsafe byte CesiumForUnity_TokenTroubleshootingDetails_Property_get_loaded(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.TokenTroubleshootingDetails)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).loaded;
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_TokenTroubleshootingDetails_Property_get_tokenType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_TokenTroubleshootingDetails_Property_get_tokenType CesiumForUnity_TokenTroubleshootingDetails_Property_get_tokenDelegate = new CesiumForUnity_TokenTroubleshootingDetails_Property_get_tokenType(CesiumForUnity_TokenTroubleshootingDetails_Property_get_token);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_TokenTroubleshootingDetails_Property_get_tokenType))]
        private static unsafe System.IntPtr CesiumForUnity_TokenTroubleshootingDetails_Property_get_token(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.TokenTroubleshootingDetails)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).token;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_TokenTroubleshootingDetails_Property_set_allowsAccessToAssetType(System.IntPtr thiz, byte value);
        private static unsafe readonly CesiumForUnity_TokenTroubleshootingDetails_Property_set_allowsAccessToAssetType CesiumForUnity_TokenTroubleshootingDetails_Property_set_allowsAccessToAssetDelegate = new CesiumForUnity_TokenTroubleshootingDetails_Property_set_allowsAccessToAssetType(CesiumForUnity_TokenTroubleshootingDetails_Property_set_allowsAccessToAsset);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_TokenTroubleshootingDetails_Property_set_allowsAccessToAssetType))]
        private static unsafe void CesiumForUnity_TokenTroubleshootingDetails_Property_set_allowsAccessToAsset(System.IntPtr thiz, byte value)
        {
            ((CesiumForUnity.TokenTroubleshootingDetails)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).allowsAccessToAsset = value != 0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_TokenTroubleshootingDetails_Property_set_associatedWithUserAccountType(System.IntPtr thiz, byte value);
        private static unsafe readonly CesiumForUnity_TokenTroubleshootingDetails_Property_set_associatedWithUserAccountType CesiumForUnity_TokenTroubleshootingDetails_Property_set_associatedWithUserAccountDelegate = new CesiumForUnity_TokenTroubleshootingDetails_Property_set_associatedWithUserAccountType(CesiumForUnity_TokenTroubleshootingDetails_Property_set_associatedWithUserAccount);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_TokenTroubleshootingDetails_Property_set_associatedWithUserAccountType))]
        private static unsafe void CesiumForUnity_TokenTroubleshootingDetails_Property_set_associatedWithUserAccount(System.IntPtr thiz, byte value)
        {
            ((CesiumForUnity.TokenTroubleshootingDetails)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).associatedWithUserAccount = value != 0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_TokenTroubleshootingDetails_Property_set_isValidType(System.IntPtr thiz, byte value);
        private static unsafe readonly CesiumForUnity_TokenTroubleshootingDetails_Property_set_isValidType CesiumForUnity_TokenTroubleshootingDetails_Property_set_isValidDelegate = new CesiumForUnity_TokenTroubleshootingDetails_Property_set_isValidType(CesiumForUnity_TokenTroubleshootingDetails_Property_set_isValid);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_TokenTroubleshootingDetails_Property_set_isValidType))]
        private static unsafe void CesiumForUnity_TokenTroubleshootingDetails_Property_set_isValid(System.IntPtr thiz, byte value)
        {
            ((CesiumForUnity.TokenTroubleshootingDetails)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).isValid = value != 0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_TokenTroubleshootingDetails_Property_set_loadedType(System.IntPtr thiz, byte value);
        private static unsafe readonly CesiumForUnity_TokenTroubleshootingDetails_Property_set_loadedType CesiumForUnity_TokenTroubleshootingDetails_Property_set_loadedDelegate = new CesiumForUnity_TokenTroubleshootingDetails_Property_set_loadedType(CesiumForUnity_TokenTroubleshootingDetails_Property_set_loaded);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_TokenTroubleshootingDetails_Property_set_loadedType))]
        private static unsafe void CesiumForUnity_TokenTroubleshootingDetails_Property_set_loaded(System.IntPtr thiz, byte value)
        {
            ((CesiumForUnity.TokenTroubleshootingDetails)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).loaded = value != 0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_TokenTroubleshootingDetails_Property_set_tokenType(System.IntPtr thiz, System.IntPtr value);
        private static unsafe readonly CesiumForUnity_TokenTroubleshootingDetails_Property_set_tokenType CesiumForUnity_TokenTroubleshootingDetails_Property_set_tokenDelegate = new CesiumForUnity_TokenTroubleshootingDetails_Property_set_tokenType(CesiumForUnity_TokenTroubleshootingDetails_Property_set_token);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_TokenTroubleshootingDetails_Property_set_tokenType))]
        private static unsafe void CesiumForUnity_TokenTroubleshootingDetails_Property_set_token(System.IntPtr thiz, System.IntPtr value)
        {
            ((CesiumForUnity.TokenTroubleshootingDetails)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).token = (string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(value)!;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr Reinterop_ObjectHandleUtility_CallCopyHandle_Lk0gUmdC13dRVZ_MAT71egType(System.IntPtr handle);
        private static unsafe readonly Reinterop_ObjectHandleUtility_CallCopyHandle_Lk0gUmdC13dRVZ_MAT71egType Reinterop_ObjectHandleUtility_CallCopyHandle_Lk0gUmdC13dRVZ_MAT71egDelegate = new Reinterop_ObjectHandleUtility_CallCopyHandle_Lk0gUmdC13dRVZ_MAT71egType(Reinterop_ObjectHandleUtility_CallCopyHandle_Lk0gUmdC13dRVZ_MAT71eg);
        [AOT.MonoPInvokeCallback(typeof(Reinterop_ObjectHandleUtility_CallCopyHandle_Lk0gUmdC13dRVZ_MAT71egType))]
        private static unsafe System.IntPtr Reinterop_ObjectHandleUtility_CallCopyHandle_Lk0gUmdC13dRVZ_MAT71eg(System.IntPtr handle)
        {
            
            var result = Reinterop.ObjectHandleUtility.CopyHandle(handle);
            
            return result;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr Reinterop_ObjectHandleUtility_CallCreateHandle_vjOnn8y5DjvqKs3467vAJQType(System.IntPtr o);
        private static unsafe readonly Reinterop_ObjectHandleUtility_CallCreateHandle_vjOnn8y5DjvqKs3467vAJQType Reinterop_ObjectHandleUtility_CallCreateHandle_vjOnn8y5DjvqKs3467vAJQDelegate = new Reinterop_ObjectHandleUtility_CallCreateHandle_vjOnn8y5DjvqKs3467vAJQType(Reinterop_ObjectHandleUtility_CallCreateHandle_vjOnn8y5DjvqKs3467vAJQ);
        [AOT.MonoPInvokeCallback(typeof(Reinterop_ObjectHandleUtility_CallCreateHandle_vjOnn8y5DjvqKs3467vAJQType))]
        private static unsafe System.IntPtr Reinterop_ObjectHandleUtility_CallCreateHandle_vjOnn8y5DjvqKs3467vAJQ(System.IntPtr o)
        {
            
            var result = Reinterop.ObjectHandleUtility.CreateHandle((object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(o)!);
            
            return result;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void Reinterop_ObjectHandleUtility_CallFreeHandle_Lk0gUmdC13dRVZ_MAT71egType(System.IntPtr handle);
        private static unsafe readonly Reinterop_ObjectHandleUtility_CallFreeHandle_Lk0gUmdC13dRVZ_MAT71egType Reinterop_ObjectHandleUtility_CallFreeHandle_Lk0gUmdC13dRVZ_MAT71egDelegate = new Reinterop_ObjectHandleUtility_CallFreeHandle_Lk0gUmdC13dRVZ_MAT71egType(Reinterop_ObjectHandleUtility_CallFreeHandle_Lk0gUmdC13dRVZ_MAT71eg);
        [AOT.MonoPInvokeCallback(typeof(Reinterop_ObjectHandleUtility_CallFreeHandle_Lk0gUmdC13dRVZ_MAT71egType))]
        private static unsafe void Reinterop_ObjectHandleUtility_CallFreeHandle_Lk0gUmdC13dRVZ_MAT71eg(System.IntPtr handle)
        {
            Reinterop.ObjectHandleUtility.FreeHandle(handle);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void System_Action_CallInvoke_1B2M2Y8AsgTpgAmY7PhCfgType(System.IntPtr thiz);
        private static unsafe readonly System_Action_CallInvoke_1B2M2Y8AsgTpgAmY7PhCfgType System_Action_CallInvoke_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new System_Action_CallInvoke_1B2M2Y8AsgTpgAmY7PhCfgType(System_Action_CallInvoke_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(System_Action_CallInvoke_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe void System_Action_CallInvoke_1B2M2Y8AsgTpgAmY7PhCfg(System.IntPtr thiz)
        {
            ((System.Action)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).Invoke();
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte System_Action_Callop_Equality__iYzpyUo7S__gDd8L5jFzrgType(System.IntPtr d1, System.IntPtr d2);
        private static unsafe readonly System_Action_Callop_Equality__iYzpyUo7S__gDd8L5jFzrgType System_Action_Callop_Equality__iYzpyUo7S__gDd8L5jFzrgDelegate = new System_Action_Callop_Equality__iYzpyUo7S__gDd8L5jFzrgType(System_Action_Callop_Equality__iYzpyUo7S__gDd8L5jFzrg);
        [AOT.MonoPInvokeCallback(typeof(System_Action_Callop_Equality__iYzpyUo7S__gDd8L5jFzrgType))]
        private static unsafe byte System_Action_Callop_Equality__iYzpyUo7S__gDd8L5jFzrg(System.IntPtr d1, System.IntPtr d2)
        {
            
            var result = ((System.MulticastDelegate)Reinterop.ObjectHandleUtility.GetObjectFromHandle(d1)!) == ((System.MulticastDelegate)Reinterop.ObjectHandleUtility.GetObjectFromHandle(d2)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte System_Action_Callop_Equality_a0RmOPC1vpOfulhhfnafBAType(System.IntPtr d1, System.IntPtr d2);
        private static unsafe readonly System_Action_Callop_Equality_a0RmOPC1vpOfulhhfnafBAType System_Action_Callop_Equality_a0RmOPC1vpOfulhhfnafBADelegate = new System_Action_Callop_Equality_a0RmOPC1vpOfulhhfnafBAType(System_Action_Callop_Equality_a0RmOPC1vpOfulhhfnafBA);
        [AOT.MonoPInvokeCallback(typeof(System_Action_Callop_Equality_a0RmOPC1vpOfulhhfnafBAType))]
        private static unsafe byte System_Action_Callop_Equality_a0RmOPC1vpOfulhhfnafBA(System.IntPtr d1, System.IntPtr d2)
        {
            
            var result = ((System.Delegate)Reinterop.ObjectHandleUtility.GetObjectFromHandle(d1)!) == ((System.Delegate)Reinterop.ObjectHandleUtility.GetObjectFromHandle(d2)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte System_Action_Callop_Inequality__iYzpyUo7S__gDd8L5jFzrgType(System.IntPtr d1, System.IntPtr d2);
        private static unsafe readonly System_Action_Callop_Inequality__iYzpyUo7S__gDd8L5jFzrgType System_Action_Callop_Inequality__iYzpyUo7S__gDd8L5jFzrgDelegate = new System_Action_Callop_Inequality__iYzpyUo7S__gDd8L5jFzrgType(System_Action_Callop_Inequality__iYzpyUo7S__gDd8L5jFzrg);
        [AOT.MonoPInvokeCallback(typeof(System_Action_Callop_Inequality__iYzpyUo7S__gDd8L5jFzrgType))]
        private static unsafe byte System_Action_Callop_Inequality__iYzpyUo7S__gDd8L5jFzrg(System.IntPtr d1, System.IntPtr d2)
        {
            
            var result = ((System.MulticastDelegate)Reinterop.ObjectHandleUtility.GetObjectFromHandle(d1)!) != ((System.MulticastDelegate)Reinterop.ObjectHandleUtility.GetObjectFromHandle(d2)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte System_Action_Callop_Inequality_a0RmOPC1vpOfulhhfnafBAType(System.IntPtr d1, System.IntPtr d2);
        private static unsafe readonly System_Action_Callop_Inequality_a0RmOPC1vpOfulhhfnafBAType System_Action_Callop_Inequality_a0RmOPC1vpOfulhhfnafBADelegate = new System_Action_Callop_Inequality_a0RmOPC1vpOfulhhfnafBAType(System_Action_Callop_Inequality_a0RmOPC1vpOfulhhfnafBA);
        [AOT.MonoPInvokeCallback(typeof(System_Action_Callop_Inequality_a0RmOPC1vpOfulhhfnafBAType))]
        private static unsafe byte System_Action_Callop_Inequality_a0RmOPC1vpOfulhhfnafBA(System.IntPtr d1, System.IntPtr d2)
        {
            
            var result = ((System.Delegate)Reinterop.ObjectHandleUtility.GetObjectFromHandle(d1)!) != ((System.Delegate)Reinterop.ObjectHandleUtility.GetObjectFromHandle(d2)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr System_Action_CombineDelegatesType(System.IntPtr thiz, System.IntPtr rhs);
        private static unsafe readonly System_Action_CombineDelegatesType System_Action_CombineDelegatesDelegate = new System_Action_CombineDelegatesType(System_Action_CombineDelegates);
        [AOT.MonoPInvokeCallback(typeof(System_Action_CombineDelegatesType))]
        private static unsafe System.IntPtr System_Action_CombineDelegates(System.IntPtr thiz, System.IntPtr rhs)
        {
            System.Action left = (System.Action)ObjectHandleUtility.GetObjectFromHandle(thiz)!;
            System.Action right = (System.Action)ObjectHandleUtility.GetObjectFromHandle(rhs)!;
            return ObjectHandleUtility.CreateHandle(left + right);
        }
        private class ActionNativeFunction : System.IDisposable
        {
            private IntPtr _callbackFunction;
        
            public ActionNativeFunction(IntPtr callbackFunction)
            {
                _callbackFunction = callbackFunction;
            }
        
            ~ActionNativeFunction()
            {
                Dispose(false);
            }
        
            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }
        
            private void Dispose(bool disposing)
            {
                if (_callbackFunction != IntPtr.Zero)
                {
                    System_Action_DisposeCallback(_callbackFunction);
                    _callbackFunction = IntPtr.Zero;
                }
            }
        
            public void Invoke()
            {
                if (_callbackFunction == null)
                    throw new System.ObjectDisposedException("Action");
        
                System_Action_InvokeCallback(_callbackFunction);
                return;;
            }
        
            [System.Runtime.InteropServices.DllImport("CesiumForUnityNative-Editor", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
            private static extern void System_Action_DisposeCallback(IntPtr callbackFunction);
            [System.Runtime.InteropServices.DllImport("CesiumForUnityNative-Editor", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
            private static extern void System_Action_InvokeCallback(IntPtr callbackFunction);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate IntPtr System_Action_CreateDelegateType(IntPtr callbackFunction);
        private static unsafe readonly System_Action_CreateDelegateType System_Action_CreateDelegateDelegate = new System_Action_CreateDelegateType(System_Action_CreateDelegate);
        [AOT.MonoPInvokeCallback(typeof(System_Action_CreateDelegateType))]
        private static unsafe IntPtr System_Action_CreateDelegate(IntPtr callbackFunction)
        {
            var receiver = new ActionNativeFunction(callbackFunction);
            return Reinterop.ObjectHandleUtility.CreateHandle(new System.Action(receiver.Invoke));
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr System_Action_RemoveDelegateType(System.IntPtr thiz, System.IntPtr rhs);
        private static unsafe readonly System_Action_RemoveDelegateType System_Action_RemoveDelegateDelegate = new System_Action_RemoveDelegateType(System_Action_RemoveDelegate);
        [AOT.MonoPInvokeCallback(typeof(System_Action_RemoveDelegateType))]
        private static unsafe System.IntPtr System_Action_RemoveDelegate(System.IntPtr thiz, System.IntPtr rhs)
        {
            System.Action left = (System.Action)ObjectHandleUtility.GetObjectFromHandle(thiz)!;
            System.Action right = (System.Action)ObjectHandleUtility.GetObjectFromHandle(rhs)!;
            return ObjectHandleUtility.CreateHandle(left - right);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void System_ActionA2lFbwI_1jdffaYu1u_OZg_CallInvoke_GZtSECpzDV__dvLP8ujKEdAType(System.IntPtr thiz, System.IntPtr obj);
        private static unsafe readonly System_ActionA2lFbwI_1jdffaYu1u_OZg_CallInvoke_GZtSECpzDV__dvLP8ujKEdAType System_ActionA2lFbwI_1jdffaYu1u_OZg_CallInvoke_GZtSECpzDV__dvLP8ujKEdADelegate = new System_ActionA2lFbwI_1jdffaYu1u_OZg_CallInvoke_GZtSECpzDV__dvLP8ujKEdAType(System_ActionA2lFbwI_1jdffaYu1u_OZg_CallInvoke_GZtSECpzDV__dvLP8ujKEdA);
        [AOT.MonoPInvokeCallback(typeof(System_ActionA2lFbwI_1jdffaYu1u_OZg_CallInvoke_GZtSECpzDV__dvLP8ujKEdAType))]
        private static unsafe void System_ActionA2lFbwI_1jdffaYu1u_OZg_CallInvoke_GZtSECpzDV__dvLP8ujKEdA(System.IntPtr thiz, System.IntPtr obj)
        {
            ((System.Action<UnityEngine.AsyncOperation>)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).Invoke((UnityEngine.AsyncOperation)Reinterop.ObjectHandleUtility.GetObjectFromHandle(obj)!);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Equality__iYzpyUo7S__gDd8L5jFzrgType(System.IntPtr d1, System.IntPtr d2);
        private static unsafe readonly System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Equality__iYzpyUo7S__gDd8L5jFzrgType System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Equality__iYzpyUo7S__gDd8L5jFzrgDelegate = new System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Equality__iYzpyUo7S__gDd8L5jFzrgType(System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Equality__iYzpyUo7S__gDd8L5jFzrg);
        [AOT.MonoPInvokeCallback(typeof(System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Equality__iYzpyUo7S__gDd8L5jFzrgType))]
        private static unsafe byte System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Equality__iYzpyUo7S__gDd8L5jFzrg(System.IntPtr d1, System.IntPtr d2)
        {
            
            var result = ((System.MulticastDelegate)Reinterop.ObjectHandleUtility.GetObjectFromHandle(d1)!) == ((System.MulticastDelegate)Reinterop.ObjectHandleUtility.GetObjectFromHandle(d2)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Equality_a0RmOPC1vpOfulhhfnafBAType(System.IntPtr d1, System.IntPtr d2);
        private static unsafe readonly System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Equality_a0RmOPC1vpOfulhhfnafBAType System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Equality_a0RmOPC1vpOfulhhfnafBADelegate = new System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Equality_a0RmOPC1vpOfulhhfnafBAType(System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Equality_a0RmOPC1vpOfulhhfnafBA);
        [AOT.MonoPInvokeCallback(typeof(System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Equality_a0RmOPC1vpOfulhhfnafBAType))]
        private static unsafe byte System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Equality_a0RmOPC1vpOfulhhfnafBA(System.IntPtr d1, System.IntPtr d2)
        {
            
            var result = ((System.Delegate)Reinterop.ObjectHandleUtility.GetObjectFromHandle(d1)!) == ((System.Delegate)Reinterop.ObjectHandleUtility.GetObjectFromHandle(d2)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Inequality__iYzpyUo7S__gDd8L5jFzrgType(System.IntPtr d1, System.IntPtr d2);
        private static unsafe readonly System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Inequality__iYzpyUo7S__gDd8L5jFzrgType System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Inequality__iYzpyUo7S__gDd8L5jFzrgDelegate = new System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Inequality__iYzpyUo7S__gDd8L5jFzrgType(System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Inequality__iYzpyUo7S__gDd8L5jFzrg);
        [AOT.MonoPInvokeCallback(typeof(System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Inequality__iYzpyUo7S__gDd8L5jFzrgType))]
        private static unsafe byte System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Inequality__iYzpyUo7S__gDd8L5jFzrg(System.IntPtr d1, System.IntPtr d2)
        {
            
            var result = ((System.MulticastDelegate)Reinterop.ObjectHandleUtility.GetObjectFromHandle(d1)!) != ((System.MulticastDelegate)Reinterop.ObjectHandleUtility.GetObjectFromHandle(d2)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Inequality_a0RmOPC1vpOfulhhfnafBAType(System.IntPtr d1, System.IntPtr d2);
        private static unsafe readonly System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Inequality_a0RmOPC1vpOfulhhfnafBAType System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Inequality_a0RmOPC1vpOfulhhfnafBADelegate = new System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Inequality_a0RmOPC1vpOfulhhfnafBAType(System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Inequality_a0RmOPC1vpOfulhhfnafBA);
        [AOT.MonoPInvokeCallback(typeof(System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Inequality_a0RmOPC1vpOfulhhfnafBAType))]
        private static unsafe byte System_ActionA2lFbwI_1jdffaYu1u_OZg_Callop_Inequality_a0RmOPC1vpOfulhhfnafBA(System.IntPtr d1, System.IntPtr d2)
        {
            
            var result = ((System.Delegate)Reinterop.ObjectHandleUtility.GetObjectFromHandle(d1)!) != ((System.Delegate)Reinterop.ObjectHandleUtility.GetObjectFromHandle(d2)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr System_ActionA2lFbwI_1jdffaYu1u_OZg_CombineDelegatesType(System.IntPtr thiz, System.IntPtr rhs);
        private static unsafe readonly System_ActionA2lFbwI_1jdffaYu1u_OZg_CombineDelegatesType System_ActionA2lFbwI_1jdffaYu1u_OZg_CombineDelegatesDelegate = new System_ActionA2lFbwI_1jdffaYu1u_OZg_CombineDelegatesType(System_ActionA2lFbwI_1jdffaYu1u_OZg_CombineDelegates);
        [AOT.MonoPInvokeCallback(typeof(System_ActionA2lFbwI_1jdffaYu1u_OZg_CombineDelegatesType))]
        private static unsafe System.IntPtr System_ActionA2lFbwI_1jdffaYu1u_OZg_CombineDelegates(System.IntPtr thiz, System.IntPtr rhs)
        {
            System.Action<UnityEngine.AsyncOperation> left = (System.Action<UnityEngine.AsyncOperation>)ObjectHandleUtility.GetObjectFromHandle(thiz)!;
            System.Action<UnityEngine.AsyncOperation> right = (System.Action<UnityEngine.AsyncOperation>)ObjectHandleUtility.GetObjectFromHandle(rhs)!;
            return ObjectHandleUtility.CreateHandle(left + right);
        }
        private class ActionA2lFbwI_1jdffaYu1u_OZgNativeFunction : System.IDisposable
        {
            private IntPtr _callbackFunction;
        
            public ActionA2lFbwI_1jdffaYu1u_OZgNativeFunction(IntPtr callbackFunction)
            {
                _callbackFunction = callbackFunction;
            }
        
            ~ActionA2lFbwI_1jdffaYu1u_OZgNativeFunction()
            {
                Dispose(false);
            }
        
            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }
        
            private void Dispose(bool disposing)
            {
                if (_callbackFunction != IntPtr.Zero)
                {
                    System_ActionA2lFbwI_1jdffaYu1u_OZg_DisposeCallback(_callbackFunction);
                    _callbackFunction = IntPtr.Zero;
                }
            }
        
            public void Invoke(UnityEngine.AsyncOperation obj)
            {
                if (_callbackFunction == null)
                    throw new System.ObjectDisposedException("Action");
        
                System_ActionA2lFbwI_1jdffaYu1u_OZg_InvokeCallback(_callbackFunction, Reinterop.ObjectHandleUtility.CreateHandle(obj));
                return;;
            }
        
            [System.Runtime.InteropServices.DllImport("CesiumForUnityNative-Editor", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
            private static extern void System_ActionA2lFbwI_1jdffaYu1u_OZg_DisposeCallback(IntPtr callbackFunction);
            [System.Runtime.InteropServices.DllImport("CesiumForUnityNative-Editor", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
            private static extern void System_ActionA2lFbwI_1jdffaYu1u_OZg_InvokeCallback(IntPtr callbackFunction, System.IntPtr obj);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate IntPtr System_ActionA2lFbwI_1jdffaYu1u_OZg_CreateDelegateType(IntPtr callbackFunction);
        private static unsafe readonly System_ActionA2lFbwI_1jdffaYu1u_OZg_CreateDelegateType System_ActionA2lFbwI_1jdffaYu1u_OZg_CreateDelegateDelegate = new System_ActionA2lFbwI_1jdffaYu1u_OZg_CreateDelegateType(System_ActionA2lFbwI_1jdffaYu1u_OZg_CreateDelegate);
        [AOT.MonoPInvokeCallback(typeof(System_ActionA2lFbwI_1jdffaYu1u_OZg_CreateDelegateType))]
        private static unsafe IntPtr System_ActionA2lFbwI_1jdffaYu1u_OZg_CreateDelegate(IntPtr callbackFunction)
        {
            var receiver = new ActionA2lFbwI_1jdffaYu1u_OZgNativeFunction(callbackFunction);
            return Reinterop.ObjectHandleUtility.CreateHandle(new System.Action<UnityEngine.AsyncOperation>(receiver.Invoke));
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr System_ActionA2lFbwI_1jdffaYu1u_OZg_RemoveDelegateType(System.IntPtr thiz, System.IntPtr rhs);
        private static unsafe readonly System_ActionA2lFbwI_1jdffaYu1u_OZg_RemoveDelegateType System_ActionA2lFbwI_1jdffaYu1u_OZg_RemoveDelegateDelegate = new System_ActionA2lFbwI_1jdffaYu1u_OZg_RemoveDelegateType(System_ActionA2lFbwI_1jdffaYu1u_OZg_RemoveDelegate);
        [AOT.MonoPInvokeCallback(typeof(System_ActionA2lFbwI_1jdffaYu1u_OZg_RemoveDelegateType))]
        private static unsafe System.IntPtr System_ActionA2lFbwI_1jdffaYu1u_OZg_RemoveDelegate(System.IntPtr thiz, System.IntPtr rhs)
        {
            System.Action<UnityEngine.AsyncOperation> left = (System.Action<UnityEngine.AsyncOperation>)ObjectHandleUtility.GetObjectFromHandle(thiz)!;
            System.Action<UnityEngine.AsyncOperation> right = (System.Action<UnityEngine.AsyncOperation>)ObjectHandleUtility.GetObjectFromHandle(rhs)!;
            return ObjectHandleUtility.CreateHandle(left - right);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate int System_Array_Property_get_LengthType(System.IntPtr thiz);
        private static unsafe readonly System_Array_Property_get_LengthType System_Array_Property_get_LengthDelegate = new System_Array_Property_get_LengthType(System_Array_Property_get_Length);
        [AOT.MonoPInvokeCallback(typeof(System_Array_Property_get_LengthType))]
        private static unsafe int System_Array_Property_get_Length(System.IntPtr thiz)
        {
            
            var result = ((System.Array)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).Length;
            
            return result;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate IntPtr CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_Constructor_SizeType(System.Int32 size);
        private static unsafe readonly CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_Constructor_SizeType CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_Constructor_SizeDelegate = new CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_Constructor_SizeType(CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_Constructor_Size);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_Constructor_SizeType))]
        private static unsafe IntPtr CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_Constructor_Size(System.Int32 size)
        {
            var result = new CesiumForUnity.Cesium3DTileset[size];
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_Property_get_ItemType(System.IntPtr thiz, int index);
        private static unsafe readonly CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_Property_get_ItemType CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_Property_get_ItemDelegate = new CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_Property_get_ItemType(CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_Property_get_Item);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_Property_get_ItemType))]
        private static unsafe System.IntPtr CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_Property_get_Item(System.IntPtr thiz, int index)
        {
            
            var result = ((CesiumForUnity.Cesium3DTileset[])Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!)[index];
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate int CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_Property_get_LengthType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_Property_get_LengthType CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_Property_get_LengthDelegate = new CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_Property_get_LengthType(CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_Property_get_Length);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_Property_get_LengthType))]
        private static unsafe int CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_Property_get_Length(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.Cesium3DTileset[])Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).Length;
            
            return result;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_SetItemType(System.IntPtr thiz, System.Int32 index, System.IntPtr value);
        private static unsafe readonly CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_SetItemType CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_SetItemDelegate = new CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_SetItemType(CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_SetItem);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_SetItemType))]
        private static unsafe void CesiumForUnity_Array10EgxpGTzCG1YTfWqwgLniw_SetItem(System.IntPtr thiz, System.Int32 index, System.IntPtr value)
        {
            ((CesiumForUnity.Cesium3DTileset[])Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!)[index] = (CesiumForUnity.Cesium3DTileset)Reinterop.ObjectHandleUtility.GetObjectFromHandle(value)!;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate IntPtr CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_Constructor_SizeType(System.Int32 size);
        private static unsafe readonly CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_Constructor_SizeType CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_Constructor_SizeDelegate = new CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_Constructor_SizeType(CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_Constructor_Size);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_Constructor_SizeType))]
        private static unsafe IntPtr CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_Constructor_Size(System.Int32 size)
        {
            var result = new CesiumForUnity.CesiumIonRasterOverlay[size];
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_Property_get_ItemType(System.IntPtr thiz, int index);
        private static unsafe readonly CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_Property_get_ItemType CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_Property_get_ItemDelegate = new CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_Property_get_ItemType(CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_Property_get_Item);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_Property_get_ItemType))]
        private static unsafe System.IntPtr CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_Property_get_Item(System.IntPtr thiz, int index)
        {
            
            var result = ((CesiumForUnity.CesiumIonRasterOverlay[])Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!)[index];
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate int CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_Property_get_LengthType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_Property_get_LengthType CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_Property_get_LengthDelegate = new CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_Property_get_LengthType(CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_Property_get_Length);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_Property_get_LengthType))]
        private static unsafe int CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_Property_get_Length(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.CesiumIonRasterOverlay[])Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).Length;
            
            return result;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_SetItemType(System.IntPtr thiz, System.Int32 index, System.IntPtr value);
        private static unsafe readonly CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_SetItemType CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_SetItemDelegate = new CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_SetItemType(CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_SetItem);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_SetItemType))]
        private static unsafe void CesiumForUnity_Array1BAtcoWNWVoAVplmna6OgsQ_SetItem(System.IntPtr thiz, System.Int32 index, System.IntPtr value)
        {
            ((CesiumForUnity.CesiumIonRasterOverlay[])Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!)[index] = (CesiumForUnity.CesiumIonRasterOverlay)Reinterop.ObjectHandleUtility.GetObjectFromHandle(value)!;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate IntPtr CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_Constructor_SizeType(System.Int32 size);
        private static unsafe readonly CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_Constructor_SizeType CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_Constructor_SizeDelegate = new CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_Constructor_SizeType(CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_Constructor_Size);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_Constructor_SizeType))]
        private static unsafe IntPtr CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_Constructor_Size(System.Int32 size)
        {
            var result = new CesiumForUnity.CesiumRasterOverlay[size];
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_Property_get_ItemType(System.IntPtr thiz, int index);
        private static unsafe readonly CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_Property_get_ItemType CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_Property_get_ItemDelegate = new CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_Property_get_ItemType(CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_Property_get_Item);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_Property_get_ItemType))]
        private static unsafe System.IntPtr CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_Property_get_Item(System.IntPtr thiz, int index)
        {
            
            var result = ((CesiumForUnity.CesiumRasterOverlay[])Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!)[index];
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate int CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_Property_get_LengthType(System.IntPtr thiz);
        private static unsafe readonly CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_Property_get_LengthType CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_Property_get_LengthDelegate = new CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_Property_get_LengthType(CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_Property_get_Length);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_Property_get_LengthType))]
        private static unsafe int CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_Property_get_Length(System.IntPtr thiz)
        {
            
            var result = ((CesiumForUnity.CesiumRasterOverlay[])Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).Length;
            
            return result;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_SetItemType(System.IntPtr thiz, System.Int32 index, System.IntPtr value);
        private static unsafe readonly CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_SetItemType CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_SetItemDelegate = new CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_SetItemType(CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_SetItem);
        [AOT.MonoPInvokeCallback(typeof(CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_SetItemType))]
        private static unsafe void CesiumForUnity_Array1H1UZCBm__Pf6NnqpE7xQ8NQ_SetItem(System.IntPtr thiz, System.Int32 index, System.IntPtr value)
        {
            ((CesiumForUnity.CesiumRasterOverlay[])Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!)[index] = (CesiumForUnity.CesiumRasterOverlay)Reinterop.ObjectHandleUtility.GetObjectFromHandle(value)!;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate IntPtr System_Array1z79ECk55IqLfMIqXBYg_8w_Constructor_SizeType(System.Int32 size);
        private static unsafe readonly System_Array1z79ECk55IqLfMIqXBYg_8w_Constructor_SizeType System_Array1z79ECk55IqLfMIqXBYg_8w_Constructor_SizeDelegate = new System_Array1z79ECk55IqLfMIqXBYg_8w_Constructor_SizeType(System_Array1z79ECk55IqLfMIqXBYg_8w_Constructor_Size);
        [AOT.MonoPInvokeCallback(typeof(System_Array1z79ECk55IqLfMIqXBYg_8w_Constructor_SizeType))]
        private static unsafe IntPtr System_Array1z79ECk55IqLfMIqXBYg_8w_Constructor_Size(System.Int32 size)
        {
            var result = new byte[size];
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate int System_Array1z79ECk55IqLfMIqXBYg_8w_Property_get_LengthType(System.IntPtr thiz);
        private static unsafe readonly System_Array1z79ECk55IqLfMIqXBYg_8w_Property_get_LengthType System_Array1z79ECk55IqLfMIqXBYg_8w_Property_get_LengthDelegate = new System_Array1z79ECk55IqLfMIqXBYg_8w_Property_get_LengthType(System_Array1z79ECk55IqLfMIqXBYg_8w_Property_get_Length);
        [AOT.MonoPInvokeCallback(typeof(System_Array1z79ECk55IqLfMIqXBYg_8w_Property_get_LengthType))]
        private static unsafe int System_Array1z79ECk55IqLfMIqXBYg_8w_Property_get_Length(System.IntPtr thiz)
        {
            
            var result = ((byte[])Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).Length;
            
            return result;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void System_Array1z79ECk55IqLfMIqXBYg_8w_SetItemType(System.IntPtr thiz, System.Int32 index, byte value);
        private static unsafe readonly System_Array1z79ECk55IqLfMIqXBYg_8w_SetItemType System_Array1z79ECk55IqLfMIqXBYg_8w_SetItemDelegate = new System_Array1z79ECk55IqLfMIqXBYg_8w_SetItemType(System_Array1z79ECk55IqLfMIqXBYg_8w_SetItem);
        [AOT.MonoPInvokeCallback(typeof(System_Array1z79ECk55IqLfMIqXBYg_8w_SetItemType))]
        private static unsafe void System_Array1z79ECk55IqLfMIqXBYg_8w_SetItem(System.IntPtr thiz, System.Int32 index, byte value)
        {
            ((byte[])Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!)[index] = value;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr System_Collections_Generic_Dictionary5Hx6c0Eu2sl__zevLSSpjKA_CallGetEnumerator_1B2M2Y8AsgTpgAmY7PhCfgType(System.IntPtr thiz);
        private static unsafe readonly System_Collections_Generic_Dictionary5Hx6c0Eu2sl__zevLSSpjKA_CallGetEnumerator_1B2M2Y8AsgTpgAmY7PhCfgType System_Collections_Generic_Dictionary5Hx6c0Eu2sl__zevLSSpjKA_CallGetEnumerator_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new System_Collections_Generic_Dictionary5Hx6c0Eu2sl__zevLSSpjKA_CallGetEnumerator_1B2M2Y8AsgTpgAmY7PhCfgType(System_Collections_Generic_Dictionary5Hx6c0Eu2sl__zevLSSpjKA_CallGetEnumerator_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(System_Collections_Generic_Dictionary5Hx6c0Eu2sl__zevLSSpjKA_CallGetEnumerator_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe System.IntPtr System_Collections_Generic_Dictionary5Hx6c0Eu2sl__zevLSSpjKA_CallGetEnumerator_1B2M2Y8AsgTpgAmY7PhCfg(System.IntPtr thiz)
        {
            
            var result = ((System.Collections.Generic.Dictionary<string, string>)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).GetEnumerator();
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte System_Collections_Generic_Enumerator1B2M2Y8AsgTpgAmY7PhCfg_CallMoveNext_1B2M2Y8AsgTpgAmY7PhCfgType(System.IntPtr thiz);
        private static unsafe readonly System_Collections_Generic_Enumerator1B2M2Y8AsgTpgAmY7PhCfg_CallMoveNext_1B2M2Y8AsgTpgAmY7PhCfgType System_Collections_Generic_Enumerator1B2M2Y8AsgTpgAmY7PhCfg_CallMoveNext_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new System_Collections_Generic_Enumerator1B2M2Y8AsgTpgAmY7PhCfg_CallMoveNext_1B2M2Y8AsgTpgAmY7PhCfgType(System_Collections_Generic_Enumerator1B2M2Y8AsgTpgAmY7PhCfg_CallMoveNext_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(System_Collections_Generic_Enumerator1B2M2Y8AsgTpgAmY7PhCfg_CallMoveNext_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe byte System_Collections_Generic_Enumerator1B2M2Y8AsgTpgAmY7PhCfg_CallMoveNext_1B2M2Y8AsgTpgAmY7PhCfg(System.IntPtr thiz)
        {
            var thizUnboxed = (System.Collections.Generic.Dictionary<string, string>.Enumerator)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!;
            var result = thizUnboxed.MoveNext();
            Reinterop.ObjectHandleUtility.ResetHandleObject(thiz, thizUnboxed);
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr System_Collections_Generic_Enumerator1B2M2Y8AsgTpgAmY7PhCfg_Property_get_CurrentType(System.IntPtr thiz);
        private static unsafe readonly System_Collections_Generic_Enumerator1B2M2Y8AsgTpgAmY7PhCfg_Property_get_CurrentType System_Collections_Generic_Enumerator1B2M2Y8AsgTpgAmY7PhCfg_Property_get_CurrentDelegate = new System_Collections_Generic_Enumerator1B2M2Y8AsgTpgAmY7PhCfg_Property_get_CurrentType(System_Collections_Generic_Enumerator1B2M2Y8AsgTpgAmY7PhCfg_Property_get_Current);
        [AOT.MonoPInvokeCallback(typeof(System_Collections_Generic_Enumerator1B2M2Y8AsgTpgAmY7PhCfg_Property_get_CurrentType))]
        private static unsafe System.IntPtr System_Collections_Generic_Enumerator1B2M2Y8AsgTpgAmY7PhCfg_Property_get_Current(System.IntPtr thiz)
        {
            var thizUnboxed = (System.Collections.Generic.Dictionary<string, string>.Enumerator)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!;
            var result = thizUnboxed.Current;
            Reinterop.ObjectHandleUtility.ResetHandleObject(thiz, thizUnboxed);
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr System_Collections_Generic_KeyValuePair5Hx6c0Eu2sl__zevLSSpjKA_Property_get_KeyType(System.IntPtr thiz);
        private static unsafe readonly System_Collections_Generic_KeyValuePair5Hx6c0Eu2sl__zevLSSpjKA_Property_get_KeyType System_Collections_Generic_KeyValuePair5Hx6c0Eu2sl__zevLSSpjKA_Property_get_KeyDelegate = new System_Collections_Generic_KeyValuePair5Hx6c0Eu2sl__zevLSSpjKA_Property_get_KeyType(System_Collections_Generic_KeyValuePair5Hx6c0Eu2sl__zevLSSpjKA_Property_get_Key);
        [AOT.MonoPInvokeCallback(typeof(System_Collections_Generic_KeyValuePair5Hx6c0Eu2sl__zevLSSpjKA_Property_get_KeyType))]
        private static unsafe System.IntPtr System_Collections_Generic_KeyValuePair5Hx6c0Eu2sl__zevLSSpjKA_Property_get_Key(System.IntPtr thiz)
        {
            var thizUnboxed = (System.Collections.Generic.KeyValuePair<string, string>)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!;
            var result = thizUnboxed.Key;
            Reinterop.ObjectHandleUtility.ResetHandleObject(thiz, thizUnboxed);
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr System_Collections_Generic_KeyValuePair5Hx6c0Eu2sl__zevLSSpjKA_Property_get_ValueType(System.IntPtr thiz);
        private static unsafe readonly System_Collections_Generic_KeyValuePair5Hx6c0Eu2sl__zevLSSpjKA_Property_get_ValueType System_Collections_Generic_KeyValuePair5Hx6c0Eu2sl__zevLSSpjKA_Property_get_ValueDelegate = new System_Collections_Generic_KeyValuePair5Hx6c0Eu2sl__zevLSSpjKA_Property_get_ValueType(System_Collections_Generic_KeyValuePair5Hx6c0Eu2sl__zevLSSpjKA_Property_get_Value);
        [AOT.MonoPInvokeCallback(typeof(System_Collections_Generic_KeyValuePair5Hx6c0Eu2sl__zevLSSpjKA_Property_get_ValueType))]
        private static unsafe System.IntPtr System_Collections_Generic_KeyValuePair5Hx6c0Eu2sl__zevLSSpjKA_Property_get_Value(System.IntPtr thiz)
        {
            var thizUnboxed = (System.Collections.Generic.KeyValuePair<string, string>)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!;
            var result = thizUnboxed.Value;
            Reinterop.ObjectHandleUtility.ResetHandleObject(thiz, thizUnboxed);
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void System_Collections_Generic_List5eSlqDLksZG1Mz9C9wH0GQ_CallAdd_LRSjiXmrvb5pgfbcZ_Nv7wType(System.IntPtr thiz, System.IntPtr item);
        private static unsafe readonly System_Collections_Generic_List5eSlqDLksZG1Mz9C9wH0GQ_CallAdd_LRSjiXmrvb5pgfbcZ_Nv7wType System_Collections_Generic_List5eSlqDLksZG1Mz9C9wH0GQ_CallAdd_LRSjiXmrvb5pgfbcZ_Nv7wDelegate = new System_Collections_Generic_List5eSlqDLksZG1Mz9C9wH0GQ_CallAdd_LRSjiXmrvb5pgfbcZ_Nv7wType(System_Collections_Generic_List5eSlqDLksZG1Mz9C9wH0GQ_CallAdd_LRSjiXmrvb5pgfbcZ_Nv7w);
        [AOT.MonoPInvokeCallback(typeof(System_Collections_Generic_List5eSlqDLksZG1Mz9C9wH0GQ_CallAdd_LRSjiXmrvb5pgfbcZ_Nv7wType))]
        private static unsafe void System_Collections_Generic_List5eSlqDLksZG1Mz9C9wH0GQ_CallAdd_LRSjiXmrvb5pgfbcZ_Nv7w(System.IntPtr thiz, System.IntPtr item)
        {
            ((System.Collections.Generic.List<string>)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).Add((string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(item)!);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void System_Collections_Generic_List5eSlqDLksZG1Mz9C9wH0GQ_CallClear_1B2M2Y8AsgTpgAmY7PhCfgType(System.IntPtr thiz);
        private static unsafe readonly System_Collections_Generic_List5eSlqDLksZG1Mz9C9wH0GQ_CallClear_1B2M2Y8AsgTpgAmY7PhCfgType System_Collections_Generic_List5eSlqDLksZG1Mz9C9wH0GQ_CallClear_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new System_Collections_Generic_List5eSlqDLksZG1Mz9C9wH0GQ_CallClear_1B2M2Y8AsgTpgAmY7PhCfgType(System_Collections_Generic_List5eSlqDLksZG1Mz9C9wH0GQ_CallClear_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(System_Collections_Generic_List5eSlqDLksZG1Mz9C9wH0GQ_CallClear_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe void System_Collections_Generic_List5eSlqDLksZG1Mz9C9wH0GQ_CallClear_1B2M2Y8AsgTpgAmY7PhCfg(System.IntPtr thiz)
        {
            ((System.Collections.Generic.List<string>)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).Clear();
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte System_Delegate_Callop_Equality_a0RmOPC1vpOfulhhfnafBAType(System.IntPtr d1, System.IntPtr d2);
        private static unsafe readonly System_Delegate_Callop_Equality_a0RmOPC1vpOfulhhfnafBAType System_Delegate_Callop_Equality_a0RmOPC1vpOfulhhfnafBADelegate = new System_Delegate_Callop_Equality_a0RmOPC1vpOfulhhfnafBAType(System_Delegate_Callop_Equality_a0RmOPC1vpOfulhhfnafBA);
        [AOT.MonoPInvokeCallback(typeof(System_Delegate_Callop_Equality_a0RmOPC1vpOfulhhfnafBAType))]
        private static unsafe byte System_Delegate_Callop_Equality_a0RmOPC1vpOfulhhfnafBA(System.IntPtr d1, System.IntPtr d2)
        {
            
            var result = ((System.Delegate)Reinterop.ObjectHandleUtility.GetObjectFromHandle(d1)!) == ((System.Delegate)Reinterop.ObjectHandleUtility.GetObjectFromHandle(d2)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte System_Delegate_Callop_Inequality_a0RmOPC1vpOfulhhfnafBAType(System.IntPtr d1, System.IntPtr d2);
        private static unsafe readonly System_Delegate_Callop_Inequality_a0RmOPC1vpOfulhhfnafBAType System_Delegate_Callop_Inequality_a0RmOPC1vpOfulhhfnafBADelegate = new System_Delegate_Callop_Inequality_a0RmOPC1vpOfulhhfnafBAType(System_Delegate_Callop_Inequality_a0RmOPC1vpOfulhhfnafBA);
        [AOT.MonoPInvokeCallback(typeof(System_Delegate_Callop_Inequality_a0RmOPC1vpOfulhhfnafBAType))]
        private static unsafe byte System_Delegate_Callop_Inequality_a0RmOPC1vpOfulhhfnafBA(System.IntPtr d1, System.IntPtr d2)
        {
            
            var result = ((System.Delegate)Reinterop.ObjectHandleUtility.GetObjectFromHandle(d1)!) != ((System.Delegate)Reinterop.ObjectHandleUtility.GetObjectFromHandle(d2)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr System_Environment_Property_get_OSVersionType();
        private static unsafe readonly System_Environment_Property_get_OSVersionType System_Environment_Property_get_OSVersionDelegate = new System_Environment_Property_get_OSVersionType(System_Environment_Property_get_OSVersion);
        [AOT.MonoPInvokeCallback(typeof(System_Environment_Property_get_OSVersionType))]
        private static unsafe System.IntPtr System_Environment_Property_get_OSVersion()
        {
            
            var result = System.Environment.OSVersion;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte System_MulticastDelegate_Callop_Equality__iYzpyUo7S__gDd8L5jFzrgType(System.IntPtr d1, System.IntPtr d2);
        private static unsafe readonly System_MulticastDelegate_Callop_Equality__iYzpyUo7S__gDd8L5jFzrgType System_MulticastDelegate_Callop_Equality__iYzpyUo7S__gDd8L5jFzrgDelegate = new System_MulticastDelegate_Callop_Equality__iYzpyUo7S__gDd8L5jFzrgType(System_MulticastDelegate_Callop_Equality__iYzpyUo7S__gDd8L5jFzrg);
        [AOT.MonoPInvokeCallback(typeof(System_MulticastDelegate_Callop_Equality__iYzpyUo7S__gDd8L5jFzrgType))]
        private static unsafe byte System_MulticastDelegate_Callop_Equality__iYzpyUo7S__gDd8L5jFzrg(System.IntPtr d1, System.IntPtr d2)
        {
            
            var result = ((System.MulticastDelegate)Reinterop.ObjectHandleUtility.GetObjectFromHandle(d1)!) == ((System.MulticastDelegate)Reinterop.ObjectHandleUtility.GetObjectFromHandle(d2)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte System_MulticastDelegate_Callop_Equality_a0RmOPC1vpOfulhhfnafBAType(System.IntPtr d1, System.IntPtr d2);
        private static unsafe readonly System_MulticastDelegate_Callop_Equality_a0RmOPC1vpOfulhhfnafBAType System_MulticastDelegate_Callop_Equality_a0RmOPC1vpOfulhhfnafBADelegate = new System_MulticastDelegate_Callop_Equality_a0RmOPC1vpOfulhhfnafBAType(System_MulticastDelegate_Callop_Equality_a0RmOPC1vpOfulhhfnafBA);
        [AOT.MonoPInvokeCallback(typeof(System_MulticastDelegate_Callop_Equality_a0RmOPC1vpOfulhhfnafBAType))]
        private static unsafe byte System_MulticastDelegate_Callop_Equality_a0RmOPC1vpOfulhhfnafBA(System.IntPtr d1, System.IntPtr d2)
        {
            
            var result = ((System.Delegate)Reinterop.ObjectHandleUtility.GetObjectFromHandle(d1)!) == ((System.Delegate)Reinterop.ObjectHandleUtility.GetObjectFromHandle(d2)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte System_MulticastDelegate_Callop_Inequality__iYzpyUo7S__gDd8L5jFzrgType(System.IntPtr d1, System.IntPtr d2);
        private static unsafe readonly System_MulticastDelegate_Callop_Inequality__iYzpyUo7S__gDd8L5jFzrgType System_MulticastDelegate_Callop_Inequality__iYzpyUo7S__gDd8L5jFzrgDelegate = new System_MulticastDelegate_Callop_Inequality__iYzpyUo7S__gDd8L5jFzrgType(System_MulticastDelegate_Callop_Inequality__iYzpyUo7S__gDd8L5jFzrg);
        [AOT.MonoPInvokeCallback(typeof(System_MulticastDelegate_Callop_Inequality__iYzpyUo7S__gDd8L5jFzrgType))]
        private static unsafe byte System_MulticastDelegate_Callop_Inequality__iYzpyUo7S__gDd8L5jFzrg(System.IntPtr d1, System.IntPtr d2)
        {
            
            var result = ((System.MulticastDelegate)Reinterop.ObjectHandleUtility.GetObjectFromHandle(d1)!) != ((System.MulticastDelegate)Reinterop.ObjectHandleUtility.GetObjectFromHandle(d2)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte System_MulticastDelegate_Callop_Inequality_a0RmOPC1vpOfulhhfnafBAType(System.IntPtr d1, System.IntPtr d2);
        private static unsafe readonly System_MulticastDelegate_Callop_Inequality_a0RmOPC1vpOfulhhfnafBAType System_MulticastDelegate_Callop_Inequality_a0RmOPC1vpOfulhhfnafBADelegate = new System_MulticastDelegate_Callop_Inequality_a0RmOPC1vpOfulhhfnafBAType(System_MulticastDelegate_Callop_Inequality_a0RmOPC1vpOfulhhfnafBA);
        [AOT.MonoPInvokeCallback(typeof(System_MulticastDelegate_Callop_Inequality_a0RmOPC1vpOfulhhfnafBAType))]
        private static unsafe byte System_MulticastDelegate_Callop_Inequality_a0RmOPC1vpOfulhhfnafBA(System.IntPtr d1, System.IntPtr d2)
        {
            
            var result = ((System.Delegate)Reinterop.ObjectHandleUtility.GetObjectFromHandle(d1)!) != ((System.Delegate)Reinterop.ObjectHandleUtility.GetObjectFromHandle(d2)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr System_Object_Construct_1B2M2Y8AsgTpgAmY7PhCfgType();
        private static unsafe readonly System_Object_Construct_1B2M2Y8AsgTpgAmY7PhCfgType System_Object_Construct_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new System_Object_Construct_1B2M2Y8AsgTpgAmY7PhCfgType(System_Object_Construct_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(System_Object_Construct_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe System.IntPtr System_Object_Construct_1B2M2Y8AsgTpgAmY7PhCfg()
        {
            
            var result = new object();
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr System_OperatingSystem_Property_get_VersionStringType(System.IntPtr thiz);
        private static unsafe readonly System_OperatingSystem_Property_get_VersionStringType System_OperatingSystem_Property_get_VersionStringDelegate = new System_OperatingSystem_Property_get_VersionStringType(System_OperatingSystem_Property_get_VersionString);
        [AOT.MonoPInvokeCallback(typeof(System_OperatingSystem_Property_get_VersionStringType))]
        private static unsafe System.IntPtr System_OperatingSystem_Property_get_VersionString(System.IntPtr thiz)
        {
            
            var result = ((System.OperatingSystem)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).VersionString;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void System_Runtime_InteropServices_Marshal_CallFreeCoTaskMem_eF5IwSJe_WM3IuDxcegQFgType(System.IntPtr ptr);
        private static unsafe readonly System_Runtime_InteropServices_Marshal_CallFreeCoTaskMem_eF5IwSJe_WM3IuDxcegQFgType System_Runtime_InteropServices_Marshal_CallFreeCoTaskMem_eF5IwSJe_WM3IuDxcegQFgDelegate = new System_Runtime_InteropServices_Marshal_CallFreeCoTaskMem_eF5IwSJe_WM3IuDxcegQFgType(System_Runtime_InteropServices_Marshal_CallFreeCoTaskMem_eF5IwSJe_WM3IuDxcegQFg);
        [AOT.MonoPInvokeCallback(typeof(System_Runtime_InteropServices_Marshal_CallFreeCoTaskMem_eF5IwSJe_WM3IuDxcegQFgType))]
        private static unsafe void System_Runtime_InteropServices_Marshal_CallFreeCoTaskMem_eF5IwSJe_WM3IuDxcegQFg(System.IntPtr ptr)
        {
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(ptr);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr System_Runtime_InteropServices_Marshal_CallStringToCoTaskMemUTF8_ga80EVd9gqZ4YlhSP8iRzgType(System.IntPtr s);
        private static unsafe readonly System_Runtime_InteropServices_Marshal_CallStringToCoTaskMemUTF8_ga80EVd9gqZ4YlhSP8iRzgType System_Runtime_InteropServices_Marshal_CallStringToCoTaskMemUTF8_ga80EVd9gqZ4YlhSP8iRzgDelegate = new System_Runtime_InteropServices_Marshal_CallStringToCoTaskMemUTF8_ga80EVd9gqZ4YlhSP8iRzgType(System_Runtime_InteropServices_Marshal_CallStringToCoTaskMemUTF8_ga80EVd9gqZ4YlhSP8iRzg);
        [AOT.MonoPInvokeCallback(typeof(System_Runtime_InteropServices_Marshal_CallStringToCoTaskMemUTF8_ga80EVd9gqZ4YlhSP8iRzgType))]
        private static unsafe System.IntPtr System_Runtime_InteropServices_Marshal_CallStringToCoTaskMemUTF8_ga80EVd9gqZ4YlhSP8iRzg(System.IntPtr s)
        {
            
            var result = System.Runtime.InteropServices.Marshal.StringToCoTaskMemUTF8((string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(s)!);
            
            return result;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr System_String_CallConcat_OM9SoWVFMTHXvbepMyUchwType(System.IntPtr str0, System.IntPtr str1);
        private static unsafe readonly System_String_CallConcat_OM9SoWVFMTHXvbepMyUchwType System_String_CallConcat_OM9SoWVFMTHXvbepMyUchwDelegate = new System_String_CallConcat_OM9SoWVFMTHXvbepMyUchwType(System_String_CallConcat_OM9SoWVFMTHXvbepMyUchw);
        [AOT.MonoPInvokeCallback(typeof(System_String_CallConcat_OM9SoWVFMTHXvbepMyUchwType))]
        private static unsafe System.IntPtr System_String_CallConcat_OM9SoWVFMTHXvbepMyUchw(System.IntPtr str0, System.IntPtr str1)
        {
            
            var result = string.Concat((string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(str0)!, (string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(str1)!);
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr System_String_CallConcat_yq7nlytzIFp8a79slfH_mwType(System.IntPtr arg0, System.IntPtr arg1);
        private static unsafe readonly System_String_CallConcat_yq7nlytzIFp8a79slfH_mwType System_String_CallConcat_yq7nlytzIFp8a79slfH_mwDelegate = new System_String_CallConcat_yq7nlytzIFp8a79slfH_mwType(System_String_CallConcat_yq7nlytzIFp8a79slfH_mw);
        [AOT.MonoPInvokeCallback(typeof(System_String_CallConcat_yq7nlytzIFp8a79slfH_mwType))]
        private static unsafe System.IntPtr System_String_CallConcat_yq7nlytzIFp8a79slfH_mw(System.IntPtr arg0, System.IntPtr arg1)
        {
            
            var result = string.Concat((object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(arg0)!, (object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(arg1)!);
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte System_String_CallContains_GImL1A5rlEQAx14EidO2oAType(System.IntPtr thiz, System.IntPtr value, System.StringComparison comparisonType);
        private static unsafe readonly System_String_CallContains_GImL1A5rlEQAx14EidO2oAType System_String_CallContains_GImL1A5rlEQAx14EidO2oADelegate = new System_String_CallContains_GImL1A5rlEQAx14EidO2oAType(System_String_CallContains_GImL1A5rlEQAx14EidO2oA);
        [AOT.MonoPInvokeCallback(typeof(System_String_CallContains_GImL1A5rlEQAx14EidO2oAType))]
        private static unsafe byte System_String_CallContains_GImL1A5rlEQAx14EidO2oA(System.IntPtr thiz, System.IntPtr value, System.StringComparison comparisonType)
        {
            
            var result = ((string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).Contains((string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(value)!, comparisonType);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte System_String_CallEquals_46DLRq__QwpwCx8Uf20Cl7AType(System.IntPtr a, System.IntPtr b);
        private static unsafe readonly System_String_CallEquals_46DLRq__QwpwCx8Uf20Cl7AType System_String_CallEquals_46DLRq__QwpwCx8Uf20Cl7ADelegate = new System_String_CallEquals_46DLRq__QwpwCx8Uf20Cl7AType(System_String_CallEquals_46DLRq__QwpwCx8Uf20Cl7A);
        [AOT.MonoPInvokeCallback(typeof(System_String_CallEquals_46DLRq__QwpwCx8Uf20Cl7AType))]
        private static unsafe byte System_String_CallEquals_46DLRq__QwpwCx8Uf20Cl7A(System.IntPtr a, System.IntPtr b)
        {
            
            var result = string.Equals((string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(a)!, (string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(b)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte System_String_CallIsNullOrEmpty_ZOWEGUlscki07yVzH4i4wwType(System.IntPtr value);
        private static unsafe readonly System_String_CallIsNullOrEmpty_ZOWEGUlscki07yVzH4i4wwType System_String_CallIsNullOrEmpty_ZOWEGUlscki07yVzH4i4wwDelegate = new System_String_CallIsNullOrEmpty_ZOWEGUlscki07yVzH4i4wwType(System_String_CallIsNullOrEmpty_ZOWEGUlscki07yVzH4i4ww);
        [AOT.MonoPInvokeCallback(typeof(System_String_CallIsNullOrEmpty_ZOWEGUlscki07yVzH4i4wwType))]
        private static unsafe byte System_String_CallIsNullOrEmpty_ZOWEGUlscki07yVzH4i4ww(System.IntPtr value)
        {
            
            var result = string.IsNullOrEmpty((string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(value)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte System_String_Callop_Equality_46DLRq__QwpwCx8Uf20Cl7AType(System.IntPtr a, System.IntPtr b);
        private static unsafe readonly System_String_Callop_Equality_46DLRq__QwpwCx8Uf20Cl7AType System_String_Callop_Equality_46DLRq__QwpwCx8Uf20Cl7ADelegate = new System_String_Callop_Equality_46DLRq__QwpwCx8Uf20Cl7AType(System_String_Callop_Equality_46DLRq__QwpwCx8Uf20Cl7A);
        [AOT.MonoPInvokeCallback(typeof(System_String_Callop_Equality_46DLRq__QwpwCx8Uf20Cl7AType))]
        private static unsafe byte System_String_Callop_Equality_46DLRq__QwpwCx8Uf20Cl7A(System.IntPtr a, System.IntPtr b)
        {
            
            var result = ((string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(a)!) == ((string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(b)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte System_String_Callop_Inequality_46DLRq__QwpwCx8Uf20Cl7AType(System.IntPtr a, System.IntPtr b);
        private static unsafe readonly System_String_Callop_Inequality_46DLRq__QwpwCx8Uf20Cl7AType System_String_Callop_Inequality_46DLRq__QwpwCx8Uf20Cl7ADelegate = new System_String_Callop_Inequality_46DLRq__QwpwCx8Uf20Cl7AType(System_String_Callop_Inequality_46DLRq__QwpwCx8Uf20Cl7A);
        [AOT.MonoPInvokeCallback(typeof(System_String_Callop_Inequality_46DLRq__QwpwCx8Uf20Cl7AType))]
        private static unsafe byte System_String_Callop_Inequality_46DLRq__QwpwCx8Uf20Cl7A(System.IntPtr a, System.IntPtr b)
        {
            
            var result = ((string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(a)!) != ((string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(b)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate int System_String_Property_get_LengthType(System.IntPtr thiz);
        private static unsafe readonly System_String_Property_get_LengthType System_String_Property_get_LengthDelegate = new System_String_Property_get_LengthType(System_String_Property_get_Length);
        [AOT.MonoPInvokeCallback(typeof(System_String_Property_get_LengthType))]
        private static unsafe int System_String_Property_get_Length(System.IntPtr thiz)
        {
            
            var result = ((string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).Length;
            
            return result;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr System_Text_Encoding_CallGetString_J_gIxYGOW0ecDuybXJZsCwType(System.IntPtr thiz, byte* bytes, int byteCount);
        private static unsafe readonly System_Text_Encoding_CallGetString_J_gIxYGOW0ecDuybXJZsCwType System_Text_Encoding_CallGetString_J_gIxYGOW0ecDuybXJZsCwDelegate = new System_Text_Encoding_CallGetString_J_gIxYGOW0ecDuybXJZsCwType(System_Text_Encoding_CallGetString_J_gIxYGOW0ecDuybXJZsCw);
        [AOT.MonoPInvokeCallback(typeof(System_Text_Encoding_CallGetString_J_gIxYGOW0ecDuybXJZsCwType))]
        private static unsafe System.IntPtr System_Text_Encoding_CallGetString_J_gIxYGOW0ecDuybXJZsCw(System.IntPtr thiz, byte* bytes, int byteCount)
        {
            
            var result = ((System.Text.Encoding)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).GetString(bytes, byteCount);
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr System_Text_Encoding_Property_get_UTF8Type();
        private static unsafe readonly System_Text_Encoding_Property_get_UTF8Type System_Text_Encoding_Property_get_UTF8Delegate = new System_Text_Encoding_Property_get_UTF8Type(System_Text_Encoding_Property_get_UTF8);
        [AOT.MonoPInvokeCallback(typeof(System_Text_Encoding_Property_get_UTF8Type))]
        private static unsafe System.IntPtr System_Text_Encoding_Property_get_UTF8()
        {
            
            var result = System.Text.Encoding.UTF8;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr System_Threading_Tasks_Task_CallRun_uG3jiSYLEmrwe0pJoPtxoAType(System.IntPtr action);
        private static unsafe readonly System_Threading_Tasks_Task_CallRun_uG3jiSYLEmrwe0pJoPtxoAType System_Threading_Tasks_Task_CallRun_uG3jiSYLEmrwe0pJoPtxoADelegate = new System_Threading_Tasks_Task_CallRun_uG3jiSYLEmrwe0pJoPtxoAType(System_Threading_Tasks_Task_CallRun_uG3jiSYLEmrwe0pJoPtxoA);
        [AOT.MonoPInvokeCallback(typeof(System_Threading_Tasks_Task_CallRun_uG3jiSYLEmrwe0pJoPtxoAType))]
        private static unsafe System.IntPtr System_Threading_Tasks_Task_CallRun_uG3jiSYLEmrwe0pJoPtxoA(System.IntPtr action)
        {
            
            var result = System.Threading.Tasks.Task.Run((System.Action)Reinterop.ObjectHandleUtility.GetObjectFromHandle(action)!);
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void* Unity_Collections_LowLevel_Unsafe_NativeArrayUnsafeUtility_CallGetUnsafeBufferPointerWithoutChecks_QIjAavb5O6M1Tim2Rs2ohQType(System.IntPtr nativeArray);
        private static unsafe readonly Unity_Collections_LowLevel_Unsafe_NativeArrayUnsafeUtility_CallGetUnsafeBufferPointerWithoutChecks_QIjAavb5O6M1Tim2Rs2ohQType Unity_Collections_LowLevel_Unsafe_NativeArrayUnsafeUtility_CallGetUnsafeBufferPointerWithoutChecks_QIjAavb5O6M1Tim2Rs2ohQDelegate = new Unity_Collections_LowLevel_Unsafe_NativeArrayUnsafeUtility_CallGetUnsafeBufferPointerWithoutChecks_QIjAavb5O6M1Tim2Rs2ohQType(Unity_Collections_LowLevel_Unsafe_NativeArrayUnsafeUtility_CallGetUnsafeBufferPointerWithoutChecks_QIjAavb5O6M1Tim2Rs2ohQ);
        [AOT.MonoPInvokeCallback(typeof(Unity_Collections_LowLevel_Unsafe_NativeArrayUnsafeUtility_CallGetUnsafeBufferPointerWithoutChecks_QIjAavb5O6M1Tim2Rs2ohQType))]
        private static unsafe void* Unity_Collections_LowLevel_Unsafe_NativeArrayUnsafeUtility_CallGetUnsafeBufferPointerWithoutChecks_QIjAavb5O6M1Tim2Rs2ohQ(System.IntPtr nativeArray)
        {
            
            var result = Unity.Collections.LowLevel.Unsafe.NativeArrayUnsafeUtility.GetUnsafeBufferPointerWithoutChecks<byte>((Unity.Collections.NativeArray<byte>)Reinterop.ObjectHandleUtility.GetObjectFromHandle(nativeArray)!);
            
            return result;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte Unity_Collections_NativeArrayz79ECk55IqLfMIqXBYg_8w_Callop_Equality___ZFbUbDYmnqRGnwegIjKPwType(System.IntPtr left, System.IntPtr right);
        private static unsafe readonly Unity_Collections_NativeArrayz79ECk55IqLfMIqXBYg_8w_Callop_Equality___ZFbUbDYmnqRGnwegIjKPwType Unity_Collections_NativeArrayz79ECk55IqLfMIqXBYg_8w_Callop_Equality___ZFbUbDYmnqRGnwegIjKPwDelegate = new Unity_Collections_NativeArrayz79ECk55IqLfMIqXBYg_8w_Callop_Equality___ZFbUbDYmnqRGnwegIjKPwType(Unity_Collections_NativeArrayz79ECk55IqLfMIqXBYg_8w_Callop_Equality___ZFbUbDYmnqRGnwegIjKPw);
        [AOT.MonoPInvokeCallback(typeof(Unity_Collections_NativeArrayz79ECk55IqLfMIqXBYg_8w_Callop_Equality___ZFbUbDYmnqRGnwegIjKPwType))]
        private static unsafe byte Unity_Collections_NativeArrayz79ECk55IqLfMIqXBYg_8w_Callop_Equality___ZFbUbDYmnqRGnwegIjKPw(System.IntPtr left, System.IntPtr right)
        {
            
            var result = ((Unity.Collections.NativeArray<byte>)Reinterop.ObjectHandleUtility.GetObjectFromHandle(left)!) == ((Unity.Collections.NativeArray<byte>)Reinterop.ObjectHandleUtility.GetObjectFromHandle(right)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte Unity_Collections_NativeArrayz79ECk55IqLfMIqXBYg_8w_Callop_Inequality___ZFbUbDYmnqRGnwegIjKPwType(System.IntPtr left, System.IntPtr right);
        private static unsafe readonly Unity_Collections_NativeArrayz79ECk55IqLfMIqXBYg_8w_Callop_Inequality___ZFbUbDYmnqRGnwegIjKPwType Unity_Collections_NativeArrayz79ECk55IqLfMIqXBYg_8w_Callop_Inequality___ZFbUbDYmnqRGnwegIjKPwDelegate = new Unity_Collections_NativeArrayz79ECk55IqLfMIqXBYg_8w_Callop_Inequality___ZFbUbDYmnqRGnwegIjKPwType(Unity_Collections_NativeArrayz79ECk55IqLfMIqXBYg_8w_Callop_Inequality___ZFbUbDYmnqRGnwegIjKPw);
        [AOT.MonoPInvokeCallback(typeof(Unity_Collections_NativeArrayz79ECk55IqLfMIqXBYg_8w_Callop_Inequality___ZFbUbDYmnqRGnwegIjKPwType))]
        private static unsafe byte Unity_Collections_NativeArrayz79ECk55IqLfMIqXBYg_8w_Callop_Inequality___ZFbUbDYmnqRGnwegIjKPw(System.IntPtr left, System.IntPtr right)
        {
            
            var result = ((Unity.Collections.NativeArray<byte>)Reinterop.ObjectHandleUtility.GetObjectFromHandle(left)!) != ((Unity.Collections.NativeArray<byte>)Reinterop.ObjectHandleUtility.GetObjectFromHandle(right)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr Unity_Collections_NativeArrayz79ECk55IqLfMIqXBYg_8w_Construct_fyLz0cEPCtnsPNSt__omZwQType(int length, Unity.Collections.Allocator allocator, Unity.Collections.NativeArrayOptions options);
        private static unsafe readonly Unity_Collections_NativeArrayz79ECk55IqLfMIqXBYg_8w_Construct_fyLz0cEPCtnsPNSt__omZwQType Unity_Collections_NativeArrayz79ECk55IqLfMIqXBYg_8w_Construct_fyLz0cEPCtnsPNSt__omZwQDelegate = new Unity_Collections_NativeArrayz79ECk55IqLfMIqXBYg_8w_Construct_fyLz0cEPCtnsPNSt__omZwQType(Unity_Collections_NativeArrayz79ECk55IqLfMIqXBYg_8w_Construct_fyLz0cEPCtnsPNSt__omZwQ);
        [AOT.MonoPInvokeCallback(typeof(Unity_Collections_NativeArrayz79ECk55IqLfMIqXBYg_8w_Construct_fyLz0cEPCtnsPNSt__omZwQType))]
        private static unsafe System.IntPtr Unity_Collections_NativeArrayz79ECk55IqLfMIqXBYg_8w_Construct_fyLz0cEPCtnsPNSt__omZwQ(int length, Unity.Collections.Allocator allocator, Unity.Collections.NativeArrayOptions options)
        {
            
            var result = new Unity.Collections.NativeArray<byte>(length, allocator, options);
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte UnityEditor_EditorApplication_CallExecuteMenuItem__mTAWffFaNJNxtE3VLYhxwType(System.IntPtr menuItemPath);
        private static unsafe readonly UnityEditor_EditorApplication_CallExecuteMenuItem__mTAWffFaNJNxtE3VLYhxwType UnityEditor_EditorApplication_CallExecuteMenuItem__mTAWffFaNJNxtE3VLYhxwDelegate = new UnityEditor_EditorApplication_CallExecuteMenuItem__mTAWffFaNJNxtE3VLYhxwType(UnityEditor_EditorApplication_CallExecuteMenuItem__mTAWffFaNJNxtE3VLYhxw);
        [AOT.MonoPInvokeCallback(typeof(UnityEditor_EditorApplication_CallExecuteMenuItem__mTAWffFaNJNxtE3VLYhxwType))]
        private static unsafe byte UnityEditor_EditorApplication_CallExecuteMenuItem__mTAWffFaNJNxtE3VLYhxw(System.IntPtr menuItemPath)
        {
            
            var result = UnityEditor.EditorApplication.ExecuteMenuItem((string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(menuItemPath)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void UnityEditor_EditorPrefs_CallDeleteKey_4Oa4KGDR__vvaosUsC29xLgType(System.IntPtr key);
        private static unsafe readonly UnityEditor_EditorPrefs_CallDeleteKey_4Oa4KGDR__vvaosUsC29xLgType UnityEditor_EditorPrefs_CallDeleteKey_4Oa4KGDR__vvaosUsC29xLgDelegate = new UnityEditor_EditorPrefs_CallDeleteKey_4Oa4KGDR__vvaosUsC29xLgType(UnityEditor_EditorPrefs_CallDeleteKey_4Oa4KGDR__vvaosUsC29xLg);
        [AOT.MonoPInvokeCallback(typeof(UnityEditor_EditorPrefs_CallDeleteKey_4Oa4KGDR__vvaosUsC29xLgType))]
        private static unsafe void UnityEditor_EditorPrefs_CallDeleteKey_4Oa4KGDR__vvaosUsC29xLg(System.IntPtr key)
        {
            UnityEditor.EditorPrefs.DeleteKey((string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(key)!);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr UnityEditor_EditorPrefs_CallGetString_4Oa4KGDR__vvaosUsC29xLgType(System.IntPtr key);
        private static unsafe readonly UnityEditor_EditorPrefs_CallGetString_4Oa4KGDR__vvaosUsC29xLgType UnityEditor_EditorPrefs_CallGetString_4Oa4KGDR__vvaosUsC29xLgDelegate = new UnityEditor_EditorPrefs_CallGetString_4Oa4KGDR__vvaosUsC29xLgType(UnityEditor_EditorPrefs_CallGetString_4Oa4KGDR__vvaosUsC29xLg);
        [AOT.MonoPInvokeCallback(typeof(UnityEditor_EditorPrefs_CallGetString_4Oa4KGDR__vvaosUsC29xLgType))]
        private static unsafe System.IntPtr UnityEditor_EditorPrefs_CallGetString_4Oa4KGDR__vvaosUsC29xLg(System.IntPtr key)
        {
            
            var result = UnityEditor.EditorPrefs.GetString((string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(key)!);
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte UnityEditor_EditorPrefs_CallHasKey_4Oa4KGDR__vvaosUsC29xLgType(System.IntPtr key);
        private static unsafe readonly UnityEditor_EditorPrefs_CallHasKey_4Oa4KGDR__vvaosUsC29xLgType UnityEditor_EditorPrefs_CallHasKey_4Oa4KGDR__vvaosUsC29xLgDelegate = new UnityEditor_EditorPrefs_CallHasKey_4Oa4KGDR__vvaosUsC29xLgType(UnityEditor_EditorPrefs_CallHasKey_4Oa4KGDR__vvaosUsC29xLg);
        [AOT.MonoPInvokeCallback(typeof(UnityEditor_EditorPrefs_CallHasKey_4Oa4KGDR__vvaosUsC29xLgType))]
        private static unsafe byte UnityEditor_EditorPrefs_CallHasKey_4Oa4KGDR__vvaosUsC29xLg(System.IntPtr key)
        {
            
            var result = UnityEditor.EditorPrefs.HasKey((string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(key)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void UnityEditor_EditorPrefs_CallSetString_eMSjpsyKrCDpoy__674QaewType(System.IntPtr key, System.IntPtr value);
        private static unsafe readonly UnityEditor_EditorPrefs_CallSetString_eMSjpsyKrCDpoy__674QaewType UnityEditor_EditorPrefs_CallSetString_eMSjpsyKrCDpoy__674QaewDelegate = new UnityEditor_EditorPrefs_CallSetString_eMSjpsyKrCDpoy__674QaewType(UnityEditor_EditorPrefs_CallSetString_eMSjpsyKrCDpoy__674Qaew);
        [AOT.MonoPInvokeCallback(typeof(UnityEditor_EditorPrefs_CallSetString_eMSjpsyKrCDpoy__674QaewType))]
        private static unsafe void UnityEditor_EditorPrefs_CallSetString_eMSjpsyKrCDpoy__674Qaew(System.IntPtr key, System.IntPtr value)
        {
            UnityEditor.EditorPrefs.SetString((string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(key)!, (string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(value)!);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void UnityEditor_EditorWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfgType(System.IntPtr thiz);
        private static unsafe readonly UnityEditor_EditorWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfgType UnityEditor_EditorWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new UnityEditor_EditorWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfgType(UnityEditor_EditorWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(UnityEditor_EditorWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe void UnityEditor_EditorWindow_CallClose_1B2M2Y8AsgTpgAmY7PhCfg(System.IntPtr thiz)
        {
            ((UnityEditor.EditorWindow)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).Close();
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte UnityEditor_EditorWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType(System.IntPtr x, System.IntPtr y);
        private static unsafe readonly UnityEditor_EditorWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType UnityEditor_EditorWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgDelegate = new UnityEditor_EditorWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType(UnityEditor_EditorWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2Wg);
        [AOT.MonoPInvokeCallback(typeof(UnityEditor_EditorWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType))]
        private static unsafe byte UnityEditor_EditorWindow_Callop_Equality_5bi2N6jTkaYVhpHPRxL2Wg(System.IntPtr x, System.IntPtr y)
        {
            
            var result = ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(x)!) == ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(y)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte UnityEditor_EditorWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType(System.IntPtr x, System.IntPtr y);
        private static unsafe readonly UnityEditor_EditorWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType UnityEditor_EditorWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgDelegate = new UnityEditor_EditorWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType(UnityEditor_EditorWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2Wg);
        [AOT.MonoPInvokeCallback(typeof(UnityEditor_EditorWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType))]
        private static unsafe byte UnityEditor_EditorWindow_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2Wg(System.IntPtr x, System.IntPtr y)
        {
            
            var result = ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(x)!) != ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(y)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte UnityEditor_IMGUI_Controls_MultiColumnHeader_CallIsSortedAscending_ZiJhFqE0LPDoV__RgQlNVpQType(System.IntPtr thiz, int columnIndex);
        private static unsafe readonly UnityEditor_IMGUI_Controls_MultiColumnHeader_CallIsSortedAscending_ZiJhFqE0LPDoV__RgQlNVpQType UnityEditor_IMGUI_Controls_MultiColumnHeader_CallIsSortedAscending_ZiJhFqE0LPDoV__RgQlNVpQDelegate = new UnityEditor_IMGUI_Controls_MultiColumnHeader_CallIsSortedAscending_ZiJhFqE0LPDoV__RgQlNVpQType(UnityEditor_IMGUI_Controls_MultiColumnHeader_CallIsSortedAscending_ZiJhFqE0LPDoV__RgQlNVpQ);
        [AOT.MonoPInvokeCallback(typeof(UnityEditor_IMGUI_Controls_MultiColumnHeader_CallIsSortedAscending_ZiJhFqE0LPDoV__RgQlNVpQType))]
        private static unsafe byte UnityEditor_IMGUI_Controls_MultiColumnHeader_CallIsSortedAscending_ZiJhFqE0LPDoV__RgQlNVpQ(System.IntPtr thiz, int columnIndex)
        {
            
            var result = ((UnityEditor.IMGUI.Controls.MultiColumnHeader)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).IsSortedAscending(columnIndex);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate int UnityEditor_IMGUI_Controls_MultiColumnHeader_Property_get_sortedColumnIndexType(System.IntPtr thiz);
        private static unsafe readonly UnityEditor_IMGUI_Controls_MultiColumnHeader_Property_get_sortedColumnIndexType UnityEditor_IMGUI_Controls_MultiColumnHeader_Property_get_sortedColumnIndexDelegate = new UnityEditor_IMGUI_Controls_MultiColumnHeader_Property_get_sortedColumnIndexType(UnityEditor_IMGUI_Controls_MultiColumnHeader_Property_get_sortedColumnIndex);
        [AOT.MonoPInvokeCallback(typeof(UnityEditor_IMGUI_Controls_MultiColumnHeader_Property_get_sortedColumnIndexType))]
        private static unsafe int UnityEditor_IMGUI_Controls_MultiColumnHeader_Property_get_sortedColumnIndex(System.IntPtr thiz)
        {
            
            var result = ((UnityEditor.IMGUI.Controls.MultiColumnHeader)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).sortedColumnIndex;
            
            return result;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void UnityEditor_IMGUI_Controls_MultiColumnHeader_Property_set_sortedColumnIndexType(System.IntPtr thiz, int value);
        private static unsafe readonly UnityEditor_IMGUI_Controls_MultiColumnHeader_Property_set_sortedColumnIndexType UnityEditor_IMGUI_Controls_MultiColumnHeader_Property_set_sortedColumnIndexDelegate = new UnityEditor_IMGUI_Controls_MultiColumnHeader_Property_set_sortedColumnIndexType(UnityEditor_IMGUI_Controls_MultiColumnHeader_Property_set_sortedColumnIndex);
        [AOT.MonoPInvokeCallback(typeof(UnityEditor_IMGUI_Controls_MultiColumnHeader_Property_set_sortedColumnIndexType))]
        private static unsafe void UnityEditor_IMGUI_Controls_MultiColumnHeader_Property_set_sortedColumnIndex(System.IntPtr thiz, int value)
        {
            ((UnityEditor.IMGUI.Controls.MultiColumnHeader)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).sortedColumnIndex = value;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void UnityEditor_IMGUI_Controls_TreeView_CallReload_1B2M2Y8AsgTpgAmY7PhCfgType(System.IntPtr thiz);
        private static unsafe readonly UnityEditor_IMGUI_Controls_TreeView_CallReload_1B2M2Y8AsgTpgAmY7PhCfgType UnityEditor_IMGUI_Controls_TreeView_CallReload_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new UnityEditor_IMGUI_Controls_TreeView_CallReload_1B2M2Y8AsgTpgAmY7PhCfgType(UnityEditor_IMGUI_Controls_TreeView_CallReload_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(UnityEditor_IMGUI_Controls_TreeView_CallReload_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe void UnityEditor_IMGUI_Controls_TreeView_CallReload_1B2M2Y8AsgTpgAmY7PhCfg(System.IntPtr thiz)
        {
            ((UnityEditor.IMGUI.Controls.TreeView)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).Reload();
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr UnityEditor_IMGUI_Controls_TreeView_Property_get_multiColumnHeaderType(System.IntPtr thiz);
        private static unsafe readonly UnityEditor_IMGUI_Controls_TreeView_Property_get_multiColumnHeaderType UnityEditor_IMGUI_Controls_TreeView_Property_get_multiColumnHeaderDelegate = new UnityEditor_IMGUI_Controls_TreeView_Property_get_multiColumnHeaderType(UnityEditor_IMGUI_Controls_TreeView_Property_get_multiColumnHeader);
        [AOT.MonoPInvokeCallback(typeof(UnityEditor_IMGUI_Controls_TreeView_Property_get_multiColumnHeaderType))]
        private static unsafe System.IntPtr UnityEditor_IMGUI_Controls_TreeView_Property_get_multiColumnHeader(System.IntPtr thiz)
        {
            
            var result = ((UnityEditor.IMGUI.Controls.TreeView)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).multiColumnHeader;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr UnityEditor_IMGUI_Controls_TreeView_Property_get_searchStringType(System.IntPtr thiz);
        private static unsafe readonly UnityEditor_IMGUI_Controls_TreeView_Property_get_searchStringType UnityEditor_IMGUI_Controls_TreeView_Property_get_searchStringDelegate = new UnityEditor_IMGUI_Controls_TreeView_Property_get_searchStringType(UnityEditor_IMGUI_Controls_TreeView_Property_get_searchString);
        [AOT.MonoPInvokeCallback(typeof(UnityEditor_IMGUI_Controls_TreeView_Property_get_searchStringType))]
        private static unsafe System.IntPtr UnityEditor_IMGUI_Controls_TreeView_Property_get_searchString(System.IntPtr thiz)
        {
            
            var result = ((UnityEditor.IMGUI.Controls.TreeView)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).searchString;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void UnityEditor_IMGUI_Controls_TreeView_Property_set_multiColumnHeaderType(System.IntPtr thiz, System.IntPtr value);
        private static unsafe readonly UnityEditor_IMGUI_Controls_TreeView_Property_set_multiColumnHeaderType UnityEditor_IMGUI_Controls_TreeView_Property_set_multiColumnHeaderDelegate = new UnityEditor_IMGUI_Controls_TreeView_Property_set_multiColumnHeaderType(UnityEditor_IMGUI_Controls_TreeView_Property_set_multiColumnHeader);
        [AOT.MonoPInvokeCallback(typeof(UnityEditor_IMGUI_Controls_TreeView_Property_set_multiColumnHeaderType))]
        private static unsafe void UnityEditor_IMGUI_Controls_TreeView_Property_set_multiColumnHeader(System.IntPtr thiz, System.IntPtr value)
        {
            ((UnityEditor.IMGUI.Controls.TreeView)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).multiColumnHeader = (UnityEditor.IMGUI.Controls.MultiColumnHeader)Reinterop.ObjectHandleUtility.GetObjectFromHandle(value)!;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void UnityEditor_IMGUI_Controls_TreeView_Property_set_searchStringType(System.IntPtr thiz, System.IntPtr value);
        private static unsafe readonly UnityEditor_IMGUI_Controls_TreeView_Property_set_searchStringType UnityEditor_IMGUI_Controls_TreeView_Property_set_searchStringDelegate = new UnityEditor_IMGUI_Controls_TreeView_Property_set_searchStringType(UnityEditor_IMGUI_Controls_TreeView_Property_set_searchString);
        [AOT.MonoPInvokeCallback(typeof(UnityEditor_IMGUI_Controls_TreeView_Property_set_searchStringType))]
        private static unsafe void UnityEditor_IMGUI_Controls_TreeView_Property_set_searchString(System.IntPtr thiz, System.IntPtr value)
        {
            ((UnityEditor.IMGUI.Controls.TreeView)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).searchString = (string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(value)!;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr UnityEditor_IMGUI_Controls_TreeViewItem_Construct_fAkE2H7EjTzReHiM2XHBPAType(int id, int depth, System.IntPtr displayName);
        private static unsafe readonly UnityEditor_IMGUI_Controls_TreeViewItem_Construct_fAkE2H7EjTzReHiM2XHBPAType UnityEditor_IMGUI_Controls_TreeViewItem_Construct_fAkE2H7EjTzReHiM2XHBPADelegate = new UnityEditor_IMGUI_Controls_TreeViewItem_Construct_fAkE2H7EjTzReHiM2XHBPAType(UnityEditor_IMGUI_Controls_TreeViewItem_Construct_fAkE2H7EjTzReHiM2XHBPA);
        [AOT.MonoPInvokeCallback(typeof(UnityEditor_IMGUI_Controls_TreeViewItem_Construct_fAkE2H7EjTzReHiM2XHBPAType))]
        private static unsafe System.IntPtr UnityEditor_IMGUI_Controls_TreeViewItem_Construct_fAkE2H7EjTzReHiM2XHBPA(int id, int depth, System.IntPtr displayName)
        {
            
            var result = new UnityEditor.IMGUI.Controls.TreeViewItem(id, depth, (string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(displayName)!);
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate int UnityEditor_IMGUI_Controls_TreeViewItem_Property_get_idType(System.IntPtr thiz);
        private static unsafe readonly UnityEditor_IMGUI_Controls_TreeViewItem_Property_get_idType UnityEditor_IMGUI_Controls_TreeViewItem_Property_get_idDelegate = new UnityEditor_IMGUI_Controls_TreeViewItem_Property_get_idType(UnityEditor_IMGUI_Controls_TreeViewItem_Property_get_id);
        [AOT.MonoPInvokeCallback(typeof(UnityEditor_IMGUI_Controls_TreeViewItem_Property_get_idType))]
        private static unsafe int UnityEditor_IMGUI_Controls_TreeViewItem_Property_get_id(System.IntPtr thiz)
        {
            
            var result = ((UnityEditor.IMGUI.Controls.TreeViewItem)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).id;
            
            return result;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void UnityEditor_IMGUI_Controls_TreeViewItem_Property_set_idType(System.IntPtr thiz, int value);
        private static unsafe readonly UnityEditor_IMGUI_Controls_TreeViewItem_Property_set_idType UnityEditor_IMGUI_Controls_TreeViewItem_Property_set_idDelegate = new UnityEditor_IMGUI_Controls_TreeViewItem_Property_set_idType(UnityEditor_IMGUI_Controls_TreeViewItem_Property_set_id);
        [AOT.MonoPInvokeCallback(typeof(UnityEditor_IMGUI_Controls_TreeViewItem_Property_set_idType))]
        private static unsafe void UnityEditor_IMGUI_Controls_TreeViewItem_Property_set_id(System.IntPtr thiz, int value)
        {
            ((UnityEditor.IMGUI.Controls.TreeViewItem)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).id = value;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr UnityEditor_IMGUI_Controls_TreeViewState_Construct_1B2M2Y8AsgTpgAmY7PhCfgType();
        private static unsafe readonly UnityEditor_IMGUI_Controls_TreeViewState_Construct_1B2M2Y8AsgTpgAmY7PhCfgType UnityEditor_IMGUI_Controls_TreeViewState_Construct_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new UnityEditor_IMGUI_Controls_TreeViewState_Construct_1B2M2Y8AsgTpgAmY7PhCfgType(UnityEditor_IMGUI_Controls_TreeViewState_Construct_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(UnityEditor_IMGUI_Controls_TreeViewState_Construct_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe System.IntPtr UnityEditor_IMGUI_Controls_TreeViewState_Construct_1B2M2Y8AsgTpgAmY7PhCfg()
        {
            
            var result = new UnityEditor.IMGUI.Controls.TreeViewState();
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr UnityEditor_Selection_Property_get_activeGameObjectType();
        private static unsafe readonly UnityEditor_Selection_Property_get_activeGameObjectType UnityEditor_Selection_Property_get_activeGameObjectDelegate = new UnityEditor_Selection_Property_get_activeGameObjectType(UnityEditor_Selection_Property_get_activeGameObject);
        [AOT.MonoPInvokeCallback(typeof(UnityEditor_Selection_Property_get_activeGameObjectType))]
        private static unsafe System.IntPtr UnityEditor_Selection_Property_get_activeGameObject()
        {
            
            var result = UnityEditor.Selection.activeGameObject;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void UnityEditor_Selection_Property_set_activeGameObjectType(System.IntPtr value);
        private static unsafe readonly UnityEditor_Selection_Property_set_activeGameObjectType UnityEditor_Selection_Property_set_activeGameObjectDelegate = new UnityEditor_Selection_Property_set_activeGameObjectType(UnityEditor_Selection_Property_set_activeGameObject);
        [AOT.MonoPInvokeCallback(typeof(UnityEditor_Selection_Property_set_activeGameObjectType))]
        private static unsafe void UnityEditor_Selection_Property_set_activeGameObject(System.IntPtr value)
        {
            UnityEditor.Selection.activeGameObject = (UnityEngine.GameObject)Reinterop.ObjectHandleUtility.GetObjectFromHandle(value)!;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void UnityEngine_Application_CallOpenURL_i4__FgVIR5VYHO4KBzPBwNQType(System.IntPtr url);
        private static unsafe readonly UnityEngine_Application_CallOpenURL_i4__FgVIR5VYHO4KBzPBwNQType UnityEngine_Application_CallOpenURL_i4__FgVIR5VYHO4KBzPBwNQDelegate = new UnityEngine_Application_CallOpenURL_i4__FgVIR5VYHO4KBzPBwNQType(UnityEngine_Application_CallOpenURL_i4__FgVIR5VYHO4KBzPBwNQ);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Application_CallOpenURL_i4__FgVIR5VYHO4KBzPBwNQType))]
        private static unsafe void UnityEngine_Application_CallOpenURL_i4__FgVIR5VYHO4KBzPBwNQ(System.IntPtr url)
        {
            UnityEngine.Application.OpenURL((string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(url)!);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate UnityEngine.RuntimePlatform UnityEngine_Application_Property_get_platformType();
        private static unsafe readonly UnityEngine_Application_Property_get_platformType UnityEngine_Application_Property_get_platformDelegate = new UnityEngine_Application_Property_get_platformType(UnityEngine_Application_Property_get_platform);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Application_Property_get_platformType))]
        private static unsafe UnityEngine.RuntimePlatform UnityEngine_Application_Property_get_platform()
        {
            
            var result = UnityEngine.Application.platform;
            
            return result;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr UnityEngine_Application_Property_get_productNameType();
        private static unsafe readonly UnityEngine_Application_Property_get_productNameType UnityEngine_Application_Property_get_productNameDelegate = new UnityEngine_Application_Property_get_productNameType(UnityEngine_Application_Property_get_productName);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Application_Property_get_productNameType))]
        private static unsafe System.IntPtr UnityEngine_Application_Property_get_productName()
        {
            
            var result = UnityEngine.Application.productName;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr UnityEngine_Application_Property_get_unityVersionType();
        private static unsafe readonly UnityEngine_Application_Property_get_unityVersionType UnityEngine_Application_Property_get_unityVersionDelegate = new UnityEngine_Application_Property_get_unityVersionType(UnityEngine_Application_Property_get_unityVersion);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Application_Property_get_unityVersionType))]
        private static unsafe System.IntPtr UnityEngine_Application_Property_get_unityVersion()
        {
            
            var result = UnityEngine.Application.unityVersion;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr UnityEngine_Application_Property_get_versionType();
        private static unsafe readonly UnityEngine_Application_Property_get_versionType UnityEngine_Application_Property_get_versionDelegate = new UnityEngine_Application_Property_get_versionType(UnityEngine_Application_Property_get_version);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Application_Property_get_versionType))]
        private static unsafe System.IntPtr UnityEngine_Application_Property_get_version()
        {
            
            var result = UnityEngine.Application.version;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void UnityEngine_AsyncOperation_Calladd_completed_89b__Riirtgd1Q5mmRzPojAType(System.IntPtr thiz, System.IntPtr value);
        private static unsafe readonly UnityEngine_AsyncOperation_Calladd_completed_89b__Riirtgd1Q5mmRzPojAType UnityEngine_AsyncOperation_Calladd_completed_89b__Riirtgd1Q5mmRzPojADelegate = new UnityEngine_AsyncOperation_Calladd_completed_89b__Riirtgd1Q5mmRzPojAType(UnityEngine_AsyncOperation_Calladd_completed_89b__Riirtgd1Q5mmRzPojA);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_AsyncOperation_Calladd_completed_89b__Riirtgd1Q5mmRzPojAType))]
        private static unsafe void UnityEngine_AsyncOperation_Calladd_completed_89b__Riirtgd1Q5mmRzPojA(System.IntPtr thiz, System.IntPtr value)
        {
            ((UnityEngine.AsyncOperation)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).completed += (System.Action<UnityEngine.AsyncOperation>)Reinterop.ObjectHandleUtility.GetObjectFromHandle(value)!;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void UnityEngine_AsyncOperation_Callremove_completed_89b__Riirtgd1Q5mmRzPojAType(System.IntPtr thiz, System.IntPtr value);
        private static unsafe readonly UnityEngine_AsyncOperation_Callremove_completed_89b__Riirtgd1Q5mmRzPojAType UnityEngine_AsyncOperation_Callremove_completed_89b__Riirtgd1Q5mmRzPojADelegate = new UnityEngine_AsyncOperation_Callremove_completed_89b__Riirtgd1Q5mmRzPojAType(UnityEngine_AsyncOperation_Callremove_completed_89b__Riirtgd1Q5mmRzPojA);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_AsyncOperation_Callremove_completed_89b__Riirtgd1Q5mmRzPojAType))]
        private static unsafe void UnityEngine_AsyncOperation_Callremove_completed_89b__Riirtgd1Q5mmRzPojA(System.IntPtr thiz, System.IntPtr value)
        {
            ((UnityEngine.AsyncOperation)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).completed -= (System.Action<UnityEngine.AsyncOperation>)Reinterop.ObjectHandleUtility.GetObjectFromHandle(value)!;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte UnityEngine_Component_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType(System.IntPtr x, System.IntPtr y);
        private static unsafe readonly UnityEngine_Component_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType UnityEngine_Component_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgDelegate = new UnityEngine_Component_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType(UnityEngine_Component_Callop_Equality_5bi2N6jTkaYVhpHPRxL2Wg);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Component_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType))]
        private static unsafe byte UnityEngine_Component_Callop_Equality_5bi2N6jTkaYVhpHPRxL2Wg(System.IntPtr x, System.IntPtr y)
        {
            
            var result = ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(x)!) == ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(y)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte UnityEngine_Component_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType(System.IntPtr x, System.IntPtr y);
        private static unsafe readonly UnityEngine_Component_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType UnityEngine_Component_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgDelegate = new UnityEngine_Component_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType(UnityEngine_Component_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2Wg);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Component_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType))]
        private static unsafe byte UnityEngine_Component_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2Wg(System.IntPtr x, System.IntPtr y)
        {
            
            var result = ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(x)!) != ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(y)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr UnityEngine_Component_Property_get_gameObjectType(System.IntPtr thiz);
        private static unsafe readonly UnityEngine_Component_Property_get_gameObjectType UnityEngine_Component_Property_get_gameObjectDelegate = new UnityEngine_Component_Property_get_gameObjectType(UnityEngine_Component_Property_get_gameObject);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Component_Property_get_gameObjectType))]
        private static unsafe System.IntPtr UnityEngine_Component_Property_get_gameObject(System.IntPtr thiz)
        {
            
            var result = ((UnityEngine.Component)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).gameObject;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void UnityEngine_Debug_CallLog_FA05wu8x__otZNsgdHTnU9AType(System.IntPtr message);
        private static unsafe readonly UnityEngine_Debug_CallLog_FA05wu8x__otZNsgdHTnU9AType UnityEngine_Debug_CallLog_FA05wu8x__otZNsgdHTnU9ADelegate = new UnityEngine_Debug_CallLog_FA05wu8x__otZNsgdHTnU9AType(UnityEngine_Debug_CallLog_FA05wu8x__otZNsgdHTnU9A);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Debug_CallLog_FA05wu8x__otZNsgdHTnU9AType))]
        private static unsafe void UnityEngine_Debug_CallLog_FA05wu8x__otZNsgdHTnU9A(System.IntPtr message)
        {
            UnityEngine.Debug.Log((object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(message)!);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void UnityEngine_Debug_CallLogError_FA05wu8x__otZNsgdHTnU9AType(System.IntPtr message);
        private static unsafe readonly UnityEngine_Debug_CallLogError_FA05wu8x__otZNsgdHTnU9AType UnityEngine_Debug_CallLogError_FA05wu8x__otZNsgdHTnU9ADelegate = new UnityEngine_Debug_CallLogError_FA05wu8x__otZNsgdHTnU9AType(UnityEngine_Debug_CallLogError_FA05wu8x__otZNsgdHTnU9A);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Debug_CallLogError_FA05wu8x__otZNsgdHTnU9AType))]
        private static unsafe void UnityEngine_Debug_CallLogError_FA05wu8x__otZNsgdHTnU9A(System.IntPtr message)
        {
            UnityEngine.Debug.LogError((object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(message)!);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void UnityEngine_Debug_CallLogWarning_FA05wu8x__otZNsgdHTnU9AType(System.IntPtr message);
        private static unsafe readonly UnityEngine_Debug_CallLogWarning_FA05wu8x__otZNsgdHTnU9AType UnityEngine_Debug_CallLogWarning_FA05wu8x__otZNsgdHTnU9ADelegate = new UnityEngine_Debug_CallLogWarning_FA05wu8x__otZNsgdHTnU9AType(UnityEngine_Debug_CallLogWarning_FA05wu8x__otZNsgdHTnU9A);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Debug_CallLogWarning_FA05wu8x__otZNsgdHTnU9AType))]
        private static unsafe void UnityEngine_Debug_CallLogWarning_FA05wu8x__otZNsgdHTnU9A(System.IntPtr message)
        {
            UnityEngine.Debug.LogWarning((object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(message)!);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr UnityEngine_GameObject_CallAddComponent_0EgxpGTzCG1YTfWqwgLniwType(System.IntPtr thiz);
        private static unsafe readonly UnityEngine_GameObject_CallAddComponent_0EgxpGTzCG1YTfWqwgLniwType UnityEngine_GameObject_CallAddComponent_0EgxpGTzCG1YTfWqwgLniwDelegate = new UnityEngine_GameObject_CallAddComponent_0EgxpGTzCG1YTfWqwgLniwType(UnityEngine_GameObject_CallAddComponent_0EgxpGTzCG1YTfWqwgLniw);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_GameObject_CallAddComponent_0EgxpGTzCG1YTfWqwgLniwType))]
        private static unsafe System.IntPtr UnityEngine_GameObject_CallAddComponent_0EgxpGTzCG1YTfWqwgLniw(System.IntPtr thiz)
        {
            
            var result = ((UnityEngine.GameObject)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).AddComponent<CesiumForUnity.Cesium3DTileset>();
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr UnityEngine_GameObject_CallAddComponent_BAtcoWNWVoAVplmna6OgsQType(System.IntPtr thiz);
        private static unsafe readonly UnityEngine_GameObject_CallAddComponent_BAtcoWNWVoAVplmna6OgsQType UnityEngine_GameObject_CallAddComponent_BAtcoWNWVoAVplmna6OgsQDelegate = new UnityEngine_GameObject_CallAddComponent_BAtcoWNWVoAVplmna6OgsQType(UnityEngine_GameObject_CallAddComponent_BAtcoWNWVoAVplmna6OgsQ);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_GameObject_CallAddComponent_BAtcoWNWVoAVplmna6OgsQType))]
        private static unsafe System.IntPtr UnityEngine_GameObject_CallAddComponent_BAtcoWNWVoAVplmna6OgsQ(System.IntPtr thiz)
        {
            
            var result = ((UnityEngine.GameObject)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).AddComponent<CesiumForUnity.CesiumIonRasterOverlay>();
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr UnityEngine_GameObject_CallGetComponent_0EgxpGTzCG1YTfWqwgLniwType(System.IntPtr thiz);
        private static unsafe readonly UnityEngine_GameObject_CallGetComponent_0EgxpGTzCG1YTfWqwgLniwType UnityEngine_GameObject_CallGetComponent_0EgxpGTzCG1YTfWqwgLniwDelegate = new UnityEngine_GameObject_CallGetComponent_0EgxpGTzCG1YTfWqwgLniwType(UnityEngine_GameObject_CallGetComponent_0EgxpGTzCG1YTfWqwgLniw);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_GameObject_CallGetComponent_0EgxpGTzCG1YTfWqwgLniwType))]
        private static unsafe System.IntPtr UnityEngine_GameObject_CallGetComponent_0EgxpGTzCG1YTfWqwgLniw(System.IntPtr thiz)
        {
            
            var result = ((UnityEngine.GameObject)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).GetComponent<CesiumForUnity.Cesium3DTileset>();
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr UnityEngine_GameObject_CallGetComponent_BAtcoWNWVoAVplmna6OgsQType(System.IntPtr thiz);
        private static unsafe readonly UnityEngine_GameObject_CallGetComponent_BAtcoWNWVoAVplmna6OgsQType UnityEngine_GameObject_CallGetComponent_BAtcoWNWVoAVplmna6OgsQDelegate = new UnityEngine_GameObject_CallGetComponent_BAtcoWNWVoAVplmna6OgsQType(UnityEngine_GameObject_CallGetComponent_BAtcoWNWVoAVplmna6OgsQ);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_GameObject_CallGetComponent_BAtcoWNWVoAVplmna6OgsQType))]
        private static unsafe System.IntPtr UnityEngine_GameObject_CallGetComponent_BAtcoWNWVoAVplmna6OgsQ(System.IntPtr thiz)
        {
            
            var result = ((UnityEngine.GameObject)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).GetComponent<CesiumForUnity.CesiumIonRasterOverlay>();
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr UnityEngine_GameObject_CallGetComponents_BAtcoWNWVoAVplmna6OgsQType(System.IntPtr thiz);
        private static unsafe readonly UnityEngine_GameObject_CallGetComponents_BAtcoWNWVoAVplmna6OgsQType UnityEngine_GameObject_CallGetComponents_BAtcoWNWVoAVplmna6OgsQDelegate = new UnityEngine_GameObject_CallGetComponents_BAtcoWNWVoAVplmna6OgsQType(UnityEngine_GameObject_CallGetComponents_BAtcoWNWVoAVplmna6OgsQ);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_GameObject_CallGetComponents_BAtcoWNWVoAVplmna6OgsQType))]
        private static unsafe System.IntPtr UnityEngine_GameObject_CallGetComponents_BAtcoWNWVoAVplmna6OgsQ(System.IntPtr thiz)
        {
            
            var result = ((UnityEngine.GameObject)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).GetComponents<CesiumForUnity.CesiumIonRasterOverlay>();
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr UnityEngine_GameObject_CallGetComponents_H1UZCBm__Pf6NnqpE7xQ8NQType(System.IntPtr thiz);
        private static unsafe readonly UnityEngine_GameObject_CallGetComponents_H1UZCBm__Pf6NnqpE7xQ8NQType UnityEngine_GameObject_CallGetComponents_H1UZCBm__Pf6NnqpE7xQ8NQDelegate = new UnityEngine_GameObject_CallGetComponents_H1UZCBm__Pf6NnqpE7xQ8NQType(UnityEngine_GameObject_CallGetComponents_H1UZCBm__Pf6NnqpE7xQ8NQ);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_GameObject_CallGetComponents_H1UZCBm__Pf6NnqpE7xQ8NQType))]
        private static unsafe System.IntPtr UnityEngine_GameObject_CallGetComponents_H1UZCBm__Pf6NnqpE7xQ8NQ(System.IntPtr thiz)
        {
            
            var result = ((UnityEngine.GameObject)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).GetComponents<CesiumForUnity.CesiumRasterOverlay>();
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte UnityEngine_GameObject_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType(System.IntPtr x, System.IntPtr y);
        private static unsafe readonly UnityEngine_GameObject_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType UnityEngine_GameObject_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgDelegate = new UnityEngine_GameObject_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType(UnityEngine_GameObject_Callop_Equality_5bi2N6jTkaYVhpHPRxL2Wg);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_GameObject_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType))]
        private static unsafe byte UnityEngine_GameObject_Callop_Equality_5bi2N6jTkaYVhpHPRxL2Wg(System.IntPtr x, System.IntPtr y)
        {
            
            var result = ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(x)!) == ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(y)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte UnityEngine_GameObject_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType(System.IntPtr x, System.IntPtr y);
        private static unsafe readonly UnityEngine_GameObject_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType UnityEngine_GameObject_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgDelegate = new UnityEngine_GameObject_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType(UnityEngine_GameObject_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2Wg);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_GameObject_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType))]
        private static unsafe byte UnityEngine_GameObject_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2Wg(System.IntPtr x, System.IntPtr y)
        {
            
            var result = ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(x)!) != ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(y)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr UnityEngine_GameObject_Construct_wfPSjxsETIcebv8un8PGZwType(System.IntPtr name);
        private static unsafe readonly UnityEngine_GameObject_Construct_wfPSjxsETIcebv8un8PGZwType UnityEngine_GameObject_Construct_wfPSjxsETIcebv8un8PGZwDelegate = new UnityEngine_GameObject_Construct_wfPSjxsETIcebv8un8PGZwType(UnityEngine_GameObject_Construct_wfPSjxsETIcebv8un8PGZw);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_GameObject_Construct_wfPSjxsETIcebv8un8PGZwType))]
        private static unsafe System.IntPtr UnityEngine_GameObject_Construct_wfPSjxsETIcebv8un8PGZw(System.IntPtr name)
        {
            
            var result = new UnityEngine.GameObject((string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(name)!);
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void UnityEngine_GUI_CallLabel_iRU7t71QqJzkr4BTYehN9AType(UnityEngine.Rect* position, System.IntPtr text);
        private static unsafe readonly UnityEngine_GUI_CallLabel_iRU7t71QqJzkr4BTYehN9AType UnityEngine_GUI_CallLabel_iRU7t71QqJzkr4BTYehN9ADelegate = new UnityEngine_GUI_CallLabel_iRU7t71QqJzkr4BTYehN9AType(UnityEngine_GUI_CallLabel_iRU7t71QqJzkr4BTYehN9A);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_GUI_CallLabel_iRU7t71QqJzkr4BTYehN9AType))]
        private static unsafe void UnityEngine_GUI_CallLabel_iRU7t71QqJzkr4BTYehN9A(UnityEngine.Rect* position, System.IntPtr text)
        {
            UnityEngine.GUI.Label(*position, (string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(text)!);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void UnityEngine_Networking_DownloadHandler_CallDispose_1B2M2Y8AsgTpgAmY7PhCfgType(System.IntPtr thiz);
        private static unsafe readonly UnityEngine_Networking_DownloadHandler_CallDispose_1B2M2Y8AsgTpgAmY7PhCfgType UnityEngine_Networking_DownloadHandler_CallDispose_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new UnityEngine_Networking_DownloadHandler_CallDispose_1B2M2Y8AsgTpgAmY7PhCfgType(UnityEngine_Networking_DownloadHandler_CallDispose_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Networking_DownloadHandler_CallDispose_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe void UnityEngine_Networking_DownloadHandler_CallDispose_1B2M2Y8AsgTpgAmY7PhCfg(System.IntPtr thiz)
        {
            ((UnityEngine.Networking.DownloadHandler)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).Dispose();
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr UnityEngine_Networking_UnityWebRequest_CallGet_Y2__l4HVQ8CbSg4jpXDip9AType(System.IntPtr uri);
        private static unsafe readonly UnityEngine_Networking_UnityWebRequest_CallGet_Y2__l4HVQ8CbSg4jpXDip9AType UnityEngine_Networking_UnityWebRequest_CallGet_Y2__l4HVQ8CbSg4jpXDip9ADelegate = new UnityEngine_Networking_UnityWebRequest_CallGet_Y2__l4HVQ8CbSg4jpXDip9AType(UnityEngine_Networking_UnityWebRequest_CallGet_Y2__l4HVQ8CbSg4jpXDip9A);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Networking_UnityWebRequest_CallGet_Y2__l4HVQ8CbSg4jpXDip9AType))]
        private static unsafe System.IntPtr UnityEngine_Networking_UnityWebRequest_CallGet_Y2__l4HVQ8CbSg4jpXDip9A(System.IntPtr uri)
        {
            
            var result = UnityEngine.Networking.UnityWebRequest.Get((string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(uri)!);
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr UnityEngine_Networking_UnityWebRequest_CallGetResponseHeader_wfPSjxsETIcebv8un8PGZwType(System.IntPtr thiz, System.IntPtr name);
        private static unsafe readonly UnityEngine_Networking_UnityWebRequest_CallGetResponseHeader_wfPSjxsETIcebv8un8PGZwType UnityEngine_Networking_UnityWebRequest_CallGetResponseHeader_wfPSjxsETIcebv8un8PGZwDelegate = new UnityEngine_Networking_UnityWebRequest_CallGetResponseHeader_wfPSjxsETIcebv8un8PGZwType(UnityEngine_Networking_UnityWebRequest_CallGetResponseHeader_wfPSjxsETIcebv8un8PGZw);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Networking_UnityWebRequest_CallGetResponseHeader_wfPSjxsETIcebv8un8PGZwType))]
        private static unsafe System.IntPtr UnityEngine_Networking_UnityWebRequest_CallGetResponseHeader_wfPSjxsETIcebv8un8PGZw(System.IntPtr thiz, System.IntPtr name)
        {
            
            var result = ((UnityEngine.Networking.UnityWebRequest)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).GetResponseHeader((string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(name)!);
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr UnityEngine_Networking_UnityWebRequest_CallGetResponseHeaders_1B2M2Y8AsgTpgAmY7PhCfgType(System.IntPtr thiz);
        private static unsafe readonly UnityEngine_Networking_UnityWebRequest_CallGetResponseHeaders_1B2M2Y8AsgTpgAmY7PhCfgType UnityEngine_Networking_UnityWebRequest_CallGetResponseHeaders_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new UnityEngine_Networking_UnityWebRequest_CallGetResponseHeaders_1B2M2Y8AsgTpgAmY7PhCfgType(UnityEngine_Networking_UnityWebRequest_CallGetResponseHeaders_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Networking_UnityWebRequest_CallGetResponseHeaders_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe System.IntPtr UnityEngine_Networking_UnityWebRequest_CallGetResponseHeaders_1B2M2Y8AsgTpgAmY7PhCfg(System.IntPtr thiz)
        {
            
            var result = ((UnityEngine.Networking.UnityWebRequest)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).GetResponseHeaders();
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr UnityEngine_Networking_UnityWebRequest_CallSendWebRequest_1B2M2Y8AsgTpgAmY7PhCfgType(System.IntPtr thiz);
        private static unsafe readonly UnityEngine_Networking_UnityWebRequest_CallSendWebRequest_1B2M2Y8AsgTpgAmY7PhCfgType UnityEngine_Networking_UnityWebRequest_CallSendWebRequest_1B2M2Y8AsgTpgAmY7PhCfgDelegate = new UnityEngine_Networking_UnityWebRequest_CallSendWebRequest_1B2M2Y8AsgTpgAmY7PhCfgType(UnityEngine_Networking_UnityWebRequest_CallSendWebRequest_1B2M2Y8AsgTpgAmY7PhCfg);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Networking_UnityWebRequest_CallSendWebRequest_1B2M2Y8AsgTpgAmY7PhCfgType))]
        private static unsafe System.IntPtr UnityEngine_Networking_UnityWebRequest_CallSendWebRequest_1B2M2Y8AsgTpgAmY7PhCfg(System.IntPtr thiz)
        {
            
            var result = ((UnityEngine.Networking.UnityWebRequest)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).SendWebRequest();
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void UnityEngine_Networking_UnityWebRequest_CallSetRequestHeader_tEfBle3aSdR47_HxLakNjwType(System.IntPtr thiz, System.IntPtr name, System.IntPtr value);
        private static unsafe readonly UnityEngine_Networking_UnityWebRequest_CallSetRequestHeader_tEfBle3aSdR47_HxLakNjwType UnityEngine_Networking_UnityWebRequest_CallSetRequestHeader_tEfBle3aSdR47_HxLakNjwDelegate = new UnityEngine_Networking_UnityWebRequest_CallSetRequestHeader_tEfBle3aSdR47_HxLakNjwType(UnityEngine_Networking_UnityWebRequest_CallSetRequestHeader_tEfBle3aSdR47_HxLakNjw);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Networking_UnityWebRequest_CallSetRequestHeader_tEfBle3aSdR47_HxLakNjwType))]
        private static unsafe void UnityEngine_Networking_UnityWebRequest_CallSetRequestHeader_tEfBle3aSdR47_HxLakNjw(System.IntPtr thiz, System.IntPtr name, System.IntPtr value)
        {
            ((UnityEngine.Networking.UnityWebRequest)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).SetRequestHeader((string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(name)!, (string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(value)!);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr UnityEngine_Networking_UnityWebRequest_Construct_N5nF6s7__PflIcgtgQgj6DAType(System.IntPtr url, System.IntPtr method, System.IntPtr downloadHandler, System.IntPtr uploadHandler);
        private static unsafe readonly UnityEngine_Networking_UnityWebRequest_Construct_N5nF6s7__PflIcgtgQgj6DAType UnityEngine_Networking_UnityWebRequest_Construct_N5nF6s7__PflIcgtgQgj6DADelegate = new UnityEngine_Networking_UnityWebRequest_Construct_N5nF6s7__PflIcgtgQgj6DAType(UnityEngine_Networking_UnityWebRequest_Construct_N5nF6s7__PflIcgtgQgj6DA);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Networking_UnityWebRequest_Construct_N5nF6s7__PflIcgtgQgj6DAType))]
        private static unsafe System.IntPtr UnityEngine_Networking_UnityWebRequest_Construct_N5nF6s7__PflIcgtgQgj6DA(System.IntPtr url, System.IntPtr method, System.IntPtr downloadHandler, System.IntPtr uploadHandler)
        {
            
            var result = new UnityEngine.Networking.UnityWebRequest((string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(url)!, (string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(method)!, (UnityEngine.Networking.DownloadHandler)Reinterop.ObjectHandleUtility.GetObjectFromHandle(downloadHandler)!, (UnityEngine.Networking.UploadHandler)Reinterop.ObjectHandleUtility.GetObjectFromHandle(uploadHandler)!);
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr UnityEngine_Networking_UnityWebRequest_Property_get_downloadHandlerType(System.IntPtr thiz);
        private static unsafe readonly UnityEngine_Networking_UnityWebRequest_Property_get_downloadHandlerType UnityEngine_Networking_UnityWebRequest_Property_get_downloadHandlerDelegate = new UnityEngine_Networking_UnityWebRequest_Property_get_downloadHandlerType(UnityEngine_Networking_UnityWebRequest_Property_get_downloadHandler);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Networking_UnityWebRequest_Property_get_downloadHandlerType))]
        private static unsafe System.IntPtr UnityEngine_Networking_UnityWebRequest_Property_get_downloadHandler(System.IntPtr thiz)
        {
            
            var result = ((UnityEngine.Networking.UnityWebRequest)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).downloadHandler;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr UnityEngine_Networking_UnityWebRequest_Property_get_errorType(System.IntPtr thiz);
        private static unsafe readonly UnityEngine_Networking_UnityWebRequest_Property_get_errorType UnityEngine_Networking_UnityWebRequest_Property_get_errorDelegate = new UnityEngine_Networking_UnityWebRequest_Property_get_errorType(UnityEngine_Networking_UnityWebRequest_Property_get_error);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Networking_UnityWebRequest_Property_get_errorType))]
        private static unsafe System.IntPtr UnityEngine_Networking_UnityWebRequest_Property_get_error(System.IntPtr thiz)
        {
            
            var result = ((UnityEngine.Networking.UnityWebRequest)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).error;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte UnityEngine_Networking_UnityWebRequest_Property_get_isDoneType(System.IntPtr thiz);
        private static unsafe readonly UnityEngine_Networking_UnityWebRequest_Property_get_isDoneType UnityEngine_Networking_UnityWebRequest_Property_get_isDoneDelegate = new UnityEngine_Networking_UnityWebRequest_Property_get_isDoneType(UnityEngine_Networking_UnityWebRequest_Property_get_isDone);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Networking_UnityWebRequest_Property_get_isDoneType))]
        private static unsafe byte UnityEngine_Networking_UnityWebRequest_Property_get_isDone(System.IntPtr thiz)
        {
            
            var result = ((UnityEngine.Networking.UnityWebRequest)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).isDone;
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr UnityEngine_Networking_UnityWebRequest_Property_get_methodType(System.IntPtr thiz);
        private static unsafe readonly UnityEngine_Networking_UnityWebRequest_Property_get_methodType UnityEngine_Networking_UnityWebRequest_Property_get_methodDelegate = new UnityEngine_Networking_UnityWebRequest_Property_get_methodType(UnityEngine_Networking_UnityWebRequest_Property_get_method);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Networking_UnityWebRequest_Property_get_methodType))]
        private static unsafe System.IntPtr UnityEngine_Networking_UnityWebRequest_Property_get_method(System.IntPtr thiz)
        {
            
            var result = ((UnityEngine.Networking.UnityWebRequest)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).method;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate long UnityEngine_Networking_UnityWebRequest_Property_get_responseCodeType(System.IntPtr thiz);
        private static unsafe readonly UnityEngine_Networking_UnityWebRequest_Property_get_responseCodeType UnityEngine_Networking_UnityWebRequest_Property_get_responseCodeDelegate = new UnityEngine_Networking_UnityWebRequest_Property_get_responseCodeType(UnityEngine_Networking_UnityWebRequest_Property_get_responseCode);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Networking_UnityWebRequest_Property_get_responseCodeType))]
        private static unsafe long UnityEngine_Networking_UnityWebRequest_Property_get_responseCode(System.IntPtr thiz)
        {
            
            var result = ((UnityEngine.Networking.UnityWebRequest)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).responseCode;
            
            return result;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate UnityEngine.Networking.UnityWebRequest.Result UnityEngine_Networking_UnityWebRequest_Property_get_resultType(System.IntPtr thiz);
        private static unsafe readonly UnityEngine_Networking_UnityWebRequest_Property_get_resultType UnityEngine_Networking_UnityWebRequest_Property_get_resultDelegate = new UnityEngine_Networking_UnityWebRequest_Property_get_resultType(UnityEngine_Networking_UnityWebRequest_Property_get_result);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Networking_UnityWebRequest_Property_get_resultType))]
        private static unsafe UnityEngine.Networking.UnityWebRequest.Result UnityEngine_Networking_UnityWebRequest_Property_get_result(System.IntPtr thiz)
        {
            
            var result = ((UnityEngine.Networking.UnityWebRequest)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).result;
            
            return result;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr UnityEngine_Networking_UnityWebRequest_Property_get_urlType(System.IntPtr thiz);
        private static unsafe readonly UnityEngine_Networking_UnityWebRequest_Property_get_urlType UnityEngine_Networking_UnityWebRequest_Property_get_urlDelegate = new UnityEngine_Networking_UnityWebRequest_Property_get_urlType(UnityEngine_Networking_UnityWebRequest_Property_get_url);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Networking_UnityWebRequest_Property_get_urlType))]
        private static unsafe System.IntPtr UnityEngine_Networking_UnityWebRequest_Property_get_url(System.IntPtr thiz)
        {
            
            var result = ((UnityEngine.Networking.UnityWebRequest)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).url;
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void UnityEngine_Networking_UnityWebRequest_Property_set_downloadHandlerType(System.IntPtr thiz, System.IntPtr value);
        private static unsafe readonly UnityEngine_Networking_UnityWebRequest_Property_set_downloadHandlerType UnityEngine_Networking_UnityWebRequest_Property_set_downloadHandlerDelegate = new UnityEngine_Networking_UnityWebRequest_Property_set_downloadHandlerType(UnityEngine_Networking_UnityWebRequest_Property_set_downloadHandler);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Networking_UnityWebRequest_Property_set_downloadHandlerType))]
        private static unsafe void UnityEngine_Networking_UnityWebRequest_Property_set_downloadHandler(System.IntPtr thiz, System.IntPtr value)
        {
            ((UnityEngine.Networking.UnityWebRequest)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).downloadHandler = (UnityEngine.Networking.DownloadHandler)Reinterop.ObjectHandleUtility.GetObjectFromHandle(value)!;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void UnityEngine_Networking_UnityWebRequest_Property_set_methodType(System.IntPtr thiz, System.IntPtr value);
        private static unsafe readonly UnityEngine_Networking_UnityWebRequest_Property_set_methodType UnityEngine_Networking_UnityWebRequest_Property_set_methodDelegate = new UnityEngine_Networking_UnityWebRequest_Property_set_methodType(UnityEngine_Networking_UnityWebRequest_Property_set_method);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Networking_UnityWebRequest_Property_set_methodType))]
        private static unsafe void UnityEngine_Networking_UnityWebRequest_Property_set_method(System.IntPtr thiz, System.IntPtr value)
        {
            ((UnityEngine.Networking.UnityWebRequest)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).method = (string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(value)!;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void UnityEngine_Networking_UnityWebRequest_Property_set_urlType(System.IntPtr thiz, System.IntPtr value);
        private static unsafe readonly UnityEngine_Networking_UnityWebRequest_Property_set_urlType UnityEngine_Networking_UnityWebRequest_Property_set_urlDelegate = new UnityEngine_Networking_UnityWebRequest_Property_set_urlType(UnityEngine_Networking_UnityWebRequest_Property_set_url);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Networking_UnityWebRequest_Property_set_urlType))]
        private static unsafe void UnityEngine_Networking_UnityWebRequest_Property_set_url(System.IntPtr thiz, System.IntPtr value)
        {
            ((UnityEngine.Networking.UnityWebRequest)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).url = (string)Reinterop.ObjectHandleUtility.GetObjectFromHandle(value)!;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void UnityEngine_Networking_UnityWebRequestAsyncOperation_Calladd_completed_89b__Riirtgd1Q5mmRzPojAType(System.IntPtr thiz, System.IntPtr value);
        private static unsafe readonly UnityEngine_Networking_UnityWebRequestAsyncOperation_Calladd_completed_89b__Riirtgd1Q5mmRzPojAType UnityEngine_Networking_UnityWebRequestAsyncOperation_Calladd_completed_89b__Riirtgd1Q5mmRzPojADelegate = new UnityEngine_Networking_UnityWebRequestAsyncOperation_Calladd_completed_89b__Riirtgd1Q5mmRzPojAType(UnityEngine_Networking_UnityWebRequestAsyncOperation_Calladd_completed_89b__Riirtgd1Q5mmRzPojA);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Networking_UnityWebRequestAsyncOperation_Calladd_completed_89b__Riirtgd1Q5mmRzPojAType))]
        private static unsafe void UnityEngine_Networking_UnityWebRequestAsyncOperation_Calladd_completed_89b__Riirtgd1Q5mmRzPojA(System.IntPtr thiz, System.IntPtr value)
        {
            ((UnityEngine.Networking.UnityWebRequestAsyncOperation)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).completed += (System.Action<UnityEngine.AsyncOperation>)Reinterop.ObjectHandleUtility.GetObjectFromHandle(value)!;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void UnityEngine_Networking_UnityWebRequestAsyncOperation_Callremove_completed_89b__Riirtgd1Q5mmRzPojAType(System.IntPtr thiz, System.IntPtr value);
        private static unsafe readonly UnityEngine_Networking_UnityWebRequestAsyncOperation_Callremove_completed_89b__Riirtgd1Q5mmRzPojAType UnityEngine_Networking_UnityWebRequestAsyncOperation_Callremove_completed_89b__Riirtgd1Q5mmRzPojADelegate = new UnityEngine_Networking_UnityWebRequestAsyncOperation_Callremove_completed_89b__Riirtgd1Q5mmRzPojAType(UnityEngine_Networking_UnityWebRequestAsyncOperation_Callremove_completed_89b__Riirtgd1Q5mmRzPojA);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Networking_UnityWebRequestAsyncOperation_Callremove_completed_89b__Riirtgd1Q5mmRzPojAType))]
        private static unsafe void UnityEngine_Networking_UnityWebRequestAsyncOperation_Callremove_completed_89b__Riirtgd1Q5mmRzPojA(System.IntPtr thiz, System.IntPtr value)
        {
            ((UnityEngine.Networking.UnityWebRequestAsyncOperation)Reinterop.ObjectHandleUtility.GetObjectFromHandle(thiz)!).completed -= (System.Action<UnityEngine.AsyncOperation>)Reinterop.ObjectHandleUtility.GetObjectFromHandle(value)!;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr UnityEngine_Networking_UploadHandlerRaw_Construct_j9VUe_obWzqxHm0yKnVCmgType(System.IntPtr data, byte transferOwnership);
        private static unsafe readonly UnityEngine_Networking_UploadHandlerRaw_Construct_j9VUe_obWzqxHm0yKnVCmgType UnityEngine_Networking_UploadHandlerRaw_Construct_j9VUe_obWzqxHm0yKnVCmgDelegate = new UnityEngine_Networking_UploadHandlerRaw_Construct_j9VUe_obWzqxHm0yKnVCmgType(UnityEngine_Networking_UploadHandlerRaw_Construct_j9VUe_obWzqxHm0yKnVCmg);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Networking_UploadHandlerRaw_Construct_j9VUe_obWzqxHm0yKnVCmgType))]
        private static unsafe System.IntPtr UnityEngine_Networking_UploadHandlerRaw_Construct_j9VUe_obWzqxHm0yKnVCmg(System.IntPtr data, byte transferOwnership)
        {
            
            var result = new UnityEngine.Networking.UploadHandlerRaw((Unity.Collections.NativeArray<byte>)Reinterop.ObjectHandleUtility.GetObjectFromHandle(data)!, transferOwnership != 0);
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr UnityEngine_Networking_UploadHandlerRaw_Construct_Wn8TTeG3Q36ufSfvO3m1sgType(System.IntPtr data);
        private static unsafe readonly UnityEngine_Networking_UploadHandlerRaw_Construct_Wn8TTeG3Q36ufSfvO3m1sgType UnityEngine_Networking_UploadHandlerRaw_Construct_Wn8TTeG3Q36ufSfvO3m1sgDelegate = new UnityEngine_Networking_UploadHandlerRaw_Construct_Wn8TTeG3Q36ufSfvO3m1sgType(UnityEngine_Networking_UploadHandlerRaw_Construct_Wn8TTeG3Q36ufSfvO3m1sg);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Networking_UploadHandlerRaw_Construct_Wn8TTeG3Q36ufSfvO3m1sgType))]
        private static unsafe System.IntPtr UnityEngine_Networking_UploadHandlerRaw_Construct_Wn8TTeG3Q36ufSfvO3m1sg(System.IntPtr data)
        {
            
            var result = new UnityEngine.Networking.UploadHandlerRaw((byte[])Reinterop.ObjectHandleUtility.GetObjectFromHandle(data)!);
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void UnityEngine_Object_CallDestroyImmediate_c5oFMRh3nzKMIo8On83YBgType(System.IntPtr obj, byte allowDestroyingAssets);
        private static unsafe readonly UnityEngine_Object_CallDestroyImmediate_c5oFMRh3nzKMIo8On83YBgType UnityEngine_Object_CallDestroyImmediate_c5oFMRh3nzKMIo8On83YBgDelegate = new UnityEngine_Object_CallDestroyImmediate_c5oFMRh3nzKMIo8On83YBgType(UnityEngine_Object_CallDestroyImmediate_c5oFMRh3nzKMIo8On83YBg);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Object_CallDestroyImmediate_c5oFMRh3nzKMIo8On83YBgType))]
        private static unsafe void UnityEngine_Object_CallDestroyImmediate_c5oFMRh3nzKMIo8On83YBg(System.IntPtr obj, byte allowDestroyingAssets)
        {
            UnityEngine.Object.DestroyImmediate((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(obj)!, allowDestroyingAssets != 0);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void UnityEngine_Object_CallDestroyImmediate_x7aQMuJcEpatC9689ghI4AType(System.IntPtr obj);
        private static unsafe readonly UnityEngine_Object_CallDestroyImmediate_x7aQMuJcEpatC9689ghI4AType UnityEngine_Object_CallDestroyImmediate_x7aQMuJcEpatC9689ghI4ADelegate = new UnityEngine_Object_CallDestroyImmediate_x7aQMuJcEpatC9689ghI4AType(UnityEngine_Object_CallDestroyImmediate_x7aQMuJcEpatC9689ghI4A);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Object_CallDestroyImmediate_x7aQMuJcEpatC9689ghI4AType))]
        private static unsafe void UnityEngine_Object_CallDestroyImmediate_x7aQMuJcEpatC9689ghI4A(System.IntPtr obj)
        {
            UnityEngine.Object.DestroyImmediate((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(obj)!);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate System.IntPtr UnityEngine_Object_CallFindObjectsOfType_0EgxpGTzCG1YTfWqwgLniwType();
        private static unsafe readonly UnityEngine_Object_CallFindObjectsOfType_0EgxpGTzCG1YTfWqwgLniwType UnityEngine_Object_CallFindObjectsOfType_0EgxpGTzCG1YTfWqwgLniwDelegate = new UnityEngine_Object_CallFindObjectsOfType_0EgxpGTzCG1YTfWqwgLniwType(UnityEngine_Object_CallFindObjectsOfType_0EgxpGTzCG1YTfWqwgLniw);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Object_CallFindObjectsOfType_0EgxpGTzCG1YTfWqwgLniwType))]
        private static unsafe System.IntPtr UnityEngine_Object_CallFindObjectsOfType_0EgxpGTzCG1YTfWqwgLniw()
        {
            
            var result = UnityEngine.Object.FindObjectsOfType<CesiumForUnity.Cesium3DTileset>();
            
            return Reinterop.ObjectHandleUtility.CreateHandle(result);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte UnityEngine_Object_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType(System.IntPtr x, System.IntPtr y);
        private static unsafe readonly UnityEngine_Object_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType UnityEngine_Object_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgDelegate = new UnityEngine_Object_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType(UnityEngine_Object_Callop_Equality_5bi2N6jTkaYVhpHPRxL2Wg);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Object_Callop_Equality_5bi2N6jTkaYVhpHPRxL2WgType))]
        private static unsafe byte UnityEngine_Object_Callop_Equality_5bi2N6jTkaYVhpHPRxL2Wg(System.IntPtr x, System.IntPtr y)
        {
            
            var result = ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(x)!) == ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(y)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate byte UnityEngine_Object_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType(System.IntPtr x, System.IntPtr y);
        private static unsafe readonly UnityEngine_Object_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType UnityEngine_Object_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgDelegate = new UnityEngine_Object_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType(UnityEngine_Object_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2Wg);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Object_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2WgType))]
        private static unsafe byte UnityEngine_Object_Callop_Inequality_5bi2N6jTkaYVhpHPRxL2Wg(System.IntPtr x, System.IntPtr y)
        {
            
            var result = ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(x)!) != ((UnityEngine.Object)Reinterop.ObjectHandleUtility.GetObjectFromHandle(y)!);
            
            return result ? (byte)1 : (byte)0;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void UnityEngine_Rect_Construct_SWzoP__nNh7g2zNwjI5mUvQType(float x, float y, float width, float height, UnityEngine.Rect* pReturnValue);
        private static unsafe readonly UnityEngine_Rect_Construct_SWzoP__nNh7g2zNwjI5mUvQType UnityEngine_Rect_Construct_SWzoP__nNh7g2zNwjI5mUvQDelegate = new UnityEngine_Rect_Construct_SWzoP__nNh7g2zNwjI5mUvQType(UnityEngine_Rect_Construct_SWzoP__nNh7g2zNwjI5mUvQ);
        [AOT.MonoPInvokeCallback(typeof(UnityEngine_Rect_Construct_SWzoP__nNh7g2zNwjI5mUvQType))]
        private static unsafe void UnityEngine_Rect_Construct_SWzoP__nNh7g2zNwjI5mUvQ(float x, float y, float width, float height, UnityEngine.Rect* pReturnValue)
        {
            
            var result = new UnityEngine.Rect(x, y, width, height);
            
            *pReturnValue = result;
        }

        #pragma warning restore 0252
    }
}
#endif
