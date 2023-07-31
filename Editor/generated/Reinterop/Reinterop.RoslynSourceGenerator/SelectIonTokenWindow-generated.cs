#if UNITY_EDITOR_OSX
using Microsoft.Win32.SafeHandles;
using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace CesiumForUnity
{
    public partial class SelectIonTokenWindow : System.IDisposable
    {
        internal class ImplementationHandle : SafeHandleZeroOrMinusOneIsInvalid
        {
            public ImplementationHandle(SelectIonTokenWindow managed) : base(true)
            {
                SetHandle(DotNet_CesiumForUnity_SelectIonTokenWindow_CreateImplementation(Reinterop.ObjectHandleUtility.CreateHandle(managed)));
            }

            [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
            protected override bool ReleaseHandle()
            {
                DotNet_CesiumForUnity_SelectIonTokenWindow_DestroyImplementation(this.handle);
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
        public void Dispose()
        {
            
            this.DisposeImplementation();
        }
        public SelectIonTokenWindow()
        {
            CreateImplementation();
        }
        public partial void RefreshTokens()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so RefreshTokens cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_SelectIonTokenWindow_RefreshTokens(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }
        private partial void CreateToken()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so CreateToken cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_SelectIonTokenWindow_CreateToken(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }
        private partial void UseExistingToken()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so UseExistingToken cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_SelectIonTokenWindow_UseExistingToken(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }
        private partial void SpecifyToken()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so SpecifyToken cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_SelectIonTokenWindow_SpecifyToken(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }

        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static extern System.IntPtr DotNet_CesiumForUnity_SelectIonTokenWindow_CreateImplementation(System.IntPtr thiz);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static extern void DotNet_CesiumForUnity_SelectIonTokenWindow_DestroyImplementation(System.IntPtr implementation);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_SelectIonTokenWindow_RefreshTokens(System.IntPtr thiz, CesiumForUnity.SelectIonTokenWindow.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_SelectIonTokenWindow_CreateToken(System.IntPtr thiz, CesiumForUnity.SelectIonTokenWindow.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_SelectIonTokenWindow_UseExistingToken(System.IntPtr thiz, CesiumForUnity.SelectIonTokenWindow.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_SelectIonTokenWindow_SpecifyToken(System.IntPtr thiz, CesiumForUnity.SelectIonTokenWindow.ImplementationHandle implementation);
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
    public partial class SelectIonTokenWindow : System.IDisposable
    {
        internal class ImplementationHandle : SafeHandleZeroOrMinusOneIsInvalid
        {
            public ImplementationHandle(SelectIonTokenWindow managed) : base(true)
            {
                SetHandle(DotNet_CesiumForUnity_SelectIonTokenWindow_CreateImplementation(Reinterop.ObjectHandleUtility.CreateHandle(managed)));
            }

            [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
            protected override bool ReleaseHandle()
            {
                DotNet_CesiumForUnity_SelectIonTokenWindow_DestroyImplementation(this.handle);
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
        public void Dispose()
        {
            
            this.DisposeImplementation();
        }
        public SelectIonTokenWindow()
        {
            CreateImplementation();
        }
        public partial void RefreshTokens()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so RefreshTokens cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_SelectIonTokenWindow_RefreshTokens(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }
        private partial void CreateToken()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so CreateToken cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_SelectIonTokenWindow_CreateToken(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }
        private partial void UseExistingToken()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so UseExistingToken cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_SelectIonTokenWindow_UseExistingToken(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }
        private partial void SpecifyToken()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so SpecifyToken cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_SelectIonTokenWindow_SpecifyToken(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }

        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static extern System.IntPtr DotNet_CesiumForUnity_SelectIonTokenWindow_CreateImplementation(System.IntPtr thiz);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static extern void DotNet_CesiumForUnity_SelectIonTokenWindow_DestroyImplementation(System.IntPtr implementation);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_SelectIonTokenWindow_RefreshTokens(System.IntPtr thiz, CesiumForUnity.SelectIonTokenWindow.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_SelectIonTokenWindow_CreateToken(System.IntPtr thiz, CesiumForUnity.SelectIonTokenWindow.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_SelectIonTokenWindow_UseExistingToken(System.IntPtr thiz, CesiumForUnity.SelectIonTokenWindow.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_SelectIonTokenWindow_SpecifyToken(System.IntPtr thiz, CesiumForUnity.SelectIonTokenWindow.ImplementationHandle implementation);
    }
}
#endif
