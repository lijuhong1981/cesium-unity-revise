#if UNITY_EDITOR_OSX
using Microsoft.Win32.SafeHandles;
using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace CesiumForUnity
{
    public partial class Cesium3DTileset : System.IDisposable
    {
        internal class ImplementationHandle : SafeHandleZeroOrMinusOneIsInvalid
        {
            public ImplementationHandle(Cesium3DTileset managed) : base(true)
            {
                SetHandle(DotNet_CesiumForUnity_Cesium3DTileset_CreateImplementation(Reinterop.ObjectHandleUtility.CreateHandle(managed)));
            }

            [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
            protected override bool ReleaseHandle()
            {
                DotNet_CesiumForUnity_Cesium3DTileset_DestroyImplementation(this.handle);
                return true;
            }
        }

        [System.NonSerialized]
        private ImplementationHandle _implementation = null;

        internal ImplementationHandle NativeImplementation
        {
            get { return _implementation; }
        }

        private void CreateImplementation()
        {
            Reinterop.ReinteropInitializer.Initialize();
            System.Diagnostics.Debug.Assert(this._implementation == null, "Implementation is already created. Be sure to call CreateImplementation only once.");
            this._implementation = new ImplementationHandle(this);
        }
        protected void DisposeImplementation()
        {
            if (this._implementation != null && !this._implementation.IsInvalid)
                this._implementation.Dispose();
            this._implementation = null;
        }
        public Cesium3DTileset()
        {
            CreateImplementation();
        }
        public partial float ComputeLoadProgress()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so ComputeLoadProgress cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_Cesium3DTileset_ComputeLoadProgress(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
                return result;
            }
        }
        private partial void SetShowCreditsOnScreen(bool value)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so SetShowCreditsOnScreen cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_Cesium3DTileset_SetShowCreditsOnScreen(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, value ? (byte)1 : (byte)0);
            }
        }
        private partial void Start()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so Start cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_Cesium3DTileset_Start(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }
        private partial void Update()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so Update cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_Cesium3DTileset_Update(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }
        private partial void OnValidate()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so OnValidate cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_Cesium3DTileset_OnValidate(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }
        private partial void OnEnable()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so OnEnable cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_Cesium3DTileset_OnEnable(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }
        private partial void OnDisable()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so OnDisable cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_Cesium3DTileset_OnDisable(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }
        public partial void RecreateTileset()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so RecreateTileset cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_Cesium3DTileset_RecreateTileset(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }
        public partial void FocusTileset()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so FocusTileset cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_Cesium3DTileset_FocusTileset(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }

        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static extern System.IntPtr DotNet_CesiumForUnity_Cesium3DTileset_CreateImplementation(System.IntPtr thiz);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static extern void DotNet_CesiumForUnity_Cesium3DTileset_DestroyImplementation(System.IntPtr implementation);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern float DotNet_CesiumForUnity_Cesium3DTileset_ComputeLoadProgress(System.IntPtr thiz, CesiumForUnity.Cesium3DTileset.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_Cesium3DTileset_SetShowCreditsOnScreen(System.IntPtr thiz, CesiumForUnity.Cesium3DTileset.ImplementationHandle implementation, byte value);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_Cesium3DTileset_Start(System.IntPtr thiz, CesiumForUnity.Cesium3DTileset.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_Cesium3DTileset_Update(System.IntPtr thiz, CesiumForUnity.Cesium3DTileset.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_Cesium3DTileset_OnValidate(System.IntPtr thiz, CesiumForUnity.Cesium3DTileset.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_Cesium3DTileset_OnEnable(System.IntPtr thiz, CesiumForUnity.Cesium3DTileset.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_Cesium3DTileset_OnDisable(System.IntPtr thiz, CesiumForUnity.Cesium3DTileset.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_Cesium3DTileset_RecreateTileset(System.IntPtr thiz, CesiumForUnity.Cesium3DTileset.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_Cesium3DTileset_FocusTileset(System.IntPtr thiz, CesiumForUnity.Cesium3DTileset.ImplementationHandle implementation);
    }
}
#endif
#if !UNITY_EDITOR && UNITY_STANDALONE_OSX
using Microsoft.Win32.SafeHandles;
using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace CesiumForUnity
{
    public partial class Cesium3DTileset : System.IDisposable
    {
        internal class ImplementationHandle : SafeHandleZeroOrMinusOneIsInvalid
        {
            public ImplementationHandle(Cesium3DTileset managed) : base(true)
            {
                SetHandle(DotNet_CesiumForUnity_Cesium3DTileset_CreateImplementation(Reinterop.ObjectHandleUtility.CreateHandle(managed)));
            }

            [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
            protected override bool ReleaseHandle()
            {
                DotNet_CesiumForUnity_Cesium3DTileset_DestroyImplementation(this.handle);
                return true;
            }
        }

        [System.NonSerialized]
        private ImplementationHandle _implementation = null;

        internal ImplementationHandle NativeImplementation
        {
            get { return _implementation; }
        }

        private void CreateImplementation()
        {
            Reinterop.ReinteropInitializer.Initialize();
            System.Diagnostics.Debug.Assert(this._implementation == null, "Implementation is already created. Be sure to call CreateImplementation only once.");
            this._implementation = new ImplementationHandle(this);
        }
        protected void DisposeImplementation()
        {
            if (this._implementation != null && !this._implementation.IsInvalid)
                this._implementation.Dispose();
            this._implementation = null;
        }
        public Cesium3DTileset()
        {
            CreateImplementation();
        }
        public partial float ComputeLoadProgress()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so ComputeLoadProgress cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_Cesium3DTileset_ComputeLoadProgress(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
                return result;
            }
        }
        private partial void SetShowCreditsOnScreen(bool value)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so SetShowCreditsOnScreen cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_Cesium3DTileset_SetShowCreditsOnScreen(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, value ? (byte)1 : (byte)0);
            }
        }
        private partial void Start()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so Start cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_Cesium3DTileset_Start(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }
        private partial void Update()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so Update cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_Cesium3DTileset_Update(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }
        private partial void OnValidate()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so OnValidate cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_Cesium3DTileset_OnValidate(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }
        private partial void OnEnable()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so OnEnable cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_Cesium3DTileset_OnEnable(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }
        private partial void OnDisable()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so OnDisable cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_Cesium3DTileset_OnDisable(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }
        public partial void RecreateTileset()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so RecreateTileset cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_Cesium3DTileset_RecreateTileset(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }
        public partial void FocusTileset()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so FocusTileset cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_Cesium3DTileset_FocusTileset(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }

        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static extern System.IntPtr DotNet_CesiumForUnity_Cesium3DTileset_CreateImplementation(System.IntPtr thiz);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static extern void DotNet_CesiumForUnity_Cesium3DTileset_DestroyImplementation(System.IntPtr implementation);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern float DotNet_CesiumForUnity_Cesium3DTileset_ComputeLoadProgress(System.IntPtr thiz, CesiumForUnity.Cesium3DTileset.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_Cesium3DTileset_SetShowCreditsOnScreen(System.IntPtr thiz, CesiumForUnity.Cesium3DTileset.ImplementationHandle implementation, byte value);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_Cesium3DTileset_Start(System.IntPtr thiz, CesiumForUnity.Cesium3DTileset.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_Cesium3DTileset_Update(System.IntPtr thiz, CesiumForUnity.Cesium3DTileset.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_Cesium3DTileset_OnValidate(System.IntPtr thiz, CesiumForUnity.Cesium3DTileset.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_Cesium3DTileset_OnEnable(System.IntPtr thiz, CesiumForUnity.Cesium3DTileset.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_Cesium3DTileset_OnDisable(System.IntPtr thiz, CesiumForUnity.Cesium3DTileset.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_Cesium3DTileset_RecreateTileset(System.IntPtr thiz, CesiumForUnity.Cesium3DTileset.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_Cesium3DTileset_FocusTileset(System.IntPtr thiz, CesiumForUnity.Cesium3DTileset.ImplementationHandle implementation);
    }
}
#endif
#if !UNITY_EDITOR && UNITY_IOS
using Microsoft.Win32.SafeHandles;
using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace CesiumForUnity
{
    public partial class Cesium3DTileset : System.IDisposable
    {
        internal class ImplementationHandle : SafeHandleZeroOrMinusOneIsInvalid
        {
            public ImplementationHandle(Cesium3DTileset managed) : base(true)
            {
                SetHandle(DotNet_CesiumForUnity_Cesium3DTileset_CreateImplementation(Reinterop.ObjectHandleUtility.CreateHandle(managed)));
            }

            [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
            protected override bool ReleaseHandle()
            {
                DotNet_CesiumForUnity_Cesium3DTileset_DestroyImplementation(this.handle);
                return true;
            }
        }

        [System.NonSerialized]
        private ImplementationHandle _implementation = null;

        internal ImplementationHandle NativeImplementation
        {
            get { return _implementation; }
        }

        private void CreateImplementation()
        {
            Reinterop.ReinteropInitializer.Initialize();
            System.Diagnostics.Debug.Assert(this._implementation == null, "Implementation is already created. Be sure to call CreateImplementation only once.");
            this._implementation = new ImplementationHandle(this);
        }
        protected void DisposeImplementation()
        {
            if (this._implementation != null && !this._implementation.IsInvalid)
                this._implementation.Dispose();
            this._implementation = null;
        }
        public Cesium3DTileset()
        {
            CreateImplementation();
        }
        public partial float ComputeLoadProgress()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so ComputeLoadProgress cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_Cesium3DTileset_ComputeLoadProgress(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
                return result;
            }
        }
        private partial void SetShowCreditsOnScreen(bool value)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so SetShowCreditsOnScreen cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_Cesium3DTileset_SetShowCreditsOnScreen(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, value ? (byte)1 : (byte)0);
            }
        }
        private partial void Start()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so Start cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_Cesium3DTileset_Start(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }
        private partial void Update()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so Update cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_Cesium3DTileset_Update(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }
        private partial void OnValidate()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so OnValidate cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_Cesium3DTileset_OnValidate(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }
        private partial void OnEnable()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so OnEnable cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_Cesium3DTileset_OnEnable(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }
        private partial void OnDisable()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so OnDisable cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_Cesium3DTileset_OnDisable(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }
        public partial void RecreateTileset()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so RecreateTileset cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_Cesium3DTileset_RecreateTileset(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }
        public partial void FocusTileset()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so FocusTileset cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_Cesium3DTileset_FocusTileset(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }

        [DllImport("__Internal", CallingConvention=CallingConvention.Cdecl)]
        private static extern System.IntPtr DotNet_CesiumForUnity_Cesium3DTileset_CreateImplementation(System.IntPtr thiz);
        [DllImport("__Internal", CallingConvention=CallingConvention.Cdecl)]
        private static extern void DotNet_CesiumForUnity_Cesium3DTileset_DestroyImplementation(System.IntPtr implementation);
        [DllImport("__Internal", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern float DotNet_CesiumForUnity_Cesium3DTileset_ComputeLoadProgress(System.IntPtr thiz, CesiumForUnity.Cesium3DTileset.ImplementationHandle implementation);
        [DllImport("__Internal", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_Cesium3DTileset_SetShowCreditsOnScreen(System.IntPtr thiz, CesiumForUnity.Cesium3DTileset.ImplementationHandle implementation, byte value);
        [DllImport("__Internal", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_Cesium3DTileset_Start(System.IntPtr thiz, CesiumForUnity.Cesium3DTileset.ImplementationHandle implementation);
        [DllImport("__Internal", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_Cesium3DTileset_Update(System.IntPtr thiz, CesiumForUnity.Cesium3DTileset.ImplementationHandle implementation);
        [DllImport("__Internal", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_Cesium3DTileset_OnValidate(System.IntPtr thiz, CesiumForUnity.Cesium3DTileset.ImplementationHandle implementation);
        [DllImport("__Internal", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_Cesium3DTileset_OnEnable(System.IntPtr thiz, CesiumForUnity.Cesium3DTileset.ImplementationHandle implementation);
        [DllImport("__Internal", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_Cesium3DTileset_OnDisable(System.IntPtr thiz, CesiumForUnity.Cesium3DTileset.ImplementationHandle implementation);
        [DllImport("__Internal", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_Cesium3DTileset_RecreateTileset(System.IntPtr thiz, CesiumForUnity.Cesium3DTileset.ImplementationHandle implementation);
        [DllImport("__Internal", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_Cesium3DTileset_FocusTileset(System.IntPtr thiz, CesiumForUnity.Cesium3DTileset.ImplementationHandle implementation);
    }
}
#endif
#if UNITY_EDITOR_WIN
using Microsoft.Win32.SafeHandles;
using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace CesiumForUnity
{
    public partial class Cesium3DTileset : System.IDisposable
    {
        internal class ImplementationHandle : SafeHandleZeroOrMinusOneIsInvalid
        {
            public ImplementationHandle(Cesium3DTileset managed) : base(true)
            {
                SetHandle(DotNet_CesiumForUnity_Cesium3DTileset_CreateImplementation(Reinterop.ObjectHandleUtility.CreateHandle(managed)));
            }

            [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
            protected override bool ReleaseHandle()
            {
                DotNet_CesiumForUnity_Cesium3DTileset_DestroyImplementation(this.handle);
                return true;
            }
        }

        [System.NonSerialized]
        private ImplementationHandle _implementation = null;

        internal ImplementationHandle NativeImplementation
        {
            get { return _implementation; }
        }

        private void CreateImplementation()
        {
            Reinterop.ReinteropInitializer.Initialize();
            System.Diagnostics.Debug.Assert(this._implementation == null, "Implementation is already created. Be sure to call CreateImplementation only once.");
            this._implementation = new ImplementationHandle(this);
        }
        protected void DisposeImplementation()
        {
            if (this._implementation != null && !this._implementation.IsInvalid)
                this._implementation.Dispose();
            this._implementation = null;
        }
        public Cesium3DTileset()
        {
            CreateImplementation();
        }
        public partial float ComputeLoadProgress()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so ComputeLoadProgress cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_Cesium3DTileset_ComputeLoadProgress(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
                return result;
            }
        }
        private partial void SetShowCreditsOnScreen(bool value)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so SetShowCreditsOnScreen cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_Cesium3DTileset_SetShowCreditsOnScreen(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, value ? (byte)1 : (byte)0);
            }
        }
        private partial void Start()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so Start cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_Cesium3DTileset_Start(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }
        private partial void Update()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so Update cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_Cesium3DTileset_Update(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }
        private partial void OnValidate()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so OnValidate cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_Cesium3DTileset_OnValidate(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }
        private partial void OnEnable()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so OnEnable cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_Cesium3DTileset_OnEnable(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }
        private partial void OnDisable()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so OnDisable cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_Cesium3DTileset_OnDisable(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }
        public partial void RecreateTileset()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so RecreateTileset cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_Cesium3DTileset_RecreateTileset(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }
        public partial void FocusTileset()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so FocusTileset cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_Cesium3DTileset_FocusTileset(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }

        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static extern System.IntPtr DotNet_CesiumForUnity_Cesium3DTileset_CreateImplementation(System.IntPtr thiz);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static extern void DotNet_CesiumForUnity_Cesium3DTileset_DestroyImplementation(System.IntPtr implementation);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern float DotNet_CesiumForUnity_Cesium3DTileset_ComputeLoadProgress(System.IntPtr thiz, CesiumForUnity.Cesium3DTileset.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_Cesium3DTileset_SetShowCreditsOnScreen(System.IntPtr thiz, CesiumForUnity.Cesium3DTileset.ImplementationHandle implementation, byte value);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_Cesium3DTileset_Start(System.IntPtr thiz, CesiumForUnity.Cesium3DTileset.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_Cesium3DTileset_Update(System.IntPtr thiz, CesiumForUnity.Cesium3DTileset.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_Cesium3DTileset_OnValidate(System.IntPtr thiz, CesiumForUnity.Cesium3DTileset.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_Cesium3DTileset_OnEnable(System.IntPtr thiz, CesiumForUnity.Cesium3DTileset.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_Cesium3DTileset_OnDisable(System.IntPtr thiz, CesiumForUnity.Cesium3DTileset.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_Cesium3DTileset_RecreateTileset(System.IntPtr thiz, CesiumForUnity.Cesium3DTileset.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_Cesium3DTileset_FocusTileset(System.IntPtr thiz, CesiumForUnity.Cesium3DTileset.ImplementationHandle implementation);
    }
}
#endif
#if !UNITY_EDITOR && UNITY_WSA
using Microsoft.Win32.SafeHandles;
using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace CesiumForUnity
{
    public partial class Cesium3DTileset : System.IDisposable
    {
        internal class ImplementationHandle : SafeHandleZeroOrMinusOneIsInvalid
        {
            public ImplementationHandle(Cesium3DTileset managed) : base(true)
            {
                SetHandle(DotNet_CesiumForUnity_Cesium3DTileset_CreateImplementation(Reinterop.ObjectHandleUtility.CreateHandle(managed)));
            }

            [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
            protected override bool ReleaseHandle()
            {
                DotNet_CesiumForUnity_Cesium3DTileset_DestroyImplementation(this.handle);
                return true;
            }
        }

        [System.NonSerialized]
        private ImplementationHandle _implementation = null;

        internal ImplementationHandle NativeImplementation
        {
            get { return _implementation; }
        }

        private void CreateImplementation()
        {
            Reinterop.ReinteropInitializer.Initialize();
            System.Diagnostics.Debug.Assert(this._implementation == null, "Implementation is already created. Be sure to call CreateImplementation only once.");
            this._implementation = new ImplementationHandle(this);
        }
        protected void DisposeImplementation()
        {
            if (this._implementation != null && !this._implementation.IsInvalid)
                this._implementation.Dispose();
            this._implementation = null;
        }
        public Cesium3DTileset()
        {
            CreateImplementation();
        }
        public partial float ComputeLoadProgress()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so ComputeLoadProgress cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_Cesium3DTileset_ComputeLoadProgress(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
                return result;
            }
        }
        private partial void SetShowCreditsOnScreen(bool value)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so SetShowCreditsOnScreen cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_Cesium3DTileset_SetShowCreditsOnScreen(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, value ? (byte)1 : (byte)0);
            }
        }
        private partial void Start()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so Start cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_Cesium3DTileset_Start(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }
        private partial void Update()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so Update cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_Cesium3DTileset_Update(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }
        private partial void OnValidate()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so OnValidate cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_Cesium3DTileset_OnValidate(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }
        private partial void OnEnable()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so OnEnable cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_Cesium3DTileset_OnEnable(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }
        private partial void OnDisable()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so OnDisable cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_Cesium3DTileset_OnDisable(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }
        public partial void RecreateTileset()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so RecreateTileset cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_Cesium3DTileset_RecreateTileset(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }
        public partial void FocusTileset()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so FocusTileset cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_Cesium3DTileset_FocusTileset(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }

        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static extern System.IntPtr DotNet_CesiumForUnity_Cesium3DTileset_CreateImplementation(System.IntPtr thiz);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static extern void DotNet_CesiumForUnity_Cesium3DTileset_DestroyImplementation(System.IntPtr implementation);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern float DotNet_CesiumForUnity_Cesium3DTileset_ComputeLoadProgress(System.IntPtr thiz, CesiumForUnity.Cesium3DTileset.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_Cesium3DTileset_SetShowCreditsOnScreen(System.IntPtr thiz, CesiumForUnity.Cesium3DTileset.ImplementationHandle implementation, byte value);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_Cesium3DTileset_Start(System.IntPtr thiz, CesiumForUnity.Cesium3DTileset.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_Cesium3DTileset_Update(System.IntPtr thiz, CesiumForUnity.Cesium3DTileset.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_Cesium3DTileset_OnValidate(System.IntPtr thiz, CesiumForUnity.Cesium3DTileset.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_Cesium3DTileset_OnEnable(System.IntPtr thiz, CesiumForUnity.Cesium3DTileset.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_Cesium3DTileset_OnDisable(System.IntPtr thiz, CesiumForUnity.Cesium3DTileset.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_Cesium3DTileset_RecreateTileset(System.IntPtr thiz, CesiumForUnity.Cesium3DTileset.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_Cesium3DTileset_FocusTileset(System.IntPtr thiz, CesiumForUnity.Cesium3DTileset.ImplementationHandle implementation);
    }
}
#endif
#if !UNITY_EDITOR && UNITY_STANDALONE_WIN
using Microsoft.Win32.SafeHandles;
using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace CesiumForUnity
{
    public partial class Cesium3DTileset : System.IDisposable
    {
        internal class ImplementationHandle : SafeHandleZeroOrMinusOneIsInvalid
        {
            public ImplementationHandle(Cesium3DTileset managed) : base(true)
            {
                SetHandle(DotNet_CesiumForUnity_Cesium3DTileset_CreateImplementation(Reinterop.ObjectHandleUtility.CreateHandle(managed)));
            }

            [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
            protected override bool ReleaseHandle()
            {
                DotNet_CesiumForUnity_Cesium3DTileset_DestroyImplementation(this.handle);
                return true;
            }
        }

        [System.NonSerialized]
        private ImplementationHandle _implementation = null;

        internal ImplementationHandle NativeImplementation
        {
            get { return _implementation; }
        }

        private void CreateImplementation()
        {
            Reinterop.ReinteropInitializer.Initialize();
            System.Diagnostics.Debug.Assert(this._implementation == null, "Implementation is already created. Be sure to call CreateImplementation only once.");
            this._implementation = new ImplementationHandle(this);
        }
        protected void DisposeImplementation()
        {
            if (this._implementation != null && !this._implementation.IsInvalid)
                this._implementation.Dispose();
            this._implementation = null;
        }
        public Cesium3DTileset()
        {
            CreateImplementation();
        }
        public partial float ComputeLoadProgress()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so ComputeLoadProgress cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_Cesium3DTileset_ComputeLoadProgress(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
                return result;
            }
        }
        private partial void SetShowCreditsOnScreen(bool value)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so SetShowCreditsOnScreen cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_Cesium3DTileset_SetShowCreditsOnScreen(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, value ? (byte)1 : (byte)0);
            }
        }
        private partial void Start()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so Start cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_Cesium3DTileset_Start(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }
        private partial void Update()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so Update cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_Cesium3DTileset_Update(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }
        private partial void OnValidate()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so OnValidate cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_Cesium3DTileset_OnValidate(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }
        private partial void OnEnable()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so OnEnable cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_Cesium3DTileset_OnEnable(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }
        private partial void OnDisable()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so OnDisable cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_Cesium3DTileset_OnDisable(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }
        public partial void RecreateTileset()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so RecreateTileset cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_Cesium3DTileset_RecreateTileset(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }
        public partial void FocusTileset()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so FocusTileset cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_Cesium3DTileset_FocusTileset(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }

        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static extern System.IntPtr DotNet_CesiumForUnity_Cesium3DTileset_CreateImplementation(System.IntPtr thiz);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static extern void DotNet_CesiumForUnity_Cesium3DTileset_DestroyImplementation(System.IntPtr implementation);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern float DotNet_CesiumForUnity_Cesium3DTileset_ComputeLoadProgress(System.IntPtr thiz, CesiumForUnity.Cesium3DTileset.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_Cesium3DTileset_SetShowCreditsOnScreen(System.IntPtr thiz, CesiumForUnity.Cesium3DTileset.ImplementationHandle implementation, byte value);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_Cesium3DTileset_Start(System.IntPtr thiz, CesiumForUnity.Cesium3DTileset.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_Cesium3DTileset_Update(System.IntPtr thiz, CesiumForUnity.Cesium3DTileset.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_Cesium3DTileset_OnValidate(System.IntPtr thiz, CesiumForUnity.Cesium3DTileset.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_Cesium3DTileset_OnEnable(System.IntPtr thiz, CesiumForUnity.Cesium3DTileset.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_Cesium3DTileset_OnDisable(System.IntPtr thiz, CesiumForUnity.Cesium3DTileset.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_Cesium3DTileset_RecreateTileset(System.IntPtr thiz, CesiumForUnity.Cesium3DTileset.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_Cesium3DTileset_FocusTileset(System.IntPtr thiz, CesiumForUnity.Cesium3DTileset.ImplementationHandle implementation);
    }
}
#endif
#if !UNITY_EDITOR && UNITY_ANDROID
using Microsoft.Win32.SafeHandles;
using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace CesiumForUnity
{
    public partial class Cesium3DTileset : System.IDisposable
    {
        internal class ImplementationHandle : SafeHandleZeroOrMinusOneIsInvalid
        {
            public ImplementationHandle(Cesium3DTileset managed) : base(true)
            {
                SetHandle(DotNet_CesiumForUnity_Cesium3DTileset_CreateImplementation(Reinterop.ObjectHandleUtility.CreateHandle(managed)));
            }

            [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
            protected override bool ReleaseHandle()
            {
                DotNet_CesiumForUnity_Cesium3DTileset_DestroyImplementation(this.handle);
                return true;
            }
        }

        [System.NonSerialized]
        private ImplementationHandle _implementation = null;

        internal ImplementationHandle NativeImplementation
        {
            get { return _implementation; }
        }

        private void CreateImplementation()
        {
            Reinterop.ReinteropInitializer.Initialize();
            System.Diagnostics.Debug.Assert(this._implementation == null, "Implementation is already created. Be sure to call CreateImplementation only once.");
            this._implementation = new ImplementationHandle(this);
        }
        protected void DisposeImplementation()
        {
            if (this._implementation != null && !this._implementation.IsInvalid)
                this._implementation.Dispose();
            this._implementation = null;
        }
        public Cesium3DTileset()
        {
            CreateImplementation();
        }
        public partial float ComputeLoadProgress()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so ComputeLoadProgress cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_Cesium3DTileset_ComputeLoadProgress(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
                return result;
            }
        }
        private partial void SetShowCreditsOnScreen(bool value)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so SetShowCreditsOnScreen cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_Cesium3DTileset_SetShowCreditsOnScreen(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, value ? (byte)1 : (byte)0);
            }
        }
        private partial void Start()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so Start cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_Cesium3DTileset_Start(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }
        private partial void Update()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so Update cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_Cesium3DTileset_Update(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }
        private partial void OnValidate()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so OnValidate cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_Cesium3DTileset_OnValidate(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }
        private partial void OnEnable()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so OnEnable cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_Cesium3DTileset_OnEnable(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }
        private partial void OnDisable()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so OnDisable cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_Cesium3DTileset_OnDisable(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }
        public partial void RecreateTileset()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so RecreateTileset cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_Cesium3DTileset_RecreateTileset(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }
        public partial void FocusTileset()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so FocusTileset cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_Cesium3DTileset_FocusTileset(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }

        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static extern System.IntPtr DotNet_CesiumForUnity_Cesium3DTileset_CreateImplementation(System.IntPtr thiz);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static extern void DotNet_CesiumForUnity_Cesium3DTileset_DestroyImplementation(System.IntPtr implementation);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern float DotNet_CesiumForUnity_Cesium3DTileset_ComputeLoadProgress(System.IntPtr thiz, CesiumForUnity.Cesium3DTileset.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_Cesium3DTileset_SetShowCreditsOnScreen(System.IntPtr thiz, CesiumForUnity.Cesium3DTileset.ImplementationHandle implementation, byte value);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_Cesium3DTileset_Start(System.IntPtr thiz, CesiumForUnity.Cesium3DTileset.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_Cesium3DTileset_Update(System.IntPtr thiz, CesiumForUnity.Cesium3DTileset.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_Cesium3DTileset_OnValidate(System.IntPtr thiz, CesiumForUnity.Cesium3DTileset.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_Cesium3DTileset_OnEnable(System.IntPtr thiz, CesiumForUnity.Cesium3DTileset.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_Cesium3DTileset_OnDisable(System.IntPtr thiz, CesiumForUnity.Cesium3DTileset.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_Cesium3DTileset_RecreateTileset(System.IntPtr thiz, CesiumForUnity.Cesium3DTileset.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_Cesium3DTileset_FocusTileset(System.IntPtr thiz, CesiumForUnity.Cesium3DTileset.ImplementationHandle implementation);
    }
}
#endif
