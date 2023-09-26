#if UNITY_EDITOR_OSX
using System;
using System.Runtime.InteropServices;

namespace CesiumForUnity
{
    public partial class CesiumGlobeAnchor
    {
        private partial void SetNewLocalToGlobeFixedMatrix(Unity.Mathematics.double4x4 newLocalToGlobeFixedMatrix)
        {
            unsafe
            {
                Reinterop.ReinteropInitializer.Initialize();
                DotNet_CesiumForUnity_CesiumGlobeAnchor_SetNewLocalToGlobeFixedMatrix(Reinterop.ObjectHandleUtility.CreateHandle(this), &newLocalToGlobeFixedMatrix);
            }
        }
        private partial void SetNewLocalToGlobeFixedMatrixFromTransform()
        {
            unsafe
            {
                Reinterop.ReinteropInitializer.Initialize();
                DotNet_CesiumForUnity_CesiumGlobeAnchor_SetNewLocalToGlobeFixedMatrixFromTransform(Reinterop.ObjectHandleUtility.CreateHandle(this));
            }
        }
        private partial Unity.Mathematics.quaternion GetLocalToEastUpNorthRotation()
        {
            unsafe
            {
                Reinterop.ReinteropInitializer.Initialize();
                var returnValue = new Unity.Mathematics.quaternion();
                DotNet_CesiumForUnity_CesiumGlobeAnchor_GetLocalToEastUpNorthRotation(Reinterop.ObjectHandleUtility.CreateHandle(this), &returnValue);
                return returnValue;
            }
        }
        private partial void SetLocalToEastUpNorthRotation(Unity.Mathematics.quaternion newRotation)
        {
            unsafe
            {
                Reinterop.ReinteropInitializer.Initialize();
                DotNet_CesiumForUnity_CesiumGlobeAnchor_SetLocalToEastUpNorthRotation(Reinterop.ObjectHandleUtility.CreateHandle(this), &newRotation);
            }
        }

        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_CesiumGlobeAnchor_SetNewLocalToGlobeFixedMatrix(System.IntPtr thiz, Unity.Mathematics.double4x4* newLocalToGlobeFixedMatrix);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_CesiumGlobeAnchor_SetNewLocalToGlobeFixedMatrixFromTransform(System.IntPtr thiz);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_CesiumGlobeAnchor_GetLocalToEastUpNorthRotation(System.IntPtr thiz, Unity.Mathematics.quaternion* pReturnValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_CesiumGlobeAnchor_SetLocalToEastUpNorthRotation(System.IntPtr thiz, Unity.Mathematics.quaternion* newRotation);
    }
}
#endif
#if !UNITY_EDITOR && UNITY_STANDALONE_OSX
using System;
using System.Runtime.InteropServices;

namespace CesiumForUnity
{
    public partial class CesiumGlobeAnchor
    {
        private partial void SetNewLocalToGlobeFixedMatrix(Unity.Mathematics.double4x4 newLocalToGlobeFixedMatrix)
        {
            unsafe
            {
                Reinterop.ReinteropInitializer.Initialize();
                DotNet_CesiumForUnity_CesiumGlobeAnchor_SetNewLocalToGlobeFixedMatrix(Reinterop.ObjectHandleUtility.CreateHandle(this), &newLocalToGlobeFixedMatrix);
            }
        }
        private partial void SetNewLocalToGlobeFixedMatrixFromTransform()
        {
            unsafe
            {
                Reinterop.ReinteropInitializer.Initialize();
                DotNet_CesiumForUnity_CesiumGlobeAnchor_SetNewLocalToGlobeFixedMatrixFromTransform(Reinterop.ObjectHandleUtility.CreateHandle(this));
            }
        }
        private partial Unity.Mathematics.quaternion GetLocalToEastUpNorthRotation()
        {
            unsafe
            {
                Reinterop.ReinteropInitializer.Initialize();
                var returnValue = new Unity.Mathematics.quaternion();
                DotNet_CesiumForUnity_CesiumGlobeAnchor_GetLocalToEastUpNorthRotation(Reinterop.ObjectHandleUtility.CreateHandle(this), &returnValue);
                return returnValue;
            }
        }
        private partial void SetLocalToEastUpNorthRotation(Unity.Mathematics.quaternion newRotation)
        {
            unsafe
            {
                Reinterop.ReinteropInitializer.Initialize();
                DotNet_CesiumForUnity_CesiumGlobeAnchor_SetLocalToEastUpNorthRotation(Reinterop.ObjectHandleUtility.CreateHandle(this), &newRotation);
            }
        }

        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_CesiumGlobeAnchor_SetNewLocalToGlobeFixedMatrix(System.IntPtr thiz, Unity.Mathematics.double4x4* newLocalToGlobeFixedMatrix);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_CesiumGlobeAnchor_SetNewLocalToGlobeFixedMatrixFromTransform(System.IntPtr thiz);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_CesiumGlobeAnchor_GetLocalToEastUpNorthRotation(System.IntPtr thiz, Unity.Mathematics.quaternion* pReturnValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_CesiumGlobeAnchor_SetLocalToEastUpNorthRotation(System.IntPtr thiz, Unity.Mathematics.quaternion* newRotation);
    }
}
#endif
#if !UNITY_EDITOR && UNITY_IOS
using System;
using System.Runtime.InteropServices;

namespace CesiumForUnity
{
    public partial class CesiumGlobeAnchor
    {
        private partial void SetNewLocalToGlobeFixedMatrix(Unity.Mathematics.double4x4 newLocalToGlobeFixedMatrix)
        {
            unsafe
            {
                Reinterop.ReinteropInitializer.Initialize();
                DotNet_CesiumForUnity_CesiumGlobeAnchor_SetNewLocalToGlobeFixedMatrix(Reinterop.ObjectHandleUtility.CreateHandle(this), &newLocalToGlobeFixedMatrix);
            }
        }
        private partial void SetNewLocalToGlobeFixedMatrixFromTransform()
        {
            unsafe
            {
                Reinterop.ReinteropInitializer.Initialize();
                DotNet_CesiumForUnity_CesiumGlobeAnchor_SetNewLocalToGlobeFixedMatrixFromTransform(Reinterop.ObjectHandleUtility.CreateHandle(this));
            }
        }
        private partial Unity.Mathematics.quaternion GetLocalToEastUpNorthRotation()
        {
            unsafe
            {
                Reinterop.ReinteropInitializer.Initialize();
                var returnValue = new Unity.Mathematics.quaternion();
                DotNet_CesiumForUnity_CesiumGlobeAnchor_GetLocalToEastUpNorthRotation(Reinterop.ObjectHandleUtility.CreateHandle(this), &returnValue);
                return returnValue;
            }
        }
        private partial void SetLocalToEastUpNorthRotation(Unity.Mathematics.quaternion newRotation)
        {
            unsafe
            {
                Reinterop.ReinteropInitializer.Initialize();
                DotNet_CesiumForUnity_CesiumGlobeAnchor_SetLocalToEastUpNorthRotation(Reinterop.ObjectHandleUtility.CreateHandle(this), &newRotation);
            }
        }

