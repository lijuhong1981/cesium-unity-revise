#if UNITY_EDITOR_OSX
using Microsoft.Win32.SafeHandles;
using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace CesiumForUnity
{
    public partial class CesiumEditorWindow : System.IDisposable
    {
        internal class ImplementationHandle : SafeHandleZeroOrMinusOneIsInvalid
        {
            public ImplementationHandle(CesiumEditorWindow managed) : base(true)
            {
                SetHandle(DotNet_CesiumForUnity_CesiumEditorWindow_CreateImplementation(Reinterop.ObjectHandleUtility.CreateHandle(managed)));
            }

            [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
            protected override bool ReleaseHandle()
            {
                DotNet_CesiumForUnity_CesiumEditorWindow_DestroyImplementation(this.handle);
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
        public CesiumEditorWindow()
        {
            CreateImplementation();
        }
        private partial void AddAssetFromIon(string name, string tilesetName, long tilesetID, string overlayName, long overlayID)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so AddAssetFromIon cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_CesiumEditorWindow_AddAssetFromIon(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(name), Reinterop.ObjectHandleUtility.CreateHandle(tilesetName), tilesetID, Reinterop.ObjectHandleUtility.CreateHandle(overlayName), overlayID);
            }
        }

        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static extern System.IntPtr DotNet_CesiumForUnity_CesiumEditorWindow_CreateImplementation(System.IntPtr thiz);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static extern void DotNet_CesiumForUnity_CesiumEditorWindow_DestroyImplementation(System.IntPtr implementation);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_CesiumEditorWindow_AddAssetFromIon(System.IntPtr thiz, CesiumForUnity.CesiumEditorWindow.ImplementationHandle implementation, System.IntPtr name, System.IntPtr tilesetName, long tilesetID, System.IntPtr overlayName, long overlayID);
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
    public partial class CesiumEditorWindow : System.IDisposable
    {
        internal class ImplementationHandle : SafeHandleZeroOrMinusOneIsInvalid
        {
            public ImplementationHandle(CesiumEditorWindow managed) : base(true)
            {
                SetHandle(DotNet_CesiumForUnity_CesiumEditorWindow_CreateImplementation(Reinterop.ObjectHandleUtility.CreateHandle(managed)));
            }

            [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
            protected override bool ReleaseHandle()
            {
                DotNet_CesiumForUnity_CesiumEditorWindow_DestroyImplementation(this.handle);
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
        public CesiumEditorWindow()
        {
            CreateImplementation();
        }
        private partial void AddAssetFromIon(string name, string tilesetName, long tilesetID, string overlayName, long overlayID)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so AddAssetFromIon cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_CesiumEditorWindow_AddAssetFromIon(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(name), Reinterop.ObjectHandleUtility.CreateHandle(tilesetName), tilesetID, Reinterop.ObjectHandleUtility.CreateHandle(overlayName), overlayID);
            }
        }

        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static extern System.IntPtr DotNet_CesiumForUnity_CesiumEditorWindow_CreateImplementation(System.IntPtr thiz);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static extern void DotNet_CesiumForUnity_CesiumEditorWindow_DestroyImplementation(System.IntPtr implementation);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_CesiumEditorWindow_AddAssetFromIon(System.IntPtr thiz, CesiumForUnity.CesiumEditorWindow.ImplementationHandle implementation, System.IntPtr name, System.IntPtr tilesetName, long tilesetID, System.IntPtr overlayName, long overlayID);
    }
}
#endif
