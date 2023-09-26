#if UNITY_EDITOR_OSX
using System;
using System.Runtime.InteropServices;

namespace CesiumForUnity
{
    public partial class CesiumTileExcluder
    {
        internal partial void AddToTileset(CesiumForUnity.Cesium3DTileset tileset)
        {
            unsafe
            {
                Reinterop.ReinteropInitializer.Initialize();
                DotNet_CesiumForUnity_CesiumTileExcluder_AddToTileset(Reinterop.ObjectHandleUtility.CreateHandle(this), Reinterop.ObjectHandleUtility.CreateHandle(tileset));
            }
        }
        internal partial void RemoveFromTileset(CesiumForUnity.Cesium3DTileset tileset)
        {
            unsafe
            {
                Reinterop.ReinteropInitializer.Initialize();
                DotNet_CesiumForUnity_CesiumTileExcluder_RemoveFromTileset(Reinterop.ObjectHandleUtility.CreateHandle(this), Reinterop.ObjectHandleUtility.CreateHandle(tileset));
            }
        }

        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_CesiumTileExcluder_AddToTileset(System.IntPtr thiz, System.IntPtr tileset);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_CesiumTileExcluder_RemoveFromTileset(System.IntPtr thiz, System.IntPtr tileset);
    }
}
#endif
#if !UNITY_EDITOR && UNITY_STANDALONE_OSX
using System;
using System.Runtime.InteropServices;

namespace CesiumForUnity
{
    public partial class CesiumTileExcluder
    {
        internal partial void AddToTileset(CesiumForUnity.Cesium3DTileset tileset)
        {
            unsafe
            {
                Reinterop.ReinteropInitializer.Initialize();
                DotNet_CesiumForUnity_CesiumTileExcluder_AddToTileset(Reinterop.ObjectHandleUtility.CreateHandle(this), Reinterop.ObjectHandleUtility.CreateHandle(tileset));
            }
        }
        internal partial void RemoveFromTileset(CesiumForUnity.Cesium3DTileset tileset)
        {
            unsafe
            {
                Reinterop.ReinteropInitializer.Initialize();
                DotNet_CesiumForUnity_CesiumTileExcluder_RemoveFromTileset(Reinterop.ObjectHandleUtility.CreateHandle(this), Reinterop.ObjectHandleUtility.CreateHandle(tileset));
            }
        }

        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_CesiumTileExcluder_AddToTileset(System.IntPtr thiz, System.IntPtr tileset);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_CesiumTileExcluder_RemoveFromTileset(System.IntPtr thiz, System.IntPtr tileset);
    }
}
#endif
#if !UNITY_EDITOR && UNITY_IOS
using System;
using System.Runtime.InteropServices;

namespace CesiumForUnity
{
    public partial class CesiumTileExcluder
    {
        internal partial void AddToTileset(CesiumForUnity.Cesium3DTileset tileset)
        {
            unsafe
            {
                Reinterop.ReinteropInitializer.Initialize();
                DotNet_CesiumForUnity_CesiumTileExcluder_AddToTileset(Reinterop.ObjectHandleUtility.CreateHandle(this), Reinterop.ObjectHandleUtility.CreateHandle(tileset));
            }
        }
        internal partial void RemoveFromTileset(CesiumForUnity.Cesium3DTileset tileset)
        {
            unsafe
            {
                Reinterop.ReinteropInitializer.Initialize();
                DotNet_CesiumForUnity_CesiumTileExcluder_RemoveFromTileset(Reinterop.ObjectHandleUtility.CreateHandle(this), Reinterop.ObjectHandleUtility.CreateHandle(tileset));
            }
        }

