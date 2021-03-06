﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppoloSharp.Model.interno;
using Newtonsoft.Json;

namespace AppoloSharp.Model
{
    public class CourseUnit
    {
        [JsonProperty("id")]
        public int Id { get; protected set; }
        [JsonProperty("shortName")]
        public string ShortName { get; protected set; }
        [JsonProperty("Name")]
        public string Name { get; protected set; }
        [JsonProperty("_links")]
        public Links Links { get; protected set; }
    }
}
