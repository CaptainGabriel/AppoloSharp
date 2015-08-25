using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppoloSharp.Model.interno
{
    public struct AvatarUrl
    {
        public AvatarUrl(string size24, string size32, string size64, string size128)
        {
            Size24 = size24;
            Size32 = size32;
            Size64 = size64;
            Size128 = size128;
        }

        public string Size24 { get; } 
        public string Size32 { get; } 
        public string Size64 { get; }
        public string Size128 { get; }
    }
}
