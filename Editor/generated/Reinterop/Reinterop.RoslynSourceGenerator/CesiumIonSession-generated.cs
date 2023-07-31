#if UNITY_EDITOR_OSX
using Microsoft.Win32.SafeHandles;
using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace CesiumForUnity
{
    public partial class CesiumIonSession : System.IDisposable
    {
        internal class ImplementationHandle : SafeHandleZeroOrMinusOneIsInvalid
        {
            public ImplementationHandle(CesiumIonSession managed) : base(true)
            {
                SetHandle(DotNet_CesiumForUnity_CesiumIonSession_CreateImplementation(Reinterop.ObjectHandleUtility.CreateHandle(managed)));
            }

            [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
            protected override bool ReleaseHandle()
            {
                DotNet_CesiumForUnity_CesiumIonSession_DestroyImplementation(this.handle);
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
        public CesiumIonSession()
        {
            CreateImplementation();
        }
        public partial bool IsConnected()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so IsConnected cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumIonSession_IsConnected(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
                return result != 0;
            }
        }
        public partial bool IsConnecting()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so IsConnecting cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumIonSession_IsConnecting(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
                return result != 0;
            }
        }
        public partial bool IsResuming()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so IsResuming cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumIonSession_IsResuming(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
                return result != 0;
            }
        }
        public partial bool IsProfileLoaded()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so IsProfileLoaded cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumIonSession_IsProfileLoaded(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
                return result != 0;
            }
        }
        public partial bool IsLoadingProfile()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so IsLoadingProfile cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumIonSession_IsLoadingProfile(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
                return result != 0;
            }
        }
        public partial bool IsAssetListLoaded()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so IsAssetListLoaded cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumIonSession_IsAssetListLoaded(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
                return result != 0;
            }
        }
        public partial bool IsLoadingAssetList()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so IsLoadingAssetList cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumIonSession_IsLoadingAssetList(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
                return result != 0;
            }
        }
        public partial bool IsTokenListLoaded()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so IsTokenListLoaded cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumIonSession_IsTokenListLoaded(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
                return result != 0;
            }
        }
        public partial bool IsLoadingTokenList()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so IsLoadingTokenList cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumIonSession_IsLoadingTokenList(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
                return result != 0;
            }
        }
        public partial void Connect()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so Connect cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_CesiumIonSession_Connect(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }
        public partial void Resume()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so Resume cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_CesiumIonSession_Resume(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }
        public partial void Disconnect()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so Disconnect cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_CesiumIonSession_Disconnect(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }
        public partial string GetProfileUsername()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetProfileUsername cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumIonSession_GetProfileUsername(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
                return (string)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        public partial string GetAuthorizeUrl()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetAuthorizeUrl cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumIonSession_GetAuthorizeUrl(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
                return (string)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        public partial void Tick()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so Tick cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_CesiumIonSession_Tick(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }
        public partial void RefreshProfile()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so RefreshProfile cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_CesiumIonSession_RefreshProfile(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }
        public partial void RefreshTokens()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so RefreshTokens cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_CesiumIonSession_RefreshTokens(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }
        public partial void RefreshAssets()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so RefreshAssets cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_CesiumIonSession_RefreshAssets(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }

        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static extern System.IntPtr DotNet_CesiumForUnity_CesiumIonSession_CreateImplementation(System.IntPtr thiz);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static extern void DotNet_CesiumForUnity_CesiumIonSession_DestroyImplementation(System.IntPtr implementation);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern byte DotNet_CesiumForUnity_CesiumIonSession_IsConnected(System.IntPtr thiz, CesiumForUnity.CesiumIonSession.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern byte DotNet_CesiumForUnity_CesiumIonSession_IsConnecting(System.IntPtr thiz, CesiumForUnity.CesiumIonSession.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern byte DotNet_CesiumForUnity_CesiumIonSession_IsResuming(System.IntPtr thiz, CesiumForUnity.CesiumIonSession.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern byte DotNet_CesiumForUnity_CesiumIonSession_IsProfileLoaded(System.IntPtr thiz, CesiumForUnity.CesiumIonSession.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern byte DotNet_CesiumForUnity_CesiumIonSession_IsLoadingProfile(System.IntPtr thiz, CesiumForUnity.CesiumIonSession.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern byte DotNet_CesiumForUnity_CesiumIonSession_IsAssetListLoaded(System.IntPtr thiz, CesiumForUnity.CesiumIonSession.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern byte DotNet_CesiumForUnity_CesiumIonSession_IsLoadingAssetList(System.IntPtr thiz, CesiumForUnity.CesiumIonSession.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern byte DotNet_CesiumForUnity_CesiumIonSession_IsTokenListLoaded(System.IntPtr thiz, CesiumForUnity.CesiumIonSession.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern byte DotNet_CesiumForUnity_CesiumIonSession_IsLoadingTokenList(System.IntPtr thiz, CesiumForUnity.CesiumIonSession.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_CesiumIonSession_Connect(System.IntPtr thiz, CesiumForUnity.CesiumIonSession.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_CesiumIonSession_Resume(System.IntPtr thiz, CesiumForUnity.CesiumIonSession.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_CesiumIonSession_Disconnect(System.IntPtr thiz, CesiumForUnity.CesiumIonSession.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_CesiumIonSession_GetProfileUsername(System.IntPtr thiz, CesiumForUnity.CesiumIonSession.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_CesiumIonSession_GetAuthorizeUrl(System.IntPtr thiz, CesiumForUnity.CesiumIonSession.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_CesiumIonSession_Tick(System.IntPtr thiz, CesiumForUnity.CesiumIonSession.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_CesiumIonSession_RefreshProfile(System.IntPtr thiz, CesiumForUnity.CesiumIonSession.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_CesiumIonSession_RefreshTokens(System.IntPtr thiz, CesiumForUnity.CesiumIonSession.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_CesiumIonSession_RefreshAssets(System.IntPtr thiz, CesiumForUnity.CesiumIonSession.ImplementationHandle implementation);
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
    public partial class CesiumIonSession : System.IDisposable
    {
        internal class ImplementationHandle : SafeHandleZeroOrMinusOneIsInvalid
        {
            public ImplementationHandle(CesiumIonSession managed) : base(true)
            {
                SetHandle(DotNet_CesiumForUnity_CesiumIonSession_CreateImplementation(Reinterop.ObjectHandleUtility.CreateHandle(managed)));
            }

            [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
            protected override bool ReleaseHandle()
            {
                DotNet_CesiumForUnity_CesiumIonSession_DestroyImplementation(this.handle);
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
        public CesiumIonSession()
        {
            CreateImplementation();
        }
        public partial bool IsConnected()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so IsConnected cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumIonSession_IsConnected(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
                return result != 0;
            }
        }
        public partial bool IsConnecting()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so IsConnecting cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumIonSession_IsConnecting(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
                return result != 0;
            }
        }
        public partial bool IsResuming()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so IsResuming cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumIonSession_IsResuming(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
                return result != 0;
            }
        }
        public partial bool IsProfileLoaded()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so IsProfileLoaded cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumIonSession_IsProfileLoaded(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
                return result != 0;
            }
        }
        public partial bool IsLoadingProfile()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so IsLoadingProfile cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumIonSession_IsLoadingProfile(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
                return result != 0;
            }
        }
        public partial bool IsAssetListLoaded()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so IsAssetListLoaded cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumIonSession_IsAssetListLoaded(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
                return result != 0;
            }
        }
        public partial bool IsLoadingAssetList()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so IsLoadingAssetList cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumIonSession_IsLoadingAssetList(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
                return result != 0;
            }
        }
        public partial bool IsTokenListLoaded()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so IsTokenListLoaded cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumIonSession_IsTokenListLoaded(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
                return result != 0;
            }
        }
        public partial bool IsLoadingTokenList()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so IsLoadingTokenList cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumIonSession_IsLoadingTokenList(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
                return result != 0;
            }
        }
        public partial void Connect()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so Connect cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_CesiumIonSession_Connect(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }
        public partial void Resume()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so Resume cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_CesiumIonSession_Resume(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }
        public partial void Disconnect()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so Disconnect cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_CesiumIonSession_Disconnect(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }
        public partial string GetProfileUsername()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetProfileUsername cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumIonSession_GetProfileUsername(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
                return (string)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        public partial string GetAuthorizeUrl()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetAuthorizeUrl cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumIonSession_GetAuthorizeUrl(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
                return (string)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        public partial void Tick()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so Tick cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_CesiumIonSession_Tick(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }
        public partial void RefreshProfile()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so RefreshProfile cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_CesiumIonSession_RefreshProfile(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }
        public partial void RefreshTokens()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so RefreshTokens cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_CesiumIonSession_RefreshTokens(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }
        public partial void RefreshAssets()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so RefreshAssets cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_CesiumIonSession_RefreshAssets(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }

        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static extern System.IntPtr DotNet_CesiumForUnity_CesiumIonSession_CreateImplementation(System.IntPtr thiz);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static extern void DotNet_CesiumForUnity_CesiumIonSession_DestroyImplementation(System.IntPtr implementation);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern byte DotNet_CesiumForUnity_CesiumIonSession_IsConnected(System.IntPtr thiz, CesiumForUnity.CesiumIonSession.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern byte DotNet_CesiumForUnity_CesiumIonSession_IsConnecting(System.IntPtr thiz, CesiumForUnity.CesiumIonSession.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern byte DotNet_CesiumForUnity_CesiumIonSession_IsResuming(System.IntPtr thiz, CesiumForUnity.CesiumIonSession.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern byte DotNet_CesiumForUnity_CesiumIonSession_IsProfileLoaded(System.IntPtr thiz, CesiumForUnity.CesiumIonSession.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern byte DotNet_CesiumForUnity_CesiumIonSession_IsLoadingProfile(System.IntPtr thiz, CesiumForUnity.CesiumIonSession.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern byte DotNet_CesiumForUnity_CesiumIonSession_IsAssetListLoaded(System.IntPtr thiz, CesiumForUnity.CesiumIonSession.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern byte DotNet_CesiumForUnity_CesiumIonSession_IsLoadingAssetList(System.IntPtr thiz, CesiumForUnity.CesiumIonSession.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern byte DotNet_CesiumForUnity_CesiumIonSession_IsTokenListLoaded(System.IntPtr thiz, CesiumForUnity.CesiumIonSession.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern byte DotNet_CesiumForUnity_CesiumIonSession_IsLoadingTokenList(System.IntPtr thiz, CesiumForUnity.CesiumIonSession.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_CesiumIonSession_Connect(System.IntPtr thiz, CesiumForUnity.CesiumIonSession.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_CesiumIonSession_Resume(System.IntPtr thiz, CesiumForUnity.CesiumIonSession.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_CesiumIonSession_Disconnect(System.IntPtr thiz, CesiumForUnity.CesiumIonSession.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_CesiumIonSession_GetProfileUsername(System.IntPtr thiz, CesiumForUnity.CesiumIonSession.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_CesiumIonSession_GetAuthorizeUrl(System.IntPtr thiz, CesiumForUnity.CesiumIonSession.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_CesiumIonSession_Tick(System.IntPtr thiz, CesiumForUnity.CesiumIonSession.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_CesiumIonSession_RefreshProfile(System.IntPtr thiz, CesiumForUnity.CesiumIonSession.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_CesiumIonSession_RefreshTokens(System.IntPtr thiz, CesiumForUnity.CesiumIonSession.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_CesiumIonSession_RefreshAssets(System.IntPtr thiz, CesiumForUnity.CesiumIonSession.ImplementationHandle implementation);
    }
}
#endif
