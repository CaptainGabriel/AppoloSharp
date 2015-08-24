using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AppoloSharp.Model
{
    public class Student
    {
        [JsonProperty("id")]
        public int Id { get; protected set; }
        [JsonProperty("number")]
        public int Number { get; protected set; }
        [JsonProperty("name")]
        public string Name { get; protected set; }
        [JsonProperty("academicEmail")]
        public string AcademicEmail { get; protected set; }
        [JsonProperty("shortName")]
        public string ShortName { get; protected set; }

    }
}
