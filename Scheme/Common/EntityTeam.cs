using System;

namespace Scheme.Common
{
    [Flags]
    public enum EntityTeam : byte
    {
        Enemies,
        
        Ally,
        
        All
    }
}