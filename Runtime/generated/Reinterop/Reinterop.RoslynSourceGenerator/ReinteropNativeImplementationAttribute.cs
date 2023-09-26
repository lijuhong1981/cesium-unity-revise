#if UNITY_EDITOR_OSX
using System;

namespace Reinterop
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    internal class ReinteropNativeImplementationAttribute : Attribute
    {
        public readonly string ImplementationClassName;

        public readonly string HeaderName;

        public readonly bool StaticOnly;

        public ReinteropNativeImplementationAttribute(string implementationClassName, string headerName, bool staticOnly = false) {
            this.ImplementationClassName = implementationClassName;
            this.HeaderName = headerName;
            this.StaticOnly = staticOnly;
        }
    }
}
#endif
#if !UNITY_EDITOR && UNITY_STANDALONE_OSX
using System;

namespace Reinterop
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    internal class ReinteropNativeImplementationAttribute : Attribute
    {
        public readonly string ImplementationClassName;

        public readonly string HeaderName;

        public readonly bool StaticOnly;

        public ReinteropNativeImplementationAttribute(string implementationClassName, string headerName, bool staticOnly = false) {
            this.ImplementationClassName = implementationClassName;
            this.HeaderName = headerName;
            this.StaticOnly = staticOnly;
        }
    }
}
#endif
#if !UNITY_EDITOR && UNITY_IOS
using System;

namespace Reinterop
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    internal class ReinteropNativeImplementationAttribute : Attribute
    {
        public readonly string ImplementationClassName;

        public readonly string HeaderName;

        public readonly bool StaticOnly;

        public ReinteropNativeImplementationAttribute(string implementationClassName, string headerName, bool staticOnly = false) {
            this.ImplementationClassName = implementationClassName;
            this.HeaderName = headerName;
            this.StaticOnly = staticOnly;
        }
    }
}
#endif
#if UNITY_EDITOR_WIN
using System;

namespace Reinterop
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    internal class ReinteropNativeImplementationAttribute : Attribute
    {
        public readonly string ImplementationClassName;

        public readonly string HeaderName;

        public readonly bool StaticOnly;

        public ReinteropNativeImplementationAttribute(string implementationClassName, string headerName, bool staticOnly = false) {
            this.ImplementationClassName = implementationClassName;
            this.HeaderName = headerName;
            this.StaticOnly = staticOnly;
        }
    }
}
#endif
#if !UNITY_EDITOR && UNITY_WSA
using System;

namespace Reinterop
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    internal class ReinteropNativeImplementationAttribute : Attribute
    {
        public readonly string ImplementationClassName;

        public readonly string HeaderName;

        public readonly bool StaticOnly;

        public ReinteropNativeImplementationAttribute(string implementationClassName, string headerName, bool staticOnly = false) {
            this.ImplementationClassName = implementationClassName;
            this.HeaderName = headerName;
            this.StaticOnly = staticOnly;
        }
    }
}
#endif
#if !UNITY_EDITOR && UNITY_STANDALONE_WIN
using System;

namespace Reinterop
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    internal class ReinteropNativeImplementationAttribute : Attribute
    {
        public readonly string ImplementationClassName;

        public readonly string HeaderName;

        public readonly bool StaticOnly;

        public ReinteropNativeImplementationAttribute(string implementationClassName, string headerName, bool staticOnly = false) {
            this.ImplementationClassName = implementationClassName;
            this.HeaderName = headerName;
            this.StaticOnly = staticOnly;
        }
    }
}
#endif
#if !UNITY_EDITOR && UNITY_ANDROID
using System;

namespace Reinterop
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    internal class ReinteropNativeImplementationAttribute : Attribute
    {
        public readonly string ImplementationClassName;

        public readonly string HeaderName;

        public readonly bool StaticOnly;

        public ReinteropNativeImplementationAttribute(string implementationClassName, string headerName, bool staticOnly = false) {
            this.ImplementationClassName = implementationClassName;
            this.HeaderName = headerName;
            this.StaticOnly = staticOnly;
        }
    }
}
#endif
