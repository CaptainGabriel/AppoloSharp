﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppoloSharp.Model.interno;
using Newtonsoft.Json;

namespace AppoloSharp.Model
{
    public class Program
    {
        [JsonProperty("id")]
        public int Id { get; protected set; }
        [JsonProperty("shortName")]
        public string ShortName { get; protected set; }
        [JsonProperty("Name")]
        public string Name { get; protected set; }
        [JsonProperty("courseUnits")]
        public CourseUnit[] CourseUnits { get; protected set; } //array de CourseUnits
        [JsonProperty("_links")]
        public Links Links { get; protected set; } 

    }
}
