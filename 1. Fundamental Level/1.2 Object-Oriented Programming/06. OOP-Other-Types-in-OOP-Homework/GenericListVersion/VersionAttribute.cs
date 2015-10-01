namespace GenericListVersion
{
    using System;
    using System.Runtime.InteropServices;
    
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class VersionAttribute : Attribute
    {
        public string Version { get; }

        public VersionAttribute(string version)
        {
            Version = version;
        }

    }
}
