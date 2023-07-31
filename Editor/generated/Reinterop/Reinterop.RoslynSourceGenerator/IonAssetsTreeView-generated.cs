#if UNITY_EDITOR_OSX
using Microsoft.Win32.SafeHandles;
using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace CesiumForUnity
{
    public partial class IonAssetsTreeView : System.IDisposable
    {
        internal class ImplementationHandle : SafeHandleZeroOrMinusOneIsInvalid
        {
            public ImplementationHandle(IonAssetsTreeView managed) : base(true)
            {
                SetHandle(DotNet_CesiumForUnity_IonAssetsTreeView_CreateImplementation(Reinterop.ObjectHandleUtility.CreateHandle(managed)));
            }

            [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
            protected override bool ReleaseHandle()
            {
                DotNet_CesiumForUnity_IonAssetsTreeView_DestroyImplementation(this.handle);
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
        public partial int GetAssetsCount()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetAssetsCount cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_IonAssetsTreeView_GetAssetsCount(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
                return result;
            }
        }
        private partial string GetAssetName(int index)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetAssetName cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_IonAssetsTreeView_GetAssetName(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, index);
                return (string)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        private partial string GetAssetType(int index)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetAssetType cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_IonAssetsTreeView_GetAssetType(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, index);
                return (string)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        private partial long GetAssetID(int index)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetAssetID cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_IonAssetsTreeView_GetAssetID(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, index);
                return result;
            }
        }
        private partial string GetAssetDescription(int index)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetAssetDescription cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_IonAssetsTreeView_GetAssetDescription(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, index);
                return (string)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        private partial string GetAssetAttribution(int index)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetAssetAttribution cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_IonAssetsTreeView_GetAssetAttribution(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, index);
                return (string)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        private partial void CellGUI(UnityEngine.Rect cellRect, int assetIndex, CesiumForUnity.IonAssetsColumn column)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so CellGUI cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_IonAssetsTreeView_CellGUI(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, &cellRect, assetIndex, column);
            }
        }
        public partial void Refresh()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so Refresh cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_IonAssetsTreeView_Refresh(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }
        public partial void AddAssetToLevel(int index)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so AddAssetToLevel cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_IonAssetsTreeView_AddAssetToLevel(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, index);
            }
        }
        public partial void AddOverlayToTerrain(int index)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so AddOverlayToTerrain cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_IonAssetsTreeView_AddOverlayToTerrain(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, index);
            }
        }

        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static extern System.IntPtr DotNet_CesiumForUnity_IonAssetsTreeView_CreateImplementation(System.IntPtr thiz);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static extern void DotNet_CesiumForUnity_IonAssetsTreeView_DestroyImplementation(System.IntPtr implementation);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern int DotNet_CesiumForUnity_IonAssetsTreeView_GetAssetsCount(System.IntPtr thiz, CesiumForUnity.IonAssetsTreeView.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_IonAssetsTreeView_GetAssetName(System.IntPtr thiz, CesiumForUnity.IonAssetsTreeView.ImplementationHandle implementation, int index);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_IonAssetsTreeView_GetAssetType(System.IntPtr thiz, CesiumForUnity.IonAssetsTreeView.ImplementationHandle implementation, int index);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern long DotNet_CesiumForUnity_IonAssetsTreeView_GetAssetID(System.IntPtr thiz, CesiumForUnity.IonAssetsTreeView.ImplementationHandle implementation, int index);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_IonAssetsTreeView_GetAssetDescription(System.IntPtr thiz, CesiumForUnity.IonAssetsTreeView.ImplementationHandle implementation, int index);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_IonAssetsTreeView_GetAssetAttribution(System.IntPtr thiz, CesiumForUnity.IonAssetsTreeView.ImplementationHandle implementation, int index);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_IonAssetsTreeView_CellGUI(System.IntPtr thiz, CesiumForUnity.IonAssetsTreeView.ImplementationHandle implementation, UnityEngine.Rect* cellRect, int assetIndex, CesiumForUnity.IonAssetsColumn column);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_IonAssetsTreeView_Refresh(System.IntPtr thiz, CesiumForUnity.IonAssetsTreeView.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_IonAssetsTreeView_AddAssetToLevel(System.IntPtr thiz, CesiumForUnity.IonAssetsTreeView.ImplementationHandle implementation, int index);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_IonAssetsTreeView_AddOverlayToTerrain(System.IntPtr thiz, CesiumForUnity.IonAssetsTreeView.ImplementationHandle implementation, int index);
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
    public partial class IonAssetsTreeView : System.IDisposable
    {
        internal class ImplementationHandle : SafeHandleZeroOrMinusOneIsInvalid
        {
            public ImplementationHandle(IonAssetsTreeView managed) : base(true)
            {
                SetHandle(DotNet_CesiumForUnity_IonAssetsTreeView_CreateImplementation(Reinterop.ObjectHandleUtility.CreateHandle(managed)));
            }

            [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
            protected override bool ReleaseHandle()
            {
                DotNet_CesiumForUnity_IonAssetsTreeView_DestroyImplementation(this.handle);
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
        public partial int GetAssetsCount()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetAssetsCount cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_IonAssetsTreeView_GetAssetsCount(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
                return result;
            }
        }
        private partial string GetAssetName(int index)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetAssetName cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_IonAssetsTreeView_GetAssetName(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, index);
                return (string)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        private partial string GetAssetType(int index)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetAssetType cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_IonAssetsTreeView_GetAssetType(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, index);
                return (string)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        private partial long GetAssetID(int index)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetAssetID cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_IonAssetsTreeView_GetAssetID(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, index);
                return result;
            }
        }
        private partial string GetAssetDescription(int index)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetAssetDescription cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_IonAssetsTreeView_GetAssetDescription(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, index);
                return (string)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        private partial string GetAssetAttribution(int index)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetAssetAttribution cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_IonAssetsTreeView_GetAssetAttribution(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, index);
                return (string)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        private partial void CellGUI(UnityEngine.Rect cellRect, int assetIndex, CesiumForUnity.IonAssetsColumn column)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so CellGUI cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_IonAssetsTreeView_CellGUI(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, &cellRect, assetIndex, column);
            }
        }
        public partial void Refresh()
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so Refresh cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_IonAssetsTreeView_Refresh(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation);
            }
        }
        public partial void AddAssetToLevel(int index)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so AddAssetToLevel cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_IonAssetsTreeView_AddAssetToLevel(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, index);
            }
        }
        public partial void AddOverlayToTerrain(int index)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so AddOverlayToTerrain cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                DotNet_CesiumForUnity_IonAssetsTreeView_AddOverlayToTerrain(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, index);
            }
        }

        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static extern System.IntPtr DotNet_CesiumForUnity_IonAssetsTreeView_CreateImplementation(System.IntPtr thiz);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static extern void DotNet_CesiumForUnity_IonAssetsTreeView_DestroyImplementation(System.IntPtr implementation);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern int DotNet_CesiumForUnity_IonAssetsTreeView_GetAssetsCount(System.IntPtr thiz, CesiumForUnity.IonAssetsTreeView.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_IonAssetsTreeView_GetAssetName(System.IntPtr thiz, CesiumForUnity.IonAssetsTreeView.ImplementationHandle implementation, int index);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_IonAssetsTreeView_GetAssetType(System.IntPtr thiz, CesiumForUnity.IonAssetsTreeView.ImplementationHandle implementation, int index);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern long DotNet_CesiumForUnity_IonAssetsTreeView_GetAssetID(System.IntPtr thiz, CesiumForUnity.IonAssetsTreeView.ImplementationHandle implementation, int index);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_IonAssetsTreeView_GetAssetDescription(System.IntPtr thiz, CesiumForUnity.IonAssetsTreeView.ImplementationHandle implementation, int index);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_IonAssetsTreeView_GetAssetAttribution(System.IntPtr thiz, CesiumForUnity.IonAssetsTreeView.ImplementationHandle implementation, int index);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_IonAssetsTreeView_CellGUI(System.IntPtr thiz, CesiumForUnity.IonAssetsTreeView.ImplementationHandle implementation, UnityEngine.Rect* cellRect, int assetIndex, CesiumForUnity.IonAssetsColumn column);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_IonAssetsTreeView_Refresh(System.IntPtr thiz, CesiumForUnity.IonAssetsTreeView.ImplementationHandle implementation);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_IonAssetsTreeView_AddAssetToLevel(System.IntPtr thiz, CesiumForUnity.IonAssetsTreeView.ImplementationHandle implementation, int index);
        [DllImport("CesiumForUnityNative-Editor", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_IonAssetsTreeView_AddOverlayToTerrain(System.IntPtr thiz, CesiumForUnity.IonAssetsTreeView.ImplementationHandle implementation, int index);
    }
}
#endif
