#if UNITY_EDITOR_OSX
using System;

namespace Reinterop
{
    [AttributeUsage(AttributeTargets.Class)]
    internal class ReinteropAttribute : Attribute
    {
    }
}
#endif
#if !UNITY_EDITOR && UNITY_STANDALONE_OSX
using System;

namespace Reinterop
{
    [AttributeUsage(AttributeTargets.Class)]
    internal class ReinteropAttribute : Attribute
    {
    }
}
#endif
#if !UNITY_EDITOR && UNITY_IOS
using System;

namespace Reinterop
{
    [AttributeUsage(AttributeTargets.Class)]
    internal class ReinteropAttribute : Attribute
    {
    }
}
#endif
#if UNITY_EDITOR_WIN
using System;

namespace Reinterop
{
    [AttributeUsage(AttributeTargets.Class)]
    internal class ReinteropAttribute : Attribute
    {
    }
}
#endif
#if !UNITY_EDITOR && UNITY_WSA
using System;

namespace Reinterop
{
    [AttributeUsage(AttributeTargets.Class)]
    internal class ReinteropAttribute : Attribute
    {
    }
}
#endif
#if !UNITY_EDITOR && UNITY_STANDALONE_WIN
using System;

namespace Reinterop
{
    [AttributeUsage(AttributeTargets.Class)]
    internal class ReinteropAttribute : Attribute
    {
    }
}
#endif
#if !UNITY_EDITOR && UNITY_ANDROID
using System;

namespace Reinterop
{
    [AttributeUsage(AttributeTargets.Class)]
    internal class ReinteropAttribute : Attribute
    {
    }
}
#endif
