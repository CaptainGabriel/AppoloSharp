using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AppoloSharp.Model.interno
{
    public struct Links
    {
        public Links(string elementRoot) : this()
        {
            ElementsRoot = elementRoot;
        }

        [JsonProperty("self")]
        public string Self { get; }
        
        public string ElementsRoot { get; }
        [JsonProperty("root")]
        public string Root { get; }
    }
}
