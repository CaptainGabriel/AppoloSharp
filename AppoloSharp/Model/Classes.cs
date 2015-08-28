using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppoloSharp.Model.interno;
using Newtonsoft.Json;

namespace AppoloSharp.Model
{
    public class Classes
    {
        [JsonProperty("id")]
        public int Id { get; protected set; }
        [JsonProperty("fullName")]
        public string Fullname { get; protected set; }
        [JsonProperty("courseunitShortName")]
        public string CourseUnitShortName { get; protected set; }
        [JsonProperty("lectiveSemesterShortName")]
        public string LectiveSemesterShortName { get; protected set; }
        [JsonProperty("className")]
        public string ClassName { get; protected set; }
        [JsonProperty("mainTeacherShortName")]
        public string MainTeacherShortName { get; protected set; }
        [JsonProperty("courseUnitId")]
        public int CourseUnitId { get; protected set; }
        [JsonProperty("lectiveSemesterId")]
        public int LectiveSemesterId { get; protected set; }
        [JsonProperty("mainTeacherId")]
        public int MainTeacherId { get; protected set; }
        [JsonProperty("maxGroupSize")]
        public int MaxGroupSize { get; protected set; }

        [JsonProperty("mainTeacher")]
        public Teacher MainTeacher { get; protected set; }
        
        //TODO otherTeachers here...

        [JsonProperty("_links")]
        public Links Links { get; protected set; }



    }
}
