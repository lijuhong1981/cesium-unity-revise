#if UNITY_EDITOR_OSX
using System;
using System.Runtime.InteropServices;

namespace CesiumForUnity
{
    public partial class IonTokenTroubleshootingWindow
    {
        private partial void GetTroubleshootingDetails()
        {
            unsafe
            {
                Reinterop.ReinteropInitializer.Initialize();
                DotNet_CesiumForUnity_IonTokenTroubleshootingWindow_GetTroubleshootingDetails(Reinterop.ObjectHandleUtility.CreateHandle(this));
            }
        }
        private partial void AuthorizeToken(string token, bool isDefaultToken)
        {
            unsafe
            {
                Reinterop.ReinteropInitializer.Initialize();
                DotNet_CesiumForUnity_IonTokenTroubleshootingWindow_AuthorizeToken(Reinterop.ObjectHandleUtility.CreateHandle(this), Reinterop.ObjectHandleUtility.CreateHandle(token), isDefaultToken ? (byte)1 : (byte)0);
            }
        }
        private partial void SelectNewDefaultToken()
        {
            unsafe
            {
                Reinterop.ReinteropInitializer.Initialize();
                DotNet_CesiumForUnity_IonTokenTroubleshootingWindow_SelectNewDefaultToken(Reinterop.ObjectHandleUtility.CreateHandle(this));
            }
        }

        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_IonTokenTroubleshootingWindow_GetTroubleshootingDetails(System.IntPtr thiz);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_IonTokenTroubleshootingWindow_AuthorizeToken(System.IntPtr thiz, System.IntPtr token, byte isDefaultToken);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_IonTokenTroubleshootingWindow_SelectNewDefaultToken(System.IntPtr thiz);
    }
}
#endif
#if UNITY_EDITOR_WIN
using System;
using System.Runtime.InteropServices;

namespace CesiumForUnity
{
    public partial class IonTokenTroubleshootingWindow
    {
        private partial void GetTroubleshootingDetails()
        {
            unsafe
            {
                Reinterop.ReinteropInitializer.Initialize();
                DotNet_CesiumForUnity_IonTokenTroubleshootingWindow_GetTroubleshootingDetails(Reinterop.ObjectHandleUtility.CreateHandle(this));
            }
        }
        private partial void AuthorizeToken(string token, bool isDefaultToken)
        {
            unsafe
            {
                Reinterop.ReinteropInitializer.Initialize();
                DotNet_CesiumForUnity_IonTokenTroubleshootingWindow_AuthorizeToken(Reinterop.ObjectHandleUtility.CreateHandle(this), Reinterop.ObjectHandleUtility.CreateHandle(token), isDefaultToken ? (byte)1 : (byte)0);
            }
        }
        private partial void SelectNewDefaultToken()
        {
            unsafe
            {
                Reinterop.ReinteropInitializer.Initialize();
                DotNet_CesiumForUnity_IonTokenTroubleshootingWindow_SelectNewDefaultToken(Reinterop.ObjectHandleUtility.CreateHandle(this));
            }
        }

        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_IonTokenTroubleshootingWindow_GetTroubleshootingDetails(System.IntPtr thiz);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_IonTokenTroubleshootingWindow_AuthorizeToken(System.IntPtr thiz, System.IntPtr token, byte isDefaultToken);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_IonTokenTroubleshootingWindow_SelectNewDefaultToken(System.IntPtr thiz);
    }
}
#endif