        [DllImport("__Internal", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_CesiumGlobeAnchor_SetNewLocalToGlobeFixedMatrix(System.IntPtr thiz, Unity.Mathematics.double4x4* newLocalToGlobeFixedMatrix);
        [DllImport("__Internal", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_CesiumGlobeAnchor_SetNewLocalToGlobeFixedMatrixFromTransform(System.IntPtr thiz);
        [DllImport("__Internal", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_CesiumGlobeAnchor_GetLocalToEastUpNorthRotation(System.IntPtr thiz, Unity.Mathematics.quaternion* pReturnValue);
        [DllImport("__Internal", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_CesiumGlobeAnchor_SetLocalToEastUpNorthRotation(System.IntPtr thiz, Unity.Mathematics.quaternion* newRotation);
    }
}
#endif
#if UNITY_EDITOR_WIN
using System;
using System.Runtime.InteropServices;

namespace CesiumForUnity
{
    public partial class CesiumGlobeAnchor
    {
        private partial void SetNewLocalToGlobeFixedMatrix(Unity.Mathematics.double4x4 newLocalToGlobeFixedMatrix)
        {
            unsafe
            {
                Reinterop.ReinteropInitializer.Initialize();
                DotNet_CesiumForUnity_CesiumGlobeAnchor_SetNewLocalToGlobeFixedMatrix(Reinterop.ObjectHandleUtility.CreateHandle(this), &newLocalToGlobeFixedMatrix);
            }
        }
        private partial void SetNewLocalToGlobeFixedMatrixFromTransform()
        {
            unsafe
            {
                Reinterop.ReinteropInitializer.Initialize();
                DotNet_CesiumForUnity_CesiumGlobeAnchor_SetNewLocalToGlobeFixedMatrixFromTransform(Reinterop.ObjectHandleUtility.CreateHandle(this));
            }
        }
        private partial Unity.Mathematics.quaternion GetLocalToEastUpNorthRotation()
        {
            unsafe
            {
                Reinterop.ReinteropInitializer.Initialize();
                var returnValue = new Unity.Mathematics.quaternion();
                DotNet_CesiumForUnity_CesiumGlobeAnchor_GetLocalToEastUpNorthRotation(Reinterop.ObjectHandleUtility.CreateHandle(this), &returnValue);
                return returnValue;
            }
        }
        private partial void SetLocalToEastUpNorthRotation(Unity.Mathematics.quaternion newRotation)
        {
            unsafe
            {
                Reinterop.ReinteropInitializer.Initialize();
                DotNet_CesiumForUnity_CesiumGlobeAnchor_SetLocalToEastUpNorthRotation(Reinterop.ObjectHandleUtility.CreateHandle(this), &newRotation);
            }
        }

        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_CesiumGlobeAnchor_SetNewLocalToGlobeFixedMatrix(System.IntPtr thiz, Unity.Mathematics.double4x4* newLocalToGlobeFixedMatrix);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_CesiumGlobeAnchor_SetNewLocalToGlobeFixedMatrixFromTransform(System.IntPtr thiz);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_CesiumGlobeAnchor_GetLocalToEastUpNorthRotation(System.IntPtr thiz, Unity.Mathematics.quaternion* pReturnValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_CesiumGlobeAnchor_SetLocalToEastUpNorthRotation(System.IntPtr thiz, Unity.Mathematics.quaternion* newRotation);
    }
}
#endif
#if !UNITY_EDITOR && UNITY_WSA
using System;
using System.Runtime.InteropServices;

namespace CesiumForUnity
{
    public partial class CesiumGlobeAnchor
    {
        private partial void SetNewLocalToGlobeFixedMatrix(Unity.Mathematics.double4x4 newLocalToGlobeFixedMatrix)
        {
            unsafe
            {
                Reinterop.ReinteropInitializer.Initialize();
                DotNet_CesiumForUnity_CesiumGlobeAnchor_SetNewLocalToGlobeFixedMatrix(Reinterop.ObjectHandleUtility.CreateHandle(this), &newLocalToGlobeFixedMatrix);
            }
        }
        private partial void SetNewLocalToGlobeFixedMatrixFromTransform()
        {
            unsafe
            {
                Reinterop.ReinteropInitializer.Initialize();
                DotNet_CesiumForUnity_CesiumGlobeAnchor_SetNewLocalToGlobeFixedMatrixFromTransform(Reinterop.ObjectHandleUtility.CreateHandle(this));
            }
        }
        private partial Unity.Mathematics.quaternion GetLocalToEastUpNorthRotation()
        {
            unsafe
            {
                Reinterop.ReinteropInitializer.Initialize();
                var returnValue = new Unity.Mathematics.quaternion();
                DotNet_CesiumForUnity_CesiumGlobeAnchor_GetLocalToEastUpNorthRotation(Reinterop.ObjectHandleUtility.CreateHandle(this), &returnValue);
                return returnValue;
            }
        }
        private partial void SetLocalToEastUpNorthRotation(Unity.Mathematics.quaternion newRotation)
        {
            unsafe
            {
                Reinterop.ReinteropInitializer.Initialize();
                DotNet_CesiumForUnity_CesiumGlobeAnchor_SetLocalToEastUpNorthRotation(Reinterop.ObjectHandleUtility.CreateHandle(this), &newRotation);
            }
        }

        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_CesiumGlobeAnchor_SetNewLocalToGlobeFixedMatrix(System.IntPtr thiz, Unity.Mathematics.double4x4* newLocalToGlobeFixedMatrix);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_CesiumGlobeAnchor_SetNewLocalToGlobeFixedMatrixFromTransform(System.IntPtr thiz);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_CesiumGlobeAnchor_GetLocalToEastUpNorthRotation(System.IntPtr thiz, Unity.Mathematics.quaternion* pReturnValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_CesiumGlobeAnchor_SetLocalToEastUpNorthRotation(System.IntPtr thiz, Unity.Mathematics.quaternion* newRotation);
    }
}
#endif
#if !UNITY_EDITOR && UNITY_STANDALONE_WIN
using System;
using System.Runtime.InteropServices;

namespace CesiumForUnity
{
    public partial class CesiumGlobeAnchor
    {
        private partial void SetNewLocalToGlobeFixedMatrix(Unity.Mathematics.double4x4 newLocalToGlobeFixedMatrix)
        {
            unsafe
            {
                Reinterop.ReinteropInitializer.Initialize();
                DotNet_CesiumForUnity_CesiumGlobeAnchor_SetNewLocalToGlobeFixedMatrix(Reinterop.ObjectHandleUtility.CreateHandle(this), &newLocalToGlobeFixedMatrix);
            }
        }
        private partial void SetNewLocalToGlobeFixedMatrixFromTransform()
        {
            unsafe
            {
                Reinterop.ReinteropInitializer.Initialize();
                DotNet_CesiumForUnity_CesiumGlobeAnchor_SetNewLocalToGlobeFixedMatrixFromTransform(Reinterop.ObjectHandleUtility.CreateHandle(this));
            }
        }
        private partial Unity.Mathematics.quaternion GetLocalToEastUpNorthRotation()
        {
            unsafe
            {
                Reinterop.ReinteropInitializer.Initialize();
                var returnValue = new Unity.Mathematics.quaternion();
                DotNet_CesiumForUnity_CesiumGlobeAnchor_GetLocalToEastUpNorthRotation(Reinterop.ObjectHandleUtility.CreateHandle(this), &returnValue);
                return returnValue;
            }
        }
        private partial void SetLocalToEastUpNorthRotation(Unity.Mathematics.quaternion newRotation)
        {
            unsafe
            {
                Reinterop.ReinteropInitializer.Initialize();
                DotNet_CesiumForUnity_CesiumGlobeAnchor_SetLocalToEastUpNorthRotation(Reinterop.ObjectHandleUtility.CreateHandle(this), &newRotation);
            }
        }

        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_CesiumGlobeAnchor_SetNewLocalToGlobeFixedMatrix(System.IntPtr thiz, Unity.Mathematics.double4x4* newLocalToGlobeFixedMatrix);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_CesiumGlobeAnchor_SetNewLocalToGlobeFixedMatrixFromTransform(System.IntPtr thiz);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_CesiumGlobeAnchor_GetLocalToEastUpNorthRotation(System.IntPtr thiz, Unity.Mathematics.quaternion* pReturnValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_CesiumGlobeAnchor_SetLocalToEastUpNorthRotation(System.IntPtr thiz, Unity.Mathematics.quaternion* newRotation);
    }
}
#endif
#if !UNITY_EDITOR && UNITY_ANDROID
using System;
using System.Runtime.InteropServices;

namespace CesiumForUnity
{
    public partial class CesiumGlobeAnchor
    {
        private partial void SetNewLocalToGlobeFixedMatrix(Unity.Mathematics.double4x4 newLocalToGlobeFixedMatrix)
        {
            unsafe
            {
                Reinterop.ReinteropInitializer.Initialize();
                DotNet_CesiumForUnity_CesiumGlobeAnchor_SetNewLocalToGlobeFixedMatrix(Reinterop.ObjectHandleUtility.CreateHandle(this), &newLocalToGlobeFixedMatrix);
            }
        }
        private partial void SetNewLocalToGlobeFixedMatrixFromTransform()
        {
            unsafe
            {
                Reinterop.ReinteropInitializer.Initialize();
                DotNet_CesiumForUnity_CesiumGlobeAnchor_SetNewLocalToGlobeFixedMatrixFromTransform(Reinterop.ObjectHandleUtility.CreateHandle(this));
            }
        }
        private partial Unity.Mathematics.quaternion GetLocalToEastUpNorthRotation()
        {
            unsafe
            {
                Reinterop.ReinteropInitializer.Initialize();
                var returnValue = new Unity.Mathematics.quaternion();
                DotNet_CesiumForUnity_CesiumGlobeAnchor_GetLocalToEastUpNorthRotation(Reinterop.ObjectHandleUtility.CreateHandle(this), &returnValue);
                return returnValue;
            }
        }
        private partial void SetLocalToEastUpNorthRotation(Unity.Mathematics.quaternion newRotation)
        {
            unsafe
            {
                Reinterop.ReinteropInitializer.Initialize();
                DotNet_CesiumForUnity_CesiumGlobeAnchor_SetLocalToEastUpNorthRotation(Reinterop.ObjectHandleUtility.CreateHandle(this), &newRotation);
            }
        }

        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_CesiumGlobeAnchor_SetNewLocalToGlobeFixedMatrix(System.IntPtr thiz, Unity.Mathematics.double4x4* newLocalToGlobeFixedMatrix);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_CesiumGlobeAnchor_SetNewLocalToGlobeFixedMatrixFromTransform(System.IntPtr thiz);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_CesiumGlobeAnchor_GetLocalToEastUpNorthRotation(System.IntPtr thiz, Unity.Mathematics.quaternion* pReturnValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_CesiumGlobeAnchor_SetLocalToEastUpNorthRotation(System.IntPtr thiz, Unity.Mathematics.quaternion* newRotation);
    }
}
#endif
