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
