#if UNITY_EDITOR_OSX
using Microsoft.Win32.SafeHandles;
using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace CesiumForUnity
{
    public partial class CesiumFeature : System.IDisposable
    {
        internal class ImplementationHandle : SafeHandleZeroOrMinusOneIsInvalid
        {
            public ImplementationHandle(CesiumFeature managed) : base(true)
            {
                SetHandle(DotNet_CesiumForUnity_CesiumFeature_CreateImplementation(Reinterop.ObjectHandleUtility.CreateHandle(managed)));
            }

            [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
            protected override bool ReleaseHandle()
            {
                DotNet_CesiumForUnity_CesiumFeature_DestroyImplementation(this.handle);
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
        public CesiumFeature()
        {
            CreateImplementation();
        }
        public partial sbyte GetInt8(string property, sbyte defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetInt8 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetInt8(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial byte GetUInt8(string property, byte defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetUInt8 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetUInt8(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial short GetInt16(string property, short defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetInt16 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetInt16(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial ushort GetUInt16(string property, ushort defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetUInt16 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetUInt16(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial int GetInt32(string property, int defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetInt32 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetInt32(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial uint GetUInt32(string property, uint defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetUInt32 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetUInt32(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial long GetInt64(string property, long defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetInt64 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetInt64(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial ulong GetUInt64(string property, ulong defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetUInt64 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetUInt64(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial float GetFloat32(string property, float defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetFloat32 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetFloat32(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial double GetFloat64(string property, double defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetFloat64 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetFloat64(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial bool GetBoolean(string property, bool defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetBoolean cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetBoolean(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue ? (byte)1 : (byte)0);
                return result != 0;
            }
        }
        public partial string GetString(string property, string defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetString cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetString(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), Reinterop.ObjectHandleUtility.CreateHandle(defaultValue));
                return (string)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        public partial sbyte GetComponentInt8(string property, int index, sbyte defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentInt8 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentInt8(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial byte GetComponentUInt8(string property, int index, byte defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentUInt8 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentUInt8(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial short GetComponentInt16(string property, int index, short defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentInt16 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentInt16(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial ushort GetComponentUInt16(string property, int index, ushort defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentUInt16 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentUInt16(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial int GetComponentInt32(string property, int index, int defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentInt32 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentInt32(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial uint GetComponentUInt32(string property, int index, uint defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentUInt32 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentUInt32(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial long GetComponentInt64(string property, int index, long defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentInt64 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentInt64(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial ulong GetComponentUInt64(string property, int index, ulong defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentUInt64 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentUInt64(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial float GetComponentFloat32(string property, int index, float defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentFloat32 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentFloat32(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial double GetComponentFloat64(string property, int index, double defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentFloat64 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentFloat64(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial bool GetComponentBoolean(string property, int index, bool defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentBoolean cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentBoolean(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue ? (byte)1 : (byte)0);
                return result != 0;
            }
        }
        public partial string GetComponentString(string property, int index, string defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentString cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentString(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, Reinterop.ObjectHandleUtility.CreateHandle(defaultValue));
                return (string)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        public partial int GetComponentCount(string property)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentCount cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentCount(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property));
                return result;
            }
        }
        public partial CesiumForUnity.MetadataType GetComponentType(string property)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentType cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentType(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property));
                return result;
            }
        }
        public partial CesiumForUnity.MetadataType GetMetadataType(string property)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetMetadataType cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetMetadataType(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property));
                return result;
            }
        }
        public partial bool IsNormalized(string property)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so IsNormalized cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_IsNormalized(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property));
                return result != 0;
            }
        }

        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static extern System.IntPtr DotNet_CesiumForUnity_CesiumFeature_CreateImplementation(System.IntPtr thiz);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static extern void DotNet_CesiumForUnity_CesiumFeature_DestroyImplementation(System.IntPtr implementation);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern sbyte DotNet_CesiumForUnity_CesiumFeature_GetInt8(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, sbyte defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern byte DotNet_CesiumForUnity_CesiumFeature_GetUInt8(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, byte defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern short DotNet_CesiumForUnity_CesiumFeature_GetInt16(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, short defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern ushort DotNet_CesiumForUnity_CesiumFeature_GetUInt16(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, ushort defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern int DotNet_CesiumForUnity_CesiumFeature_GetInt32(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern uint DotNet_CesiumForUnity_CesiumFeature_GetUInt32(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, uint defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern long DotNet_CesiumForUnity_CesiumFeature_GetInt64(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, long defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern ulong DotNet_CesiumForUnity_CesiumFeature_GetUInt64(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, ulong defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern float DotNet_CesiumForUnity_CesiumFeature_GetFloat32(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, float defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern double DotNet_CesiumForUnity_CesiumFeature_GetFloat64(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, double defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern byte DotNet_CesiumForUnity_CesiumFeature_GetBoolean(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, byte defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_CesiumFeature_GetString(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, System.IntPtr defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern sbyte DotNet_CesiumForUnity_CesiumFeature_GetComponentInt8(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, sbyte defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern byte DotNet_CesiumForUnity_CesiumFeature_GetComponentUInt8(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, byte defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern short DotNet_CesiumForUnity_CesiumFeature_GetComponentInt16(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, short defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern ushort DotNet_CesiumForUnity_CesiumFeature_GetComponentUInt16(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, ushort defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern int DotNet_CesiumForUnity_CesiumFeature_GetComponentInt32(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, int defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern uint DotNet_CesiumForUnity_CesiumFeature_GetComponentUInt32(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, uint defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern long DotNet_CesiumForUnity_CesiumFeature_GetComponentInt64(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, long defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern ulong DotNet_CesiumForUnity_CesiumFeature_GetComponentUInt64(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, ulong defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern float DotNet_CesiumForUnity_CesiumFeature_GetComponentFloat32(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, float defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern double DotNet_CesiumForUnity_CesiumFeature_GetComponentFloat64(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, double defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern byte DotNet_CesiumForUnity_CesiumFeature_GetComponentBoolean(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, byte defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_CesiumFeature_GetComponentString(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, System.IntPtr defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern int DotNet_CesiumForUnity_CesiumFeature_GetComponentCount(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern CesiumForUnity.MetadataType DotNet_CesiumForUnity_CesiumFeature_GetComponentType(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern CesiumForUnity.MetadataType DotNet_CesiumForUnity_CesiumFeature_GetMetadataType(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern byte DotNet_CesiumForUnity_CesiumFeature_IsNormalized(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property);
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
    public partial class CesiumFeature : System.IDisposable
    {
        internal class ImplementationHandle : SafeHandleZeroOrMinusOneIsInvalid
        {
            public ImplementationHandle(CesiumFeature managed) : base(true)
            {
                SetHandle(DotNet_CesiumForUnity_CesiumFeature_CreateImplementation(Reinterop.ObjectHandleUtility.CreateHandle(managed)));
            }

            [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
            protected override bool ReleaseHandle()
            {
                DotNet_CesiumForUnity_CesiumFeature_DestroyImplementation(this.handle);
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
        public CesiumFeature()
        {
            CreateImplementation();
        }
        public partial sbyte GetInt8(string property, sbyte defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetInt8 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetInt8(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial byte GetUInt8(string property, byte defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetUInt8 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetUInt8(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial short GetInt16(string property, short defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetInt16 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetInt16(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial ushort GetUInt16(string property, ushort defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetUInt16 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetUInt16(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial int GetInt32(string property, int defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetInt32 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetInt32(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial uint GetUInt32(string property, uint defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetUInt32 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetUInt32(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial long GetInt64(string property, long defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetInt64 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetInt64(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial ulong GetUInt64(string property, ulong defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetUInt64 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetUInt64(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial float GetFloat32(string property, float defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetFloat32 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetFloat32(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial double GetFloat64(string property, double defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetFloat64 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetFloat64(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial bool GetBoolean(string property, bool defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetBoolean cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetBoolean(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue ? (byte)1 : (byte)0);
                return result != 0;
            }
        }
        public partial string GetString(string property, string defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetString cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetString(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), Reinterop.ObjectHandleUtility.CreateHandle(defaultValue));
                return (string)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        public partial sbyte GetComponentInt8(string property, int index, sbyte defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentInt8 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentInt8(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial byte GetComponentUInt8(string property, int index, byte defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentUInt8 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentUInt8(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial short GetComponentInt16(string property, int index, short defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentInt16 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentInt16(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial ushort GetComponentUInt16(string property, int index, ushort defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentUInt16 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentUInt16(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial int GetComponentInt32(string property, int index, int defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentInt32 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentInt32(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial uint GetComponentUInt32(string property, int index, uint defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentUInt32 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentUInt32(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial long GetComponentInt64(string property, int index, long defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentInt64 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentInt64(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial ulong GetComponentUInt64(string property, int index, ulong defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentUInt64 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentUInt64(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial float GetComponentFloat32(string property, int index, float defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentFloat32 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentFloat32(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial double GetComponentFloat64(string property, int index, double defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentFloat64 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentFloat64(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial bool GetComponentBoolean(string property, int index, bool defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentBoolean cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentBoolean(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue ? (byte)1 : (byte)0);
                return result != 0;
            }
        }
        public partial string GetComponentString(string property, int index, string defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentString cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentString(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, Reinterop.ObjectHandleUtility.CreateHandle(defaultValue));
                return (string)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        public partial int GetComponentCount(string property)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentCount cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentCount(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property));
                return result;
            }
        }
        public partial CesiumForUnity.MetadataType GetComponentType(string property)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentType cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentType(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property));
                return result;
            }
        }
        public partial CesiumForUnity.MetadataType GetMetadataType(string property)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetMetadataType cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetMetadataType(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property));
                return result;
            }
        }
        public partial bool IsNormalized(string property)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so IsNormalized cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_IsNormalized(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property));
                return result != 0;
            }
        }

        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static extern System.IntPtr DotNet_CesiumForUnity_CesiumFeature_CreateImplementation(System.IntPtr thiz);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static extern void DotNet_CesiumForUnity_CesiumFeature_DestroyImplementation(System.IntPtr implementation);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern sbyte DotNet_CesiumForUnity_CesiumFeature_GetInt8(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, sbyte defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern byte DotNet_CesiumForUnity_CesiumFeature_GetUInt8(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, byte defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern short DotNet_CesiumForUnity_CesiumFeature_GetInt16(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, short defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern ushort DotNet_CesiumForUnity_CesiumFeature_GetUInt16(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, ushort defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern int DotNet_CesiumForUnity_CesiumFeature_GetInt32(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern uint DotNet_CesiumForUnity_CesiumFeature_GetUInt32(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, uint defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern long DotNet_CesiumForUnity_CesiumFeature_GetInt64(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, long defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern ulong DotNet_CesiumForUnity_CesiumFeature_GetUInt64(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, ulong defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern float DotNet_CesiumForUnity_CesiumFeature_GetFloat32(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, float defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern double DotNet_CesiumForUnity_CesiumFeature_GetFloat64(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, double defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern byte DotNet_CesiumForUnity_CesiumFeature_GetBoolean(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, byte defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_CesiumFeature_GetString(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, System.IntPtr defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern sbyte DotNet_CesiumForUnity_CesiumFeature_GetComponentInt8(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, sbyte defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern byte DotNet_CesiumForUnity_CesiumFeature_GetComponentUInt8(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, byte defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern short DotNet_CesiumForUnity_CesiumFeature_GetComponentInt16(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, short defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern ushort DotNet_CesiumForUnity_CesiumFeature_GetComponentUInt16(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, ushort defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern int DotNet_CesiumForUnity_CesiumFeature_GetComponentInt32(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, int defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern uint DotNet_CesiumForUnity_CesiumFeature_GetComponentUInt32(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, uint defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern long DotNet_CesiumForUnity_CesiumFeature_GetComponentInt64(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, long defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern ulong DotNet_CesiumForUnity_CesiumFeature_GetComponentUInt64(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, ulong defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern float DotNet_CesiumForUnity_CesiumFeature_GetComponentFloat32(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, float defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern double DotNet_CesiumForUnity_CesiumFeature_GetComponentFloat64(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, double defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern byte DotNet_CesiumForUnity_CesiumFeature_GetComponentBoolean(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, byte defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_CesiumFeature_GetComponentString(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, System.IntPtr defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern int DotNet_CesiumForUnity_CesiumFeature_GetComponentCount(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern CesiumForUnity.MetadataType DotNet_CesiumForUnity_CesiumFeature_GetComponentType(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern CesiumForUnity.MetadataType DotNet_CesiumForUnity_CesiumFeature_GetMetadataType(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern byte DotNet_CesiumForUnity_CesiumFeature_IsNormalized(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property);
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
    public partial class CesiumFeature : System.IDisposable
    {
        internal class ImplementationHandle : SafeHandleZeroOrMinusOneIsInvalid
        {
            public ImplementationHandle(CesiumFeature managed) : base(true)
            {
                SetHandle(DotNet_CesiumForUnity_CesiumFeature_CreateImplementation(Reinterop.ObjectHandleUtility.CreateHandle(managed)));
            }

            [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
            protected override bool ReleaseHandle()
            {
                DotNet_CesiumForUnity_CesiumFeature_DestroyImplementation(this.handle);
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
        public CesiumFeature()
        {
            CreateImplementation();
        }
        public partial sbyte GetInt8(string property, sbyte defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetInt8 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetInt8(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial byte GetUInt8(string property, byte defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetUInt8 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetUInt8(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial short GetInt16(string property, short defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetInt16 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetInt16(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial ushort GetUInt16(string property, ushort defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetUInt16 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetUInt16(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial int GetInt32(string property, int defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetInt32 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetInt32(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial uint GetUInt32(string property, uint defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetUInt32 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetUInt32(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial long GetInt64(string property, long defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetInt64 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetInt64(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial ulong GetUInt64(string property, ulong defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetUInt64 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetUInt64(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial float GetFloat32(string property, float defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetFloat32 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetFloat32(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial double GetFloat64(string property, double defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetFloat64 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetFloat64(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial bool GetBoolean(string property, bool defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetBoolean cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetBoolean(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue ? (byte)1 : (byte)0);
                return result != 0;
            }
        }
        public partial string GetString(string property, string defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetString cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetString(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), Reinterop.ObjectHandleUtility.CreateHandle(defaultValue));
                return (string)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        public partial sbyte GetComponentInt8(string property, int index, sbyte defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentInt8 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentInt8(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial byte GetComponentUInt8(string property, int index, byte defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentUInt8 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentUInt8(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial short GetComponentInt16(string property, int index, short defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentInt16 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentInt16(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial ushort GetComponentUInt16(string property, int index, ushort defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentUInt16 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentUInt16(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial int GetComponentInt32(string property, int index, int defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentInt32 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentInt32(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial uint GetComponentUInt32(string property, int index, uint defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentUInt32 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentUInt32(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial long GetComponentInt64(string property, int index, long defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentInt64 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentInt64(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial ulong GetComponentUInt64(string property, int index, ulong defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentUInt64 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentUInt64(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial float GetComponentFloat32(string property, int index, float defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentFloat32 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentFloat32(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial double GetComponentFloat64(string property, int index, double defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentFloat64 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentFloat64(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial bool GetComponentBoolean(string property, int index, bool defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentBoolean cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentBoolean(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue ? (byte)1 : (byte)0);
                return result != 0;
            }
        }
        public partial string GetComponentString(string property, int index, string defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentString cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentString(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, Reinterop.ObjectHandleUtility.CreateHandle(defaultValue));
                return (string)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        public partial int GetComponentCount(string property)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentCount cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentCount(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property));
                return result;
            }
        }
        public partial CesiumForUnity.MetadataType GetComponentType(string property)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentType cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentType(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property));
                return result;
            }
        }
        public partial CesiumForUnity.MetadataType GetMetadataType(string property)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetMetadataType cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetMetadataType(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property));
                return result;
            }
        }
        public partial bool IsNormalized(string property)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so IsNormalized cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_IsNormalized(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property));
                return result != 0;
            }
        }

        [DllImport("__Internal", CallingConvention=CallingConvention.Cdecl)]
        private static extern System.IntPtr DotNet_CesiumForUnity_CesiumFeature_CreateImplementation(System.IntPtr thiz);
        [DllImport("__Internal", CallingConvention=CallingConvention.Cdecl)]
        private static extern void DotNet_CesiumForUnity_CesiumFeature_DestroyImplementation(System.IntPtr implementation);
        [DllImport("__Internal", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern sbyte DotNet_CesiumForUnity_CesiumFeature_GetInt8(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, sbyte defaultValue);
        [DllImport("__Internal", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern byte DotNet_CesiumForUnity_CesiumFeature_GetUInt8(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, byte defaultValue);
        [DllImport("__Internal", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern short DotNet_CesiumForUnity_CesiumFeature_GetInt16(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, short defaultValue);
        [DllImport("__Internal", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern ushort DotNet_CesiumForUnity_CesiumFeature_GetUInt16(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, ushort defaultValue);
        [DllImport("__Internal", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern int DotNet_CesiumForUnity_CesiumFeature_GetInt32(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int defaultValue);
        [DllImport("__Internal", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern uint DotNet_CesiumForUnity_CesiumFeature_GetUInt32(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, uint defaultValue);
        [DllImport("__Internal", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern long DotNet_CesiumForUnity_CesiumFeature_GetInt64(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, long defaultValue);
        [DllImport("__Internal", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern ulong DotNet_CesiumForUnity_CesiumFeature_GetUInt64(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, ulong defaultValue);
        [DllImport("__Internal", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern float DotNet_CesiumForUnity_CesiumFeature_GetFloat32(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, float defaultValue);
        [DllImport("__Internal", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern double DotNet_CesiumForUnity_CesiumFeature_GetFloat64(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, double defaultValue);
        [DllImport("__Internal", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern byte DotNet_CesiumForUnity_CesiumFeature_GetBoolean(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, byte defaultValue);
        [DllImport("__Internal", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_CesiumFeature_GetString(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, System.IntPtr defaultValue);
        [DllImport("__Internal", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern sbyte DotNet_CesiumForUnity_CesiumFeature_GetComponentInt8(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, sbyte defaultValue);
        [DllImport("__Internal", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern byte DotNet_CesiumForUnity_CesiumFeature_GetComponentUInt8(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, byte defaultValue);
        [DllImport("__Internal", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern short DotNet_CesiumForUnity_CesiumFeature_GetComponentInt16(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, short defaultValue);
        [DllImport("__Internal", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern ushort DotNet_CesiumForUnity_CesiumFeature_GetComponentUInt16(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, ushort defaultValue);
        [DllImport("__Internal", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern int DotNet_CesiumForUnity_CesiumFeature_GetComponentInt32(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, int defaultValue);
        [DllImport("__Internal", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern uint DotNet_CesiumForUnity_CesiumFeature_GetComponentUInt32(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, uint defaultValue);
        [DllImport("__Internal", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern long DotNet_CesiumForUnity_CesiumFeature_GetComponentInt64(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, long defaultValue);
        [DllImport("__Internal", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern ulong DotNet_CesiumForUnity_CesiumFeature_GetComponentUInt64(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, ulong defaultValue);
        [DllImport("__Internal", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern float DotNet_CesiumForUnity_CesiumFeature_GetComponentFloat32(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, float defaultValue);
        [DllImport("__Internal", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern double DotNet_CesiumForUnity_CesiumFeature_GetComponentFloat64(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, double defaultValue);
        [DllImport("__Internal", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern byte DotNet_CesiumForUnity_CesiumFeature_GetComponentBoolean(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, byte defaultValue);
        [DllImport("__Internal", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_CesiumFeature_GetComponentString(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, System.IntPtr defaultValue);
        [DllImport("__Internal", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern int DotNet_CesiumForUnity_CesiumFeature_GetComponentCount(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property);
        [DllImport("__Internal", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern CesiumForUnity.MetadataType DotNet_CesiumForUnity_CesiumFeature_GetComponentType(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property);
        [DllImport("__Internal", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern CesiumForUnity.MetadataType DotNet_CesiumForUnity_CesiumFeature_GetMetadataType(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property);
        [DllImport("__Internal", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern byte DotNet_CesiumForUnity_CesiumFeature_IsNormalized(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property);
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
    public partial class CesiumFeature : System.IDisposable
    {
        internal class ImplementationHandle : SafeHandleZeroOrMinusOneIsInvalid
        {
            public ImplementationHandle(CesiumFeature managed) : base(true)
            {
                SetHandle(DotNet_CesiumForUnity_CesiumFeature_CreateImplementation(Reinterop.ObjectHandleUtility.CreateHandle(managed)));
            }

            [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
            protected override bool ReleaseHandle()
            {
                DotNet_CesiumForUnity_CesiumFeature_DestroyImplementation(this.handle);
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
        public CesiumFeature()
        {
            CreateImplementation();
        }
        public partial sbyte GetInt8(string property, sbyte defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetInt8 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetInt8(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial byte GetUInt8(string property, byte defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetUInt8 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetUInt8(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial short GetInt16(string property, short defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetInt16 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetInt16(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial ushort GetUInt16(string property, ushort defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetUInt16 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetUInt16(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial int GetInt32(string property, int defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetInt32 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetInt32(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial uint GetUInt32(string property, uint defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetUInt32 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetUInt32(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial long GetInt64(string property, long defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetInt64 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetInt64(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial ulong GetUInt64(string property, ulong defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetUInt64 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetUInt64(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial float GetFloat32(string property, float defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetFloat32 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetFloat32(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial double GetFloat64(string property, double defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetFloat64 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetFloat64(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial bool GetBoolean(string property, bool defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetBoolean cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetBoolean(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue ? (byte)1 : (byte)0);
                return result != 0;
            }
        }
        public partial string GetString(string property, string defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetString cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetString(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), Reinterop.ObjectHandleUtility.CreateHandle(defaultValue));
                return (string)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        public partial sbyte GetComponentInt8(string property, int index, sbyte defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentInt8 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentInt8(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial byte GetComponentUInt8(string property, int index, byte defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentUInt8 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentUInt8(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial short GetComponentInt16(string property, int index, short defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentInt16 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentInt16(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial ushort GetComponentUInt16(string property, int index, ushort defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentUInt16 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentUInt16(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial int GetComponentInt32(string property, int index, int defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentInt32 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentInt32(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial uint GetComponentUInt32(string property, int index, uint defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentUInt32 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentUInt32(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial long GetComponentInt64(string property, int index, long defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentInt64 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentInt64(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial ulong GetComponentUInt64(string property, int index, ulong defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentUInt64 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentUInt64(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial float GetComponentFloat32(string property, int index, float defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentFloat32 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentFloat32(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial double GetComponentFloat64(string property, int index, double defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentFloat64 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentFloat64(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial bool GetComponentBoolean(string property, int index, bool defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentBoolean cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentBoolean(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue ? (byte)1 : (byte)0);
                return result != 0;
            }
        }
        public partial string GetComponentString(string property, int index, string defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentString cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentString(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, Reinterop.ObjectHandleUtility.CreateHandle(defaultValue));
                return (string)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        public partial int GetComponentCount(string property)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentCount cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentCount(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property));
                return result;
            }
        }
        public partial CesiumForUnity.MetadataType GetComponentType(string property)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentType cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentType(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property));
                return result;
            }
        }
        public partial CesiumForUnity.MetadataType GetMetadataType(string property)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetMetadataType cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetMetadataType(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property));
                return result;
            }
        }
        public partial bool IsNormalized(string property)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so IsNormalized cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_IsNormalized(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property));
                return result != 0;
            }
        }

        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static extern System.IntPtr DotNet_CesiumForUnity_CesiumFeature_CreateImplementation(System.IntPtr thiz);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static extern void DotNet_CesiumForUnity_CesiumFeature_DestroyImplementation(System.IntPtr implementation);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern sbyte DotNet_CesiumForUnity_CesiumFeature_GetInt8(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, sbyte defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern byte DotNet_CesiumForUnity_CesiumFeature_GetUInt8(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, byte defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern short DotNet_CesiumForUnity_CesiumFeature_GetInt16(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, short defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern ushort DotNet_CesiumForUnity_CesiumFeature_GetUInt16(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, ushort defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern int DotNet_CesiumForUnity_CesiumFeature_GetInt32(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern uint DotNet_CesiumForUnity_CesiumFeature_GetUInt32(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, uint defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern long DotNet_CesiumForUnity_CesiumFeature_GetInt64(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, long defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern ulong DotNet_CesiumForUnity_CesiumFeature_GetUInt64(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, ulong defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern float DotNet_CesiumForUnity_CesiumFeature_GetFloat32(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, float defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern double DotNet_CesiumForUnity_CesiumFeature_GetFloat64(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, double defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern byte DotNet_CesiumForUnity_CesiumFeature_GetBoolean(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, byte defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_CesiumFeature_GetString(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, System.IntPtr defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern sbyte DotNet_CesiumForUnity_CesiumFeature_GetComponentInt8(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, sbyte defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern byte DotNet_CesiumForUnity_CesiumFeature_GetComponentUInt8(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, byte defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern short DotNet_CesiumForUnity_CesiumFeature_GetComponentInt16(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, short defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern ushort DotNet_CesiumForUnity_CesiumFeature_GetComponentUInt16(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, ushort defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern int DotNet_CesiumForUnity_CesiumFeature_GetComponentInt32(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, int defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern uint DotNet_CesiumForUnity_CesiumFeature_GetComponentUInt32(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, uint defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern long DotNet_CesiumForUnity_CesiumFeature_GetComponentInt64(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, long defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern ulong DotNet_CesiumForUnity_CesiumFeature_GetComponentUInt64(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, ulong defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern float DotNet_CesiumForUnity_CesiumFeature_GetComponentFloat32(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, float defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern double DotNet_CesiumForUnity_CesiumFeature_GetComponentFloat64(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, double defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern byte DotNet_CesiumForUnity_CesiumFeature_GetComponentBoolean(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, byte defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_CesiumFeature_GetComponentString(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, System.IntPtr defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern int DotNet_CesiumForUnity_CesiumFeature_GetComponentCount(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern CesiumForUnity.MetadataType DotNet_CesiumForUnity_CesiumFeature_GetComponentType(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern CesiumForUnity.MetadataType DotNet_CesiumForUnity_CesiumFeature_GetMetadataType(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern byte DotNet_CesiumForUnity_CesiumFeature_IsNormalized(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property);
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
    public partial class CesiumFeature : System.IDisposable
    {
        internal class ImplementationHandle : SafeHandleZeroOrMinusOneIsInvalid
        {
            public ImplementationHandle(CesiumFeature managed) : base(true)
            {
                SetHandle(DotNet_CesiumForUnity_CesiumFeature_CreateImplementation(Reinterop.ObjectHandleUtility.CreateHandle(managed)));
            }

            [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
            protected override bool ReleaseHandle()
            {
                DotNet_CesiumForUnity_CesiumFeature_DestroyImplementation(this.handle);
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
        public CesiumFeature()
        {
            CreateImplementation();
        }
        public partial sbyte GetInt8(string property, sbyte defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetInt8 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetInt8(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial byte GetUInt8(string property, byte defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetUInt8 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetUInt8(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial short GetInt16(string property, short defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetInt16 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetInt16(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial ushort GetUInt16(string property, ushort defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetUInt16 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetUInt16(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial int GetInt32(string property, int defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetInt32 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetInt32(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial uint GetUInt32(string property, uint defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetUInt32 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetUInt32(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial long GetInt64(string property, long defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetInt64 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetInt64(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial ulong GetUInt64(string property, ulong defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetUInt64 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetUInt64(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial float GetFloat32(string property, float defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetFloat32 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetFloat32(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial double GetFloat64(string property, double defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetFloat64 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetFloat64(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial bool GetBoolean(string property, bool defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetBoolean cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetBoolean(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue ? (byte)1 : (byte)0);
                return result != 0;
            }
        }
        public partial string GetString(string property, string defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetString cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetString(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), Reinterop.ObjectHandleUtility.CreateHandle(defaultValue));
                return (string)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        public partial sbyte GetComponentInt8(string property, int index, sbyte defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentInt8 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentInt8(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial byte GetComponentUInt8(string property, int index, byte defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentUInt8 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentUInt8(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial short GetComponentInt16(string property, int index, short defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentInt16 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentInt16(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial ushort GetComponentUInt16(string property, int index, ushort defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentUInt16 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentUInt16(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial int GetComponentInt32(string property, int index, int defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentInt32 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentInt32(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial uint GetComponentUInt32(string property, int index, uint defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentUInt32 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentUInt32(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial long GetComponentInt64(string property, int index, long defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentInt64 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentInt64(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial ulong GetComponentUInt64(string property, int index, ulong defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentUInt64 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentUInt64(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial float GetComponentFloat32(string property, int index, float defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentFloat32 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentFloat32(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial double GetComponentFloat64(string property, int index, double defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentFloat64 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentFloat64(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial bool GetComponentBoolean(string property, int index, bool defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentBoolean cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentBoolean(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue ? (byte)1 : (byte)0);
                return result != 0;
            }
        }
        public partial string GetComponentString(string property, int index, string defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentString cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentString(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, Reinterop.ObjectHandleUtility.CreateHandle(defaultValue));
                return (string)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        public partial int GetComponentCount(string property)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentCount cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentCount(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property));
                return result;
            }
        }
        public partial CesiumForUnity.MetadataType GetComponentType(string property)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentType cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentType(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property));
                return result;
            }
        }
        public partial CesiumForUnity.MetadataType GetMetadataType(string property)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetMetadataType cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetMetadataType(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property));
                return result;
            }
        }
        public partial bool IsNormalized(string property)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so IsNormalized cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_IsNormalized(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property));
                return result != 0;
            }
        }

        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static extern System.IntPtr DotNet_CesiumForUnity_CesiumFeature_CreateImplementation(System.IntPtr thiz);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static extern void DotNet_CesiumForUnity_CesiumFeature_DestroyImplementation(System.IntPtr implementation);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern sbyte DotNet_CesiumForUnity_CesiumFeature_GetInt8(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, sbyte defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern byte DotNet_CesiumForUnity_CesiumFeature_GetUInt8(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, byte defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern short DotNet_CesiumForUnity_CesiumFeature_GetInt16(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, short defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern ushort DotNet_CesiumForUnity_CesiumFeature_GetUInt16(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, ushort defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern int DotNet_CesiumForUnity_CesiumFeature_GetInt32(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern uint DotNet_CesiumForUnity_CesiumFeature_GetUInt32(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, uint defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern long DotNet_CesiumForUnity_CesiumFeature_GetInt64(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, long defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern ulong DotNet_CesiumForUnity_CesiumFeature_GetUInt64(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, ulong defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern float DotNet_CesiumForUnity_CesiumFeature_GetFloat32(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, float defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern double DotNet_CesiumForUnity_CesiumFeature_GetFloat64(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, double defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern byte DotNet_CesiumForUnity_CesiumFeature_GetBoolean(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, byte defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_CesiumFeature_GetString(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, System.IntPtr defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern sbyte DotNet_CesiumForUnity_CesiumFeature_GetComponentInt8(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, sbyte defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern byte DotNet_CesiumForUnity_CesiumFeature_GetComponentUInt8(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, byte defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern short DotNet_CesiumForUnity_CesiumFeature_GetComponentInt16(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, short defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern ushort DotNet_CesiumForUnity_CesiumFeature_GetComponentUInt16(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, ushort defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern int DotNet_CesiumForUnity_CesiumFeature_GetComponentInt32(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, int defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern uint DotNet_CesiumForUnity_CesiumFeature_GetComponentUInt32(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, uint defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern long DotNet_CesiumForUnity_CesiumFeature_GetComponentInt64(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, long defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern ulong DotNet_CesiumForUnity_CesiumFeature_GetComponentUInt64(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, ulong defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern float DotNet_CesiumForUnity_CesiumFeature_GetComponentFloat32(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, float defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern double DotNet_CesiumForUnity_CesiumFeature_GetComponentFloat64(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, double defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern byte DotNet_CesiumForUnity_CesiumFeature_GetComponentBoolean(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, byte defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_CesiumFeature_GetComponentString(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, System.IntPtr defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern int DotNet_CesiumForUnity_CesiumFeature_GetComponentCount(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern CesiumForUnity.MetadataType DotNet_CesiumForUnity_CesiumFeature_GetComponentType(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern CesiumForUnity.MetadataType DotNet_CesiumForUnity_CesiumFeature_GetMetadataType(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern byte DotNet_CesiumForUnity_CesiumFeature_IsNormalized(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property);
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
    public partial class CesiumFeature : System.IDisposable
    {
        internal class ImplementationHandle : SafeHandleZeroOrMinusOneIsInvalid
        {
            public ImplementationHandle(CesiumFeature managed) : base(true)
            {
                SetHandle(DotNet_CesiumForUnity_CesiumFeature_CreateImplementation(Reinterop.ObjectHandleUtility.CreateHandle(managed)));
            }

            [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
            protected override bool ReleaseHandle()
            {
                DotNet_CesiumForUnity_CesiumFeature_DestroyImplementation(this.handle);
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
        public CesiumFeature()
        {
            CreateImplementation();
        }
        public partial sbyte GetInt8(string property, sbyte defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetInt8 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetInt8(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial byte GetUInt8(string property, byte defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetUInt8 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetUInt8(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial short GetInt16(string property, short defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetInt16 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetInt16(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial ushort GetUInt16(string property, ushort defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetUInt16 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetUInt16(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial int GetInt32(string property, int defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetInt32 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetInt32(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial uint GetUInt32(string property, uint defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetUInt32 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetUInt32(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial long GetInt64(string property, long defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetInt64 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetInt64(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial ulong GetUInt64(string property, ulong defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetUInt64 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetUInt64(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial float GetFloat32(string property, float defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetFloat32 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetFloat32(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial double GetFloat64(string property, double defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetFloat64 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetFloat64(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial bool GetBoolean(string property, bool defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetBoolean cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetBoolean(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue ? (byte)1 : (byte)0);
                return result != 0;
            }
        }
        public partial string GetString(string property, string defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetString cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetString(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), Reinterop.ObjectHandleUtility.CreateHandle(defaultValue));
                return (string)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        public partial sbyte GetComponentInt8(string property, int index, sbyte defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentInt8 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentInt8(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial byte GetComponentUInt8(string property, int index, byte defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentUInt8 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentUInt8(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial short GetComponentInt16(string property, int index, short defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentInt16 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentInt16(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial ushort GetComponentUInt16(string property, int index, ushort defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentUInt16 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentUInt16(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial int GetComponentInt32(string property, int index, int defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentInt32 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentInt32(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial uint GetComponentUInt32(string property, int index, uint defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentUInt32 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentUInt32(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial long GetComponentInt64(string property, int index, long defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentInt64 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentInt64(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial ulong GetComponentUInt64(string property, int index, ulong defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentUInt64 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentUInt64(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial float GetComponentFloat32(string property, int index, float defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentFloat32 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentFloat32(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial double GetComponentFloat64(string property, int index, double defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentFloat64 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentFloat64(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial bool GetComponentBoolean(string property, int index, bool defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentBoolean cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentBoolean(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue ? (byte)1 : (byte)0);
                return result != 0;
            }
        }
        public partial string GetComponentString(string property, int index, string defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentString cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentString(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, Reinterop.ObjectHandleUtility.CreateHandle(defaultValue));
                return (string)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        public partial int GetComponentCount(string property)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentCount cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentCount(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property));
                return result;
            }
        }
        public partial CesiumForUnity.MetadataType GetComponentType(string property)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentType cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentType(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property));
                return result;
            }
        }
        public partial CesiumForUnity.MetadataType GetMetadataType(string property)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetMetadataType cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetMetadataType(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property));
                return result;
            }
        }
        public partial bool IsNormalized(string property)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so IsNormalized cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_IsNormalized(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property));
                return result != 0;
            }
        }

        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static extern System.IntPtr DotNet_CesiumForUnity_CesiumFeature_CreateImplementation(System.IntPtr thiz);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static extern void DotNet_CesiumForUnity_CesiumFeature_DestroyImplementation(System.IntPtr implementation);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern sbyte DotNet_CesiumForUnity_CesiumFeature_GetInt8(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, sbyte defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern byte DotNet_CesiumForUnity_CesiumFeature_GetUInt8(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, byte defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern short DotNet_CesiumForUnity_CesiumFeature_GetInt16(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, short defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern ushort DotNet_CesiumForUnity_CesiumFeature_GetUInt16(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, ushort defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern int DotNet_CesiumForUnity_CesiumFeature_GetInt32(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern uint DotNet_CesiumForUnity_CesiumFeature_GetUInt32(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, uint defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern long DotNet_CesiumForUnity_CesiumFeature_GetInt64(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, long defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern ulong DotNet_CesiumForUnity_CesiumFeature_GetUInt64(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, ulong defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern float DotNet_CesiumForUnity_CesiumFeature_GetFloat32(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, float defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern double DotNet_CesiumForUnity_CesiumFeature_GetFloat64(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, double defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern byte DotNet_CesiumForUnity_CesiumFeature_GetBoolean(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, byte defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_CesiumFeature_GetString(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, System.IntPtr defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern sbyte DotNet_CesiumForUnity_CesiumFeature_GetComponentInt8(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, sbyte defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern byte DotNet_CesiumForUnity_CesiumFeature_GetComponentUInt8(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, byte defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern short DotNet_CesiumForUnity_CesiumFeature_GetComponentInt16(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, short defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern ushort DotNet_CesiumForUnity_CesiumFeature_GetComponentUInt16(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, ushort defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern int DotNet_CesiumForUnity_CesiumFeature_GetComponentInt32(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, int defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern uint DotNet_CesiumForUnity_CesiumFeature_GetComponentUInt32(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, uint defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern long DotNet_CesiumForUnity_CesiumFeature_GetComponentInt64(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, long defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern ulong DotNet_CesiumForUnity_CesiumFeature_GetComponentUInt64(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, ulong defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern float DotNet_CesiumForUnity_CesiumFeature_GetComponentFloat32(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, float defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern double DotNet_CesiumForUnity_CesiumFeature_GetComponentFloat64(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, double defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern byte DotNet_CesiumForUnity_CesiumFeature_GetComponentBoolean(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, byte defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_CesiumFeature_GetComponentString(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, System.IntPtr defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern int DotNet_CesiumForUnity_CesiumFeature_GetComponentCount(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern CesiumForUnity.MetadataType DotNet_CesiumForUnity_CesiumFeature_GetComponentType(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern CesiumForUnity.MetadataType DotNet_CesiumForUnity_CesiumFeature_GetMetadataType(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern byte DotNet_CesiumForUnity_CesiumFeature_IsNormalized(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property);
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
    public partial class CesiumFeature : System.IDisposable
    {
        internal class ImplementationHandle : SafeHandleZeroOrMinusOneIsInvalid
        {
            public ImplementationHandle(CesiumFeature managed) : base(true)
            {
                SetHandle(DotNet_CesiumForUnity_CesiumFeature_CreateImplementation(Reinterop.ObjectHandleUtility.CreateHandle(managed)));
            }

            [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
            protected override bool ReleaseHandle()
            {
                DotNet_CesiumForUnity_CesiumFeature_DestroyImplementation(this.handle);
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
        public CesiumFeature()
        {
            CreateImplementation();
        }
        public partial sbyte GetInt8(string property, sbyte defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetInt8 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetInt8(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial byte GetUInt8(string property, byte defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetUInt8 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetUInt8(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial short GetInt16(string property, short defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetInt16 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetInt16(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial ushort GetUInt16(string property, ushort defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetUInt16 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetUInt16(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial int GetInt32(string property, int defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetInt32 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetInt32(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial uint GetUInt32(string property, uint defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetUInt32 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetUInt32(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial long GetInt64(string property, long defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetInt64 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetInt64(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial ulong GetUInt64(string property, ulong defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetUInt64 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetUInt64(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial float GetFloat32(string property, float defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetFloat32 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetFloat32(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial double GetFloat64(string property, double defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetFloat64 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetFloat64(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue);
                return result;
            }
        }
        public partial bool GetBoolean(string property, bool defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetBoolean cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetBoolean(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), defaultValue ? (byte)1 : (byte)0);
                return result != 0;
            }
        }
        public partial string GetString(string property, string defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetString cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetString(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), Reinterop.ObjectHandleUtility.CreateHandle(defaultValue));
                return (string)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        public partial sbyte GetComponentInt8(string property, int index, sbyte defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentInt8 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentInt8(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial byte GetComponentUInt8(string property, int index, byte defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentUInt8 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentUInt8(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial short GetComponentInt16(string property, int index, short defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentInt16 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentInt16(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial ushort GetComponentUInt16(string property, int index, ushort defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentUInt16 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentUInt16(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial int GetComponentInt32(string property, int index, int defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentInt32 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentInt32(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial uint GetComponentUInt32(string property, int index, uint defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentUInt32 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentUInt32(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial long GetComponentInt64(string property, int index, long defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentInt64 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentInt64(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial ulong GetComponentUInt64(string property, int index, ulong defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentUInt64 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentUInt64(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial float GetComponentFloat32(string property, int index, float defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentFloat32 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentFloat32(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial double GetComponentFloat64(string property, int index, double defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentFloat64 cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentFloat64(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue);
                return result;
            }
        }
        public partial bool GetComponentBoolean(string property, int index, bool defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentBoolean cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentBoolean(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, defaultValue ? (byte)1 : (byte)0);
                return result != 0;
            }
        }
        public partial string GetComponentString(string property, int index, string defaultValue)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentString cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentString(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property), index, Reinterop.ObjectHandleUtility.CreateHandle(defaultValue));
                return (string)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        public partial int GetComponentCount(string property)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentCount cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentCount(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property));
                return result;
            }
        }
        public partial CesiumForUnity.MetadataType GetComponentType(string property)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetComponentType cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetComponentType(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property));
                return result;
            }
        }
        public partial CesiumForUnity.MetadataType GetMetadataType(string property)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetMetadataType cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_GetMetadataType(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property));
                return result;
            }
        }
        public partial bool IsNormalized(string property)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so IsNormalized cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeature_IsNormalized(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(property));
                return result != 0;
            }
        }

        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static extern System.IntPtr DotNet_CesiumForUnity_CesiumFeature_CreateImplementation(System.IntPtr thiz);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static extern void DotNet_CesiumForUnity_CesiumFeature_DestroyImplementation(System.IntPtr implementation);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern sbyte DotNet_CesiumForUnity_CesiumFeature_GetInt8(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, sbyte defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern byte DotNet_CesiumForUnity_CesiumFeature_GetUInt8(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, byte defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern short DotNet_CesiumForUnity_CesiumFeature_GetInt16(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, short defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern ushort DotNet_CesiumForUnity_CesiumFeature_GetUInt16(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, ushort defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern int DotNet_CesiumForUnity_CesiumFeature_GetInt32(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern uint DotNet_CesiumForUnity_CesiumFeature_GetUInt32(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, uint defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern long DotNet_CesiumForUnity_CesiumFeature_GetInt64(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, long defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern ulong DotNet_CesiumForUnity_CesiumFeature_GetUInt64(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, ulong defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern float DotNet_CesiumForUnity_CesiumFeature_GetFloat32(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, float defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern double DotNet_CesiumForUnity_CesiumFeature_GetFloat64(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, double defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern byte DotNet_CesiumForUnity_CesiumFeature_GetBoolean(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, byte defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_CesiumFeature_GetString(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, System.IntPtr defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern sbyte DotNet_CesiumForUnity_CesiumFeature_GetComponentInt8(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, sbyte defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern byte DotNet_CesiumForUnity_CesiumFeature_GetComponentUInt8(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, byte defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern short DotNet_CesiumForUnity_CesiumFeature_GetComponentInt16(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, short defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern ushort DotNet_CesiumForUnity_CesiumFeature_GetComponentUInt16(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, ushort defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern int DotNet_CesiumForUnity_CesiumFeature_GetComponentInt32(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, int defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern uint DotNet_CesiumForUnity_CesiumFeature_GetComponentUInt32(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, uint defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern long DotNet_CesiumForUnity_CesiumFeature_GetComponentInt64(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, long defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern ulong DotNet_CesiumForUnity_CesiumFeature_GetComponentUInt64(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, ulong defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern float DotNet_CesiumForUnity_CesiumFeature_GetComponentFloat32(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, float defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern double DotNet_CesiumForUnity_CesiumFeature_GetComponentFloat64(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, double defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern byte DotNet_CesiumForUnity_CesiumFeature_GetComponentBoolean(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, byte defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_CesiumFeature_GetComponentString(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property, int index, System.IntPtr defaultValue);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern int DotNet_CesiumForUnity_CesiumFeature_GetComponentCount(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern CesiumForUnity.MetadataType DotNet_CesiumForUnity_CesiumFeature_GetComponentType(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern CesiumForUnity.MetadataType DotNet_CesiumForUnity_CesiumFeature_GetMetadataType(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern byte DotNet_CesiumForUnity_CesiumFeature_IsNormalized(System.IntPtr thiz, CesiumForUnity.CesiumFeature.ImplementationHandle implementation, System.IntPtr property);
    }
}
#endif