        [DllImport("__Internal", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_CesiumTileExcluder_AddToTileset(System.IntPtr thiz, System.IntPtr tileset);
        [DllImport("__Internal", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_CesiumTileExcluder_RemoveFromTileset(System.IntPtr thiz, System.IntPtr tileset);
    }
}
#endif
#if UNITY_EDITOR_WIN
using System;
using System.Runtime.InteropServices;

namespace CesiumForUnity
{
    public partial class CesiumTileExcluder
    {
        internal partial void AddToTileset(CesiumForUnity.Cesium3DTileset tileset)
        {
            unsafe
            {
                Reinterop.ReinteropInitializer.Initialize();
                DotNet_CesiumForUnity_CesiumTileExcluder_AddToTileset(Reinterop.ObjectHandleUtility.CreateHandle(this), Reinterop.ObjectHandleUtility.CreateHandle(tileset));
            }
        }
        internal partial void RemoveFromTileset(CesiumForUnity.Cesium3DTileset tileset)
        {
            unsafe
            {
                Reinterop.ReinteropInitializer.Initialize();
                DotNet_CesiumForUnity_CesiumTileExcluder_RemoveFromTileset(Reinterop.ObjectHandleUtility.CreateHandle(this), Reinterop.ObjectHandleUtility.CreateHandle(tileset));
            }
        }

        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_CesiumTileExcluder_AddToTileset(System.IntPtr thiz, System.IntPtr tileset);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_CesiumTileExcluder_RemoveFromTileset(System.IntPtr thiz, System.IntPtr tileset);
    }
}
#endif
#if !UNITY_EDITOR && UNITY_WSA
using System;
using System.Runtime.InteropServices;

namespace CesiumForUnity
{
    public partial class CesiumTileExcluder
    {
        internal partial void AddToTileset(CesiumForUnity.Cesium3DTileset tileset)
        {
            unsafe
            {
                Reinterop.ReinteropInitializer.Initialize();
                DotNet_CesiumForUnity_CesiumTileExcluder_AddToTileset(Reinterop.ObjectHandleUtility.CreateHandle(this), Reinterop.ObjectHandleUtility.CreateHandle(tileset));
            }
        }
        internal partial void RemoveFromTileset(CesiumForUnity.Cesium3DTileset tileset)
        {
            unsafe
            {
                Reinterop.ReinteropInitializer.Initialize();
                DotNet_CesiumForUnity_CesiumTileExcluder_RemoveFromTileset(Reinterop.ObjectHandleUtility.CreateHandle(this), Reinterop.ObjectHandleUtility.CreateHandle(tileset));
            }
        }

        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_CesiumTileExcluder_AddToTileset(System.IntPtr thiz, System.IntPtr tileset);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_CesiumTileExcluder_RemoveFromTileset(System.IntPtr thiz, System.IntPtr tileset);
    }
}
#endif
#if !UNITY_EDITOR && UNITY_STANDALONE_WIN
using System;
using System.Runtime.InteropServices;

namespace CesiumForUnity
{
    public partial class CesiumTileExcluder
    {
        internal partial void AddToTileset(CesiumForUnity.Cesium3DTileset tileset)
        {
            unsafe
            {
                Reinterop.ReinteropInitializer.Initialize();
                DotNet_CesiumForUnity_CesiumTileExcluder_AddToTileset(Reinterop.ObjectHandleUtility.CreateHandle(this), Reinterop.ObjectHandleUtility.CreateHandle(tileset));
            }
        }
        internal partial void RemoveFromTileset(CesiumForUnity.Cesium3DTileset tileset)
        {
            unsafe
            {
                Reinterop.ReinteropInitializer.Initialize();
                DotNet_CesiumForUnity_CesiumTileExcluder_RemoveFromTileset(Reinterop.ObjectHandleUtility.CreateHandle(this), Reinterop.ObjectHandleUtility.CreateHandle(tileset));
            }
        }

        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_CesiumTileExcluder_AddToTileset(System.IntPtr thiz, System.IntPtr tileset);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_CesiumTileExcluder_RemoveFromTileset(System.IntPtr thiz, System.IntPtr tileset);
    }
}
#endif
#if !UNITY_EDITOR && UNITY_ANDROID
using System;
using System.Runtime.InteropServices;

namespace CesiumForUnity
{
    public partial class CesiumTileExcluder
    {
        internal partial void AddToTileset(CesiumForUnity.Cesium3DTileset tileset)
        {
            unsafe
            {
                Reinterop.ReinteropInitializer.Initialize();
                DotNet_CesiumForUnity_CesiumTileExcluder_AddToTileset(Reinterop.ObjectHandleUtility.CreateHandle(this), Reinterop.ObjectHandleUtility.CreateHandle(tileset));
            }
        }
        internal partial void RemoveFromTileset(CesiumForUnity.Cesium3DTileset tileset)
        {
            unsafe
            {
                Reinterop.ReinteropInitializer.Initialize();
                DotNet_CesiumForUnity_CesiumTileExcluder_RemoveFromTileset(Reinterop.ObjectHandleUtility.CreateHandle(this), Reinterop.ObjectHandleUtility.CreateHandle(tileset));
            }
        }

        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_CesiumTileExcluder_AddToTileset(System.IntPtr thiz, System.IntPtr tileset);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_CesiumTileExcluder_RemoveFromTileset(System.IntPtr thiz, System.IntPtr tileset);
    }
}
#endif
