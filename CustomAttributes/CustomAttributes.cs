using System;

namespace uh_sample.CustomAttributes
{
    /// <summary>
    /// DoNotPatchAttribute used to decorate DTO properties to prevent patching immutable fields
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class DoNotPatchAttribute : Attribute
    {
    }
}
