using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AppoloSharp.Model
{
    public class CourseUnit
    {
        [JsonProperty("id")]
        public int Id { get; protected set; }
        [JsonProperty("shortName")]
        public string ShortName { get; protected set; }
        [JsonProperty("fullName")]
        public string FullName { get; protected set; }
    }
}
