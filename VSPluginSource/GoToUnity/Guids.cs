// Guids.cs
// MUST match guids.h
using System;

namespace VoidUpdate.GoToUnity
{
    static class GuidList
    {
        public const string guidGoToUnityPkgString = "d5cfc0c4-2622-4b40-9d36-f0fc4ab43a48";
        public const string guidGoToUnityCmdSetString = "73a3114e-bf01-404f-8210-a4c0074cfece";

        public static readonly Guid guidGoToUnityCmdSet = new Guid(guidGoToUnityCmdSetString);
    };
}