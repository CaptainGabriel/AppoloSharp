using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AppoloSharp.Model
{
    public class CourseUnitSet
    {
        [JsonProperty("courseUnits")]
        public CourseUnit[] CourseUnitArray { get; protected set; }
    }
}
