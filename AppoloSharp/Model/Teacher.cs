﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppoloSharp.Model.interno;
using Newtonsoft.Json;

namespace AppoloSharp.Model
{
    public class Teacher
    {
        [JsonProperty("id")]
        public int Id { get; protected set; }
        [JsonProperty("number")]
        public int Number { get; protected set; }
        [JsonProperty("fullName")]
        public string FullName { get; protected set; }
        [JsonProperty("academicEmail")]
        public string AcademicEmail { get; protected set; }
        [JsonProperty("shortName")]
        public string ShortName { get; protected set; }

        [JsonProperty("avatarUrl")]
        public AvatarUrl AvatarUrl { get; protected set; }
        [JsonProperty("_links")]
        public Links Links { get; protected set; }
    }
}
